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

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TARGA,MARCA, MODELLO, COLORE,ALIMENTAZIONE, KM,CAMBIOAUTOMATICO ";
            cmd.CommandText += "FROM AUTOMOBILI, MARCHE, MODELLI, ALIMENTAZIONI ";
            cmd.CommandText += "WHERE DISPONIBILE=1 AND MARCHE.IDMARCA= MODELLI.IDMARCA ";
            cmd.CommandText += " AND MODELLI.IDMODELLO=AUTOMOBILI.IDMODELLO ";
            cmd.CommandText += "  AND AUTOMOBILI.idAl = ALIMENTAZIONI.idAl ";
            cmd.CommandText += "ORDER BY TARGA";
            dt = ado.EseguiQuery(cmd);

            return dt;
        }
        public DataTable GetAllModelli()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idModello,modello ";
            cmd.CommandText += "FROM MODELLI";
            dt = ado.EseguiQuery(cmd);

            return dt;
        }
        public DataTable GetAllAlimentazione()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idAl,alimentazione ";
            cmd.CommandText += "FROM alimentazioni";
            dt = ado.EseguiQuery(cmd);

            return dt;
        }

        public void InsertAuto(string targa, int km, string colore, bool cambioAutomatico, bool disponibile, int idModello, int idAl)
        {
            // Construct the SQL INSERT query with parameter placeholders
            string query = "INSERT INTO AUTOMOBILI (TARGA, KM, COLORE, CAMBIOAUTOMATICO, DISPONIBILE, IDMODELLO, IDAL) " +
                           "VALUES (@TARGA, @KM, @COLORE, @CAMBIOAUTOMATICO, @DISPONIBILE, @IDMODELLO, @IDAL);";

            // Create a new SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@TARGA", targa);
            cmd.Parameters.AddWithValue("@KM", km);
            cmd.Parameters.AddWithValue("@COLORE", colore);
            cmd.Parameters.AddWithValue("@CAMBIOAUTOMATICO", cambioAutomatico);
            cmd.Parameters.AddWithValue("@DISPONIBILE", disponibile);
            cmd.Parameters.AddWithValue("@IDMODELLO", idModello);
            cmd.Parameters.AddWithValue("@IDAL", idAl);

            // Execute the query
            ado.EseguiNonQuery(cmd);
        }

        public void DeleteAuto(string targa)
        {
            // Construct the SQL DELETE query with parameter placeholders
            string query = "DELETE FROM AUTOMOBILI WHERE TARGA = @TARGA;";
            // Create a new SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@TARGA", targa);
            // Execute the query
            ado.EseguiNonQuery(cmd);
        }

        internal void EditAuto(string targa, int km, string colore, bool cambioAutomatico1, bool cambioAutomatico2, int modello, int alimentazione)
        {
            // Construct the SQL UPDATE query with parameter placeholders
            string query = "UPDATE AUTOMOBILI SET KM = @KM, COLORE = @COLORE, CAMBIOAUTOMATICO = @CAMBIOAUTOMATICO, IDMODELLO = @IDMODELLO, IDAL = @IDAL WHERE TARGA = @TARGA;";
            // Create a new SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            // Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@TARGA", targa);
            cmd.Parameters.AddWithValue("@KM", km);
            cmd.Parameters.AddWithValue("@COLORE", colore);
            cmd.Parameters.AddWithValue("@CAMBIOAUTOMATICO", cambioAutomatico1);
            cmd.Parameters.AddWithValue("@IDMODELLO", modello);
            cmd.Parameters.AddWithValue("@IDAL", alimentazione);
            // Execute the query
            ado.EseguiNonQuery(cmd);
        }

        /// <summary>
        /// Modifica i chilometri di un'auto.
        /// </summary>
        /// <param name="targa">La targa dell'auto.</param>
        /// <param name="nuoviKm">Il nuovo valore dei chilometri.</param>
        public void ModificaChilometri(string targa, int nuoviKm)
        {
            string query = "UPDATE AUTOMOBILI SET KM = @KM WHERE TARGA = @TARGA;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TARGA", targa);
            cmd.Parameters.AddWithValue("@KM", nuoviKm);
            ado.EseguiNonQuery(cmd);
        }
        /// <summary>
        /// Modifica la disponibilità di un'auto.
        /// </summary>
        /// <param name="targa">La targa dell'auto.</param>
        /// <param name="disponibile">Il nuovo stato di disponibilità (true o false).</param>
        public void ModificaDisponibilita(string targa, bool disponibile)
        {
            string query = "UPDATE AUTOMOBILI SET DISPONIBILE = @DISPONIBILE WHERE TARGA = @TARGA;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TARGA", targa);
            cmd.Parameters.AddWithValue("@DISPONIBILE", disponibile);
            ado.EseguiNonQuery(cmd);
        }
        /// <summary>
        /// Cancella un'auto solo se non è mai stata noleggiata.
        /// </summary>
        /// <param name="targa">La targa dell'auto.</param>
        public void CancellaAutoSeMaiNoleggiata(string targa)
        {
            string queryVerifica = "SELECT COUNT(*) FROM NOLEGGI WHERE TARGA = @TARGA;";
            SqlCommand cmdVerifica = new SqlCommand();
            cmdVerifica.CommandType = CommandType.Text;
            cmdVerifica.CommandText = queryVerifica;
            cmdVerifica.Parameters.AddWithValue("@TARGA", targa);

            int numeroNoleggi = Convert.ToInt32(ado.EseguiScalar(cmdVerifica));
            if (numeroNoleggi > 0)
            {
                throw new InvalidOperationException("Non è possibile cancellare l'auto perché è stata noleggiata.");
            }

            string queryCancella = "DELETE FROM AUTOMOBILI WHERE TARGA = @TARGA;";
            SqlCommand cmdCancella = new SqlCommand();
            cmdCancella.CommandType = CommandType.Text;
            cmdCancella.CommandText = queryCancella;
            cmdCancella.Parameters.AddWithValue("@TARGA", targa);
            ado.EseguiNonQuery(cmdCancella);
        }
        /// <summary>
        /// Visualizza tutti i campi di un'auto conoscendo la targa.
        /// </summary>
        /// <param name="targa">La targa dell'auto.</param>
        /// <returns>Un DataTable contenente i dati dell'auto.</returns>
        public DataTable VisualizzaAutoPerTarga(string targa)
        {
            string query = "SELECT * FROM AUTOMOBILI WHERE TARGA = @TARGA;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TARGA", targa);
            return ado.EseguiQuery(cmd);
        }

    }
}
