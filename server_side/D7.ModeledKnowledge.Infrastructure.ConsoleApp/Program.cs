using Antlr4.Runtime;
using D7.ModeledKnowledge.Infrastructure.Formula;
using System;
using System.Collections.Generic;

namespace D7.ModeledKnowledge.Infrastructure.ConsoleApp
{
    class TestParser : Traveler<string>
    {
        public TestParser()
        {
            OnFunc+=new VisitFunc(_Traveler_OnFunc);
        }

        private void _Traveler_OnFunc(string name, string[] args)
        {

        }
    }
    class Program
    {
        class Item : Element
        {
            public string Name { get; set; }

            public string Formula { get; set; }

            public object Value { get; set; }

            public string Message { get; set; }
        }

        static void Main(string[] args)
        {
            //Test1();

            Test2();
        }

        static void Test1()
        {
            TestParser test = new TestParser();

            test.Execute("func(a(12),'daf')");
        }

        static void Test2()
        {
            Item t1 = new Item { Name="t1", Formula="t2/5"};
            Item t2 = new Item { Name = "t2", Formula = "t3+9" };
            Item t3 = new Item { Name = "t3", Formula = "4*2+1" };

            Item[] array = new Item[] { t1, t2, t3 };

            NamedElementCalculator<Item> calc = new NamedElementCalculator<Item>();
            calc.Initalize();

            calc.Load(array);

            IList<Item> rlt = calc.Execute();
        }
    }
}
