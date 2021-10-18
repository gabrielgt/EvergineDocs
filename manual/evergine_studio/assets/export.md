# Exporting assets

![Assets](images/assets.jpg)

**Evergine** usually doesn't load the resource files (`.jpg`, `.fbx`, etc.) directly at runtime. However, it processes the resource files and **compile** or **export** them into actual binary files that can be properly and efficiently loaded into **Evergine**. 

For example, the **Model** asset exported file contains areas that can be directly copied into buffers and uploaded into the graphic card. 

> [!NOTE]
> **Evergine** actually _can_ load direct resource files at runtime. However it relies on third-party libraries that would make the asset workflow much slower and memory consuming. Also you wouldn't be able to edit their properties.
> However for many application that's not only a good option, but a desirable one. Specially if it needs to load images dynamically loaded from internet, for example

## Exported asset file extensions.

Every asset type defines the exported file asset extension (in the same way it defines its metafile file extension). Below you can find them:

| Asset type | Exported extension |
| ---------- | ------------------ | 
| Texture    | `.weptx`           |
| Model      | `.wepmd`           |
| Sound      | `.wepsn`           |
| Scene      | `.wepsc`           |
| Effect     | `.wepfx`           |
| Sampler    | `.wepsp`           |
| Material   | `.wepmt`           |
| Render Layer  | `.weprl`           |
| Post Processing Graph      | `.weppp`           |

## Export process

**Evergine** asset export process is actually a pipeline with the next steps:

1. Gather information about the **resource file** (if any).
2. Get the **application profile** name.
3. Check if the asset **metafile** contains specific parameters for the **app profile**.
   * If there is a specific **profile definition** use those parameters.
   * Otherwise the asset will use its **default profile** parameters.
4. Convey all the parameters of the asset and **generate** the exported binary file.