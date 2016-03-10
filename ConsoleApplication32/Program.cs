using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1409, Два бандита
            string str = Console.ReadLine();
            var numbers = str.Split(' ').Select(item => Convert.ToInt32(item)).ToArray();
            Console.Write((numbers[1]-1) + " " + (numbers[0]-1));
        }
    }
}
