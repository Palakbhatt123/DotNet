using System;

namespace ConsoleApp3
{
    class A
    {
        static void Main(string[] args)
        {
            Nullable<int> n = 5;
            Console.WriteLine(n.GetValueOrDefault());
            int? n1 = null;
            Console.WriteLine(n1.GetValueOrDefault());
            Nullable<double> n2 = null;
            Console.WriteLine(n2.GetValueOrDefault());
            int? n3= 9;
            Console.WriteLine(n3.GetValueOrDefault());

            Nullable<int> a = null;
            Console.WriteLine(a.HasValue);
            Nullable<int> b = 5.5;
            Console.WriteLine(b.HasValue);






        }
    }




}
   