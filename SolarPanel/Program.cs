﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello word test
            int[] areas;
            areas = AreaSolarPanel.answer(15324).ToArray();

            foreach (int area in areas)
            {
                Console.WriteLine(area);
            }
        }
    }
}
