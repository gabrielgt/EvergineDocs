# Create Effects
---
![Effect header](images/effects.jpg)

An **effect** is a _uber-shader_ so be able to represent a single shader or a large group of shaders. There are two type of effect in Evergine:

<br> 

| Effect type | Description |
|------------ | ----------- |
| Graphics Effect | Defines a rasterization pipeline Vertex Shader, Geometry Shader, Hull Shader, Domain shader, Pixel Shader and are useful to create materials. |
| Compute Effect | Defines a compute pipeline with Compute Shader and are useful to create [compute task]() and [post-processing graph](../postprocessing/index.md) nodes.|

## Create a Effect asset in Evergine Studio

You can create an effect click button on ![Plus Icon](../images/plusIcon.jpg) from [Assets Details](../../evergine_studio/interface.md) panel to deploy a create menu options and click on the option _"Create effect->Graphics Effect or Compute Effect"_

![Create new effect menu option](images/AssetsDetailsMenu.jpg)

### Inspect effects in Asset Details

You can find the effect assets in the [**Assets Details**](../../evergine_studio/interface.md) panel when you select a folder in the [**Project Explorer**](../../evergine_studio/interface.md).

![Effect asset](images/effectAsset.jpg)

### Effects files in content directory

The effect file has the `.wefx` extension and always comes together with a folder with the same name of the effect. This folder contains the source code:

![Effect file](images/effectFile.jpg)

## Effect source code example
While Effects in Evergine uses HLSL as shading language, it is empowered by using differents [Metatags](effect_metatags.md) to automatize some tasks and help users.

A tipical effect code looks like this:

```csharp
[Begin_ResourceLayout]

    [Directives:UseTexture TEX_OFF TEX]

    cbuffer PerDrawCall : register(b0)
    {
        float4x4 WorldViewProj    : packoffset(c0);    [WorldViewProjection]
    };

    cbuffer Parameters : register(b1)
    {
        float3 Color            : packoffset(c0);   [Default(1, 1, 1)]
    };
    
    Texture2D ColorTexture       : register(t0);
    SamplerState ColorSampler    : register(s0);

[End_ResourceLayout]

[Begin_Pass:Default]
    [Profile 10_0]
    [Entrypoints VS=VertexShaderCode PS=PixelShaderCode]

    struct VS_IN
    {
        float4 Position : POSITION;
        #if TEX
        float2 TexCoord : TEXCOORD;
        #endif
    };

    struct PS_IN
    {
        float4 Pos : SV_POSITION;
        #if TEX
        float2 Tex : TEXCOORD;
        #endif
    };

    PS_IN VertexShaderCode(VS_IN input)
    {
        PS_IN output = (PS_IN)0;

        output.Pos = mul(input.Position, WorldViewProj);
        
        #if TEX
        output.Tex = input.TexCoord;
        #endif

        return output;
    }

    float4 PixelShaderCode(PS_IN input) : SV_Target
    {
        float4 color = float4(Color,1);
        
        #if TEX
        color *= ColorTexture.Sample(ColorSampler, input.Tex);
        #endif
        
        return color;
    }

[End_Pass]
```

An effect file in Evergine is divided into the following sections:
* Resource Layout definition
* List of Passes

### Resource Layout definition

This block of code defines all resources (Constant Buffers, Structured Buffers, Textures and Samplers) that will be used into your shaders.
This section is enclosed between `[Begin_ResourceLayout]` and `[End_ResourceLayout]` tags.

```csharp
[Begin_ResourceLayout]

    [Directives:UseTexture TEX_OFF TEX]

    cbuffer PerDrawCall : register(b0)
    {
        float4x4 WorldViewProj    : packoffset(c0);    [WorldViewProjection]
    };

    cbuffer Parameters : register(b1)
    {
        float3 Color            : packoffset(c0);   [Default(1, 1, 1)]
    };
    
    Texture2D ColorTexture        : register(t0);
    SamplerState ColorSampler    : register(s0);

[End_ResourceLayout]
```

In this example, :
* `[Directives:UseTexture TEX_OFF TEX]`:  This section contains a **Directive** (Called `UseTexture` in this example), which allows the users to enable different features in your effect.
  * This directive specifies two macros (`TEX_OFF` and `TEX`) which indicates if this shader will use a color texture or not. In your effect code you are free to define any number of directives as you can. The tradeof is that the number of possible effect combinations rise exponentially in proportion of the number of directives.
  * You can enable or disable features using macros into your shader with the `#if` `#else` and `#endif` preprocessor directives.
* The definition of two constant buffers, a Texture2D and a SamplerState:
  * `cbuffer PerDrawCall : register(b0) { ... }`: A constant buffer.
  * `cbuffer Parameters : register(b1) { ... }`: A second constant buffer.
  * `Texture2D ColorTexture : register(t0);`: A texture 2D.
  * `SamplerState ColorSampler : register(s0);`: A Sampler state.
