# Post-Processing Graph

![PostProcessing graph](images/postProcessingGraph.jpg)

Post-Processing graph allows you to apply visual effects like Tonemapping, Depth of Field, Temporal Anti-Aliasing, SSAO, SSR ... to your scene final render. The Post-Processing graph is a group of nodes connected that apply visual effects to the output render before drawing on the screen. Each node is a compute [effect](effects.md). For know more details about Post-Processing graph read this [section](../../graphics/post_processing_graph.md). Default evergine project template imports the [**Evergine.Core** package](../packages.md) and this package includes the Default Post-Processing graph with the most important post-processing visual effect common in a project. So in the most of time, you will use this asset reserving to create a new custom post-processing graph only to create new visual effects or to improve performance needs. Post-Processing graphs are a type of [asset](index.md) and have a dedicated Editor [**Post-Processing Graph Editor**]().

You can find the post-processing graph assets in the [**Assets Details**](../interface.md) panel when you select a folder in the [**Project Explorer**](../interface.md).

![PostProcessing graph asset](images/postProcessinGraphAsset.jpg)

The post-processing graph file has the **_wepp_** extension.

![PostProcessing graph file](images/postProcessingGraphFile.jpg)

## Create a new Post-Processing Graph asset
You can create a Post-Processing Graph click button on ![Plus Icon](images/plusIcon.jpg) from [Assets Details](../interface.md) panel to deploy a create menu options and click on the option _"Post-Processing Graph"_

![Create new scene menu option](images/AssetsDetailsMenu.jpg)