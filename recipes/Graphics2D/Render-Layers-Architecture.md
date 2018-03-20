## Goal

A layer is a set of render properties to draw any element. Using **Render layers** is an effective way to organize your drawable content. You can establish order between layers and between sprites inside those. Each render layer is drawn in sequence (_First In First Draw_).

Wave Engine provides a default list of render layers but, you can define as many as you need in your game. The default ones (in drawing order) are:
 1. Opaque
 2. Skybox
 3. Alpha
 4. Additive
 5. GUI
 6. Debug

It makes sense, for instance, to draw a semitransparent sprite within the alpha layer _after_ an opaque one within the same name layer. The may be pixels from the second one which will remain visible in the final render.

You will learn within this guide how to work with this layers architecture.

## Hands-on

### With Wave Visual Editor

Layers are defined at project level and can be accessed through **Wave Editor** menu *Edit/Project Properties*. Selecting *Render Layers* you will see:
 ![](images/RenderLayers/RenderLayersDefinition.jpg)

You can modify all properties of every render layer the way you can, and you can define new ones based on an existing one by pressin the ![](images/RenderLayers/addRenderLayer.jpg)  button.

This way you can now create a new **Material** in your project and set the _LayerId_ property to the desired. So that material will be rendered in that layer every time it is needed:

![](images/RenderLayers/material.jpg)
 
### With Visual Studio (for Windows or Mac)

In case you need it, you can reference the render layer you want by code with the **WaveContent.RenderLayers** property.

## Wrap-up

We have learned how to modify and create new render layers in our projects.