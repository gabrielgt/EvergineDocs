# Primitives
---

![Primitives](images/primitives.jpg)

Evergine has a 3D **primitives** collection that you can use for prototyping proposes. The primitives are easier and faster to use so they are very useful when you are making tests or your creating a prototype scene.

Primitive collection:

* Capsule
* Cone       
* Cube       
* Cylinder   
* Plane      
* Pyramid
* Sphere
* Teapot
* Torus

## Create primitive from Evergine Studio
From the Entity Hierarchy panel click on![plus](images/plusIcon.jpg) button and go to Primitives 3D submenu.

![Create Primitive](images/CreatePrimitivesMenu.jpg)

## Create primtive from code
To create a primitive only need to create an entity with the following components:

```csharp
protected override void CreateScene()
        {
            var assetsService = Application.Current.Container.Resolve<AssetsService>();

            var material = assetsService.Load<Material>(EvergineContent.Materials.DefaultMaterial);

            Entity e = new Entity()
                .AddComponent(new Transform3D())
                .AddComponent(new MaterialComponent() { Material = material })
                .AddComponent(new CubeMesh())
                .AddComponent(new MeshRenderer());

            this.Managers.EntityManager.Add(e);
        }
```
> [!Tip]
> To create primitive only need to change _CubeMesh_ component by _CapsuleMesh_, _ConeMesh_, _CylinderMesh_, _PlaneMesh_, _PyramidMesh_, _SphereMesh_, _TeapotMesh_ or _TorusMesh_ component.

## Capsule Parameters

| Parameter | Description |
| -----------| ----------- |
| **Height**     | The height of the capsule. Must be greater than 0. |
| **Radius**     | The radius of the capsule. Must be greater than 0. |
| **Tessellation** | the tessellation of the capsule. Must be even. |

## Cone Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Height**   | The height of the cone. Must be greater than 0. |
| **Diameter** | The diameter of the cone. Must be greater than 0. |
| **Tessellation** | The tessellation of the cone. |

## Cube Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Size** | The size of the cube. Must be greater than 0.|
| **UVHorizontalFlip** | Value indicating whether to flip the horizontal texture coordinate.|
| **UVVerticalFlip** | Value indicating whether to flip the vertical texture coordinate.|
| **InitialU** | The horizontal texture coordinate offset.|
| **InitialV** | The vertical texture coordinate offset. |
| **UTile** | The horizontal texture coordinate scale factor.|
| **VTile** | The vertical texture coordinate scale factor.|

## Cylinder Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Height** | The height of the cylinder. Must be greater than 0. |
| **Diameter** | The diameter of the cylinder. Must be greater than 0. |
| **Tessellation** | The tessellation of the cylinder. Must be greater than 3. |

## Plane Parameters

| Parameter  | Description |
| -----------| ----------- |
| **PlaneNormal** | The normal of the plane. Availables values: _XPositive, YPositive, ZPositive, XNegative, YNegative, ZNegative_. |
| **Width** | The width of the plane. Must be greater than 0.|
| **Height** | The height of the plane. Must be greater than 0. |
| **TwoSides** | Value indicating whether the plane has two sides.|
| **UVHorizontalFlip** | Value indicating whether to flip the horizontal texture coordinate.| 
| **UVVerticalFlip** | Value indicating whether to flip the vertical texture coordinate.|
| **InitialU** | The horizontal texture coordinate offset.|
| **InitialV** | The vertical texture coordinate offset.|
| **UTile** | The horizontal texture coordinate scale factor.|
| **VTile** | The vertical texture coordinate scale factor.|

## Pyramid Parameters

| Parameter  | Description |
| -----------| ----------- |
| Size  | The size of the pyramid. Must be greater than 0. |

## Sphere Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Diameter** | The diameter of the sphere. Must be greater than 0. |
| **Tessellation** | The tessellation of the sphere. Must be greater than 3. |
| **UVHorizontalFlip** | Value indicating whether to flip the horizontal texture coordinate.|
| **UVVerticalFlip** | Value indicating whether to flip the vertical texture coordinate.|

## Teapot Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Size** | The size of the teapot. Must be greater than 0. |
| **Tessellation** | The tessellation of the teapot. Must be greater than 3.|

## Torus Parameters

| Parameter  | Description |
| -----------| ----------- |
| **Diameter** | The diameter of the torus. Must be greater than 0.|
| **Thickness** | The thickness of the torus. Must be greater than 0. |
| **Tessellation** | The tessellation of the torus. Must be greater than 3. |

