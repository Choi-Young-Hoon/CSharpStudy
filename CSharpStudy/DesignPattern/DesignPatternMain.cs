using CSharpStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class DesignPatternMain
    {
        static void Main(string[] args)
        {
            BehavioralPatternStart();
            CreationalPatternsStart();
            StructuralPatternsStart();
        }

        public static void BehavioralPatternStart()
        {
            Console.WriteLine("BehavioralPattern Start =========================================");
            TestObserver observer = new TestObserver();


            observer.Start();
            Console.WriteLine("BehavioralPattern End =========================================");
        }

        public static void CreationalPatternsStart()
        {
            TestObserver observer = new TestObserver();


            observer.Start();
        }

        public static void StructuralPatternsStart()
        {
            TestObserver observer = new TestObserver();


            observer.Start();
        }
    }
}
