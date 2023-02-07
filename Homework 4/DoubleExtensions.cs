using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public static class DoubleExtensions
    {
        public static double Normalize(this double value, double size, double maxValue, double minValue = 0) => (value - minValue) / (maxValue - minValue) * size;
        public static double Normalize(this int value, double size, double maxValue, double minValue = 0) => (double)(value - minValue) / (maxValue - minValue) * size;

    }
}
