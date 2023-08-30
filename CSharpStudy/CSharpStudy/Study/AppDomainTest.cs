using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpStudy.Study
{
    internal class AppDomainTest : ITestObserver
    {
        void ITestObserver.Run()
        {
            GetAssemblyList();
        }

        // 어셈블리 리스트를 출력한다.
        void GetAssemblyList()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("Current Domain Name: " + currentDomain.FriendlyName);

            // 어셈블리들을 출력
            Console.WriteLine("Assembly List=================================");
            foreach (Assembly asm in currentDomain.GetAssemblies())
            {
                Console.WriteLine("-" + asm.FullName);

                // 어셈블리에 포함된 모듈들 출력
                Console.WriteLine("--Module List=================================");
                foreach (Module module in asm.GetModules())
                {
                    Console.WriteLine("---" + module.FullyQualifiedName);
                }
            }
        }
    }
}
