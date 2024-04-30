using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int MyDelegate(int a);

namespace Delegates
{
    internal class Program
    {
        static int n = 90;
        public static int Add(int a)
        {
            n += a;
            return n;
        }

        public static int View()
        {
            return n;
        }
        static int Sum(int x, int y)
            {
                return x + y;
            }


            static void Main(string[] args)
        {
            MyDelegate Del = new MyDelegate(Add);

            Del(56);

            Console.WriteLine(View());

            Func<int, int, int> add = Sum;

            int result = add(20, 10);

            Console.WriteLine(result);

            Console.ReadKey();
        }

      
            
            
         
        
    }
}