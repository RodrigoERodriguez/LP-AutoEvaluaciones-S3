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
    public partial class NUEVO_BARRIO : Form
    {
        clsBarrios B;

        public NUEVO_BARRIO()
        {
            InitializeComponent();
        }

        private void NUEVO_BARRIO_Load(object sender, EventArgs e)
        {
             B = new clsBarrios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                B.BARRIO = Convert.ToInt32(textBox1.Text);
                B.NOMBRE = textBox2.Text;
                B.Agregar();
            }
            catch (Exception)
            {
                MessageBox.Show("Che mostro, esta repetido");
            }
        }
    }
}
