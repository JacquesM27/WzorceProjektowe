namespace Decorator
{
    class CTest1
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }

        public CTest1(int myProperty, int myProperty2)
        {
            MyProperty = myProperty;
            MyProperty2 = myProperty2;
        }

        void DoJob() { }
    }

    struct STest1
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public readonly CTest1 MyProperty3 { get; init; }//ciekawa konstrukcja
        public STest1(int prop, int prop2)
        {
            MyProperty = prop;
            MyProperty2 = prop2;
        }
        void DoJob() { }
        readonly void DoB()
        {
            MyProperty3.MyProperty++;
        }
    }

    readonly record struct RRSTest1
    {

    }

    readonly struct RSTest1
    {

    }

    record RTest1
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; init; }//fajne, taki readonly tylko property
        public RTest1(int myProperty, int myProperty2)
        {
            MyProperty = myProperty;
            MyProperty2 = myProperty2;
        }
        void DoJob() { }

    }

    record struct RSTest12
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; init; }//fajne, taki readonly tylko property
        public RSTest12(int myProperty, int myProperty2)
        {
            MyProperty = myProperty;
            MyProperty2 = myProperty2;
        }
        void DoJob() { }
        readonly void DoB()
        {

        }
    }

    record RTest3
    {
        public int MyProperty { get; set; }

        void DoA()
        {
            MyProperty++;
        }
    }

    class Tester
    {
        void DoSomething()
        {
            CTest1 cTest1 = new(1,2);
            STest1 sTest1 = new(1,2);
            STest1 sTest11 = new();
            RTest1 rTest1 = new(1, 2);
            //rTest1.MyProperty2 = 2;

            RTest3 rtest3 = new() { MyProperty = 1};

            var rTest4 = default(RTest3);
            var ct1 = default(CTest1);
        }
    }

    interface IFake
    {
        public void DoJob();
    }

    abstract class ACTest2
    {
        public int MyProperty { get; set; }
        public abstract void DoSomething();
    }
    class CTest2 : ACTest2, IFake
    {
        public void DoJob()
        {
            throw new NotImplementedException();
        }

        public override void DoSomething()
        {
            throw new NotImplementedException();
        }
    }

    abstract record ARTest2
    {
        public int MyProperty { get; set; }
        public abstract void DoSomething();
    }

    record RTest2 : ARTest2, IFake
    {
        public void DoJob()
        {
            throw new NotImplementedException();
        }

        public override void DoSomething()
        {
            throw new NotImplementedException();
        }
    }

    struct STest2 : IFake
    {
        public void DoJob()
        {
            throw new NotImplementedException();
        }
    }

    record struct RSTest3
    {
        public RSTest3()
        {

        }
    }

    record struct RSTest4
    {
        public RSTest4()
        {

        }
    }
}
