// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility2;

Console.WriteLine("Hello, World!");

RequestContext RequestContext = new()
{
    Request = new()
    {
        EntityId = 1,
        UserId = 1,
        UserRole = "User"
    },
    Response = new()
};
Client.SomeBusinessLogic(RequestContext);

RequestContext = new()
{
    Request = new()
    {
        EntityId = 2,
        UserId = 1,
        UserRole = "User"
    },
    Response = new()
};
Client.SomeBusinessLogic(RequestContext);

RequestContext = new()
{
    Request = new()
    {
        EntityId = 2,
        UserId = 2,
        UserRole = "User"
    },
    Response = new()
};
Client.SomeBusinessLogic(RequestContext);