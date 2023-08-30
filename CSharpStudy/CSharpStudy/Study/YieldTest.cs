using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Study
{
    internal class YieldTest : ITestObserver
    {
        void ITestObserver.Run()
        {
            foreach (int n in YieldClass.Next(100))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }

    class YieldClass
    {
        public static IEnumerable<int> Next(int max)
        {
            int _start = 0;

            while(true)
            {
                _start++;
                if (max < _start)
                {
                    yield break; // max만큼만 루프를 수행 후 열거 중지
                }

                yield return _start;
            }
        }
    }
}
