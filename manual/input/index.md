# Input
---

Reading the application input is the most essential part of providing user interaction in graphic applications. Every application should support at least one input device.

Evergine captures [keyboard](keyboard.md), [mouse](mouse.md) and [touch](touch.md) from different surfaces and map the results into a unified API with same key definitions and expected behavior.

## Input and Surfaces

In Evergine, each application Surface exposes different Input dispatchers. So, for example, an Evergine application could launch two separate windows, and each surface may be interacted only when this window is focused.

## In this section
* [Button states](button_states.md)
* [Keyboard](keyboard.md)
* [Mouse](mouse.md)
* [Touch](touch.md)