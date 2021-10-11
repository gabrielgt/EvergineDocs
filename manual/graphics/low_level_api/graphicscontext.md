# GraphicsContext

The Low-Level API uses several abstract classes that represent specific native object on DirectX, Vulkan and Metal.
To use this API just need to create or get access to the GraphicsContext instance indicating the graphics backend.

```csharp
this.graphicsContext = new Evergine.DirectX11.DX11GraphicsContext();
this.graphicsContext.CreateDevice(new ValidationLayer());
```

Use the specify constructor to initialize a concrete graphics API.

| API |  Class |
|--------| ----------- |
| DirectX 11    | new DX11GraphicsContext() |
| DirectX 12    | new DX12GraphicsContext() |
| Vulkan    | new VKGraphicsContext() |
| OpenGL    | new GLGraphicsContext() |
| Metal    | new MTLGraphicsContext() |

Once you have the GraphicsContext you can use it to create the swapchain and use it to render on a surface.

```csharp
var windowSystem = new Evergine.WindowsForms.FormsWindowsSystem();
var window = windowSystem.CreateWindow(windowsTitle, width, height);

var swapChainDescriptor = test.CreateSwapChainDescription(window.Width, window.Height);
swapChainDescriptor.SurfaceInfo = window.SurfaceInfo;

this.swapChain = this.graphicsContext.CreateSwapChain(swapChainDescriptor);
this.swapChain.VerticalSync = false;
```

To create the surface you need to select a UI technology:

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
