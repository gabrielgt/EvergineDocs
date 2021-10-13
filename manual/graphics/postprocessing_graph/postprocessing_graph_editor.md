# Postprocessing Graph Editor
---
![Postprocessing Graph Interface](images/PostprocessingGraphEditor.jpg)

**Postprocessing Graph Editor** allows editing the Postprocessing Graph assets. Double click over a postprocessing graph asset shown in [Assets Details](../../evergine_studio/interface.md) will open this editor. The editor is composed of 3 main parts Graph Editor, Compute Effects collection and Viewport.

## **Graph Editor**

The **Graph Editor** allows creating the graph nodes to connect the start node (_Render_) with the last node (_Screen_). The nodes are computed effects and his parameters, input, and output are defined by his ResourceLayout block.

| Node elements | Description |
| ------------- | ----------- |
| Name          | Located on top of the Node is the name of the compute effect used. |
| Divisors      | Allows configure the ThreadGroupDivisor X,y and Z to dispatch the compute effect.
| Parameters    | Allows configuring constant buffer or structure buffer properties to the compute effect. |
| Input         | Allows set Textures and Samplers to the compute effect. |
| Output        | Allows set RWTextures to the compute effect. |

![Node Parts](images/PostprocessingNode.jpg)

> [!Tip]
>The node inputs only can be connected with a single node output but a node output can be connected with multiple node inputs.

### **Toolbox**

The graph editor toolbox is located on the top side of the graph editor and allows to manipulate the graph view.

| Icon  | Description |
| ----- | ----------- |
|![Delete](images/deleteIcon.jpg)| Delete the selected node. |
|![Relocate](images/relocateIcon.jpg)    | Execute an algorithm to relocated nodes and avoid node overlapping. |
|![Zoom In](images/zoomInIcon.jpg) ![Zoom Out](images/zoomOutIcon.jpg) | Zoom in/out the graph. |
|![Center](images/centerIcon.jpg) | Center the view over the graph. |

| Actions | Description |
|---------| ----------- |
| Left mouse button | Selection tool. Allows to select a single or multiple nodes.|
| Right mouse button | Cut tool. Allows the draw a cut line to break conections.|
| Medium mouse button | Pan tool. Allows to move along the graph.|
| Mouse wheel | Allows to make zoom in/out over the graph.  |

## **Compuse Effects Collection**
In this panel, you can find all compute effects existing in the project and drag an effect to the graph editor to use it.

## **Viewport**
Allows seeing the result of the postprocessing graph applied to the scene _(Note. requires save the graph)_.

| Icon  | Description |
| ----- | ----------- |
|![Select scene](images/sceneIcon.jpg)| The combobox allows to select the current scene for the viewport.|
|![Camera settings](images/cameraIcon.jpg)    | Opens the camera settings to configure all its parameters. The camera changes are not stored so it is only for testing proposes. |

| Actions | Description |
|---------| ----------- |
| W,S,D,A | Move camera along the scene.|
| Right mouse button | Rotates camera. |
| Medium mouse button | Camera panning. |
| Mouse wheel | Camera zoom in/out.  |