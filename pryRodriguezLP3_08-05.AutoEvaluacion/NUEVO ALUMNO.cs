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
    public partial class NUEVO_ALUMNO : Form
    {
        clsAlumnos A;
        public NUEVO_ALUMNO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A.NOMBRE = textBox1.Text;
            A.DNI = Convert.ToInt32(textBox2.Text);
            A.FOTO = textBox3.Text;
            A.BARRIO = Convert.ToInt32(comboBox1.Text);

            if (radioButton1.Checked = true)
            {
                A.SEXO = "F";
            }
            if (radioButton2.Checked = true)
            {
                A.SEXO = "M";
            }
        }
    }
}
