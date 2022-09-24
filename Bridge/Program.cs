// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");


var tv = new Tv();
var remoteControl = new RemoteControl(tv);
remoteControl.TogglePower();
remoteControl.ChannelUp();
remoteControl.VolumeUp();
remoteControl.TogglePower();

var radio = new Radio();
var premiumRemoteControl = new PremiumRemoteControl(radio);
premiumRemoteControl.ChannelUp();
premiumRemoteControl.ChannelDown();
premiumRemoteControl.VolumeUp();
premiumRemoteControl.Mute();
premiumRemoteControl.TogglePremiumPower();