using CSharpStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    internal class SingletonTest : ITestObserver
    {
        void ITestObserver.Run()
        {
            Singleton instance1 = Singleton.GetInstance();
            instance1.Value = 100;

            Singleton instance2 = Singleton.GetInstance();
            instance2.Value = 200;
        }
    }
}
