using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int b= int.Parse(Console.ReadLine());
            Addition add = new Addition();
            Console.WriteLine("Result is: "+add.Sum(a, b));
            Console.ReadLine();
        }
    }
}