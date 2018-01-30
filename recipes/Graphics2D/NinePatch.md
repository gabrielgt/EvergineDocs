## Goal

Within this recipe you will learn how to take advance of [Nine-Patch](https://geeks.ms/waveengineteam/2016/09/29/nine-patch-in-waveengine/) assets features within **Wave Engine** 

## Hands-on

### With Wave Visual Editor

Given an empty Wave Engine project, just import as a simple asset a Nine-Patch texture as [this](images/NinePatch/ninePatchImage.9.png).

Just add it to your scene and Wave Engine Editor will detect that it is a Nine-Path texture and you can choose to use it as a nine-patch texture by modifing the `DrawMode`property from the Entity Details pane:

![](images/NinePatch/DrawModeProperty.jpg)

If you select the `Sliced`option, and you modify the scale of the entity by code, or with the Editor, it will scale according to a Nine-Patch format:

![](images/NinePatch/Scene.jpg);


## Wrap-up

You have learned how you can use Nine-Path capabilities in with **Wave Engine**

> [!Note]
> You can find more information about Nine-Patch support in our blog [here](https://geeks.ms/waveengineteam/2016/09/29/nine-patch-in-waveengine/) and [here](https://geeks.ms/waveengineteam/2017/06/13/ninepatch-native-support/)