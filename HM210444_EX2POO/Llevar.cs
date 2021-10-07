using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HM210444_EX2POO
{
    public partial class Llevar : HM210444_EX2POO.FmMenu
    {
      
        procesosProductos precioProductos = new procesosProductos();
        public Llevar()
        {
            InitializeComponent();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            //conversion de precios
            
            ParaLlevar para_Llevar = new ParaLlevar();
            double bebida1 = para_Llevar.operar1(Convert.ToDouble(texB1.Text));

       
            double bebida2 = para_Llevar.operar2(Convert.ToDouble(texB2.Text));

            
            double bebida3 = para_Llevar.operar3(Convert.ToDouble(texB3.Text));

            
            double bebida4 = para_Llevar.operar5(Convert.ToDouble(texB4.Text));

            
            double bebida5 = para_Llevar.operar5(Convert.ToDouble(texB5.Text));

            
            double bebida6 = para_Llevar.operar6(Convert.ToDouble(texB6.Text));

            
            double bebida7 = para_Llevar.operar7(Convert.ToDouble(texB7.Text));

            double total = bebida1 + bebida2 + bebida3 + bebida4 + bebida5 + bebida6 + bebida7;
            MessageBox.Show("Su total es: $" + total);
        }
    }
}
