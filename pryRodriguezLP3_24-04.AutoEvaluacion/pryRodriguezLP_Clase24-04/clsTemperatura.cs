using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryRodriguezLP_Clase24_04
{
    internal class clsTemperatura
    {
        private string Cadena = "";
        private OleDbConnection Conector;
        private OleDbCommand Comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;

        public clsTemperatura()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            Conector = new OleDbConnection(Cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Temperaturas";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);
        }

        //

        public DataTable getAll()
        {
            return Tabla;
        }
    }
}
