using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class DebugMessageTest : TestObserverInterface
    {
        void TestObserverInterface.Run()
        {

            //디버깅 시에만 컴파일시 추가되고 릴리즈시에는 제거되는 함수
            DebugMessage1();

            DebugMessage2();

            // 변수명, 파일명, 라인번호를 출력
            DebugMessage3();
        }

        // 디버깅시에만 사용될 함수
        [Conditional("DEBUG")]
        static void DebugMessage1()
        {
            Console.WriteLine("Debug Message2!!!");
        }

        // 디버깅 시에만 출력될 메시지
        void DebugMessage2()
        {
#if DEBUG
            Console.WriteLine("Debug Message 1!!");
#endif
        }

        void DebugMessage3(
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine("memberName: " + memberName);
            Console.WriteLine("filePath: " + filePath);
            Console.WriteLine("lineNumber: " + lineNumber);
        }
    }
}
