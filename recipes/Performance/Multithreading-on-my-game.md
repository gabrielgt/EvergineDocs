## Goal

Within this recipe you will learn how to use the `WaveBackgroundTask` and `WaveForegroundTask`

## Hands-on

You can take a look at the following resources:
- [New async/await features](https://geeks.ms/waveengineteam/2017/08/03/new-asyncawait-features/)
- [Loading sample](https://github.com/WaveEngine/Samples/blob/dev/Performance/Loading/SharedSource/Main/LoadingScene.cs)
- [AsyncAwait sample](https://github.com/WaveEngine/Samples/blob/dev/Performance/AsyncAwait/SharedSource/Main/MyScene.cs)

### WaveForegroundTask
This is usefull for launch code that needs to be executed in the update cycle of our game.

```C#
using WaveEngine.Framework.Threading;
...
WaveForegroundTask.Run(() => { ... });
```

This helper class can be usefull when treating with async code, but if you are using 'await', you can use the extension method 'ConfigureWaveAwait', which allows us to configure where the await continuation is executed: in the Foreground or the Background thread.

```C#
await myMethodAsync().ConfigureWaveAwait(WaveTaskContinueOn.Foreground);
... // This code will be executed in the next update.
```

```C#
await myMethodAsync().ConfigureWaveAwait(WaveTaskContinueOn.Background);
... // This code will be executed in the background thread.
```

### WaveBackgroundTask
For example we are going to begin loading **GameScene** and when all assets are in memory make the transition to it, this is usefull for example for loading scene with heavy assets in background.

```C#
var scene = await WaveBackgroundTask.Run(() =>
{
    var gameScene = new GameScene();
    // This method will take some time loading assets and initializing the scene.
    gameScene.Initialize(WaveServices.GraphicsDevice);
    return gameScene;
}).ConfigureWaveAwait(WaveTaskContinueOn.Foreground);

WaveServices.ScreenContextManager.To(new ScreenContext(scene));
```
With the Background thread, the tasks are executed sequentially in a specific thread that can access the graphic resources. This allows us, for example, to load textures.

As you can see, using the 'ConfigureWaveAwait' extension method we can ensure that when the load ends, the navigation to the next scene will be executed in the Foreground thread.

## Wrap-up

You have learn how to make multithreading in your games with some simple lines of code.
