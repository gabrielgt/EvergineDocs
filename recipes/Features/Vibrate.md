# Vibrate Feature

Simple way to trigger the **vibration** on a device in your Wave Engine projects.

**Platform Support**

- Android
- iOS
- UWP

## Setup

You need to install the [Wave Engine NuGet package](https://www.nuget.org/packages/WaveEngine/) in every Platform project.

## Usage

From your Shared project you can access to the Connectivity Wave Engine feature using:

    IVibrate vibrate = WaveServices.Platform.Features.Vibrate;

This feature has just a simple **event**.

**StartVibrate**

With StartVibrate method you can vibrate the device for specified amount of time.

    /// <summary>
    /// Vibrate the device for specified amount of time
    /// </summary>
    /// <param name="milliseconds">Time in Milliseconds to vibrate. 500ms is default</param>
    void StartVibrate(int milliseconds = 500);

## Samples

The use of the vibration feature is extremely simple.

    IVibrate vibrate = WaveServices.Platform.Features.Vibrate;
	vibrate.StartVibrate(750);

We use the StartVibrate method to trigger the vibration on the device during 750 ms.