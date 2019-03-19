﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTanks.myClassLib
{
    public class Tank
    {
        public string Name { get; set; }
        public int Amunit { get; set; }
        public int Armor { get; set; }
        public int Manevr { get; set; }
        Random random = new Random();
        public Tank()
        {
            Amunit = random.Next(100);
            Armor = random.Next(100);
            Manevr = random.Next(100);
            System.Threading.Thread.Sleep(50);
        }

        public static Tank operator*(Tank tank1, Tank tank2)
        {
            if ((tank1.Amunit + tank1.Armor + tank1.Manevr) > (tank2.Amunit + tank2.Armor + tank2.Manevr))
            {
                return tank1;
            }
            else if ((tank1.Amunit + tank1.Armor + tank1.Manevr) < (tank2.Amunit + tank2.Armor + tank2.Manevr))
            {
                return tank2;
            }
            return null;
        }
    }
}
