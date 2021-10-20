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