# QueryHeap

A query heap contains an array of GPU queries. A query heap allows batch a set of GPU queries to get better performance.

## Creation

To create a QueryHeap, first you need to construct a QueryHeapDescription:

```csharp
QueryHeap queryHeap;
uint maxQueries = 4;

QueryHeapDescription desc = new QueryHeapDescription()
{
    Type = QueryType.Timestamp,
    QueryCount = maxQueries,
};

this.queryHeap = this.graphicsContext.Factory.CreateQueryHeap(ref desc);

```

## QueryType

| Value | Description |
|--------| ----------- |----------- |
| **Timestamp** | Indicates the query is for high definition GPU and CPU timestamps. |
| **Occlusion** | Indicates the query is for depth/stencil occlusion counts. |
| **BinaryOcclusion** | Indicates the query is for a binary depth/stencil occlusion statistics. |

## Timestamp queries

You can obtain timestamps as part of a command list (rather than a CPU-side call on a command queue) via timestamp queries.

### How to use timestamp queries

```csharp
ulong[] results;

var commandBuffer = this.commandQueue.CommandBuffer();

commandBuffer.Begin();
commandBuffer.WriteTimestamp(this.queryHeap, 0);
commandBuffer.UpdateBufferData(this.constantBuffer, ref worldViewProj);

commandBuffer.SetViewports(this.viewports);
commandBuffer.SetScissorRectangles(this.scissors);

var renderPassDescription = new RenderPassDescription(this.frameBuffer, ClearValue.Default);
commandBuffer.BeginRenderPass(ref renderPassDescription);

commandBuffer.SetGraphicsPipelineState(this.pipelineState);
commandBuffer.SetResourceSet(this.resourceSet);
commandBuffer.SetVertexBuffers(this.vertexBuffers);
commandBuffer.Draw((uint)this.vertexData.Length / 2);

commandBuffer.EndRenderPass();
commandBuffer.WriteTimestamp(this.queryHeap, 1);

commandBuffer.End();
commandBuffer.Commit();

this.commandQueue.Submit();
this.commandQueue.WaitIdle();

this.queryHeap.ReadData(0, 4, this.results);
```

### How to show timestamp results

```csharp
this.surface.MouseDispatcher.DispatchEvents();
this.surface.KeyboardDispatcher.DispatchEvents();

commandBuffer.SetViewports(this.viewports);

this.uiRenderer.NewFrame(gameTime);

double gpuFrequency = this.graphicsContext.TimestampFrequency;

double time1 = ((this.results[1] - this.results[0]) / gpuFrequency) * 1000.0;
double time2 = ((this.results[3] - this.results[2]) / gpuFrequency) * 1000.0;

ImGui.SetNextWindowSize(new System.Numerics.Vector2(300, 100));
ImGui.Begin("Timmings");
ImGui.Text($"Draw: { time1.ToString("0.0000") } ms");
ImGui.Text($"ImGui: { time2.ToString("0.0000") } ms");
ImGui.End();

this.uiRenderer.Render(commandBuffer);
```

## Occlusion queries

Hardware occlusion queries were one of the most eagerly awaited graphics hardware features in a long time. This feature makes it possible for an application to ask the 3D API whether or not any pixels would be drawn if a particular object were rendered. With this feature, applications can check whether or not the bounding boxes of complex objects are visible; if the bounds are occluded, the application can skip drawing those objects.

### QueryHeap creation

```csharp
uint maxQueries = 4;
QueryHeapDescription desc = new QueryHeapDescription()
{
    Type = QueryType.Occlusion,
    QueryCount = maxQueries,
};

var queryHeap = this.graphicsContext.Factory.CreateQueryHeap(ref desc);
```

### How to use occlusion queries

```csharp
// Draw
var commandBuffer = this.commandQueue.CommandBuffer();

commandBuffer.Begin();
commandBuffer.UpdateBufferData(this.constantBuffer0, ref viewProj);
commandBuffer.UpdateBufferData(this.constantBuffer1, ref worldViewProj);

commandBuffer.SetViewports(this.viewports);
commandBuffer.SetScissorRectangles(this.scissors);

var renderPassDescription = new RenderPassDescription(this.frameBuffer, ClearValue.Default);
commandBuffer.BeginRenderPass(ref renderPassDescription);

commandBuffer.SetGraphicsPipelineState(this.pipelineState);
commandBuffer.SetResourceSet(this.resourceSet0);
commandBuffer.SetVertexBuffers(this.vertexBuffers);

commandBuffer.BeginQuery(this.queryHeap, 0);
commandBuffer.Draw((uint)this.vertexData.Length / 2);
commandBuffer.EndQuery(this.queryHeap, 0);

commandBuffer.EndRenderPass();
commandBuffer.End();
commandBuffer.Commit();

this.commandQueue.Submit();
this.commandQueue.WaitIdle();

this.queryHeap.ReadData(0, 1, this.results);
```

### How to show occlusion results

```csharp
this.surface.MouseDispatcher.DispatchEvents();
this.surface.KeyboardDispatcher.DispatchEvents();

commandBuffer.SetViewports(this.viewports);

this.uiRenderer.NewFrame(gameTime);

ImGui.SetNextWindowSize(new System.Numerics.Vector2(300, 100));
ImGui.Begin("Occlusion Test");
ImGui.Text($"Samples: { this.results[0] } ");
ImGui.End();

this.uiRenderer.Render(commandBuffer);
```