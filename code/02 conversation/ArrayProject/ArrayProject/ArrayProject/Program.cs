using System;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            num = new int[20];
            Console.WriteLine("please enter a number");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("your output is:");
            for (int i = num.Length -1; i > 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
        }
    }
}
