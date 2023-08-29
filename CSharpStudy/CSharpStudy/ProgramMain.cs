using CSharpStudy.Study;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class ProgramMain
    {
        static void Main(string[] args)
        {
            TestObserver observer = new TestObserver();

            observer.Add(new DebugMessageTest());
            observer.Add(new AppDomainTest());
            observer.Add(new ReflectionTest());
            observer.Add(new GenericTest());
            observer.Add(new YieldTest());
            observer.Add(new AsyncAwaitTest());
            observer.Add(new LinQTest());

            observer.Start();
        }
    }
}
