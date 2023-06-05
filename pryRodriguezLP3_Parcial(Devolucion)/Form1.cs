using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUELDOS
{
    public partial class Form1 : Form
    {
        Empleados emp;
        Adelantos ade;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ade = new Adelantos();
                emp = new Empleados();
                emp.ArmarArbolito(tv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMAS CON LA BASE DE DATOS", "ERROR");
                this.Close();
            }
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtEmail.Text = "";
            dgv.Rows.Clear();
            ss.Items.Clear();

            if(e.Node.Level==2)
            {
                DataRow filae = emp.buscar(Convert.ToInt32(e.Node.Tag));
                Decimal sueldo = Convert.ToDecimal(filae["sueldo"]);


                txtEmail.Text = filae["email"].ToString();
                Decimal total = ade.ver(dgv, Convert.ToInt32(e.Node.Tag));

                ss.Items.Add("SUELDO EMPLEADO --->");
                ss.Items.Add(sueldo.ToString("#,###,##0.00"));
                ss.Items.Add("TOTAL ADELANTOS --->");
                ss.Items.Add(total.ToString("#,###,##0.00"));
                ss.Items.Add("IMPORTE A COBRAR --->");
                ss.Items.Add((sueldo-total).ToString("#,###,##0.00"));


            }
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