* You would notice that you can add metatags to your constant buffers attributes to specify default values or to inject useful engine parameters. In the example we are using:
  *  The `[WorldViewProjection]` to inject the object world view projection matrix.
  *  The `[Default(1, 1, 1)]`, which indicate the default value of the `Color` attribute (white color in this example).

The majority of topics mentioned here is detailed in [Effect Metatags](effect_metatags.md) document.

### List of Passes

After the Resource Layout block, your code will specify a list of Passes, each Pass is defined using the `[Begin_Pass]` and `[End_Pass]` tags. Each pass requires a name, which will be used by the render path. As a naming convention, all render paths in Evergine must support the `Default` pass name.

In the previous effect example, a Default pass is defined:

```csharp
[Begin_Pass:Default]
    [Profile 10_0]
    [Entrypoints VS=VertexShaderCode PS=PixelShaderCode]

    struct VS_IN
    {
        float4 Position : POSITION;
        #if TEX
        float2 TexCoord : TEXCOORD;
        #endif
    };

    struct PS_IN
    {
        float4 Pos : SV_POSITION;
        #if TEX
        float2 Tex : TEXCOORD;
        #endif
    };

    PS_IN VertexShaderCode(VS_IN input)
    {
        PS_IN output = (PS_IN)0;

        output.Pos = mul(input.Position, WorldViewProj);
        
        #if TEX
        output.Tex = input.TexCoord;
        #endif

        return output;
    }

    float4 PixelShaderCode(PS_IN input) : SV_Target
    {
        float4 color = float4(Color,1);
        
        #if TEX
        color *= ColorTexture.Sample(ColorSampler, input.Tex);
        #endif
        
        return color;
    }

[End_Pass]
```

In this pass, you will find:
* The `[Entrypoints VS=... PS=...]` tag, wich defines the entry point per each render pipeline stage. In the example, you are indicating that this pass will use the following entry points:
  * `VS=VertexShaderCode`: During the **Vertex Shader** stage, the VertexShaderCode function will be executed.
  * `PS=PixelShaderCode`: During the **Pixel Shader** stage, the PixelShaderCode function will be executed.
* Hereafter, a typical HLSL shader code is written. You are free to define structures, functions and uses all resources defined inside Resource Layout section.

As we mentioned earlier, visit [Effect Metatags](effect_metatags.md) for more information.

## Create a new Effect from code

The following sample code can be used to create a new effect and its associated material to apply to an entity in your scene.

```csharp
protected override void CreateScene()
{
    protected override void CreateScene()
        {
            var graphicsContext = Application.Current.Container.Resolve<GraphicsContext>();
            var assetsService = Application.Current.Container.Resolve<AssetsService>();

            string shaderSource = @"
                [Begin_ResourceLayout]

                    cbuffer PerDrawCall : register(b0)
                    {
                        float4x4 WorldViewProj    : packoffset(c0);    [WorldViewProjection]
                    };

                    cbuffer Parameters : register(b1)
                    {
                        float3 Color            : packoffset(c0);   [Default(1.0, 0.0, 0.0)]
                    };

                [End_ResourceLayout]

                [Begin_Pass:Default]
                    [Profile 10_0]
                    [Entrypoints VS=VS PS=PS]

                    struct VS_IN
                    {
                        float4 Position : POSITION;
                        float3 Normal    : NORMAL;
                        float2 TexCoord : TEXCOORD;
                    };

                    struct PS_IN
                    {
                        float4 pos : SV_POSITION;
                        float3 Nor    : NORMAL;
                        float2 Tex : TEXCOORD;
                    };

                    PS_IN VS(VS_IN input)
                    {
                        PS_IN output = (PS_IN)0;

                        output.pos = mul(input.Position, WorldViewProj);
                        output.Nor = input.Normal;
                        output.Tex = input.TexCoord;

                        return output;
                    }

                    float4 PS(PS_IN input) : SV_Target
                    {
                        return float4(Color,1);
                    }

                [End_Pass]
            ";

            // Create effect
            Effect myEffect = new EffectFromCode(graphicsContext, shaderSource);

            // Create material asociated
            Material myMaterial = new Material(myEffect)
            {
                LayerDescription = assetsService.Load<RenderLayerDescription>(EvergineContent.RenderLayers.Opaque),
            };

            // Apply to an entity
            Entity primitive = new Entity()
                    .AddComponent(new Transform3D())
                    .AddComponent(new MaterialComponent() { Material = myMaterial })
                    .AddComponent(new SphereMesh())
                    .AddComponent(new MeshRenderer());

            this.Managers.EntityManager.Add(primitive);
        }
}