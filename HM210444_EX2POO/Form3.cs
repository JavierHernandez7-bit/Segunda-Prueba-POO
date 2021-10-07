using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HM210444_EX2POO
{
    public partial class Form3 : HM210444_EX2POO.Form1
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            Domicilio domicilio = new Domicilio();//Llamando al nuevo formulario
            this.Hide();//Ocultando Form3
            domicilio.Show();
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            Llevar llevar = new Llevar();//Llamando al nuevo formulario
            this.Hide();//Ocultando Form3
            llevar.Show();
        }
    }
}
