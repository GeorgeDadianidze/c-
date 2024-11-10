using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    internal class Martkutxedi
    {
        private int gverdi1;
        private int gverdi2;
        public int fartobi;

        public void Minicheba(int gverdi1, int gverdi2)
        {
            this.gverdi1 = gverdi1;
            this.gverdi2 = gverdi2;
        }

        public void Gamotana(Label lab1, Label lab2)
        {
            lab1.Text = gverdi1.ToString();
            lab2.Text = gverdi2.ToString();

        }

        public void Fartobi(Label lab3)
        {
            fartobi = gverdi1 * gverdi2;
            lab3.Text = fartobi.ToString();
        }
    }
}
