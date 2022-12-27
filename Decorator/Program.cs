// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

var fileDataSource = new FileDataSource();
var encryptorDataSource = new EncryptorDecorator(fileDataSource);
var compressionDataSource = new CompressionDecorator(encryptorDataSource);

Console.WriteLine(compressionDataSource.ReadData());




