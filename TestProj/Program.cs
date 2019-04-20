using System;
namespace TestProj
{
    class Program
    {
        static string GetDate() => DateTime.Now.ToShortDateString();

        static void Main(string[] args)
        {
            Console.WriteLine("Arnold!");

            Console.Read();
        }
    }
}
