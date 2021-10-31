# Services
---

In Evergine, **Services** are elements that allow you to manage global features. A Service functionality could be accessed from every Scene, Component or Behavior in your application. The services could be bond from any [component](component_arch/components/index.md) even other services using the [aplication container](application/index.md).

Developing custom Evergine services are useful to integrate your application with external external services or APIs.

There are two kind of services:
 
 * **Basic Services**: This kind of service is very useful to expose functionality or to execute global tasks.
 * **Updatable Services**: Is a Service subclass with an `Update()` method that allows running an action every application update cycle.

## Creating a Service
To create a basic Service, add a class from _Visual Studio_ and extend the `Service` class:
 
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

### Create an UpdatableService

On the other hand, to create a updatable service add a class from Visual Studio and extend the `UpdatableService' class.

```csharp
 using Evergine.Framework.Services;

public class MyUpdatableService : UpdatableService
{
    public override void Update(TimeSpan gameTime)
    {
        // Called on every application update cycle...
    }        
}

 ``` 

## Register a new Service in your Application

Before using a service is necessary to register it in the [application container](application/index.md) where you can register the type or an instance.

 ```csharp
 public partial class MyApplication : Application
    {
        public MyApplication()
        {
            // Previous code :)

            // You could register the service by type...
            this.Container.RegisterType<MyService>();

            // Or register the Service using an instance...
            this.Container.RegisterInstance(new MyService());            
        }
    ...
 ```

## Using Services

Accessing registered services could be done by two ways:

### Using [BindService] attribute

You can use the [BindService] attribute in your Component, SceneManager or even from another Services to automatically inject the Service instance into your property.

 ```csharp
using Evergine.Framework;
using System;

namespace MyProject
{
    public class MyBehavior : Behavior
    {
        // Use the BindService attribute on top of the property or attribute in which you want to inject the Service
        [BindService]
        private MyService myService = null;

        protected override void Update(TimeSpan gameTime)
        {
            this.myService.DoRequest();
        }
    }
}
 ```

 ### Using Application Container

 In the other hand, you could obtains the Service instance directly from the Application Container:

  ```csharp
using Evergine.Framework;
using System;

namespace MyProject
{
    public class MyBehavior : Behavior
    {
        private MyService myService = null;

        protected override bool OnAttached()
        {            
            // Use the Resolve<Type> method from the Application Container....
            this.myService = Application.Current.Container.Resolve<MyService>();

            return base.OnAttached();
        }

        protected override void Update(TimeSpan gameTime)
        {
            this.myService.DoRequest();
        }

        protected override bool OnDettached()
        {
            // Release the reference when a component is being dettached...
            this.myService = null;
        }
    }
}
 ```