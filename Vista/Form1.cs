using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificador oa = new datos.Verificador();

            oa.esEntero(textBox1.Text);
            oa.esDecimal(textBox2.Text);
            oa.esEdad(textBox3.Text);
        }
    }
}
