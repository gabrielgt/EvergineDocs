# Using Postprocessing Graph

![Postprocessing Graph header](images/PostProcessingGraph.jpg)

In this document, you will learn how to load and use **Postprocesing Graph** in your applications.

## Load Postprocessing Graph from code
The following sample code can be used to instantiate an existing postprocessing graph asset and apply it in your scene.
```csharp
protected override void CreateScene()
{
    var assetsService = Application.Current.Container.Resolve<AssetsService>();

    var graph = assetsService.Load<PostProcessingGraph>(EvergineContent.PostprocessingGraph.MyPostProcessingGraph);

    // Add postprocessing graph to scene
    Entity postprocessingVolume = new Entity()
        .AddComponent(new Transform3D())
        .AddComponent(new PostProcessingGraphRenderer() { ppGraph = graph });

    this.Managers.EntityManager.Add(postprocessingVolume);
}
```

## How to apply Postprocessing graph to a scene from Evergine Studio.

You can apply a postprocessing graph to your scene click on ![Plus Icon](../images/plusIcon.jpg) button from [Entities Hierarchy](../../evergine_studio/interface.md) panel and select _Post-processing Volume_

![Create Postprocessing Volume](images/CreatePostprocessingGraph.jpg)

Postprocessing Volume is an entity in your scene composed of 3 components:
* `Transform3D`
* `PostProcessingGraphRenderer`
* `BoxCollider3D`

With the `PostProcessingGraphRenderer` component, you can configure it to work in two modes.

| Mode | Description |
| ---- | ----------- |
| **Global** | All cameras in your scene will be affected by the postprocessing graph. |
| **Volume** | The cameras enter into the volume defines by a BoxCollider will be affected by the postprocessing graph. |

In addition, you can configure the _LayerOrder_ to execute the postprocessing in your scene. For example, you can execute the postprocessing after drawing all entities of your scene but before the UI entities.

Finally, The PostProcessingGraphRenderer allows to load a Postprocessing Graph asset and displays all his nodes or his associated [decorator](custom_postprocessing_graph.md).

![Postprocessing Renderer](images/PostprocessingGraphRenderer.jpg)

