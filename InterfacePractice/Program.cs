using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassThree A = new ClassThree();
            ClassThree B = new ClassThree();

            A.PrintClassOne();
            B.PrintClassTwo();

            Console.ReadKey();
        }
    }
}
