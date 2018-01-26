## Goal

Fonts can be the difference between a bad-looking app and an awesome one. It is also one of the root differences in UIs between platforms, such like Android with its Roboto and iOS with San Francisco.

Within this recipe you will learn to add custom fonts to be used with the included GUI toolkit.

## Hands-on

### With Wave Visual Editor

New fonts are added by doing right-click inside the Asset Details panel and then selecting *Create Font*. A widely-known window will appear, Add Font, where you can choose the font family, weight and size. Clicking on OK will generate the needed assets to reference such font on a TextBlock, for instance.

> [!Note]
> In order to select a font in the Add Font window, it needs to be added to the corresponding location matching your host OS.

Now, move on to the next point to actually make use of the font.

### With Visual Studio (for Windows or Mac)

When the font is added with Wave Visual Editor, the file `WaveContent.cs` is regenerated to include the path to it. So, it is as easy as specifying this value in the font path properties the GUI toolkit provides. For instance, here we will add a `TextBlock` which will be rendered with the created font (here, we selected Segoe UI, Regular, 16):

```C#
var customFontTextBlock = new TextBlock()
{
    Text = "Hello, World!",
    FontPath = WaveContent.Assets.Segoe_UI_16_ttf
};

this.EntityManager.Add(customFontTextBlock);
```

Remember to add the following using directive:

```C#
using WaveEngine.Components.UI;
```

## Wrap-up

You have learned how to add custom fonts to be used along with the GUI toolkit.