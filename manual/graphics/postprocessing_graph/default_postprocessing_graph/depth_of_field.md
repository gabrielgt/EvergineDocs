# Depth of Field (DoF)

The **Depth of Field (DoF)** effect tries to simulate the blur or *bokeh* observed in out-of-focus areas in the camera field of vision. The depth of field can be calculated based on focal length, distance to subject, the acceptable circle of confusion size, and aperture. A particular depth of field may be chosen for technical or artistic purposes.

![Depth of Field](images/DoF.jpg)

| Parameter  | Description |
| ---------- | ----------- |
| **Debug Mode** | Mode debug enabled draws red the nearest areas, green the focus areas and blue the farest areas. Only for debug proposes. | 
| **Focal Region** | Size of the focus area. |
| **Bokeh Shape** | Shape uses to simulate bokeh effect: _Circle_, _Pentagon_, _Hexagon_, _Heptagon_. |
| **Bokeh Size** | Size of the bokeh shapes. | 
| **Bokeh rotation** | Angle of the bokeh shapes. |
| **Near Fade Power** | Blur border size around the nearest areas.|

> [!Tip]
> The Focal Distance is a [Camera](../../cameras.md) parameter.