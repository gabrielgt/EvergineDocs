# GraphicsContext

The Low-Level API uses several abstract classes that represent specific native object on DirectX, Vulkan and Metal.
To use this API just need to create or get access to the GraphicsContext instance indicating the graphics backend.

```csharp
var graphicsContext = new Evergine.DirectX11.DX11GraphicsContext();
graphicsContext.CreateDevice();
```

Use the specify constructor to initialize a concrete graphics API.

| API |  Class |
|--------| ----------- |
| DirectX 11    | new DX11GraphicsContext() |
| DirectX 12    | new DX12GraphicsContext() |
| Vulkan    | new VKGraphicsContext() |
| OpenGL    | new GLGraphicsContext() |
| Metal    | new MTLGraphicsContext() |

## Validation Layer

To enabled debug graphics mode you must added the ValidationLayer object to the device constructor, this will show you the native and internal errors:

```csharp
graphicsContext.CreateDevice(new ValidationLayer());
```

By default, the ValidationLayer use exception to notify any issue, but it is possible to change it:

| Notify Method |  Declaration | Description |
|--------| ----------- | ----------- |
| Exception    | new ValidationLayer() | Throws exception with each internal error and stop the execution. |
| Trace        | new ValidationLayer(ValidationLayer.NotifyMethod.Trace) | Display all errors in console without stopping the execution |
| Event        | new ValidationLayer(ValidationLayer.NotifyMethod.Event) | The ValidationLayer.Error event allow to obtains the error messages |

## Initialize Swapchain

Once you have the GraphicsContext you can use it to create the swapchain and use it to render on a surface.

```csharp
var windowSystem = new Evergine.WindowsForms.FormsWindowsSystem();
var window = windowSystem.CreateWindow(windowsTitle, width, height);

var swapChainDescriptor = test.CreateSwapChainDescription(window.Width, window.Height);
swapChainDescriptor.SurfaceInfo = window.SurfaceInfo;

var swapChain = this.graphicsContext.CreateSwapChain(swapChainDescriptor);
swapChain.VerticalSync = false;
```

To create the surface first you need to select an UI technology:

| UI |  Class |
|--------| ----------- |
| Windows Forms    | Evergine.Forms.FormsWindowsSystem |
| WPF    | Evergine.WPF.WPFWindowsSystem |
| SDL    | Evergine.SDL.SDLWindowsSystem |
| Android    | Evergine.AndroidView.AndroidWindowsSystem |
| iOS    | Evergine.iOSView.iOSWindowsSystem |
| UWP    | Evergine.UWPView.UWPWindowsSystem |
| WinUI    | Evergine.WinUI.WinUIWindowsSystem |
| MixedReality    | Evergine.MixedReality.MixedRealityWindowsSystem |
| Web    | Evergine.Web.WebWindowsSystem |

## Create from scratch

Visit the [Low-Level test samples](https://github.com/WaveEngine/LowLevelAPIDemo) to learn how to create an application from scratch using this cross-platform API.
