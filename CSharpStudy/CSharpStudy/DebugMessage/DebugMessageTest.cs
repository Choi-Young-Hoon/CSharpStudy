using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class DebugMessageTest : TestOpserverInterface
    {
        void TestOpserverInterface.Run()
        {
#if DEBUG
            Console.WriteLine("Debug Message 1!!");
#endif

            //디버깅 시에만 컴파일시 추가되고 릴리즈시에는 제거되는 함수
            DebugMessage();
        }

        // 디버깅시에만 사용될 함수
        [Conditional("DEBUG")]
        static void DebugMessage()
        {
            Console.WriteLine("Debug Message2!!!");
        }
    }
}
