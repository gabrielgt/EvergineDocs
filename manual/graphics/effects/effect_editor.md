# Effect Editor

![Material Editor Interface](images/EffectEditor.jpg)

**Effect Editor** allows editing the effect assets. Double click over a effect asset shown in [Assets Details](../../evergine_studio/interface.md) will open this editor. The editor is composed of 2 main parts Shader Text Editor and Viewport:

## **Shader Text Editor**

The shader text editor allows writing your effects in [**HLSL**](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl-pguide) language with [**metatags**](effect_metatags.md). This editor has the common code editor feature included error marks, syntax highlighting and code completion (`Ctrl+Space`) that help you to create your custom effects. 

| Actions | Description |
|---------| ----------- |
| Ctrl+Space | Code completion. |
| Ctrl+F | Search word toolbox |
| Alt+Left mouse button | Edit multiple code lines. |

The effect are compiled automatically while your are writing the shader and on the editor bottom side you can see the compilation process result.

![Compilation result](images/compilationResult.jpg)

When the compilation result in errors, you can click on the error text and de editor will mark the error line and scroll view to it.

### **Toolbox**
The shader text editor has a toolbox that help you with some important task as enable/disable directives, generate material decorator associated or configure effect asset properties. The complete option list is:

| Icon  | Description |
| ----- | ----------- |
|![Compilation](images/CompilationIcon.jpg)![Compilation](images/Compilation2Icon.jpg) | Toggle button to indicate if the automatic compilation mode is enabled or manual compilation mode _(Key `F5`)_ is enabled. |
|![Pass](images/PassIcon.jpg) | Combo box to enable the current effect pass. |
|![Directives](images/DirectivesIcon.jpg) | Shows the effect directive list and allows enable/disable combinations. |
|![Snippets](images/SnippetsIcon.jpg) | Allow to add common snippet codes into your effects. |
|![Material Decorator](images/MaterialDecoratorIcon.jpg) | Generates the Material Decorator class in your project. |
|![All Combinations](images/CombinationsIcon.jpg) | Compiles all directive combinations and shows the combinations with errors. |
|![Translate](images/TranslationIcon.jpg) | Shows the automatically translation from original `HLSL` to `SPIRV`(Vulkan), `GLSL`(OpenGL/OpenGLES) or `MSL`(Metal) when it will be used in other backends. |
|![Profile](images/ProfileIcon.jpg) | Allows configure the asset profile as: exclude effect on a single platform or pre-compile effect for a single platform. |

### Translation Panel
The translation panel is shown below the shader text editor after click on ![Translate](images/TranslationIcon.jpg) button and shows the result to translate the HLSL current pass and directive combinations to other languages. The panel includes two combo boxes to select the translation languages: `GLSL`, `ESSL`, `WebGL1`, `WebGL2`, `MSL` or `SPIRV` and another to select the stage to translate: _Vertex_, _Geometry_, _Hull_, _Domain_ or _Compute_.

![Translation Panel](images/translationPanel.jpg)

### Profile Panel
This panel allows to configure the effect asset properties by platform. The first tab is the default or global configuration but you can modify the default configuration using the platform tabs. 
<br>
The effect asset properties are:
| Property | Values | Description |
| -------- | ------ | ----------- |
| ExludeAsset | True, false | If is enabled the effect asset will be exclude in the build project for the plaform. If it is enable in the Default configuration tab the asset never will be include in the build project process. |
| GraphicsBackend | ByPlatform, DirectX11, DirectX12, OpenGL, OpenGLES, Metal, Vulkan, WebGL1, WebGL2 or WebGPU. | Defines the backend and languages that the effect will be translation and compile. ByPlatform value indicates that the data will get from project settings (`weproj` file)|
| Compile | ByPlatform, Yes or No | Defines if the effect will be pre-compiled or no. ByPlatform value indicates that the data will get from project settings (`weproj` file). |

## **Viewport** [WIP]

### **Toolbox**

### **Input Resources and properties**
