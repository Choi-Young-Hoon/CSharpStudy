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
            TestOpserver opserver = new TestOpserver();

            opserver.Add(new DebugMessageTest());

            opserver.Start();
        }
    }
}
