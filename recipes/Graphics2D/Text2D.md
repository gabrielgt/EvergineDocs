## Goal

There is a component to render texts into a scene. 
On the following paragraphs we will learn how to add text into a 2D context. 

## Hands-on

### With Wave Visual Editor

Set **Wave Editor** on 2D mode, next from the _Entities Hierarchy_ window add a **Text 2D** entity:

![](images/Text2D/Text2D.jpg)

You will see the editor rendering the text 

![](images/Text2D/Text2DEditor.jpg)

### With Visual Studio (for Windows or Mac)

To get a similar behavior by code just create an entity in this way:

```c#
var text = new Entity()
    .AddComponent(new Transform2D())
    .AddComponent(new TextComponent() { Text = "Hello world!" })
    .AddComponent(new TextRenderer2D());

EntityManager.Add(text);

```


## Wrap-up

You have learned how to add text in a 2D context.