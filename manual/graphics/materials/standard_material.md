# Using Materials

![Materials header](images/materials.jpg)

Materials describe the appearance of object surfaces and how they react to [light](../lights.md).

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
