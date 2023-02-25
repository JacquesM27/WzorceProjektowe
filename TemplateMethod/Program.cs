using TemplateMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        FakeBusinessLogic(new FirstConcreteClass());
        Console.WriteLine("===================================");
        FakeBusinessLogic(new SecondConcreteClass());
    }

    private static void FakeBusinessLogic(SomeAbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}