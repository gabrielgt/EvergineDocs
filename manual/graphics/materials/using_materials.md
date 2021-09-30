# Using Materials

![Materials header](images/materials.jpg)

In this document you will learn how to load and use **Materials** in your applications.

## Load Material from code
The following sample code can be used to instantiate an existing material asset and apply to an entity in your scene.
```c#
protected override void CreateScene()
{
    var assetsService = Application.Current.Container.Resolve<AssetsService>();

    // Load Material
    Material defaultMaterial = assetsService.Load<Material>(EvergineContent.Materials.DefaultMaterial);

    // Apply to an entity
    Entity primitive = new Entity()
            .AddComponent(new Transform3D())
            .AddComponent(new MaterialComponent() { Material = defaultMaterial })
            .AddComponent(new SphereMesh())
            .AddComponent(new MeshRenderer());

    this.Managers.EntityManager.Add(primitive);
}
```

## How to apply material to an entity from Evergine Studio.
To assign a material to your objects...