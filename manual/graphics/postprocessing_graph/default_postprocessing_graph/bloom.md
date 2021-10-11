# Bloom, Dirt, LightShaft and Lensflare
---
In this section, multiples effects are explained because the process steps to calculate them are similar and by performance reason, the effects have been implemented together.

## Bloom

The effect produces fringes (or feathers) of light extending from the borders of bright areas in an image, contributing to the illusion of an extremely bright light overwhelming the camera or eye capturing the scene.

![Bloom](images/bloom.jpg)

| Parameter  | Description |
| ---------- | ----------- |
| Threshold  | The pixels with a luminance higher than threshold value will apply the effect. |
| Color Intensity | Defines the bloom color intensity in the final blend image. |
| Intensity | Defines how the render image and the bloom output will be blended. |

## Dirt

This effect tries to simulate when the camera lens is dirty and some lens stains are visible.

| Parameter  | Description |
| ---------- | ----------- |
| Texture | Dirt texture used. |
| Intensity | Dirt intentsity or how the render image and the dirt output will be blended. |

## LightShaft

**LightShaft** or only known as **God Rays** allows the viewer to see beams of light shining across the environment.

| Parameter  | Description |
| ---------- | ----------- |
| Min.Threshold | Minimun luminance of the pixel will be affected by the effect. |
| Max. Threshold | Maximum luminance of the pixel will be affected by the effect. |
| Scale | -- |
| Intensity | Defines how the render image and the bloom output will be blended. |

## LensFlare

A **Lens flare** happens when light is scattered or flared in a lens system, often in response to a bright light, producing a sometimes undesirable artifact in the image. This happens through light scattered by the imaging mechanism itself, for example through internal reflection and forward scatter from material imperfections in the lens.

| Parameter  | Description |
| ---------- | ----------- |
| Ghost Count | The ghost image number. |
| Ghost Spacing | The distance between ghost elements. |
| Ghost threshold | The pixels with upper luminance value to the threshold will be used to generate the ghost elements. |
| Halo radius | External halo radius. |
| Halo thickness | External halo thickness. |
| Halo threshold | The pixels with upper luminance value to the threshold will be used to generate the halo. |
| Halo Chro. Aberration | Amout of chromatic aberration. |
| Intensity | -- |