# Touch

The `PointerDispatcher` is a class used to track touch o pointer events. 

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