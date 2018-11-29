using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoKnight.AlgoQList;

namespace AlgoKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            AlgoQList.A27 test = new A27();
            int t = test.RemoveElementWay4(nums, 2);
            Console.WriteLine(t);
            Console.ReadLine();

        }
    }
}
