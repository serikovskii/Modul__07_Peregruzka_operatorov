using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkTanks.myClassLib;

namespace HomeWorkTanks
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Tank[] tank1 = new Tank[size];
            Tank[] tank2 = new Tank[size];

            for (int i = 0; i < size; i++)
            {
                tank1[i] = new Tank { Name = "T-34" };
                tank2[i] = new Tank { Name = "Pantera" };
            }
            Tank result = new Tank();
            int victoryT1 = 0;
            int victoryT2 = 0;
            int draw = 0;
            for (int j = 0; j< size; j++)
            {
                result = tank1[j] * tank2[j];

                try
                {
                    if (result == tank1[j])
                        victoryT1++;

                    else if (result == tank2[j])
                        victoryT2++;
                    else
                        throw new ArgumentNullException("result");
                }
                catch(ArgumentNullException)
                {
                    draw++;
                }
            }
            Console.WriteLine($"T-34 побед: {victoryT1}\nPantera побед: {victoryT2}\nНичья: {draw}");
            
        }
    }
}
