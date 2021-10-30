# Using Application

In this documents yo will learn the common usages and tips to deal with Evergine Application class.

## Default Application
After creating a new Evergine project (checks the [Project Structure](../project_structure.md) document for further details), you will find a `MyApplication` class that inherit from Application:

```csharp
public partial class MyApplication : Application
{
    public MyApplication()
    {
        // Register services into application container...
        this.Container.RegisterType<Clock>();
        this.Container.RegisterType<TimerFactory>();
        this.Container.RegisterType<Random>();
        this.Container.RegisterType<ErrorHandler>();
        this.Container.RegisterType<ScreenContextManager>();
        this.Container.RegisterType<GraphicsPresenter>();
        this.Container.RegisterType<AssetsDirectory>();
        this.Container.RegisterType<AssetsService>();
        this.Container.RegisterType<ForegroundTaskSchedulerService>();            
        this.Container.RegisterType<WorkActionScheduler>();
    }

    public override void Initialize()
    {
        base.Initialize();

        // Get ScreenContextManager...
        var screenContextManager = this.Container.Resolve<ScreenContextManager>();
        var assetsService = this.Container.Resolve<AssetsService>();

        // Load the scene asset and instantiate into a MyScene class instance...
        var scene = assetsService.Load<MyScene>(EvergineContent.Scenes.MyScene_wescene);
                
        // Use ScreenContextManager service to navigate the main scene (MyScene)...
        ScreenContext screenContext = new ScreenContext(scene);
        screenContextManager.To(screenContext);
    }
}
```
Interesting things:
* It uses the MyApplication constructor to register all available services. You can register services in any part of your code, but it is a good place to register services.
* The `Initialize()` method is invoked to initialize your application. In that part the ScreenContextManager is notified what Scene is going to be played.

> [!NOTE]
> You can register Services on any place of your code. For example, if you want to register the GraphicsContext, we suggest to register in the Profile Project (I recommend again the [**Project Structure**](../project_structure.md) document). For example, you will register the DX11GraphicsContext in the Windows profile project, or VulkanGraphicsContetx in the Android profile. 

## Application lifecycle methods

The application class will invoke several methods to maintain its lifecycle, and helps developers to keep things going well.

| Methods | Description |
| --- | --- |
| **Initialize()** | Initialize all aspects needed to start your application. Here you will usually navigate to the Scene to be played, and setup initial functionality or services to be consumed during the execution. |
| **UpdateFrame()** | This method execute the Update cycle of your application. It will notify all UpdatableServices to be updated, including the ScreenContextManager, that will propagate this invocation to the Scene and finally your Components. You can override this method to customize the Update loop. |
| **DrawFrame()** | This method is triggered to Draw your application. All Scenes will be rendered, and the GraphicsPresenter service will present the rendering results in all displays (windows, XR headsets, off screen rendering, etc...). You can override this method to customize the Draw loop. |
| **Destrot()** | Use this method to dispose all resources of your application. |

## Checks if the application is running inside Evergine Studio

When you are developing components or functionality, you maybe need to check if your code is running inside Evergine Studio or outside.

| Property | Description |
| --- | --- |
| **IsEditor** | Application property that indicates if the application is running in **Evergine Studio**.  |


 ```csharp
public class MyBehavior : Behavior
{
    [BindComponent]
    private  Transform3D transform;

    protected override void Start()
    {    
        // Reset the position to Zero only if is not Evergine Studio...        
        if (!Application.Current.IsEditor)
        {
            this.transform.Positon = Vector3.Zero;
        }
    }
}
 ```