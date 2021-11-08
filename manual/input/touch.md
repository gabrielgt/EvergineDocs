# Touch

Touch is the most common input system on mobile devices. **Pointers** are points on the device screen corresponding to **finger touches**. Devices with multi-touch functionality support multiple simultaneous pointers.

## PointerDispatcher

The `PointerDispatcher` is a class used to track pointer events. 

```csharp
public abstract class PointerDispatcher
{
    public IList<PointerPoint> Points { get; }

    public event EventHandler<PointerEventArgs> PointerDown;
    public event EventHandler<PointerEventArgs> PointerUp;
    public event EventHandler<PointerEventArgs> PointerMove;
}
```

`Points` property gets a list of points detected inside the surface at the current frame.

`PointerDown`, `PointerUp` and `PointerMove` events are available to track touch and pointer points.

### PointerPoint
The PointerPoint class give the following information:

| Property | Description |
| --- | --- |
| **Id** | A number that is uniquely associated to this touch. It is usually given by the underliying platform. |
| **Position** | The pointer position in screen coordinates |
| **State** | Get the current pointer state. See [Button States](button_states.md) for more information. |

### Using PointerDispatcher
The `PointerDispatcher` can be found within the `Display` or `Surface` objects. The following sample code can be used to access the pointer dispatcher from a `Component` or `Service`.

```csharp
[BindService]
protected GraphicsPresenter graphicsPresenter;

protected override void Update(TimeSpan time)
{
    PointerDispatcher pointerDispatcher = this.graphicsPresenter.FocusedDisplay?.PointerDispatcher;

    if (keyboardDispatcher == null)
    {
        return;
    }

    foreach (PointerPoint p in keyboardDispatcher.Points)
    {
        if (p.State == ButtonState.Pressing)
        {
            // Do something
        }
    }
}
```