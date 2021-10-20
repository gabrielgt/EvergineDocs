# Texture Editor

![Texture Editor](Images/textureEditorHighlight.png)

**Texture Editor** allows the editing of texture assets.  Double click over a **Texture** asset shown in [Assets Details](../../evergine_studio/interface.md) will open this editor. The editor is composed of 3 main parts:

## Viewport
Shows the **Texture** with the current configuration. It contains a label with the following information:

- TextureType
- Resolution in pixels
- Pixel Format.
- Size of the texture on disc.

> [!NOTE]
> An example of descriptive text would be _Texture2D 4096x4096 px R8G8B8A8_Unorm_.-


## Toolbox
Helps with the texture visualization. Has the following options:

| Item | Description |
| ---- | ----------- |
| ![channel selector](Images/toolboxChannelSelector.png) | Each button enables or disables the **Texture** channels. |
| ![mipmapp selector](Images/toolboxMipmapping.png) | Slider that sets the current **Mipmap level** of the texture. This control will be hidden in case of textures without mipmapping |
| ![background selector](Images/toolboxBackground.png) | Sets the background color on the **Viewport**. |

## Properties
Panel with all the **Texture** properties. They don't depend on the profile.

| Property | Description |
|----------|-------------|
| NinePathType| Sets the ninepath information of the image. It defines how the texture can stretch un a ui component.
| GenerateMipmaps | If **Evergine** will generate all the mipmaps for the **Texture**.
| PremultipliedAlpha | If the **RGB** channels are multiplied by the **Alpha (A)** channel.
| Sampler | The **SamplerState** asset that will defines how the **Texture** is sampled and filtered.

## Profile Properties
Properties that can be changed in every app profile.

| Property | Description |
|----------|-------------|
| ScalingType | Sets how the texture will be scaled: <ul><li>**Original:** Don't affect the image size.</li><li>**Percentage:** Scale the image using the **ScaledPercentage** value.</li><li>**FreeForm:** Set the **Texture** size directy using the **ScaledWidth** and **ScaledHeight**.</li><li>**PowerOfTwo:** Scales to the smallest power of two size per dimension.</li><li>**SquarePowerOfTwo:** Scales to the smallest **square** power of two size per dimension.</li></ul> |
| ScaledPercentage | Defines the scale factor of the texture when using **Percentage** scaling type. **1.0 by default**.
| ScaledWidth | Defines the width of **Texture** when using  **Freeform** scaling type.
| ScaledHeight | Defines the height of **Texture** when using  **Freeform** scaling type.
| PixelFormat | Defines the size, elements and name of **Texture** pixels.

