# Effect Metatags

In evergine the effect are written in [**HLSL**](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl-pguide) languages, but to automatize some tasks evergine includes an additional tags that you can add to the HLSL code.

## Block Metatags

Effect code are organize in two importants kind of blocks:

| Block     | Tags      | Description        |
| --------- | --------- | ------------------ |
| Resource Layout | [Begin_ResourceLayout] <br> [End_ResourceLayout] | This block of code defines all resources (Constant Buffers, Structured Buffers, Textures and Samplers) using by all effect passes. |
| Pass | [Begin_Pass:PassName] <br> [End_Pass] | This block of code defines a RenderPipeline pass. The _DefaultRenderPipeline_ defines 3 passes that any effect can define:  ZPrePass, Distortion, Default |

## Pass settings

These tags are used inside of a pass block code and are useful to configure which settings do you want to compile this pass.

| Tag   | Description  |
| ----- | ------------ |
| [Profile `API_Level`] | Defines HLSL language version and capabilities. The API level values could be: <ul><li>**9_1:** DirectX9.1 HLSL 3.0.</li><li>**9_2:** DirectX 9.2 HLSL 3.0</li><li>**9_3:** DirectX 9.3 HLSL 3.0</li><li>**10_0:** DirectX 10 HLSL 4.0</li><li>**10_1:** DirectX 10.1 HLSL 4.1</li><li>**11_0:** DirectX 11 HLSL 5.0</li><li>**11_1:** DirectX 11 HLSL 5.0</li><li>**12_0:** DirectX 12 HLSL 6.0</li><li>**12_1:** DirectX 12 HLSL 6.1</li><li>**12_3:** DirectX 12 HLSL 6.3 (Raytracing)</li></ul>
| [Entirypoints `Stage=MethodName`] | Defines the entrypoint stage methods of the pass. The valid stages values are: <ul><li>**VS:** Vertex Shader.</li><li>**HS:** Hull Shader.</li><li>**DS:** Domain Shader.</li><li>**GS:** Geometry Shader.</li><li>**PS:** Pixel Shader.</li><li>**CS:** Compute Shader.</li></ul>
| [Mode `value`]| Defines the compilation mode of the pass. Available mode list:<ul><li>**None:** Default compilation mode.</li><li>**Debug:** Debug mode includes depuration symbols to analyze with shader tools like [RenderDoc](https://renderdoc.org/), [PIX](https://devblogs.microsoft.com/pix/introduction/) or [NVidia Nsight Graphics](https://developer.nvidia.com/nsight-graphics)</li><li>**Release:** Optimize compilation mode.</li></ul> |


