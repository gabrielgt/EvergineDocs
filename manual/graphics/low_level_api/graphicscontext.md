# GraphicsContext



The GraphicsContext is the central class for displaying your application. It's used to create and manage graphic resources.

Like the majority of Low-level-API classes, GraphicsContext is an abstract class that exposes common functionality of each graphics API (e.g. DirectX, Vulkan, Metal...). To use this API just need to create or get access to the GraphicsContext instance indicating the properly implementation depending of which graphic backend are you interested. 

In the following example, we are creating a DirectX11 GraphicsContext:

```csharp
var graphicsContext = new Evergine.DirectX11.DX11GraphicsContext();
```

Use the specify constructor to initialize a concrete graphics API.

| API |  Class |
|--------| ----------- |
| DirectX 11    | `new DX11GraphicsContext()` |
| DirectX 12    | `new DX12GraphicsContext()` |
| Vulkan    | `new VKGraphicsContext()` |
| OpenGL    | `new GLGraphicsContext()` |
| Metal    | `new MTLGraphicsContext()` |

## Initialize the Device

Once you have created the Graphics context, in order to create resources and render your content, you need to create the graphics device:
```csharp
graphicsContext.CreateDevice();
```

### Validation Layer

To enable debug graphics mode you must added the ValidationLayer object to the device constructor, this will show you the native and internal errors:

```csharp
// Add a ValidationLayer instance in the CreateDevice invocation...
graphicsContext.CreateDevice(new ValidationLayer());
```

By default, the ValidationLayer use exception to notify any issue, but it is possible to change it:

| Notify Method |  Declaration | Description |
|--------| ----------- | ----------- |
| **Exception**    | `new ValidationLayer()` | Throws exception with each internal error and stop the execution. |
| **Trace**        | `new ValidationLayer(ValidationLayer.NotifyMethod.Trace)` | Display all errors in console without stopping the execution |
| **Event**        | `new ValidationLayer(ValidationLayer.NotifyMethod.Event)` | The ValidationLayer.Error event allow to obtains the error messages |

## Initialize Swapchain

Once you have the GraphicsContext you can use it to create the swapchain and use it to render on a surface.

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

To create the surface first you need to select an UI technology:

| UI |  Class |
|--------| ----------- |
| **Windows Forms**    | Evergine.Forms.FormsWindowsSystem |
| **WPF**    | Evergine.WPF.WPFWindowsSystem |
| **SDL**    | Evergine.SDL.SDLWindowsSystem |
| **Android**    | Evergine.AndroidView.AndroidWindowsSystem |
| **iOS**    | Evergine.iOSView.iOSWindowsSystem |
| **UWP**    | Evergine.UWPView.UWPWindowsSystem |
| **WinUI**    | Evergine.WinUI.WinUIWindowsSystem |
| **MixedReality**    | Evergine.MixedReality.MixedRealityWindowsSystem |
| **Web**    | Evergine.Web.WebWindowsSystem |

## Create from scratch

Visit the [Low-Level test samples](https://github.com/WaveEngine/LowLevelAPIDemo) to learn how to create an application from scratch using this cross-platform API.
