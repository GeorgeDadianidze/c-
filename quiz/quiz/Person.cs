using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    internal class Person
    {
        protected string saxeli;
        protected string gvari;
        protected int asaki;

        public Person(string saxeli, string gvari, int asaki)
        {
            this.saxeli = saxeli;
            this.gvari = gvari;
            this.asaki = asaki;
        }
    }


    class Doctor : Person
    {
        public string departamentis_dasaxeleba;
        public string tanamdeboba;
        public int staji;

        public Doctor(string departamentis_dasaxeleba, string tanamdeboba, int staji, string saxeli, string gvari, int asaki) : base(saxeli, gvari, asaki)
        {
            this.departamentis_dasaxeleba = departamentis_dasaxeleba;
            this.tanamdeboba = tanamdeboba;
            this.staji = staji;
        }

        public void Gamotana(Label lab1)
        {
            lab1.Text = "gvari: " + gvari +
                         "\nsaxeli: " + saxeli +
                         "\nasaki: " + asaki +
                         "\ndepartamentis dasaxeleba: " + departamentis_dasaxeleba +
                         "\ntanamdeboba: " + tanamdeboba +
                         "\nstaji: " + staji.ToString();
        }
    }
}
