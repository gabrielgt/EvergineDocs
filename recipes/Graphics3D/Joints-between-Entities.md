## Goal

A joint in physics is a relationship between two different objects. Such is a base behaviour when working with physics, and [Wave Engine](http://waveengine.net) supports multiple types of 3D joints.

This recipe will briefly summarise all of the available 3D joints, showing how are handled in code in general aspects.

## Hands-on

Every 3D joint inherits from abstract class [WaveEngine.Framework.Physics3D.Joint3D](xref:WaveEngine.Framework.Physics3D.Joint3D`2). Wave Engine supplies currently the following implementations:

![](images/Joint/AddJoint.png)

 - [FixedJoint3D](xref:WaveEngine.Framework.Physics3D.FixedJoint3D): restricts all the degrees of freedom. Each entity has an axis attached and the constraint attempts to prevent any relative twisting motion around the axes.
 - [HingeJoint3D](xref:WaveEngine.Framework.Physics3D.HingeJoint3D): allows one angular degree of freedom between two entities. Hinge Joints are commonly used for door hinges, elbows, and axis joints. 
 - [SliderJoint3D](xref:WaveEngine.Framework.Physics3D.SliderJoint3D): allows a body to rotate around one axis and translate alogn this axis.
 - [ConeTwistJoint3D](xref:WaveEngine.Framework.Physics3D.ConeTwistJoint3D): adds a cone and a twist axis limits.
 - [GearJoint3D](xref:WaveEngine.Framework.Physics3D.GearJoint3D)
 - [Generic6DofJoint3D](xref:WaveEngine.Framework.Physics3D.Generic6DofJoint3D): allows to configure each of the 6 degrees of freedom
 - [PointToPointJoint3D](xref:WaveEngine.Framework.Physics3D.PointToPointJoint3D): limits the translation around a pivot point
 - [SpringJoint3D](xref:WaveEngine.Framework.Physics3D.SpringJoint3D)
 
### With Wave Visual Editor

In order to demo how a 3D joint can be added within Wave Visual Editor, we will focus on `FixedJoint3D` one, although the same steps apply to other ones from above list. Also, we will start with an existing sample: [FixedJoint](https://github.com/WaveEngine/Samples/tree/master/Physics3D/FixedJoint) one, where two boxes are joined through a `FixedJoint`.

In the scene where we have the two box entities, select the one on top and add a [FixedJoint3D](xref:WaveEngine.Framework.Physics3D.FixedJoint3D) component, using the Add component button in the Entity Details panel. In the properties list you will find a new one called FixedJoint3D. 

![](images/Joint/FixedJointProperties.jpg)

With the `ConnectedEntitityPath` property, you can define with which other entity the joint is connected. It will only shows those entities that has a RigidBody Component.

### With Visual Studio (for Windows or Mac)

To recreate the previous sample using code, it is supposed we have already created the two boxes. Finally, simply add a `JointMap3D` component to one of them, establishing a link/join with the other:

```c#
var boxA = CreateBoxA(); // This method returns the boxA entity
var boxB = CreateBoxB(); // This method returns the boxB entity

boxA.AddComponent(new FixedJoint3D());
```

## Wrap-up

This recipe has showed us which are the available [FixedJoint3D](xref:WaveEngine.Framework.Physics3D.FixedJoint3D) in Wave Engine, how those are briefly used and, more specifically, how the `FixedJoint` works on one of our samples.

Take a look at the Physics samples that plays with joints on [github](https://github.com/WaveEngine/Samples/tree/master/Physics3D)