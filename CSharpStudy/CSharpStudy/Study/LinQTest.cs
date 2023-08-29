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
            LinqTestGroupBy();
            LinqTestJoin();
            LinqTest4();
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

        class Product
        {
            public string Title { get; set; }
            public string Star { get; set; }
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

        void LinqTestGroupBy()
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "TEST1", Height = 100 },
                new Profile() { Name = "TEST2", Height = 101 },
                new Profile() { Name = "TEST3", Height = 102 },
                new Profile() { Name = "TEST4", Height = 103 },
                new Profile() { Name = "TEST5", Height = 104 },
                new Profile() { Name = "TEST6", Height = 105 }
            };

            var listProfiles = 
                from profile in arrProfile 
                orderby profile.Height
                group profile by profile.Height < 103 into g
                select new { GroupKey = g.Key, Profiles = g };

            foreach (var profileGroup in listProfiles)
            {
                Console.WriteLine($" - 103 미만? : {profileGroup.GroupKey}"); 
                foreach (var profile in profileGroup.Profiles)
                {
                    Console.WriteLine($"      {profile.Name}, {profile.Height}");
                }
            }
        }

        void LinqTestJoin()
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "TEST1", Height = 100 },
                new Profile() { Name = "TEST2", Height = 101 },
                new Profile() { Name = "TEST3", Height = 102 },
                new Profile() { Name = "TEST4", Height = 103 },
                new Profile() { Name = "TEST5", Height = 104 },
                new Profile() { Name = "TEST6", Height = 105 }
            };

            Product[] arrProduct =
            {
                new Product() { Title = "TITLE1", Star = "TEST1" },
                new Product() { Title = "TITLE2", Star = "TEST5" },
                new Product() { Title = "TITLE3", Star = "TEST3" },
                new Product() { Title = "TITLE4", Star = "TEST1" },
                new Product() { Title = "TITLE5", Star = "TEST10" }
            };

            // inner join
            var innerJoinQuery =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Title = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine("Innser join 결과");
            foreach (var profile in innerJoinQuery)
            {
                Console.WriteLine($"이름: {profile.Name}, 타이틀: {profile.Title}, 무게: {profile.Height}");
            }

            // outer join
            var outerJoinQuery =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps
                from product in ps.DefaultIfEmpty(new Product() { Title = "EMPTY" })
                select new
                {
                    Name = profile.Name,
                    Title = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine();
            Console.WriteLine("Outer join 결과");
            foreach(var profile in outerJoinQuery)
            {
                Console.WriteLine($"이름: {profile.Name}, 타이틀: {profile.Title}, 무게: {profile.Height}");
            }
        }

        class Class
        {
            public string Name { get; set; }
            public int[] Score { get; set; }
        }

        void LinqTest4()
        {
            Class[] arrClass =
            {
                new Class() { Name = "연두반", Score = new int[] { 50, 45, 90, 10 } },
                new Class() { Name = "파랑반", Score = new int[] { 10, 100, 80, 75 } },
                new Class() { Name = "분홍반", Score = new int[] { 90, 88, 0, 17 } },
                new Class() { Name = "빨강반", Score = new int[] { 92, 30, 80, 94 } }
            };

            var classes =
                from c in arrClass
                from s in c.Score
                where s < 60
                orderby s
                select new { c.Name, Lowest = s };

            foreach (var c in classes)
            {
                Console.WriteLine($"낙제: {c.Name} {c.Lowest}");
            }
        }
    }
}
