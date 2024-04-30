using System;

namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter your fname");
            string fname = Console.ReadLine();
            Console.WriteLine("your name is :{0}", fname);//placeholder syntax

            Console.WriteLine("Enter your lname");
            
            string lname = Console.ReadLine();


            Console.WriteLine("your name is :"+fname+ lname);//concatenation 
            Console.WriteLine("your name is :{0} {1}", fname,lname);//placeholder syntax

            int a = 30;
            int b = 50;

            bool c = a > b;
            Console.WriteLine(c);
            
            



            Console.ReadLine();

            
        }
    }
}
