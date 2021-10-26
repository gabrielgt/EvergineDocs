# Behaviours
---

The **Behaviors** are one kind of Component that allows you to do and action each update cycle of the application. A behavior is associated with an entity and all behaviors in a scene are managed by **Behavior Manager**.

The **Behavior Manager** is a manager registered in a scene that manages the execution of all behaviors in each update cycle. The behaviors are registered automatically in the Behavior Manager associated with the scene that contains its entity owner.

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

## Behavior family
There are three behavior families that you can specify in the constructor of your behavior using the base constructor with the `FamilyType` parameter.
 
 *  **DefaultBehavior**: This is the default family when you don't specify anything in the constructor. The behavior only runs in runtime but not in the Evergine Studio.
 *  **PriorityBehavior**: This is a special family that indicates your behavior runs both in runtime and in Evergine Studio.
 *  **PhysicBehavior**: This family is specific to behaviors with physic that manage in the independent thread for performance proposes.

## Behavior example
The following example creates behavior that allows you to rotate your entity every update cycle.

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
            : base(FamilyType.DefaultBehavior)
        { }

        protected override void Update(TimeSpan gameTime)
        {
            transform.Orientation *= Quaternion.CreateFromEuler(new Vector3(0, (float)gameTime.TotalSeconds, 0));
        }
    }
}
```
> [!Tip]
> BindComponent allows binding other components, to know more about that visit the following [**section**](../Binding.md)

## Add/Remove a behavior
To add/remove a behavior to/from your entity both from code or Evergine Studio is the same that adding/removing a component because a behavior is a kind of component. You can see how to add/remove a component [here](index.md)