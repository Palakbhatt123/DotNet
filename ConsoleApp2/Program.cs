using System;
using System.Net.NetworkInformation;
using Second;




namespace ConsoleApp2
{
    class A:B
    {
        A()
        {
            p4 = 67;
            

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            B a = new B();

            Console.WriteLine(a.p);
            Console.WriteLine(a.p4); 
            Console.WriteLine(a.p3);
           
            



        }
    }
}

namespace Second
{
    public class B
    {
        public int p = 10;
        private int p2 = 20;
        internal int p3 = 30;
        internal protected int p4;



        public static void display()
        {

            Console.WriteLine("i am namespace of Second");

        }
    }

}



