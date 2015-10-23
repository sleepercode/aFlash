Flashlight
=================
<a href="https://platform.telerik.com/#appbuilder/clone/https%3A%2F%2Fgithub.com%2FIcenium%2Fsample-flashlight" target="_blank"><img src="http://docs.telerik.com/platform/appbuilder/sample-apps/images/try-in-appbuilder.png" alt="Try in AppBuilder" title="Try in AppBuilder" /></a>  <a href="https://github.com/Icenium/sample-custom-url-scheme" target="_blank"><img style="padding-left:20px" src="http://docs.telerik.com/platform/samples/images/get-github.png" alt="Get from GitHub" title="Get from GitHub"></a>

<a id="top"></a>
* [Overview](#overview)
* [Showcased APIs](#showcased-apis)
* [Important Directories and Files](#important-directories-and-files)
* [Screenshots](#screenshots)
* [Test the Sample](#test-the-sample)
* [Limitations](#limitations)

This sample shows you how to use the Flashlight custom Apache Cordova plugin. This plugin lets you use the built-in flash of the device camera to turn your device into a torch.

> *Supported mobile platforms:* iOS, Android, Windows Phone
>
> *Developed with:* Apache Cordova 3.7.0, Flashlight 2.0.9

[Back to Top](#top)

# Showcased APIs

This sample includes the [Flashlight API][Flashlight API] as a custom Apache Cordova plugin and uses the following plugin methods.

* **flashlight.available()**: Checks if the device has a camera with a flash.
* **flashlight.toggle()**: Turns the device flash on or off.

[Back to Top](#top)

# Important Directories and Files

* `Plugins\Flashlight`: Contains the Flashlight custom plugin.

[Back to Top](#top)

# Screenshots

Platform | Home
---|---
All | ![](https://raw.githubusercontent.com/Icenium/sample-flashlight/master/screenshots/home.png)

[Back to Top](#top)

# Test the Sample

Apart from exploring the sample code base in GitHub, you can also clone and run the sample in your preferred AppBuilder client.

## In-Browser

With the AppBuilder in-browser client, you can develop hybrid and NativeScript cross-platform mobile apps from your browser. You can use the in-browser client at [https://platform.telerik.com](https://platform.telerik.com).

### Clone the sample

1. Click **Try in AppBuilder** above.
1. Provide your login credentials, if prompted.

### Run the sample

* [Deploy on device via QR code.][QR code in-browser]

[Back to Top](#top)

## Windows

With the AppBuilder Windows client, you can develop hybrid and NativeScript cross-platform mobile apps from your Windows desktop. You can download and install the Windows client from [http://www.telerik.com/appbuilder/windows-client](http://www.telerik.com/appbuilder/windows-client).

### Clone the sample

1. Verify that the AppBuilder Windows client is running and you are logged in the Telerik Platform in the account in which you want to develop your application.
1. In the dashboard, click **Samples** and select **Hybrid**.
1. From the **Workspace** drop-down menu, select the workspace in which you want to develop your application.
1. Select **Advanced APIs**.
1. Select **Flashlight**.
1. (Optional) Rename the project.
1. Click **Clone**.

### Run the sample

With the AppBuilder Windows client, you can quickly test your apps on device, in the simulator or in the native emulators.

1. [Run in the native emulators.][emulators windows]
1. [Deploy on device via QR code.][QR code windows]
1. [Deploy on device via USB cable.][USB deploy windows]

[Back to Top](#top)

## Visual Studio

With the AppBuilder extension for Visual Studio, you can develop hybrid and NativeScript cross-platform mobile apps from Microsoft Visual Studio. You can download and install the extension from [http://www.telerik.com/appbuilder/visual-studio-extension](http://www.telerik.com/appbuilder/visual-studio-extension).

### Clone the sample

1. Verify that the AppBuilder extension for Visual Studio is running and you are logged in the Telerik Platform in the account in which you want to develop your application.
1. Select **AppBuilder** &#8594; **Get Sample**.
1. Select **Hybrid**.
1. Select **Advanced APIs**.
1. Select **Flashlight**.
1. (Optional) Rename the project.
1. Click **Get**.

The extension for Visual Studio copies the sample files locally. The extension creates a new solution and project and loads them.

### Run the sample

With the AppBuilder extension for Visual Studio, you can quickly test your apps on device, in the simulator or in the native emulators.

1. [Run in the native emulators.][emulators vse]
1. [Deploy on device via QR code.][QR code vse]
1. [Deploy on device via USB cable.][USB deploy vse]

[Back to Top](#top)

## CLI

With the AppBuilder command-line interface, you can develop hybrid and NativeScript cross-platform mobile apps from the command line. You can learn how to add the AppBuilder commands to your command line from [http://www.telerik.com/appbuilder/command-line-interface](http://www.telerik.com/appbuilder/command-line-interface).

### Clone the sample

1. Verify that a command prompt is running and you are logged in the Telerik Platform in the account in which you want to develop your application.
1. To list the available samples, run the following command.

	```bash
	appbuilder sample
	```
1. Run the clone command for the sample as listed by `appbuilder sample`.
	
	```bash
	appbuilder sample clone flashlight
	```

The AppBuilder command-line interface shows the following message: `Successfully initialized project in the folder!`

### Run the sample

With the AppBuilder command-line interface, you can quickly test your apps on device, in the simulator or in the native emulators.

1. [Run in the native emulators.][emulators cli]
1. [Deploy on device via QR code.][QR code cli]
1. [Deploy on device via USB cable.][USB deploy cli]

[Back to Top](#top)

# Limitations

* You cannot run this sample in the device simulator.
* You cannot run this sample in the companion apps.

[Back to Top](#top)

[QR code in-browser]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/deploy-remote#in-browser
[QR code windows]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/deploy-remote#windows
[QR code vse]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/deploy-remote#visual-studio
[QR code cli]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/deploy-remote#cli
[USB deploy windows]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/running-on-connected-devices/deploy-connected#windows
[USB deploy vse]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/running-on-connected-devices/deploy-connected#visual-studio
[USB deploy cli]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-on-devices/running-on-connected-devices/deploy-connected#cli
[emulators windows]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-in-emulators/native-emulators#windows
[emulators vse]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-in-emulators/native-emulators#visual-studio
[emulators cli]: http://docs.telerik.com/platform/appbuilder/testing-your-app/running-in-emulators/native-emulators#cli
[Flashlight API]: https://github.com/Icenium/sample-flashlight/blob/master/sample-flashlight/Plugins/Flashlight-Plugin/README.md