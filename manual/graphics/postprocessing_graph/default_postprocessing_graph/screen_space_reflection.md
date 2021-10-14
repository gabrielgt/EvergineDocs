# Screen Space Reflection (SSR)
---
This effect allows to simulate real time reflection surface. The effect uses the depth buffer to throw rays from reflection surface.

![SSR](images/SSR.jpg)

| Parameter  | Description |
| ---------- | ----------- |
| Num. Rays  | Number of rays per pixel. |
| Max. Reflection Distance | Maximum ray reflection distance |
| Refinement steps | After the ray hit detection, number of steps of the refinement hit algoritm. |
| Pixel Thickness | Helps to avoid depth shadow areas. |
| Max. Roughness | Maximun roughness value which the reflection will be calculated. |
| Intensity | Blend with original render. |
| Debug Mode Enable | Allows to check only the reflection output. |