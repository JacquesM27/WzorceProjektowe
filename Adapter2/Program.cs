// See https://aka.ms/new-console-template for more information
using Adapter2;

Console.WriteLine("Hello, World!");

BankXmlObject BankXmlObject1 = new() { AccountId = 1, Name = "John", Value = 123 };
BankXmlObject BankXmlObject2 = new() { AccountId = 2, Name = "Barbra", Value = 333 };

TransferFromXml transfer1 = new(BankXmlObject1);
TransferFromXml transfer2 = new(BankXmlObject2);
transfer1.DoTransfer();
transfer2.DoTransfer();

ReportJsonService reportService = new();

//reportService.AddDataToReport(BankXmlObject1);
BankXmlObjectAdapter BankXmlObjectAdapter1 = new(BankXmlObject1);
BankXmlObjectAdapter BankXmlObjectAdapter2 = new(BankXmlObject2);
reportService.AddDataToReport(BankXmlObjectAdapter1);
reportService.AddDataToReport(BankXmlObjectAdapter2);
reportService.PrintReport();