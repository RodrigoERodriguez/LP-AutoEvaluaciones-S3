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
    class Adelantos
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        public Adelantos()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Adelantos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["adelanto"];
            tabla.PrimaryKey = dc;

        }

        public Decimal ver(DataGridView dgv, int dni)
        {
            Decimal total = 0;

            dgv.Rows.Clear();

            foreach (DataRow filaa in tabla.Rows)
            {
                if (Convert.ToInt32(filaa["dni"]) == dni)
                {
                    dgv.Rows.Add(filaa["adelanto"], filaa["fecha"], filaa["importe"]);
                    total = total + Convert.ToDecimal(filaa["importe"]);
                }
            }

            return total;
        }
    }
}
