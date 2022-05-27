# AWS Toolkit

This plugin is intended to be used by [Flow Launcher](https://www.flowlauncher.com/). It will not work with Wox.

Search for AWS services by using the action keyword (default: `aws`) followed by the AWS service name. Press enter to open the AWS Console page for the highlighted service in your web browser.

![screenshot of plugin in use](https://raw.github.com/mjtimblin/Flow.Launcher.Plugin.AwsToolkit/master/screenshots/screenshot_2.jpg)

## Installation

### Flow Launcher

To install, type `pm install AWS Toolkit` into Flow Launcher.

![screenshot of plugin install command](https://raw.github.com/mjtimblin/Flow.Launcher.Plugin.AwsToolkit/master/screenshots/screenshot_1.jpg)

### Manual Installation

Extract [Flow.Launcher.Plugin.AwsToolkit.zip](https://github.com/mjtimblin/Flow.Launcher.Plugin.AwsToolkit/releases/latest) to Flow Launcher's plugin directory.

| Flow Launcher Mode | Plugin Directory Path                                                                  |
|--------------------|----------------------------------------------------------------------------------------|
| Standard           | `%appdata%\FlowLauncher\Plugins`                                                       |
| Portable           | `<YourPortableLocation>\FlowLauncher\app-<VersionOfYourFlowLauncher>\UserData\Plugins` |

## Acknowledgments

This is a port of the Wox plugin [Wox.Plugin.AwsToolkit](https://github.com/mikemorain/Wox.Plugin.AwsToolkit) (AWS Toolkit) created by Mike Morain ([@mikemorain](https://github.com/mikemorain)).

The Wox plugin, and therefore this plugin as well, was heavily inspired by the Alfred workflow: [AWS Console Services](https://github.com/rkoval/alfred-aws-console-services-workflow) created by Ryan Koval ([@rkoval](https://github.com/rkoval)).
