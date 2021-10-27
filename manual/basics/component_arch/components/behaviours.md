# Behaviours
---

The **Behaviors** are one kind of Component that allows you to do and action each Update cycle of the Application. A Behavior is associated with an Entity and all Behaviors in a scene are managed by **Behavior Manager**.

## Create a Behavior
From Visual Studio you can create a c# class with the following template.

```csharp
using Evergine.Framework;
using System;

namespace MyProject
{
    public class MyBehavior : Behavior
    {
        protected override void Update(TimeSpan gameTime)
        {
            // Your code
        }
    }
}
```

## Update Order

You can indicate the order of execution of every Behavior by setting its `UpdateOrder` property. 

| Property | Description |
| --- | --- |
| **UpdateOrder** | Value used to order the execution of every Behavior of the Scene, whether lower values indicate that the Behavior would be updated first. The default value is 0.5 |

## Behavior family
There are three Behavior families that you can specify in the constructor of your Behavior using the base constructor with the `FamilyType` parameter.
 
 *  **DefaultBehavior**: This is the default family when you don't specify anything in the constructor. The Behavior only runs in runtime but not in the Evergine Studio.
 *  **PriorityBehavior**: This is a special family that indicates your Behavior runs both in runtime and in Evergine Studio.
 *  **PhysicBehavior**: This family is specific to Physics components that need to be updated by the PhysicsManager.


## BehaviorManager
The **Behavior Manager** is a SceneManager registered by default in every SCene that manages the execution of all Behaviors in each update cycle. All Behaviors are registered automatically into the BehaviorManager when it's attached, and unregistered when the Behaviour is detached.

## Behavior example
The following example creates Behavior that allows you to rotate your entity every update cycle.

```csharp
using Evergine.Framework;
using Evergine.Framework.Graphics;
using Evergine.Mathematics;
using System;

namespace MyProject
{
    public class MyBehavior : Behavior
    {
        [BindComponent]
        private Transform3D transform = null;

        public MyBehavior()
            : base(FamilyType.DefaultBehavior) // This base(...) constructor could be ommited.
        { }

        protected override void Update(TimeSpan gameTime)
        {
            this.transform.LocalOrientation *= Quaternion.CreateFromEuler(new Vector3(0, (float)gameTime.TotalSeconds, 0));
        }
    }
}
```
> [!Tip]
> BindComponent allows binding other components, to know more about that visit the following [**section**](../Binding.md)

## Add/Remove a Behavior
To add/remove a Behavior to/from your entity both from code or Evergine Studio is the same that adding/removing a component because a Behavior is a kind of component. You can see how to add/remove a component [here](index.md)