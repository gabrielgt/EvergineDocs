## Goal

Within this recipe you will learn to add buttons to your games. Note that all UI components can be added in the same way.

## Hands-on

### With Wave Visual Editor

> [!Note]
> At the time of writing this recipe, Wave Visual Editor does not support adding UI components, so continue reading please.

### With Visual Studio (for Windows or Mac)

Edit the `MyScene` class, adding these two using directives:

```C#
using WaveEngine.Framework.UI;
using WaveEngine.Components.UI;
```

Edit `CreateScene` method with the code that will add a button to the scene:

```C#
Button button = new Button("Hello World")
{
    HorizontalAlignment = HorizontalAlignment.Center,
    VerticalAlignment = VerticalAlignment.Center,
};

this.EntityManager.Add(button.Entity);
```

`Button` class and every component in `WaveEngine.Components.UI` namespace have very useful properties to play with. Please feel free to try them out.

## Wrap-up

You have learned how to add a UI component to your scenes.