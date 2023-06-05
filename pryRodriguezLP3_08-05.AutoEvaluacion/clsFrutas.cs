using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryRodriguezRodrigo_AutoEvaluacion_08_05
{
    internal class clsFrutas
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;


        public clsFrutas()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Frutas";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["fruta"];
            tabla.PrimaryKey = dc;
        }

        public DataTable getAll()
        {
            return tabla;
        }

        public void Grabar()
        {
            DataRow Busca = null;
            if (Busca is null)
            {
                DataRow fila = tabla.NewRow();
                //Busca[1] = ;
                //Busca[1] = ;
                //Busca[1] = ;
                //Busca[1] = ;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                adaptador.Update(tabla);
            }
            else
            {

            }
        }
    }
}
