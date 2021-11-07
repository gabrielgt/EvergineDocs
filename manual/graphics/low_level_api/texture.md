# Texture

A texture stores texel information.

## Creation

To create a texture first you need to construct the TextureDescription struct, it contains the following list of properties:

```csharp
uint expectedSize = 256;
ResourceUsage expectedUsage = ResourceUsage.Default;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = expectedUsage,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = expectedFormat,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);
```

## TextureDescription

| Property | Type | Description |
|--------| ----------- |----------- |
| **Type** | TextureType | Texture type TextureType. |
| **Format** | PixelFormat | Texture format PixelFormat. |
| **Width** | uint | Texture width (in texels). |
| **Height** | uint | Texture height (in texels). |
| **Depth** | uint | Texture Depth (in texels). |
| **ArraySize** | uint | Number of textures in the texture array. |
| **Faces** | uint | Number of texture faces useful in TextureCube and TextureCubeArray. |
| **MipLevels** | uint | The maximum number of mipmap levels in the texture. |
| **Flags** | TextureFlags | The texture flags TextureFlags. |
| **Usage** | ResourceUsage | Value that identifies how the texture is to be read from and written to. |
| **SampleCount** | TextureSampleCount | The number of samples in this texture. |
| **CpuAccess** | ResourceCpuAccess | Flags ResourceCpuAccess to specify the type of CPU access allowed. |

## TextureType

Specify the texture type.

| TextureType |  Description |
|--------| ----------- |
| **Texture2D**    | Represent a two dimensions texture. |
| **Texture2DArray**    | Represent an array of 2D textures. |
| **Texture1D**    | Represent a one dimension texture. |
| **Texture1DArray**    | Represent an array of 1D textures. |
| **TextureCube**    | Represent a 6 faces texture cube. |
| **TextureCubeArray**    | Represent an array of textures cube. |
| **Texture3D**    | Represent a three dimensions texture. |

## PixelFormat

Specify the bytes format used in each texel. 
The most common format are:

| PixelFormat |  Description |
|--------| ----------- |
| **R8_UNorm**    | A single-component, 8-bit unsigned-normalized-integer format that supports 8 bits for the red channel. |
| **R8G8_UNorm**    | A two-component, 16-bit unsigned-normalized-integer format that supports 8 bits for the red channel and 8 bits for the green channel.|
| **R8G8B8A8_UNorm**| A four-component, 32-bit unsigned-normalized-integer format that supports 8 bits per channel including alpha. |
| **R8G8B8A8_UNorm_SRgb**    | A four-component, 32-bit unsigned-normalized integer sRGB format that supports 8 bits per channel including alpha.|
| **R16_Float**    |  A single-component, 16-bit floating-point format that supports 16 bits for the red channel.|
| **R16_SInt**    | A single-component, 16-bit signed-integer format that supports 16 bits for the red channel.|
| **R16_UInt**    | A single-component, 16-bit unsigned-integer format that supports 16 bits for the red channel.|
| **R16_UNorm**    | A single-component, 16-bit unsigned-normalized-integer format that supports 16 bits for the red channel.|
| **R16G16_Float**    | A two-component, 32-bit floating-point format that supports 16 bits for the red channel and 16 bits for the green channel.|
| **R16G16_SInt**    | A two-component, 32-bit signed-integer format that supports 16 bits for the red channel and 16 bits for the green channel. |
| **R16G16_UInt**    | A two-component, 32-bit unsigned-integer format that supports 16 bits for the red channel and 16 bits for the green channel.|
| **R16G16B16A16_Float**    | A four-component, 64-bit floating-point format that supports 16 bits per channel including alpha.|
| **R16G16B16A16_SInt**    | A four-component, 64-bit signed-integer format that supports 16 bits per channel including alpha.|
| **R16G16B16A16_UInt**    | A four-component, 64-bit unsigned-integer format that supports 16 bits per channel including alpha.|
| **R32_Float**    | A single-component, 32-bit floating-point format that supports 32 bits for the red channel.|
| **R32_SInt**    | A single-component, 32-bit signed-integer format that supports 32 bits for the red channel.|
| **R32_UInt**    | A single-component, 32-bit unsigned-integer format that supports 32 bits for the red channel.|
| **R32G32_Float**    | A two-component, 64-bit floating-point format that supports 32 bits for the red channel and 32 bits for the green channel.|
| **R32G32_SInt**    | A two-component, 64-bit signed-integer format that supports 32 bits for the red channel and 32 bits for the green channel.|
| **R32G32_UInt**    | A two-component, 64-bit unsigned-integer format that supports 32 bits for the red channel and 32 bits for the green channel.|
| **R32G32B32_Float**    | A three-component, 96-bit floating-point format that supports 32 bits per color channel.|
| **R32G32B32_SInt**    | A three-component, 96-bit signed-integer format that supports 32 bits per color channel.|
| **R32G32B32_UInt**    | A three-component, 96-bit unsigned-integer format that supports 32 bits per color channel.|
| **R32G32B32A32_Float**    |  A four-component, 128-bit floating-point format that supports 32 bits per channel including alpha. 1|
| **R32G32B32A32_SInt**    | A four-component, 128-bit signed-integer format that supports 32 bits per channel including alpha. 1|
| **R32G32B32A32_UInt**    | A four-component, 128-bit unsigned-integer format that supports 32 bits per channel including alpha. 1|

> [!Note]
> See the PixelFormat enum at Evergine.Common namespace for the complete list.

## TextureFlags

Identifies how to bing a texture.

