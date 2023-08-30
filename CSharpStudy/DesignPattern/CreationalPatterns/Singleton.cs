using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPatterns
{
    internal class Singleton
    {
        // Singleton의 인스턴스
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

        // Singleton의 인스턴스 외부에서 사용시 해당 함수에서 인스턴스를 반환받아 사용
        public static Singleton GetInstance() => _instance.Value;


        // Singleton의 값.
        public int Value { get; set; }

    }
}
