# Effects

![Graphics](images/effects.jpg)

A effect is a uber-shader so be able to represent a single shader or a large group of shaders. A shader is a piece of code write in a specify language creates to run on a GPU.is  describe a single or multiple shader Materials describe how the [light](../../graphics/lights.md) interacts with the mesh surface. This allow you simulate properties like roughness, reflection, specular to create realistic materials of the real world as metal, plastic, concrete etc. The materials are based on an [effect](effects.md) so you first need to create one or use an existing effect. Default evergine project template imports the [**Evergine.Core** package](../packages.md) and this package includes the [Default Material](../../graphics/materials.md) that you can use to simulate a large amount of surfaces. Materials are a type of [asset](index.md) and have a dedicated Editor [**Material Editor**]().

You can find the effect assets in the [**Assets Details**](../interface.md) panel when you select a folder in the [**Project Explorer**](../interface.md).

![Graphics](images/effectAsset.jpg)

The effect file has the **_wefx_** extension and always come together a folder with the same name of the effect.

![Graphics](images/effectFile.jpg)

## Create a new effect asset
You can create a effect click button on ![Plus Icon](images/plusIcon.jpg) from [Assets Details](../interface.md) panel to deploy a create menu options and click on the option _"Create effect->Graphics Effect or Compute Effect"_

![Create new scene menu option](images/AssetsDetailsMenu.jpg)