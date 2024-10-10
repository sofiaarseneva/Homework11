using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal struct Linear
    {
        //структура для решения линейного уравнения kx+b=0
        double k;
        double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            //в таком случае получаем уравнение 0 * х + 0 = 0, т.е. 0 * х = 0
            if (k == 0 && b == 0)
                return "Уравнение имеет бесконечно много корней!";
            //в таком случае получаем уравнение 0 * х + b = 0, т.е. 0 * x = - b, что не имеет решения 
            if (k == 0 && b != 0)
                return "Уравнение не имеет корней!";
            //выразим х через коэффициенты kx = -b, x = - b / k
            double x = - (b / k);

            return $"Уравнение имеет единственный корень x = {x}!";
        }
    }
}
