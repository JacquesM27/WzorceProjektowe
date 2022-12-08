// See https://aka.ms/new-console-template for more information
using Adapter3;

Console.WriteLine("Hello, World!");

INotificationSender notificationSender = new EmailSender()
{
    RecipientEmail = "john.smith@gmail.com",
    SubjectEmail = "Blah",
    Content = "bidfkssdkjs"
};
notificationSender.SendNotification();

notificationSender = new PushSender()
{
    AppName = "Whatsapp",
    Content = "Hi here Derek, whats up?"
};
notificationSender.SendNotification();

notificationSender = new SmsSenderAdapter()
{
    PhoneNumber = "222123000",
    Text = "Give me my money back!"
};
notificationSender.SendNotification();