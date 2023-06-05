using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryRodriguezRodrigo_AutoEvaluacion_08_05
{
    internal class clsBarrios
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;


        private int barrio;
        private string nombre;

        public int BARRIO
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public clsBarrios()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["barrio"];
            tabla.PrimaryKey = dc;
        }

        public void Agregar()
        {
            DataRow fila = tabla.NewRow(); //Crea variable registro y agrega nueva fila
            fila["barrio"] = barrio;
            fila["nombre"] = nombre;
            tabla.Rows.Add(fila);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); //Tengo que declarar el adaptador  
            adaptador.Update(tabla);//Lleva los datos de la memoria a tabla
        }

        public void Buscar()
        {
            DataRow fila = tabla.Rows.Find(barrio);//Busqueda rapida sin repetitiva
                                                   //cuando sea unicamente primarykey
            if (fila == null)
            {
                nombre = "";
            }
            else
            {
                nombre = fila["nombre"].ToString();
            }         
        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
