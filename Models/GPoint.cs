using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Models
{
    public class GPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public GPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

