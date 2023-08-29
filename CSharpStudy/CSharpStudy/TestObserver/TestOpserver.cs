using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class TestOpserver
    {
        ArrayList opserverList;

        public TestOpserver()
        {
            this.opserverList = new ArrayList();
        }
        public void Add(TestOpserverInterface opserver)
        {
            opserverList.Add(opserver);
        }
        public void Start()
        {
            foreach (TestOpserverInterface opserver in this.opserverList)
            {
                opserver.Run();
            }
        }
    }
}
