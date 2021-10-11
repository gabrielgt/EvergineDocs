# Assets
---
![Assets](images/assets.jpg)

An **asset** is an item that represents an element in **Evergine Studio** that can be used in your project. It can represent visual or graphic elements like **3D models**, **textures**, or either more abstract engine elements like **sampler states**, **materials** and **render layers**. 

Here it is a summary of different asset types.

## Assets with resource file

Some assets are created using external applications, like _3ds Max_, _Blender_ or _Photoshop_. 

These assets are _resource files_ that can be imported in **Evergine Studio** and used in your project, either by the **Studio** or directly by code. 

Here are the asset with resource files that **Evergine** currently supports.

| Asset | Description | Supported file extensions|
|--------------------|-------------|-------------|
| Texture | Image file used as texture graphic resource. | .jpg, .jpeg, .png, .bmp, .tga, .ktx, .dds, .hdr|
| Model | 3d model with geometry, animation and material information. | .gltf, .glb, .fbx, .3ds, .obj, .dxf, .dae|
| Sound | Audio file used for music and sound effects | .wav, .mp3, .ogg
| File | Any file that does not satisfy the previous formats | Any other file.

## Assets created only by Evergine

However, some assets represents just abstract elements that can only be created by **Evergine Studio**, some of them even by code. They don't have any external associated resource file. Some of these assets have complex folder structure, while others are more basic.

| Asset | Description |
|-------|-------------|
| Scene | Main **Evergine** asset. It defines an entity graph that populates a scene, and also define their components. 
| Effect | Contains a **HLSL shader**. It automatically translates to other shading languages like **GLSL**. They are also flavored with custom attributes and annotations for a better integration.
| Post Processing Graph | Defines a visual post processing graph node, using **compute shaders** for effects like _anti-aliasing_, _tone mapping_, _SSAO_, and many others.
| Material | Represents how a geometry is rendered. It references an Effect asset and describes its parameters like textures and values.
| Prefab | Contains an entity hierarchy that can be instance in any scene.
| Render Layer | Contains **Rasterizer**, **Blending**, **Depth** and **Stencil** information. Every material needs a Render Layer asset.
| Sampler State | Element that represents a texture sampler state description, like **filtering**, **clamping** or **wrapping** information.|

## In this section
* [Create Assets](create.md)
* [Edit Assets](edit.md)