using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace SUELDOS
{
    class Empleados
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Empleados()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Empleados";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["dni"];
            tabla.PrimaryKey = dc;

        }

        public void ArmarArbolito(TreeView tv)
        {
            TreeNode raiz = tv.Nodes.Add("EMPLEADOS");
            TreeNode fem = raiz.Nodes.Add("FEMENINO");
            TreeNode mas = raiz.Nodes.Add("MASCULINO");

            foreach(DataRow filae in tabla.Rows)
            {
                if(filae["sexo"].ToString()=="F")
                {
                    TreeNode emp = fem.Nodes.Add(filae["nombre"].ToString());
                    emp.Tag = filae["dni"];
                }else
                {
                    TreeNode emp = mas.Nodes.Add(filae["nombre"].ToString());
                    emp.Tag = filae["dni"];
                }
            }
        }

        public DataRow buscar(int dni)
        {
            DataRow filae = tabla.Rows.Find(dni);
            return filae;
        }

       
    }
}
