using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM210444_EX2POO
{
    class ParaLlevar:procesosProductos //llamar clase
    {

        public double  operar1(double bebida1)
        {
            valor1 = bebida1 * 3.50;
            return valor1;
        }
        public double operar2(double bebida2)
        {
            valor2 = bebida2 * 4.50;
            return valor2;
        }
        public double operar3(double bebida3)
        {
            valor3 = bebida3 * 5.00;
            return valor3;
        }
        public double operar4(double bebida4)
        {
            valor4 = bebida4 * 6.00;
            return valor4;
        }
        public double operar5(double bebida5)
        {
            valor5 = bebida5 * 2.50;
            return valor5;
        }
        public double operar6(double bebida6)
        {
            valor6 = bebida6 * 2.50;
            return valor6;
        }
        public double operar7(double bebida7)
        {
            valor7 = bebida7 * 2.75;
            return valor7;
        }
    }
}
