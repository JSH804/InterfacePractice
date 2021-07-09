using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class ClassTwo: IClassTwo
    {
        public void PrintClassTwo()
        {
            Console.WriteLine("Class Two Method");
        }
    }
}
