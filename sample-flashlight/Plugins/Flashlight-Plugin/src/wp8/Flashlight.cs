using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Windows.Phone.Media.Capture;

namespace WPCordovaClassLib.Cordova.Commands
{
	public class Flashlight : BaseCommand
	{
		private const CameraSensorLocation SensorLocation = CameraSensorLocation.Back;

		private AudioVideoCaptureDevice captureDevice;

		public void available(string options)
		{
			string callbackId;
			if (!TryDeserializeOptions(options, out callbackId))
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.JSON_EXCEPTION));
				return;
			}

			var supportedCameraModes = AudioVideoCaptureDevice.GetSupportedPropertyValues(SensorLocation, KnownCameraAudioVideoProperties.VideoTorchMode);

			if (!supportedCameraModes.Contains((uint)VideoTorchMode.On))
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR), callbackId);
				return;
			}

			this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK), callbackId);
		}

		public void switchOn(string options)
		{
			string callbackId;
			if (!TryDeserializeOptions(options, out callbackId))
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.JSON_EXCEPTION));
				return;
			}

			Deployment.Current.Dispatcher.BeginInvoke(() =>
			{
				this.StartFlash(callbackId);
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK), callbackId);
			});
		}

		public void switchOff(string options)
		{
			string callbackId;
			if (!TryDeserializeOptions(options, out callbackId))
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.JSON_EXCEPTION));
				return;
			}

			Deployment.Current.Dispatcher.BeginInvoke(() =>
			{
				this.StopFlash(callbackId);
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK), callbackId);
			});
		}

		private static bool TryDeserializeOptions(string options, out string callbackId)
		{
			callbackId = string.Empty;
			try
			{
				var jsonOptions = JsonConvert.DeserializeObject<string[]>(options);
				callbackId = jsonOptions[0];
				return true;
			}
			catch
			{
				return false;
			}
		}

		private async void StartFlash(string callbackId)
		{
			try
			{
				var device = await this.GetCaptureDevice();
				device.SetProperty(KnownCameraAudioVideoProperties.VideoTorchMode, VideoTorchMode.On);
				device.SetProperty(KnownCameraAudioVideoProperties.VideoTorchPower,
					AudioVideoCaptureDevice.GetSupportedPropertyRange(SensorLocation, KnownCameraAudioVideoProperties.VideoTorchPower).Max);
			}
			catch
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR), callbackId);
			}
		}

		private async void StopFlash(string callbackId)
		{
			try
			{
				var device = await this.GetCaptureDevice();
				device.SetProperty(KnownCameraAudioVideoProperties.VideoTorchMode, VideoTorchMode.Off);
			}
			catch
			{
				this.DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR), callbackId);
			}
		}

		private async Task<AudioVideoCaptureDevice> GetCaptureDevice()
		{
			if (this.captureDevice == null)
			{
				this.captureDevice = await AudioVideoCaptureDevice.OpenAsync(SensorLocation, AudioVideoCaptureDevice.GetAvailableCaptureResolutions(SensorLocation).First());
			}

			return this.captureDevice;
		}
	}
}