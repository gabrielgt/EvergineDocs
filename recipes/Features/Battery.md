# Battery Feature

Wave Engine has cross platform feature to check battery status of device, get remaining percentage and other nice features.

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

From your Shared project you can access to the Battery Wave Engine feature using:

    IBattery battery = WaveServices.Platform.Features.Battery;

This feature has some **properties** and **events**.

###Properties 

**RemainingChargePercent**

Get the current charge **percent** of the battery. Is value between 0 and 100.

    /// <summary>
    /// Current battery level 0 - 100
    /// </summary>
    int RemainingChargePercent { get; }


**Status**

The **status** of the battey. 

    /// <summary>
    /// Gets the current battery status
    /// </summary>
    WaveBatteryStatus Status

This use an enum with the current status of the battery:

- **Unknown**: The battery is in an unknown state.
- **Charging**: The battery is plugged in and charging.
- **Discharging**: The battery is currently discharging.
- **Full**: The battery is completely full.
- **NotCharging**: The battery is neither charging nor discharging.
- **NoBattery**: The battery is not present.

**PowerSource**

Returns how the phone is being charged.

    /// <summary>
    /// Currently how the battery is being charged.
    /// </summary>
    PowerSource PowerSource { get; }

The PowerSource enum:

- **None**: No external power source.
- **Ac**: Charging from AC.
- **usb**: Charging from USB.
- **Wireless**: Charging with a wireless charger.

### Events

**BatteryChangedEventArgs** 

This occurs when plugged, unplugged, or battery change.

    /// <summary>
    /// Event handler when battery changes
    /// </summary>
    event BatteryChangedEventHandler BatteryChanged;

## Samples

Using battery feature you can get information related to the battery status.

    IBattery battery = WaveServices.Platform.Features.Battery;
	int remainingChargePercent = battery.RemainingChargePercent;
    BatteryStatus batteryStatus = battery.Status;


