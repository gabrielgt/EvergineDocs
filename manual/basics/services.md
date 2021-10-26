# Services
---

The Services are elements that allow you to manage global features. Service is a behavior but is not associated with the entity or scene. The services could be bonded from any [component](component_arch/components/index.md) even other services using the [aplication container](application.md).

There are two kind of services:
 
 * **Basic Services**: This kind of service is very useful to store global data or to call to execute global tasks.
 * **Updatable Services**: This kind of service extends basic services with an update method that allows running an action every update cycle.

 ## Create a services
To create a basic service, add a class from _Visual Studio_ and extend the `Service` class.
 
 ```csharp
 using Evergine.Framework.Services;

namespace MyProject
{
    public struct MyServiceData
    {
        public string name;
        public int requests;
    }

    public class MyService : Service
    {
        private MyServiceData data;

        public MyServiceData Data 
        {
            get => this.data;
            private set => this.data = value;
        }

        public MyService()
        {
            this.data.name = "myService";
        }

        public void DoRequest()
        {
            this.data.requests++;
        }        
    }
}

 ``` 

> [!Note]
> On the other hand, to create a updatable service add a class from _Visual Studio_ and extend the `UpdatableService' class.


 ## Register a new service in your app
Before using a service is necessary to register it in the [application container](application.md) where you can register the type or an instance.

 ```csharp
 public partial class MyApplication : Application
    {
        public MyApplication()
        {
            ...            
            this.Container.RegisterType<MyService>();
        }
    ...
 ```

 ## Using a service
 To use a registered service from a component, behavior, or drawable even another service only need to bind the services.

 ```csharp
using Evergine.Framework;
using System;

namespace MyProject
{
    public class MyBehavior : Behavior
    {
        [BindService]
        private MyService myService = null;

        protected override void Update(TimeSpan gameTime)
        {
            this.myService.DoRequest();
        }
    }
}
 ```