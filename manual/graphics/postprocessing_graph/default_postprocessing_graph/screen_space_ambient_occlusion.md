# Screen Space Ambient Occlusion (SSAO)
---
This effect generates darkness over the areas with geometries very close to it, simulating ambient light. This effect uses the depth framebuffer data this effect throws several rays into a range in different directions from each pixel. If a ray hits with any geometry the pixel will be dark. The darkest pixel will be where all his rays hit with something and the lightest pixel will be where his rays didn't hit with anything.

![SSAO](images/SSAO.jpg)
In the above picture you can see first the scene without effect applied, then the scene with the SSAO output, and finally the blend combination between original render and SSAO output.

| Parameter  | Description |
| ---------- | ----------- |
| SPP        | Samples per pixel.   |
| Range      | Range around the point using to calculate close geometries. |
| Power      | Amount of darkness |
| Scale Bias | --  |
| Intensity  | Intensity of the blend with render image. |