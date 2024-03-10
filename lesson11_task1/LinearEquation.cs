using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_task1
{
    struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0){
                if (b == 0) return " x - любое число";
                return "нет решений";
            }
            else
            {
                return $"x = {((0 - b) / k)}";
            }
        }
    }
}
