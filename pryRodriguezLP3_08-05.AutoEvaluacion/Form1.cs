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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NUEVO_ALUMNO NV = new NUEVO_ALUMNO();
            NV.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONSULTAR_ALUMNO_POR_DNI NV = new CONSULTAR_ALUMNO_POR_DNI();
            NV.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CONSULTAR_ALUMNOS_POR_PARTE_DE_SU_NOMBRE NV = new CONSULTAR_ALUMNOS_POR_PARTE_DE_SU_NOMBRE();
            NV.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VER_TODOS_LOS_ALUMNOS NV = new VER_TODOS_LOS_ALUMNOS();
            NV.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NUEVA_FRUTA NV = new NUEVA_FRUTA();
            NV.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VER_TODAS_LAS_FRUTAS NV = new VER_TODAS_LAS_FRUTAS();
            NV.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AGREGAR_O_QUITAR_FRUTAS_QUE_LE_GUSTA_AL_ALUMNO NV = new AGREGAR_O_QUITAR_FRUTAS_QUE_LE_GUSTA_AL_ALUMNO();
            NV.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QUE_FRUTAS_LE_GUSTAN_A_UN_ALUMNO NV = new QUE_FRUTAS_LE_GUSTAN_A_UN_ALUMNO();
            NV.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            QUE_FRUTAS_NO_LE_GUSTAN_A_UN_ALUMNO NV = new QUE_FRUTAS_NO_LE_GUSTAN_A_UN_ALUMNO();
            NV.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            A_QUE_ALUMNOS_LE_GUSTA_UNA_FRUTA NV = new A_QUE_ALUMNOS_LE_GUSTA_UNA_FRUTA();
            NV.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            A_QUE_ALUMNOS_NO_LES_GUSTA_UNA_FRUTA NV = new A_QUE_ALUMNOS_NO_LES_GUSTA_UNA_FRUTA();
            NV.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VER_TODAS_FRUTAS_Y_LA_CANTIDAD_TOTAL_DE_ALUMNOS NV = new VER_TODAS_FRUTAS_Y_LA_CANTIDAD_TOTAL_DE_ALUMNOS();
            NV.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ARBOLITO_FRUTAS_ALUMNOS NV = new ARBOLITO_FRUTAS_ALUMNOS();
            NV.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ARBOLITO_ALUMNOS_FRUTAS NV = new ARBOLITO_ALUMNOS_FRUTAS();
            NV.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NUEVO_BARRIO NV= new NUEVO_BARRIO();
            NV.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("01. NUEVO ALUMNO\r\n\r\n02. CONSULTAR ALUMNO POR DNI\r\n\r\n03. CONSULTAR ALUMNOS POR PARTE DE SU NOMBRE\r\n\r\n04. VER TODOS LOS ALUMNOS\r\n\r\n05. NUEVA FRUTA\r\n\r\n06. VER TODAS LAS FRUTAS\r\n\r\n07. AGREGAR O QUITAR FRUTAS QUE LE GUSTA AL ALUMNO\r\n\r\n08. QUE FRUTAS LE GUSTAN A UN ALUMNO\r\n\r\n09. QUE FRUTAS NO LE GUSTAN A UN ALUMNO\r\n\r\n10. A QUE ALUMNOS LE GUSTA UNA FRUTA\r\n\r\n11. A QUE ALUMNOS NO LES GUSTA UNA FRUTA\r\n\r\n12. VER TODAS FRUTAS Y LA CANTIDAD TOTAL DE ALUMNOS\r\n    QUE LE GUSTA CADA FRUTA\r\n\r\n13. ARBOLITO FRUTAS ALUMNOS\r\n\r\n14. ARBOLITO ALUMNOS FRUTAS\r\n\r\n15. NUEVO BARRIO");
        }
    }
}
