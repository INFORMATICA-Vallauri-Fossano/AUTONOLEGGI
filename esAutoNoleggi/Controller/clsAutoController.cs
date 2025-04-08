using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;   //x oggetti adonet
using System.Data.SqlClient;

using ES32noleggioAuto.Model;  //x i vari model
using ADOSQLServer2017_ns;     // x metodi eseguiQuery,scalar,nonquery 

namespace ES32noleggioAuto.Controller
{
    public class clsAutoController
    {
        ADOSQLServer2017 ado;

        public clsAutoController(string dbName)
        {
            ado = new ADOSQLServer2017(dbName);
        }

        /// <summary>
        /// visualizziamo le automobili disponibili
        /// </summary>
        /// <returns>dataTable</returns>
       public DataTable GetAllAuto()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd= new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TARGA,MARCA, MODELLO, COLORE,ALIMENTAZIONE, KM ";
            cmd.CommandText += "FROM AUTOMOBILI, MARCHE, MODELLI, ALIMENTAZIONI "; 
            cmd.CommandText +="WHERE DISPONIBILE=1 AND MARCHE.IDMARCA= MODELLI.IDMARCA ";
            cmd.CommandText += " AND MODELLI.IDMODELLO=AUTOMOBILI.IDMODELLO ";
            cmd.CommandText += "  AND AUTOMOBILI.idAl = ALIMENTAZIONI.idAl ";
            cmd.CommandText += "ORDER BY TARGA";
            dt=ado.EseguiQuery(cmd);

            return dt;
        }

    }
}
