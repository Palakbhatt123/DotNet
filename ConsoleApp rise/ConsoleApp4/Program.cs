
using System;
using System.Text;x

namespace ConsoleApp4
{

	class A
	{
		public string name = "palak";
		public string surname="bhatt";
		public int ID=12;
        public string str= @"abcds";

        public void show()
		{
			Console.WriteLine($" {surname}  {name} {ID}");
			Console.WriteLine("palak" + "bhatt"+23);
			Console.WriteLine($"{str}");
			Console.WriteLine(@"i am \$");	
		}
		public void show1()
		{
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);
        }

	}
	

	internal class Program
	{
	   	public static void Main(string[] args)
	    {
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");

            Console.WriteLine(sb);
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str1 = new string(chars);
            

            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine(str1[i]);
            }
        
    



            A a = new A();
            a.show();
			a.show1();	

            Console.ReadLine();
        }
    }
}
