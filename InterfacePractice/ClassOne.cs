using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class ClassOne: IClassOne
    {
        public void PrintClassOne()
        {
            Console.WriteLine("Class One Method");
        }
    }
}
