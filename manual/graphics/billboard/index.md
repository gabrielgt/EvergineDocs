# Billboard
---
![Billboards header](images/billboards.jpg)

**Billboard** is a quad orientated to face the camera. While the active camera in your scene is moving the billboard is orientated to face the camera. The billboards are useful to create an impostor of your far mesh to reduce the geometry that the render needs to draw. A common use is to simulate far bushes or trees.

There are two types of billboarding.
* **Point orientation**: The billboard is oriented about his origin to always face the camera. With this type of billboarding, the object will always appear the same to the camera, however, it will be affected by perspective.
* **Axial orientation**: The billboard is rotated about an axis to face towards the camera.

The following sections show how to create and use billboards in your scene.

## In this section

* [Create Billboard](create_billboard.md)