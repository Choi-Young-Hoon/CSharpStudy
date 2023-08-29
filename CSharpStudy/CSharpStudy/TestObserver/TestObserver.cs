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
        ArrayList opserverList;

        public TestObserver()
        {
            this.opserverList = new ArrayList();
        }

        public void Add(TestObserverInterface opserver)
        {
            opserverList.Add(opserver);
        }

        public void Start()
        {
            foreach (TestObserverInterface opserver in this.opserverList)
            {
                Console.WriteLine("");
                opserver.Run();
            }
        }
    }
}
