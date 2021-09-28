# Materials

![Materials header](images/materials.jpg)

**Materials** are [assets](../evergine_studio/assets/materials.md) that allows simulate different surfaces like Plastic, Concrete, Metal ... A material requires a graphics effect so for create a new material you can use an effect includes in [**Evergine.Core** package](../evergine_studio/packages.md) or create your own effect. Also the Evergine.Core package includes a **Default Material** that will be used when you import any [model](models.md) to the Evergine Studio. **Default Material** is based on [**PBR**](https://en.wikipedia.org/wiki/Physically_based_rendering) that allows you simulate realistic materials.

## Create a Material from code
The following sample code can be used to instantiate a new material and apply to an entity in your scene.
```c#
protected override void CreateScene()
{
    var assetsService = Application.Current.Container.Resolve<AssetsService>();

    // Load Material
    Material defaultMaterial = assetsService.Load<Material>(EvergineContent.Materials.DefaultMaterial);

    // Apply to an entity
    Entity primitive = new Entity()
            .AddComponent(new Transform3D())
            .AddComponent(new MaterialComponent() { Material = defaultMaterial })
            .AddComponent(new SphereMesh())
            .AddComponent(new MeshRenderer());

    this.Managers.EntityManager.Add(primitive);
}
```

## Create a Material in Evergine Studio
Materials are a type of asset so for more details about how to create read this [section](../evergine_studio/assets/materials.md).

## Material properties

A material will have the properties define by his effect. In this section are described the materials include in [**Evergine.Core** package](../evergine_studio/packages.md)

### Default Material properties

|Property                       | Description |
|-------------------------------|-------------|
| **Lighting enabled**          | Indicates that the material interacts with the lights of the scene. In the following image the left material has disabled ligth and the right material has it enabled <br> ![Light off/on](images/DefaultMaterialLightOnOff.png)|
| **IBL enabled**               | Indicates that the material reflects the enviroment of the scene. In the following image the left material has disabled it while the right material has it enabled <br> ![IBL off/on](images/DefaultMaterialIBLOnOff.png)|
| **Base Color**                | Indicates the surface color.  |
| **Alpha**                     | Indicates the transparent of the surface. _Note. This parameter requires set the LayerDescription property to Alpha or a layer with blend mode enable_ <br> ![Alpha values](images/DefaultMaterialAlphaOnOff.png) |
| **Vertex Color**              | Indicates the surface color will be read from vertex data of the mesh. |
| **Base Color Texture**        | Albedo texture to define the color of the surface. |
| **Base Color Sampler**        | Albedo texture sampler used by Base Color Texture. |
| **UVOffsets 0**               | Texcoord UV offset added to the vertex texcoord data of the mesh. _Note. You can create interesting material effect only animating this parameter._|
| **Metallic**                  | Indicates how "metal-like" the surface is. Its value is between [0-1]. In the following image you can see the result with different values. <br> ![Metallic values](images/DefaultMaterialMetallic.png) |
| **Roughness**                 | - |
| **Reflectance**               | - |
| **Reference Alpha**           | - |
| **MetalRoughness Texture**    | - |
| **MetalRoughness Sampler**    | - |
| **Normal Texture**            | - |
| **Normal Smapler**            | - |
| **Occlusion Texture**         | - |
| **Occlusion Sampler**         | - |
| **EmissiveColor**             | - |
| **Emissive Compensation**     | - |
| **Emissive Texture**          | - |
| **Emissive Sampler**          | - |
| **ClearCoat**                 | - |
| **ClearCoat Roughness**       | - |
| **ClearCoat Normal Texture**  | - |
| **ClearCoat Normal Sampler**  | - |
| **Alpha Cutout**              | - |
| **Dual Texture Blend**        | - |
| **UV Offsets 1**              | - |
| **2nd Base Color Texture**    | - |
| **2nd Base Color Sampler**    | - |
| **AllowInstancing**           | - |
| **OrderBias**                 | - |
| **LayerDescription**          | - |


### Distortion Material properties

|Property                       | Description |
|-------------------------------|-------------|
| **RenderLayer**               | - |
| **Intensity**                 | - |
| **Distortion Texture**        | - |
| **Sampler**                   | - |

## How to apply material to an entity from Evergine Studio.