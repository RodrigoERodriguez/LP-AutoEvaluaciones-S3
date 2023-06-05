using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryRodriguezLP_Clase24_04
{
    public partial class frmClima : Form
    {
        public frmClima()
        {
            InitializeComponent();
        }

        clsLocalidades Localidades;
        clsTemperatura Temperatura;
        DataTable TablaL;
        DataTable TablaT;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int Localidad= Convert.ToInt32(cbLocalidad.SelectedValue);
            string Fecha = dtpFecha.Text;

            foreach (DataRow fila in TablaT.Rows)
            {            
                if (Localidad == Convert.ToInt32(fila[0]))
                {
                    DateTime FechaDT = Convert.ToDateTime(fila["fecha"]);
                    string FechaDTB = FechaDT.ToString("dd/MM/yyyy");
                    if (Fecha == FechaDTB)
                    {
                        lblMax.Text = fila[2].ToString();
                        lblMin.Text = fila[3].ToString();
                    }
                }
            }
        }

        //

        private void frmClima_Load(object sender, EventArgs e)
        {
            try
            {
                Localidades = new clsLocalidades();
                //Hace que me muestre el nombre de la especialidad
                cbLocalidad.DisplayMember = "nombre";
                //Hace que retorne el valor nominal de la especialidad
                cbLocalidad.ValueMember = "localidad";
                cbLocalidad.DataSource = Localidades.getAll();
                TablaL = Localidades.getAll();
                Temperatura = new clsTemperatura();
                TablaT = Temperatura.getAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos");
                this.Close();
            }
        }
    }
}
