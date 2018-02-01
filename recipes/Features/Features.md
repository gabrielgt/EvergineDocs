## Goal

Adapting the experience of our game to the characteristics and the state of the device where it is executed is important. Adapt the game based on whether there is an active connection or if the device has a low battery.

Wave Engine comes with sime nice **features** system which makes those tasks particularly easy. 

## Hands-on

There are four available features in this moment:

- **Battery**: check battery status of device, get remaining percentage and other nice features.
- **Connectivity**: check connectivity of device.
- **Vibration**: simple way to trigger the vibration on a device in your Wave Engine projects.
- **GPS**: 

### Battery

From your Shared project you can access to the Battery Wave Engine feature using:

    IBattery battery = WaveServices.Platform.Features.Battery;

Using battery feature you can get information related to the battery status.

    IBattery battery = WaveServices.Platform.Features.Battery;
	int remainingChargePercent = battery.RemainingChargePercent;
    BatteryStatus batteryStatus = battery.Status;

## Connectivity 

The Wave Engine applications and games can be adapted to differents network states.

    IConnectivity connectivity = WaveServices.Platform.Features.Connectivity;
    connectivity.IsConnectedChanged += OnIsConnectedChanged;
    
    
    private void OnIsConnectedChanged(object sender, IsConnectedChangedEventArgs e)
    {
         var isConnected = e.IsConnected;
    }

The `IsConnectedChanged` event will be fired every time the connection change. Using the `IsConnectedChangedEventArgs` argument can determinate if the device is connected or nor.

## Vibration

The use of the vibration feature is extremely simple.

    IVibrate vibrate = WaveServices.Platform.Features.Vibrate;
	vibrate.StartVibrate(750);

We use the StartVibrate method to trigger the vibration on the device during 750 ms.

## GPS

The use of the gps feature is extremely simple.

    IGPS gps = WaveServices.Platform.Features.GPS;
	this.gps.PositionChanged += Gps_PositionChanged;
    this.gps.StartListeningAsync(TimeSpan.FromSeconds(0.1), 0.1);

    private void Gps_PositionChanged(object sender, PositionEventArgs e)
    {
        ...
    }

The `PositionChanged` event will be fired everty time the gps location changes.