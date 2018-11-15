using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i+1);
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            var list1 = list.OrderByDescending(item=> item);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
   
}
