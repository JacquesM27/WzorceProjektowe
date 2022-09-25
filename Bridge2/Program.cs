// See https://aka.ms/new-console-template for more information
using Bridge2;

Console.WriteLine("Hello, World!");


var emailSender = new EmailSender();
var msmqSender = new MSMQSender();

var userMessage = new UserMessage(emailSender);
userMessage.UserDescription = "unbelievable things happen!";
userMessage.Send("user email title", "Lorem ipsum dolor sit amet[...]");
Console.WriteLine();
userMessage.MessageSender = msmqSender;
userMessage.Send("user msmq title", "Lorem ipsum dolor sit amet[...]");
Console.WriteLine();

var systemMessage = new SystemMessage(emailSender);
systemMessage.Send("system email title", "Task failed successfully");
Console.WriteLine();
systemMessage.MessageSender = msmqSender;
systemMessage.Send("system msmq title", "The queue is not open or might not exist.");
Console.WriteLine();