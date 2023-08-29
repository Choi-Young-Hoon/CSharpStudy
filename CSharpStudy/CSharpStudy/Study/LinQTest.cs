using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Study
{
    internal class LinQTest : TestObserverInterface
    {
        void TestObserverInterface.Run()
        {
            LinqTest1();
            LinqTest2();
            LinqTest3();
        }

        void LinqTest1()
        {
            int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            var numQuery =
                from num in numbers
                where (num % 2 == 0)
                select num;

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0} ", num);
            }
        }

        void LinqTest2()
        {
            int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            List<int> numQuery =
                (from num in numbers
                 where (num % 2) == 0
                 orderby num
                 select num).ToList();

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0} ", num);
            }
        }


        class Profile
        {
            public string Name { get; set; }
            public int Height { get; set; }
        }

        void LinqTest3()
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "TEST1", Height = 100 },
                new Profile() { Name = "TEST2", Height = 101 },
                new Profile() { Name = "TEST3", Height = 102 },
                new Profile() { Name = "TEST4", Height = 103 }
            };

            var profiles =
                from profile in arrProfile
                where profile.Height < 102
                orderby profile.Height
                select new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 100
                };

            foreach (var profile in profiles)
            {
                Console.WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
            }
        }
    }
}
