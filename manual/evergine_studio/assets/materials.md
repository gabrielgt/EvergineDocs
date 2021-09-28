# Materials

![Material header](images/materials.jpg)

Materials describe how the [light](../../graphics/lights.md) interacts with the mesh surface. This allow you simulate properties like roughness, reflection, specular to create realistic materials of the real world as metal, plastic, concrete etc. The materials are based on an [effect](effects.md) so you first need to create one or use an existing effect. Default evergine project template imports the [**Evergine.Core** package](../packages.md) and this package includes the [Default Material](../../graphics/materials.md) that you can use to simulate a large amount of surfaces. Materials are a type of [asset](index.md) and have a dedicated Editor [**Material Editor**]().

You can find the material assets in the [**Assets Details**](../interface.md) panel when you select a folder in the [**Project Explorer**](../interface.md).

![Material asset](images/materialAsset.jpg)

The material file has the **_wemt_** extension.

![Material file](images/materialFile.jpg)

## Create a new material asset
You can create a material click button on ![Plus Icon](images/plusIcon.jpg) from [Assets Details](../interface.md) panel to deploy a create menu options and click on the option _"Create material"_

![Create new scene menu option](images/AssetsDetailsMenu.jpg)