# Buffer

A Buffer represents a block of memory that can be used in GPU operations. You can use buffers to store a wide variety of data, including position vectors, normal vectors, texture coordinates in a vertex buffer, indexes in an index buffer for example.

## Creation

To create a buffer first you need to construct the BufferDescription object:

```csharp
var vertexData = new Vector4[]
{
    new Vector4(0.0f, 0.2f, 0.0f, 1.0f),   new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
    new Vector4(0.2f, -0.2f, 0.0f, 1.0f),  new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
    new Vector4(-0.2f, -0.2f, 0.0f, 1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
};

uint expectedSize = (4 * 4) * (uint)vertexData.Length;
BufferFlags expectedFlags = BufferFlags.VertexBuffer;
ResourceUsage expectedUsage = ResourceUsage.Default;

var bufferDescription = new BufferDescription(expectedSize, expectedFlags, expectedUsage);
var buffer = this.GraphicsContext.Factory.CreateBuffer(vertexData, ref bufferDescription);
```

## ResourceUsage

Identifies expected texture use during rendering.

| ResourceUsage |  Description |
|--------| ----------- |
| Default    | A resource that requires read and write access by the GPU, Default value. |
| Immutable    | A resource that can only be read by the GPU. It cannot be written by the GPU, and cannot be accessed at all by the CPU. |
| Dynamic    | A resource that is accessible by both the GPU (read only) and the CPU (write only). |
| Staging    | A resource that supports data transfer (copy) from the GPU to the CPU. |

## BufferFlags

Identifies how to bing a buffer.

| BufferFlags |  Description |
|--------| ----------- |
| None    | No option. |
| VertexBuffer    | Bind a buffer as a vertex buffer to the input-assembler stage. |
| IndexBuffer    | Bind a buffer as an index buffer to the input-assembler stage. |
| ConstantBuffer    | Bind a buffer as a constant buffer to a shader stage. This flag may NOT be combined with any other bind flag. |
| ShaderResource    | Bind a buffer or texture to a shader stage. |
| AccelerationStructure    | Bind a buffer to used in a raytracing stage. |
| RenderTarget    | Bind a texture as a render target for the output-merger stage. |
| UnorderedAccess    | Bind a buffer as unordered access resource. |
| BufferStructured    | Bind a buffer as structured buffer resoruce. |
| IndirectBuffer    | Bind a buffer as indirect buffer to the input-assembler stage. |

## Usage examples

### How to update a default buffer

```csharp
var vertexData = new Vector4[]
{
    new Vector4(0.0f, 0.2f, 0.0f, 1.0f),   new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
    new Vector4(0.2f, -0.2f, 0.0f, 1.0f),  new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
    new Vector4(-0.2f, -0.2f, 0.0f, 1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
};

uint sizeInBytes = (4 * 4) * (uint)vertexData.Length;
var bufferDescription = new BufferDescription(sizeInBytes, BufferFlags.VertexBuffer, ResourceUsage.Default);
var buffer = this.GraphicsContext.Factory.CreateBuffer(ref bufferDescription);
this.GraphicsContext.UpdateBufferData(buffer, vertexData);

buffer.Dispose();
```

### how to copy a default buffer into another default buffer.

```csharp
var vertexData = new Vector4[]
{
    new Vector4(0.0f, 0.2f, 0.0f, 1.0f),   new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
    new Vector4(0.2f, -0.2f, 0.0f, 1.0f),  new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
    new Vector4(-0.2f, -0.2f, 0.0f, 1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
};

var description = new BufferDescription(
    4 * 4 * (uint)vertexData.Length,
    BufferFlags.VertexBuffer,
    ResourceUsage.Default);

var buffer = this.GraphicsContext.Factory.CreateBuffer(vertexData, ref description);

var bufferCopyDescription = new BufferDescription(
    (4 * 4) * (uint)vertexData.Length,
    BufferFlags.VertexBuffer,
    ResourceUsage.Default);

var bufferCopy = this.GraphicsContext.Factory.CreateBuffer(ref bufferCopyDescription);

var queue = this.GraphicsContext.Factory.CreateCommandQueue();
var command = queue.CommandBuffer();

command.Begin();
command.CopyBufferDataTo(buffer, bufferCopy, buffer.Description.SizeInBytes);
command.End();
command.Commit();
queue.Submit();
queue.WaitIdle();

buffer.Dispose();
bufferCopy.Dispose();
stagingBuffer.Dispose();
queue.Dispose();
```

### How to copy a default buffer into a staging buffer

```csharp

var vertexData = new Vector4[]
{
    new Vector4(0.0f, 0.2f, 0.0f, 1.0f),   new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
    new Vector4(0.2f, -0.2f, 0.0f, 1.0f),  new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
    new Vector4(-0.2f, -0.2f, 0.0f, 1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
};

var description = new BufferDescription(
    4 * 4 * (uint)vertexData.Length,
    BufferFlags.VertexBuffer,
    ResourceUsage.Default);

var buffer = this.GraphicsContext.Factory.CreateBuffer(vertexData, ref description);

var stagingDescription = new BufferDescription(
    4 * 4 * (uint)vertexData.Length,
    BufferFlags.None,
    ResourceUsage.Staging,
    ResourceCpuAccess.Read);

var stagingBuffer = this.GraphicsContext.Factory.CreateBuffer(ref stagingDescription);

var queue = this.GraphicsContext.Factory.CreateCommandQueue();
var command = queue.CommandBuffer();

command.Begin();
command.CopyBufferDataTo(buffer, stagingBuffer, buffer.Description.SizeInBytes);
command.End();
command.Commit();
queue.Submit();
queue.WaitIdle();

var readableResource = this.GraphicsContext.MapMemory(stagingBuffer, MapMode.Read);

for (int i = 0; i < vertexData.Length; i++)
{
    Vector4* pointer = (Vector4*)(readableResource.Data + (i * sizeof(Vector4)));
    Assert.Equal(*pointer, vertexData[i]);
}

this.GraphicsContext.UnmapMemory(stagingBuffer);

buffer.Dispose();
stagingBuffer.Dispose();
queue.Dispose();
```

### How to update a dynamic buffer from CPU

```csharp
var vectorSize = (uint)Unsafe.SizeOf<Vector4>();
var vertexData = new Vector4[]
{
    new Vector4(0.0f, 0.2f, 0.0f, 1.0f),   new Vector4(1.0f, 0.0f, 0.0f, 1.0f),
    new Vector4(0.2f, -0.2f, 0.0f, 1.0f),  new Vector4(0.0f, 1.0f, 0.0f, 1.0f),
    new Vector4(-0.2f, -0.2f, 0.0f, 1.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f),
};

var dynamicDescription = new BufferDescription(
    vectorSize * (uint)vertexData.Length,
    BufferFlags.VertexBuffer,
    ResourceUsage.Dynamic,
    ResourceCpuAccess.Write);

var dynamicBuffer = this.GraphicsContext.Factory.CreateBuffer(ref dynamicDescription);

// Map the write staging and leave mapped
var writableResource = this.GraphicsContext.MapMemory(dynamicBuffer, MapMode.Write);

Vector4* pointer = (Vector4*)writableResource.Data;
for (int i = 0; i < vertexData.Length; i++)
{
    *pointer = vertexData[i];
    pointer++;
}

this.GraphicsContext.UnmapMemory(dynamicBuffer);
dynamicBuffer.Dispose();
```