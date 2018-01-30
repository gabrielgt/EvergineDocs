# Connectivity Feature

Wave Engine has cross platform feature to check connectivity of device and more.

**Platform Support**

- Android
- iOS
- Linux
- macOS
- UWP
- Windows

##Setup

You need to install the [Wave Engine NuGet package](https://www.nuget.org/packages/WaveEngine/) in every Platform project.

## Usage

From your Shared project you can access to the Connectivity Wave Engine feature using:

    IConnectivity connectivity = WaveServices.Platform.Features.Connectivity;

This feature has some **properties** and **events**.

### Properties 

**IsConnected**

Gets if there is an active internet connection.

    /// <summary>
    /// Gets if there is an active internet connection
    /// </summary>
    bool IsConnected { get; }

### Events 

**IsConnectedChanged**

You can subscribe to IsConnectedChanged, which will return **IsConnectedChangedEventArgs** with all information you need. This occurs when the connection changes.

    /// <summary>
    /// Event handler for connection changes.
    /// </summary>
    event ConnectivityIsConnectedChangedEventHandler IsConnectedChanged;

## Samples

The Wave Engine applications and games can be adapted to differents network states.

    IConnectivity connectivity = WaveServices.Platform.Features.Connectivity;
    connectivity.IsConnectedChanged += OnIsConnectedChanged;
    
    
    private void OnIsConnectedChanged(object sender, IsConnectedChangedEventArgs e)
    {
         var isConnected = e.IsConnected;
    }

The `IsConnectedChanged` event will be fired every time the connection change. Using the `IsConnectedChangedEventArgs` argument can determinate if the device is connected or nor.