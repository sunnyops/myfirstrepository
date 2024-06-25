using System;
namespace Helloworld
{
    class Pony
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a integer");
            string str1 = Console.ReadLine();
            int num = int.Parse(str1);
            int sum = 0;
            for (int v = 1; v <= num; v = v + 1) { 
            
                sum = sum + v;
            }
            Console.Write("the sum of [0 ... " + num + "] " + sum);
            Console.ReadLine();
        }
    }
}
                

