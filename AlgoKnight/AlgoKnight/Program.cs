using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoQ.AlgoQList;

namespace AlgoKnight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1,2};
            A189 test = new A189();
            test.Rotate2(nums, 3);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
