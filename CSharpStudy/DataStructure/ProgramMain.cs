using DataStructure.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class ProgramMain
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                customLinkedList.PushBack(i);
            }
            customLinkedList.PushFront(100);
            customLinkedList.PushFront(200);

            customLinkedList.PrintAll();

            Console.WriteLine("-=======");
            customLinkedList.Clear();
            Console.ReadLine();
            Console.WriteLine("========");
        }
    }
}
