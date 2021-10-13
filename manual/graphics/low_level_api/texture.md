# Texture

A texture stores texel information.

## Creation

```csharp
uint expectedSize = 256;
ResourceUsage expectedUsage = ResourceUsage.Default;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = expectedUsage,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = expectedFormat,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);
```

## Usage examples

### How to update a default texture

```csharp
uint expectedSize = 256;
ResourceUsage expectedUsage = ResourceUsage.Default;
PixelFormat expectedFormat = PixelFormat.R8G8B8A8_UNorm;

var description = new TextureDescription()
{
    Type = TextureType.Texture2D,
    Width = expectedSize,
    Height = expectedSize,
    Depth = 1,
    ArraySize = 1,
    Faces = 1,
    Usage = expectedUsage,
    CpuAccess = ResourceCpuAccess.None,
    Flags = TextureFlags.None,
    Format = expectedFormat,
    MipLevels = 1,
    SampleCount = TextureSampleCount.None,
};

var texture = this.GraphicsContext.Factory.CreateTexture(ref description);

float[] data = Enumerable.Range(0, (int)(expectedSize * expectedSize)).Select(i => (float)i).ToArray();

this.GraphicsContext.UpdateTextureData(texture, data);
texture.Dispose();
```

### How to set 