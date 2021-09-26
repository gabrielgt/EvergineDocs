# OpenGL

![OpenGL API](images/opengl.jpg)

Open Graphics Library (OpenGL) is the most widely adopted 2D and 3D graphics API in the industry cross-platform.
Silicon Graphics Inc, began developing OpenGL in 1991 and released it on June 30 1992, and now is a technology maintained by **Khronos Group**.

**Evergine** use OpenGL graphics API on Web platform and Windows desktop but is deprecating this technology in favor of [Vulkan](vulkan.md), which is the new modern graphics API created by the **Khronos Group**.

**OpenGL** is used on Web platform by **Evergine** through the version named **WebGL**. This is the default version supported in the most popular browsers.

* Chrome, Edge, Firefox support WebGL 2.0
* Safari supports WebGL 1.0

## Supported OpenGL devices

* Windows 8/10/11 x64/x86 desktop
* Web Browsers desktop, tablet and mobile.

## Checking OpenGL version

If you a running Windows 7 or later the **OpenGL** library has already been installed on your system.

To check the **OpenGL** version available on your system just find out the control panel of your graphics card or you can download the [OpenGL Hardware Capability Viewer](https://opengl.gpuinfo.org/download.php).

## Build & Run on OpenGL

You can select **OpenGL** API support during the new project creation from the **Evergine** launcher.

If the project already exists you can add the **OpenGL** support from **Evergine Studio** by clicking on Settings -> Project Settings.

![Settings](images/dx12_support_0.jpg)

Selecting and adding the profile for Windows (DirectX12).

![Settings](images/gl_support_1.jpg)

![Settings](images/gl_support_2.jpg)

You can run on **OpenGL** by clicking on File -> Build & Run -> Windows.DirectX12.

![Settings](images/gl_support_3.jpg)

To support Web Platforms based on **WebGL** versions you also need to add from project setting the WebGL Template, selecting WebGL 2.0 or 1.0 depends your project needs.

![Settings](images/gl_support_4.jpg)