using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezRodrigo_AutoEvaluacion_08_05
{
    public partial class CONSULTAR_ALUMNO_POR_DNI : Form
    {
        clsAlumnos A;
        public CONSULTAR_ALUMNO_POR_DNI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Load("JPG\\CARLOTA.jpg"); (Cargo directamente la imagen)
            A.DNI = Convert.ToInt32(textBox2.Text);
            A.Buscar();
            textBox1.Text = A.NOMBRE;
            if (A.NOMBRE == "")
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Load("JPG/" + A.FOTO);
            }
        }

        private void CONSULTAR_ALUMNO_POR_DNI_Load(object sender, EventArgs e)
        {
            A = new clsAlumnos();
        }
    }
}
