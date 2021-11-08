# Screen Space Ambient Occlusion (SSAO)

The **Screen Space Ambient Occlusion (SSAO)** effect approximates Ambient Occlusion in realtime, as an image post-processing effect. It darkens creases, holes and surfaces that are close to each others. In real life, such areas tend to block out or occlude ambient light, hence they appear darker.

This effect uses the depth framebuffer data and throws several rays into a range in different directions from each pixel. If a ray hits with any geometry the pixel will become darker. The darkest pixel will be the one that all rays hit with something, and in the other part, the lightest pixel will occurs where all his rays didn't hit with anything.

![SSAO](images/SSAO.jpg)

In the above picture you can see first the scene without effect applied, then the scene with the SSAO output, and finally the blend combination between original render and SSAO output.

## SSAO Parameters

| Parameter  | Description |
| ---------- | ----------- |
| **SPP**        | Samples per pixel. |
| **Range**      | Range around the point using to calculate close geometries. |
| **Power**      | Amount of darkness |
| **Scale Bias** | --  |
| **Intensity**  | Intensity of the blend with render image. |