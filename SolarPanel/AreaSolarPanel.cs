using System;
using System.Collections.Generic;

namespace SolarPanel
{
    internal static class AreaSolarPanel
    {
        public static IList<int> answer(int area)
        {
            int sideInteger;
            double sideDouble;
            int _areaSmallsquare;
            List<int> _areasSquares = new List<int>();

            while (area != 0)
            {
                sideDouble = Math.Sqrt(area);
                sideInteger = (int)Math.Floor(sideDouble);
                _areaSmallsquare = sideInteger * sideInteger;
                _areasSquares.Add(_areaSmallsquare);
                area -= _areaSmallsquare;
            }

            return _areasSquares;
        }
    }
}
