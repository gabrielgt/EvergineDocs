# Keyboard

The `KeyboardDispatcher` is a class used to track keyboard key events. 

```csharp
public abstract class KeyboardDispatcher
{
    public event EventHandler<KeyCharEventArgs> KeyChar;
    public event EventHandler<KeyEventArgs> KeyDown;
    public event EventHandler<KeyEventArgs> KeyUp;

    public bool IsKeyDown(Keys key);
    public ButtonState ReadKeyState(Keys key);
}
```

`KeyChar` event is useful for text input. It occurs when a key is pressed and a character is generated.

`KeyDown` and `KeyUp` events are available to track keyboard pressed keys but it is recommended to use `IsKeyDown` and `ReadKeyState` methods.
 - IsKeyDown: Gets a value indicating whether the current state of a keyboard key is [Pressing](button_states.md) or [Pressed](button_states.md).
 - ReadKeyState: Gets the current [state](button_states.md) of a keyboard key.

The `KeyboardDispatcher` can be found within the `Display` or `Surface` objects. The following sample code can be used to access the keyboard dispatcher from a `Component` or `Service`.

```csharp
[BindService]
protected GraphicsPresenter graphicsPresenter;

protected override void Update(TimeSpan time)
{
    KeyboardDispatcher keyboardDispatcher = this.graphicsPresenter.FocusedDisplay?.KeyboardDispatcher;

    if (keyboardDispatcher?.ReadKeyState(Keys.A) == ButtonState.Pressing)
    {
        // Do something
    }
}
```