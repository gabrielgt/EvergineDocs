# Effects

![Effects](images/effects.jpg)

A effect is a uber-shader so be able to represent a single shader or a large group of shaders. A shader is a piece of code write in a specify language creates to run on a GPU. The effects in evergine are written using [**HLSL**](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl-pguide). The effects are automatically translate to another languages when it is neccesary. Default evergine project template imports the [**Evergine.Core** package](../packages.md) and this package includes several effects like the [Standard Effect](../../graphics/effects.md) used by Default Material asset. Effects are a type of [asset](index.md) and have a dedicated Editor [**Effect Editor**]().

You can find the effect assets in the [**Assets Details**](../interface.md) panel when you select a folder in the [**Project Explorer**](../interface.md).

![Effect asset](images/effectAsset.jpg)

The effect file has the **_wefx_** extension and always come together a folder with the same name of the effect.

![Effect file](images/effectFile.jpg)

## Create a new effect asset
You can create a effect click button on ![Plus Icon](images/plusIcon.jpg) from [Assets Details](../interface.md) panel to deploy a create menu options and click on the option _"Create effect->Graphics Effect or Compute Effect"_

![Create new scene menu option](images/AssetsDetailsMenu.jpg)