# Binding Elements
---
Evergine allows to bind dependencies automatically across your components, services and sceneManagers.

For example, bindings allow a custom component to require that its Owner Entity has a Transform3D component, and set it to a property during the **Attach** phase (see the [Lifecycle](../lifecycle_elements.md) documents)

This binding feature gives to developers a lot of flexibility to interconnect components, services and scene managers, avoiding the tedious part to setup this dependencies in Evergine Studio or from code.

In Evergine, we define bindings using property attributes ([BindComponent] for example).

> [!NOTE]
> All dependencies are not available until the Attach phase, if you try to access during in the constructor,  `OnLoaded()` or `OnDestroy()` methods, the property value is goint to be `null`

## In this section

There are four types of binding:
* [Bind Components](bind_components.md)
* [Bind Services](bind_services.md)
* [Bind Entities](bind_entities.md)
* [Bind SceneManagers](bind_scenemanagers.md)

## Example

In the following example, the component will bind a service, a component an a scene manager.
```csharp
public class MyComponent : Component
{
    [BindService]
    private AssetsService assetsService;

    [BindSceneManager]
    private RenderManager renderManager;

    [BindComponent]
    private Transform3D transform;

    private Material defaultMaterial;

    protected override Start()
    {
        // All values of bind attributes will be injected after the Attach phase...
        
        // Bind assetService
        this.defaultMaterial = this.assetsService.Load<Material>(EvergineContent.Materials.DefaultMaterial);
        
        // Bind SceneManagers
        this.RenderManager.DebugLines = true;
        
        // Bind Components
        this.transform.Position = Vector3.Zero;
    }

    // ... 
}
```

