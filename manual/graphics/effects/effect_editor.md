# Effect Editor

![Material Editor Interface](images/EffectEditor.jpg)

**Effect Editor** allows editing the effect assets. Double click over a effect asset shown in [Assets Details](../../evergine_studio/interface.md) will open this editor. The editor is composed of 2 main parts Shader Text Editor and Viewport:

## **Shader Text Editor**

Shader text editor allows write your effects in [**HLSL**](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl-pguide) language with [**metatags**](effect_metatags.md). This editor has the common code editor feature included syntax highlighting and code completion (`Ctrl+Space`) that help you to create your custom effects.

| Actions | Description |
|---------| ----------- |
| Ctrl+Space | Code completion. |
| Ctrl+F | Search word toolbox |
| Alt+Left mouse button | Edit multiple code lines. |

### **Toolbox**

## **Viewport**

The properties of the material will be defined by the effect used. So first to edit or configure your material you need the select the effect that you want to use. The _Standard effect_ is the default effect used when you create a new material.

### **Toolbox**

### **Input Resources and properties**

The properties panel displays all effect properties or the [Material decorator](material_decorators.md) properties associated with the effect. You can configure your materials to change their properties and the result will be shown on the Viewport.