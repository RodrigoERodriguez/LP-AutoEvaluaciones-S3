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
    internal class clsAlumnos
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int dni;
        private string nombre;
        private string sexo;
        private string foto;
        private int barrio;

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string SEXO
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string FOTO
        {
            get { return foto; }
            set { foto = value; }
        }
        public int BARRIO
        {
            get { return barrio; }
            set { barrio = value; }
        }


        public clsAlumnos()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["dni"];
            tabla.PrimaryKey = dc;
        }

        public void Agregar()
        {
            DataRow fila = tabla.NewRow(); //Crea variable registro y agrega nueva fila
            fila["barrio"] = dni;
            fila["nombre"] = nombre;
            fila["sexo"] = sexo;
            fila["foto"] = foto;
            fila["barrio"] = barrio;
            tabla.Rows.Add(fila);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); //Tengo que declarar el adaptador  
            adaptador.Update(tabla);//Lleva los datos de la memoria a tabla
        }

        public void Buscar()
        {
            DataRow fila = tabla.Rows.Find(dni);//Busqueda rapida sin repetitiva
                                                   //cuando sea unicamente primarykey
            if (fila == null)
            {
                nombre = "";
                foto = "";
            }
            else
            {
                dni = Convert.ToInt32(fila["dni"]);
                nombre = fila["nombre"].ToString();
                //sexo = fila["sexo"].ToString();
                foto = fila["foto"].ToString();
                //barrio = Convert.ToInt32(fila["barrio"]);
            }
        }

        public DataTable getAll()
        {
            return tabla;
        }
    }
}
