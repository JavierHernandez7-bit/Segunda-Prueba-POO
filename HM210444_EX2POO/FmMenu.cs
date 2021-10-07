using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HM210444_EX2POO
{
    public partial class FmMenu : HM210444_EX2POO.Form1
    {
        public FmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texB1.Text=("0");
            texB2.Text=("0");
            texB3.Text=("0");
            texB4.Text=("0");
            texB5.Text=("0");
            texB6.Text=("0");
            texB7.Text=("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form3 FmMenu = new Form3();
            FmMenu.Show();
            this.Hide();
            
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {

        }
    }
}
