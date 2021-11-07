# Swapchain

A swap chain is a collection of buffers that are used for displaying frames to the user. Each time an application presents a new frame for display, the first buffer in the swap chain takes the place of the displayed buffer. This process is called swapping or flipping.

A graphics adapter holds a pointer to a surface that represents the image being displayed on the monitor, called a front buffer. As the monitor is refreshed, the graphics card sends the contents of the front buffer to the monitor to be displayed. However, this leads to a problem when rendering real-time graphics. The heart of the problem is that monitor refresh rates are very slow in comparison to the rest of the computer. Common refresh rates range from 60 Hz (60 times per second) to 100 Hz. If your application is updating the front buffer while the monitor is in the middle of a refresh, the image that is displayed will be cut in half with the upper half of the display containing the old image and the lower half containing the new image. This problem is referred to as tearing.

## Creation

To create a Swapchain, first you need to create the SwapChainDescription struct:

```csharp
// Create a windows...
var windowSystem = new Evergine.WindowsForms.FormsWindowsSystem();
var window = windowSystem.CreateWindow(windowsTitle, width, height);

// Create a swapchain descriptor and assign the surface info...
var swapChainDescriptor = new SwapChainDescription()
{
    Width = window.Width,
    Height = window.Height,
    SurfaceInfo = info,
    ColorTargetFormat = PixelFormat.R8G8B8A8_UNorm,
    ColorTargetFlags = TextureFlags.RenderTarget | TextureFlags.ShaderResource,
    DepthStencilTargetFormat = PixelFormat.D24_UNorm_S8_UInt,
    DepthStencilTargetFlags = TextureFlags.DepthStencil,
    SampleCount = this.SampleCount,
    IsWindowed = true,
    RefreshRate = 60,
    SurfaceInfo = window.SurfaceInfo
};

// Finally, create the swapchain...
var swapChain = this.graphicsContext.CreateSwapChain(swapChainDescriptor);
swapChain.VerticalSync = false;
```

## SwapChainDescription

| Property | Type | Description |
|--------| ----------- |----------- |
| **SurfaceInfo** | SurfaceInfo | Surface information. |
| **Width** | uint | The swapchain buffers width. |
| **Height** | uint | The swapchain buffers height. |
| **RefreshRate** | uint | The screen refresh rate. |
| **ColorTargetFormat** | PixelFormat | The pixel format of the color target. |
| **ColorTargetFlags** | TextureFlags | The color texture flags for binding to pipeline stages. The flags ca be combined by a logical OR. |
| **DepthStencilTargetFormat** | PixelFormat | The pixel format of the depthstencil target. |
| **DepthStencilTargetFlags** | TextureFlags | The depth texture flags for binding to pipeline stages. The flags ca be combined by a logical OR. |
| **SampleCount** | TextureSampleCount | The sampler count of this swapchain. |
| **IsWindowed** | bool | Whether the output is in windowed mode. |

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
