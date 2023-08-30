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
        ArrayList _opserverList;

        public TestObserver()
        {
            this._opserverList = new ArrayList();
        }

        public void Add(ITestObserver opserver)
        {
            _opserverList.Add(opserver);
        }

        public void Start()
        {
            foreach (ITestObserver opserver in this._opserverList)
            {
                Console.WriteLine("");
                opserver.Run();
            }
        }
    }
}
