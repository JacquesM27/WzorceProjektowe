// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");

var videoConverter = new VideoConverter();
var mp4 = videoConverter.Convert("test.mp4", "ogg");