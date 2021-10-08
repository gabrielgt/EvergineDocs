# Create Postprocessing Graph
---
![Postprocessing header](images/PostProcessingGraph.jpg)

The Post-Processing graph is a group of nodes connected that apply visual effects to the output render before drawing on the screen. Each node is a compute [effect](effects.md). 

## Create a Postprocessing Graph asset in Evergine Studio
You can create a postprocessing graph click button on ![Plus Icon](../images/plusIcon.jpg) from [Assets Details](../../evergine_studio/interface.md) panel to deploy a create menu options and click on the option _"Create Post-Processing Graph"_

![Create new postprocessing graph menu option](images/AssetsDetailsMenu.jpg)

### Inspect Postprocessing Graph in Asset Details
You can find the postprocessing graph assets in the [**Assets Details**](../../evergine_studio/interface.md) panel when you select a folder in the [**Project Explorer**](../../evergine_studio/interface.md).

![Postprocessing Graph asset](images/postProcessinGraphAsset.jpg)

### Postprocessing Graph files in content directory
The postprocessing graph file has the `.wepp` extension.

![Postprocessing Graph file](images/postProcessingGraphFile.jpg)

## Create a new Postprocessing from code
The following sample code can be used to create a new postprocessing graph and apply to an entity in your scene.

```csharp
protected override void CreateScene()
{
    var assetsService = Application.Current.Container.Resolve<AssetsService>();

    var graph = assetsService.Load<PostProcessingGraph>(EvergineContent.PostProcessingGraph.DefaultPostProcessingGraph);

    Entity postprocessingVolume = new Entity()
        .AddComponent(new Transform3D())
        .AddComponent(new PostProcessingGraphRenderer() { ppGraph = graph });

    this.Managers.EntityManager.Add(postprocessingVolume);
}