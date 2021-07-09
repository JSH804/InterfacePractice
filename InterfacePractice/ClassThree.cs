using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class ClassThree: IClassOne, IClassTwo
    {
        ClassOne ObjectOne = new ClassOne();
        ClassTwo ObjectTwo = new ClassTwo();

        public void PrintClassOne()
        {
            ObjectOne.PrintClassOne();
        }
        public void PrintClassTwo()
        {
            ObjectTwo.PrintClassTwo();
        }
    }
}
