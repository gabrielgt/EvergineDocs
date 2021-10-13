# ResourceFactory

This API is used to **Evergine** on all platform and graphics APIs (DirectX, Vulkan, OpenGL, WebGL, Metal and WebGPU), so if you need to create a Low-Level object like a native Texture, Sampler, GraphicsPipeline or buffer you need to use the ResourceFactory.

All the common Low-Level object (textures, buffer, ...) are represented by abstract classes and this Factory allow you to create them in the same way for all the supported APIs.

Once you have the [GraphicsContext](graphicscontext.md) instance you can use it to access to the resource factory and start creating Low-Level objects. To create a VertexBuffer object:

```csharp
var vertexBufferDescription = 
    new BufferDescription((uint)Unsafe.SizeOf<VertexPositionNormalTexture>() * (uint)vertexData.Length, BufferFlags.VertexBuffer, ResourceUsage.Default);

var vertexBuffer = this.graphicsContext.Factory.CreateBuffer(vertexData, ref vertexBufferDescription);
```

## Objects

The complete list of objects that you can create using the ResourceFactory is:

* [Buffer](buffer.md)
* [Texture](texture.md)
* [Sampler](sampler.md)
* [Framebuffer](framebuffer.md)
* [Shader](shader.md)
* [QueryHeap](queryheap.md)
* [ResourceLayout](resourcelayout.md)
* [GraphicsPipeline](graphicspipeline.md)
* [ComputePipeline](computepipeline.md)
* [RayTracingPipeline](raytracingpipeline.md)
* [ResourceSet](resourceset.md)
* [CommandQueue](commandqueue.md)
* [CommandBuffer](commandbuffer.md)