using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datos
{
    public class Verificador
    {
        public bool esEntero(string a) {
            Boolean e = false;
            Regex t = new Regex("[0-9]+", RegexOptions.IgnoreCase);
            Match r = t.Match(a);
            if (r.Success) {
                e = true;
                MessageBox.Show("Si es entero");
            }
            else {
                MessageBox.Show("No es entero");
            }
            return e;
        }

        public bool esDecimal(string a)
        {
            Boolean e = false;
            Regex t = new Regex("[0-9]+[.][0-9]+", RegexOptions.IgnoreCase);
            Match r = t.Match(a);
            if (r.Success)
            {
                e = true;
                MessageBox.Show("Si es decimal");
            }
            else
            {
                MessageBox.Show("No es decimal");
            }
            return e;
        }

        public bool esEdad(string a)
        {
            int k = int.Parse(a);
            Boolean e = false;
            Regex t = new Regex("[0-9]+", RegexOptions.IgnoreCase);
            Match r = t.Match(a);
            if (r.Success&&(k<100)&&(k>0))
            {
                e = true;
                MessageBox.Show("Si es Edad");
            }
            else
            {
                MessageBox.Show("No es edad");
            }
            return e;
        }
    }
}
