# GPS Feature

Wave Engine has cross platform feature to check GPS status of the device.

**Platform Support**

- Android
- iOS
- Linux
- macOS
- UWP
- Windows

##Setup

You need to install the [Wave Engine NuGet package](https://www.nuget.org/packages/WaveEngine/) from version 2.4 or higher in every Platform project.

## Usage

From your Shared project you can access to the GPS Wave Engine feature using:
```c#
    IGPS gps = WaveServices.Platform.Features.GPS;
```    

This feature has some **properties** and **events** that you can reach at [GPS documentation](xref:WaveEngine.Common.Features.GPS.IGPS))

## Samples

Using GPS feature you can get the location of the device.

```c#
    var gps = WaveServices.Platform.Features.GPS;
    gps.DesiredAccuracy = 0.1;

    this.gps.PositionChanged += Gps_PositionChanged;
    this.gps.StartListeningAsync(TimeSpan.FromSeconds(0.1), 0.1);

    private void Gps_PositionChanged(object sender, PositionEventArgs e)
    {
    ...
    }
```


