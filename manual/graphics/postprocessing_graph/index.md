# Postprocessing Graph
---
![PostProcessing graph](images/postProcessingGraph.jpg)

Post-Processing graph allows you to apply visual effects like Tonemapping, Depth of Field, Temporal Anti-Aliasing, SSAO, SSR ... to your scene final render. The Post-Processing graph is a group of nodes connected that apply visual effects to the output render before drawing on the screen. Each node is a compute [effect](effects.md). 

## Postprocessing and compute effects

A postprocessing graph is a group of compute effect nodes that apply effects to the first render node and connect the result to the last Screen node. You can create a postprocessing graph with single or multiples nodes depends on your proposal. Post-Processing graphs are a type of [asset](index.md) and have a dedicated Editor [**Post-Processing Graph Editor**](postprocessing_graph_editor.md).

## Default Postprocessing Graph

Default Evergine project template imports the [**Evergine.Core** package](../packages.md) and this package includes the Default Post-Processing graph with the most important post-processing visual effect common in a project. So in the most of time, you will use this asset reserving to create a new custom post-processing graph only to create new visual effects or to improve performance needs.

## In this section

* [Create Postprocessing Graph](create_postprocessing_graphs.md)
* [Using Postprocessing Graph](using_postprocessing_graphs.md)
* [Postprocessing Graph Editor](postprocessing_graph_editor.md)
* [Default postprocessing graph](default_postprocessing_graph.md)
* [Custom postprocessing graph](custom_postprocessing_graph.md)
* [Postprocessing Graph Decorator](postprocessing_graph_decorator.md)