# Built-in Effects
---
In this section are described the effects included in [**Evergine.Core** package](../evergine_studio/packages.md)

## Standard Effect

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
| **Alpha Cutout**              | - |
| **AllowInstancing**           | - |
| **OrderBias**                 | - |
| **LayerDescription**          | - |

### Metal Roughness
|Property                       | Description |
|-------------------------------|-------------|
| **MetalRoughness Texture**    | - |
| **MetalRoughness Sampler**    | - |

### Normal

|Property                       | Description |
|-------------------------------|-------------|
| **Normal Texture**            | - |
| **Normal Smapler**            | - |

### Ambient occlusion

|Property                       | Description |
|-------------------------------|-------------|
| **Occlusion Texture**         | - |
| **Occlusion Sampler**         | - |

### Emissive

|Property                       | Description |
|-------------------------------|-------------|
| **EmissiveColor**             | - |
| **Emissive Compensation**     | - |
| **Emissive Texture**          | - |
| **Emissive Sampler**          | - |

### Clear Coat

|Property                       | Description |
|-------------------------------|-------------|
| **ClearCoat**                 | - |
| **ClearCoat Roughness**       | - |
| **ClearCoat Normal Texture**  | - |
| **ClearCoat Normal Sampler**  | - |

### Dual Texture

|Property                       | Description |
|-------------------------------|-------------|
| **Dual Texture Blend**        | - |
| **UV Offsets 1**              | - |
| **2nd Base Color Texture**    | - |
| **2nd Base Color Sampler**    | - |


## Distortion Effect

|Property                       | Description |
|-------------------------------|-------------|
| **RenderLayer**               | - |
| **Intensity**                 | - |
| **Distortion Texture**        | - |
| **Sampler**                   | - |