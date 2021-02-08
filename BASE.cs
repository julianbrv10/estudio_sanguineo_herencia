using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio_sanguineo_herencia
{
    public partial class BASE : Form
    {
        private int bandera;
        public BASE(int bandera) //este es un metodo inicializador que llamare al crear mis objetor para poder pasarle paramatros
        {
            InitializeComponent(); //metodo inicializador
            this.bandera = bandera;
        }

        private void calculo_sangre()
        {
            if (this.bandera == 1)
            {
                conversion.Text = (float.Parse(mGlucosa.Text) * 18.02 + " mg/dL");
                conversion1.Text = (float.Parse(mAcido.Text) * 0.02 + " mg/dL");
                conversion2.Text = (float.Parse(mCol.Text) * 380.66 + " mg/dL");
            } 
            else if (this.bandera == 0)
            {
                conversion.Text = (float.Parse(mGlucosa.Text) * 18.02 + " mg/dL");
                conversion1.Text = (float.Parse(mAcido.Text) * 0.02 + " mg/dL");
                conversion2.Text = (float.Parse(mCol.Text) * 380.66 + " mg/dL");
                conversion3.Text = (float.Parse(mUrea.Text) * 6.01 + " mg/dL");
                conversion4.Text = (float.Parse(mTrig.Text) * 87.5 + " mg/dL");
                conversion5.Text = (float.Parse(mCrea.Text) * 0.01 + " mg/dL");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void BASE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.calculo_sangre();  //cuando se presione este, llamará al metodo calcular sangre que se encuentra aqui mismo y lo ejecutará
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
