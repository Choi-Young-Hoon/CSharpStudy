using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Study
{
    internal class GenericTest : TestObserverInterface
    {
        void TestObserverInterface.Run()
        {
            GenericStack<int> intStack = new GenericStack<int>(10);
            intStack.Push(1);
            intStack.Push(2);

            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
        }

        class GenericStack<T>
        {
            T[] _objList;
            int _pos;

            public GenericStack(int size)
            {
                this._objList = new T[size];
            }

            public void Push(T value)
            {
                this._objList[this._pos] = value;
                this._pos++;
            }

            public T Pop()
            {
                this._pos--;
                return _objList[this._pos];
            }
        }
    }
}
