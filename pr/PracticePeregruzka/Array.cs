using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePeregruzka
{
    public class Array
    {
        public int[] ArrayInt { get; set; }
        public static bool operator <(Array arrayFirst, Array arraySecond)
        {
            if (arrayFirst.ArrayInt.Sum() < arraySecond.ArrayInt.Sum())
                return true;
            else
                return false;

        }
        public static bool operator >(Array arrayFirst, Array arraySecond)
        {
            if (arrayFirst.ArrayInt.Sum() > arraySecond.ArrayInt.Sum())
                return true;
            else
                return false;
        }
    }
}
