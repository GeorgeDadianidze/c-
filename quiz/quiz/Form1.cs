using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Martkutxedi martkutxedi = new Martkutxedi();

            martkutxedi.Minicheba(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            martkutxedi.Fartobi(label4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gvari;
            string saxeli;
            int asaki;
            string departamentis_dasaxeleba;
            string tanamdeboba;
            int staji;

            saxeli = textBox4.Text;
            gvari = textBox3.Text;
            asaki = int.Parse(textBox5.Text);
            departamentis_dasaxeleba = textBox6.Text;
            tanamdeboba = textBox7.Text;
            staji = int.Parse(textBox8.Text);

            Doctor doctor = new Doctor(departamentis_dasaxeleba, tanamdeboba, staji, saxeli, gvari, asaki);
            doctor.Gamotana(label11);
        }
    }
}
