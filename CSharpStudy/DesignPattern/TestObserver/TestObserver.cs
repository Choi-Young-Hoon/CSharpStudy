using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class TestObserver
    {
        ArrayList __opserverList;

        public TestObserver()
        {
            this.__opserverList = new ArrayList();
        }

        public void Add(ITestObserver opserver)
        {
            __opserverList.Add(opserver);
        }

        public void Start()
        {
            foreach (ITestObserver opserver in this.__opserverList)
            {
                Console.WriteLine("");
                opserver.Run();
            }
        }
    }
}
