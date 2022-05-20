using System;

namespace Overloading
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int n1 = Over.Summ(8, 5);
            double n2 = Over.Summ(4.3, 6.5);
            Console.WriteLine("Int: " + n1);
            Console.WriteLine("Double: " + n2);
        }
    }
}
