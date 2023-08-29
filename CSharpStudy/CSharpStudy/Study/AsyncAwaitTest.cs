using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Study
{
    internal class AsyncAwaitTest : TestObserverInterface
    {
        void TestObserverInterface.Run()
        {
            AwaitRead();

            TaskClassTest1();
            TaskClassTest2();
            //Console.ReadLine();
        }

        private static async void AwaitRead()
        {
            using (FileStream fs =
                new FileStream(@"C:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                Console.WriteLine("HOSTS read start ==================================");
                await fs.ReadAsync(buf, 0, buf.Length);
                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
                Console.WriteLine("HOSTS read end ==================================");

            }
        }

        void TaskClassTest1()
        {
            Task task1 = new Task(
                () =>
                {
                    Console.WriteLine("Task1======");
                });

            Task task2 = new Task(
                () =>
                {
                    Console.WriteLine("Task2======");
                });

            task1.Start();
            task2.Start();

            task1.Wait();
            task2.Wait();
        }

        void TaskClassTest2()
        {
            Task<int> task = new Task<int>(
                () =>
                {
                    Console.WriteLine("Task return test");
                    return 100;
                });
            task.Start();
            task.Wait();
            Console.WriteLine("Task return value: " + task.Result);
        }
    }
}
