## Goal

Within this recipe you will learn how to use the `WaveBackgroundTask` and `WaveForegroundTask`

## Hands-on

Take a look at the [Loading sample](https://github.com/WaveEngine/Samples/blob/master/Performance/Loading/SharedSource/Main/LoadingScene.cs)

### WaveBackgroundTask
For example we are going to begin loading **GameScene** and when all assets are in memory make the transition to it, this is usefull for example for loading scene with heavy assets in bakcground.

```C#
using WaveEngine.Framework.Threading;
...
var gameScene = new GameScene();
 WaveBackgroundTask.Run(() =>
            {
                gameScene.Initialize(WaveServices.GraphicsDevice);
                Thread.Sleep(5000);
            }).ContinueWith((t) =>
            {
                WaveServices.ScreenContextManager.To(new ScreenContext(gameScene));
            });
```
Note that there is only one backgrodun thread, and if you all the threads will be enqueued to this
This is creating a task to initialize the game scene, and sleep the thread five seconds, when initialization task ends, the _EndAnimation_ method will be executed in other thread.

### WaveForegroundTask
This is usefull for launch and forget a task in a thread differnt of this, for example [loading a asset from a URL](https://github.com/WaveEngine/Samples/blob/19b2d516170730181a7cc2ca86f753f617ae6a17/Graphics2D/InternetTextureLoad/SharedSource/Main/SpriteUrl.cs)

```C#
using WaveEngine.Framework.Threading;
...
WaveForegroundTask.Run(() =>
                    {
                        await this.LaunchAndForget();
                    });
```
## Wrap-up

You have learn how to make multithreading in your games with some simple lines of code.
