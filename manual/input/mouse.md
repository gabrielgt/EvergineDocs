# Mouse

The `MouseDispatcher` is a class used to track mouse button events. It inherits from [`PointerDispatcher`](touch.md) so it can be used to produce touch events using the mouse.

```csharp
public abstract class MouseDispatcher : PointerDispatcher
{
    public MouseButtons State { get; }
    public Point ScrollDelta { get; }
    public Point PositionDelta { get; }
    public Point Position { get; }
    public abstract CursorTypes CursorType { get; }
    public bool IsMouseOver { get; }

    public event EventHandler<MouseButtonEventArgs> MouseButtonUp;
    public event EventHandler<MouseButtonEventArgs> MouseButtonDown;
    public event EventHandler<MouseEventArgs> MouseLeave;
    public event EventHandler<MouseEventArgs> MouseEnter;
    public event EventHandler<MouseEventArgs> MouseMove;
    public event EventHandler<MouseScrollEventArgs> MouseScroll;

    public bool IsButtonDown(MouseButtons button);
    public ButtonState ReadButtonState(MouseButtons button);
    public bool TrySetCursorPosition(Point position);
    public abstract bool TrySetCursorType(CursorTypes cursorType);
}
```
`State` property gets a flag enum that indicates which mouse buttons are pressed at the current frame.

`ScrollDelta` property gets the mouse scroll increment since the last frame.
 - The value *X* indicates a horizontal scroll increment. The value is positive if the mouse wheel is rotated to the right or negative if the mouse wheel is rotated to the left.
 - The value *Y* indicates a vertical scroll increment. The value is positive if the mouse wheel is rotated in an upward direction (away from the user) or negative if the mouse wheel is rotated in a downward direction (toward the user).

`PositionDelta` property gets the mouse delta position since the last frame.

`Position` property gets the mouse absolute position at the current frame.

`CursorType` property gets the mouse active cursor type.

`IsMouseOver` property indicates whether the mouse is inside the `Surface`.

`MouseButtonUp` and `MouseButtonDown` events are available to track mouse pressed buttons but it is recommended to use `IsButtonDown` and `ReadButtonState` methods.
 - IsButtonDown: Gets a value indicating whether the current state of a mouse button is [Pressing](button_states.md) or [Pressed](button_states.md).
 - ReadButtonState: Gets the current [state](button_states.md) of a mouse button.

`MouseLeave` and `MouseEnter` events are available to track changes in `IsMouseOver` property.

`MouseMove` and `MouseScroll` events are available to track changes in mouse position and scroll.

`TrySetCursorPosition` and `TrySetCursorType` methods can be user to try to update the position and and cursor type. When this action is supported by the platform, these methods will return *true*; otherwise *false*.

The `MouseDispatcher` can be found within the `Display` or `Surface` objects. The following sample code can be used to access the mouse dispatcher from a `Component` or `Service`.

```csharp
[BindService]
protected GraphicsPresenter graphicsPresenter;

protected override void Update(TimeSpan time)
{
    MouseDispatcher mouseDispatcher = this.graphicsPresenter.FocusedDisplay?.MouseDispatcher;

    if (mouseDispatcher?.ReadKeyState(MouseButtons.Left) == ButtonState.Pressing)
    {
        // Do something
    }
}
```