| TextureFlags |  Description |
|--------| ----------- |
| **None**    | Not specified, **Default value**. |
| **ShaderResource**    | A texture usable as a ShaderResourceView. |
| **RenderTarget**    | A texture usable as render target. |
| **UnorderedAccess**    | A texture usable as an unordered access buffer. |
| **DepthStencil**    | A texture usable as a depth stencil buffer. |
| **GenerateMipmaps**    | Enables MIP map generation by GPU. |

## ResourceUsage

Identifies expected resource usage during rendering.

| ResourceUsage |  Description |
|--------| ----------- |
| **Default**    | A resource that requires read and write access by the GPU, **Default value**. |
| **Immutable**    | A resource that can only be read by the GPU. It cannot be written by the GPU, and cannot be accessed at all by the CPU. |
| **Dynamic**    | A resource that is accessible by both the GPU (read only) and the CPU (write only). |
| **Staging**    | A resource that supports data transfer (copy) from the GPU to the CPU. |

## TextureSampleCount

Describes the number of samples to use in a Texture.

| TextureSampleCount |  Description |
|--------| ----------- |
| **None**    | Not multisample. **Default value**. |
| **Count2**    | Multisample count of 2 pixels. |
| **Count4**    | Multisample count of 4 pixels. |
| **Count8**    | Multisample count of 8 pixels. |
| **Count16**    | Multisample count of 16 pixels. |
| **Count32**    | Multisample count of 32 pixels. |

## ResourceCpuAccess

Specifies the types of CPU access allowed for a resource.

| ResourceCpuAccess |  Description |
|--------| ----------- |
| **None**    | Not specified, **Default value**. |
| **Write**    | The CPU can be write this resource. |
| **Read**    | The CPU can be read this resources. |

## Usage examples

## How to create and fill a texture by code

```csharp
uint expectedSize = 256;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = ResourceUsage.Default,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = PixelFormat.R8G8B8A8_UNorm,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

float[] data = Enumerable.Range(0, (int)(expectedSize * expectedSize)).Select(i => (float)i).ToArray();

var rowPitch = Common.Graphics.Helpers.GetRowPitch(expectedSize, PixelFormat.R8G8B8A8_UNorm);
var slicePitch = Common.Graphics.Helpers.GetSlicePitch(rowPitch, expectedSize, PixelFormat.R8G8B8A8_UNorm);

var pinnedHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
IntPtr dataPointer = Marshal.UnsafeAddrOfPinnedArrayElement(data, 0);
var databox = new DataBox[] { new DataBox(dataPointer, rowPitch, slicePitch) };

var texture = this.GraphicsContext.Factory.CreateTexture(databox, ref description);

pinnedHandle.Free();
```

### How to update a default texture

```csharp
uint expectedSize = 256;
ResourceUsage expectedUsage = ResourceUsage.Default;
PixelFormat expectedFormat = PixelFormat.R8G8B8A8_UNorm;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = expectedUsage,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = expectedFormat,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);

float[] data = Enumerable.Range(0, (int)(expectedSize * expectedSize)).Select(i => (float)i).ToArray();

this.GraphicsContext.UpdateTextureData(texture, data);
texture.Dispose();
```

### How to copy from other device texture

```csharp
uint expectedSize = 256;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = ResourceUsage.Default,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = PixelFormat.R8G8B8A8_UNorm,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);

float[] data = Enumerable.Range(0, 256 * 256).Select(i => (float)i).ToArray();
this.GraphicsContext.UpdateTextureData(texture, data);

var textureCopy = this.GraphicsContext.Factory.CreateTexture(ref description);

var queue = this.GraphicsContext.Factory.CreateCommandQueue();
var command = queue.CommandBuffer();

command.Begin();
command.CopyTextureDataTo(texture, textureCopy);
command.End();
command.Commit();
queue.Submit();
queue.WaitIdle();

texture.Dispose();
textureCopy.Dispose();
queue.Dispose();

```

### How to set data in a staging texture

```csharp
uint expectedSize = 256;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = ResourceUsage.Staging,
    CpuAccess = ResourceCpuAccess.Write | ResourceCpuAccess.Read,
    Flags = TextureFlags.None,
    Format = PixelFormat.R8G8B8A8_UNorm,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);

float[] data = Enumerable.Range(0, (int)(expectedSize * expectedSize)).Select(i => (float)i).ToArray();

this.GraphicsContext.UpdateTextureData(texture, data);

texture.Dispose();

```

### How to map and read a staging texture

```csharp
uint expectedSize = 256;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = ResourceUsage.Staging,
    CpuAccess = ResourceCpuAccess.Write | ResourceCpuAccess.Read,
    Flags = TextureFlags.None,
    Format = PixelFormat.R8G8B8A8_UNorm,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);

float[] data = Enumerable.Range(0, (int)(expectedSize * expectedSize)).Select(i => (float)i).ToArray();

this.GraphicsContext.UpdateTextureData(texture, data);

var mappedResource = this.GraphicsContext.MapMemory(texture, MapMode.Read);
for (int y = 0; y < expectedSize; y++)
{
    for (int x = 0; x < expectedSize; x++)
    {
        int offset = ((y * ((int)mappedResource.RowPitch / sizeof(float))) + x) * sizeof(float);
        float* pointer = (float*)(mappedResource.Data + offset);
        int index = (y * (int)expectedSize) + x;
        Assert.Equal(data[index], *pointer);
    }
}

this.GraphicsContext.UnmapMemory(texture);

texture.Dispose();
```
