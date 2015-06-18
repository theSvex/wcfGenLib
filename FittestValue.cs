using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcfGenLib
{
    public class FittestValue
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        private double fit;
        public double Fit
        {
            get { return fit; }
            set { fit = value; }
        }

        public FittestValue() { }

        public FittestValue(double x, double y, double fit)
        {
            this.X = x;
            this.Y = y;
            this.Fit = fit;
        }
    }
}
