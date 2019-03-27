using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePeregruzka
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Tank tank1 = new Tank();
            Tank tank2 = new Tank();
            Console.WriteLine(tank1 == tank2);
            // 2
            Array arr1 = new Array() { ArrayInt = new int[] { 12, 8, 3, 4 } };
            Array arr2 = new Array() { ArrayInt = new int[] { 1, 2, 9, 5 } };
            Console.WriteLine(arr1 > arr2); 
        }
    }
}
