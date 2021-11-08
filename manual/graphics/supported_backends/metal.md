# Metal

![Metal API](images/metal.jpg)

**Metal** is a low-level graphics and compute API created by **Apple** and is the default API on MacOS and iOS devices.

**Metal** has been available since June 2 2014 on iOS devices powered by Apple A7 or later and sice June 8 2015 on MacOS running OS X El capitan.

**Evergine** uses **Metal** API on MacOS and iOS devices like iPhone and IPad but also supports [Vulkan](vulkan.md) graphics API on those platforms through MoltenVK which allows to convert a subset of **Vulkan** API to run on top of **Metal** on MacOS and iOS operating systems.

## Supported Metal devices

* MacOS x64/x86/ARM64 desktop
* iOS iPhone and iPad

## Checking Metal version

It is the default graphics API used on iOS and MacOS devices and **Apple** updates through updates. To make sure you have the latest version just update to the latest OS version.

## Create a Graphics Context

To create a graphics context based on **Metal** just write:

```csharp
GraphicsContext graphicsContext = new Evergine.Metal.MTLGraphicsContext();
graphicsContext.CreateDevice();
```

## Build & Run

The project template will be available soon.