using ADOSQLServer2017_ns;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES32noleggioAuto.Controller
{
    internal class clsNoleggiController
    {
        ADOSQLServer2017 ado;

        public clsNoleggiController(string dbName)
        {
            ado = new ADOSQLServer2017(dbName);
        }
        /// <summary>
        /// Inserisce un nuovo noleggio e aggiorna la disponibilità dell'auto.
        /// </summary>
        /// <param name="idCliente">L'ID del cliente che noleggia l'auto.</param>
        /// <param name="targa">La targa dell'auto noleggiata.</param>
        /// <param name="dataInizio">La data di inizio del noleggio.</param>
        public void InserisciNoleggio(int idCliente, string targa, DateTime dataInizio)
        {
            // Inserire il noleggio
            string queryNoleggio = "INSERT INTO NOLEGGI (IDCLIENTE, TARGA, DATAINIZIO, DATAFINE) " +
                                   "VALUES (@IDCLIENTE, @TARGA, @DATAINIZIO, NULL);";

            SqlCommand cmdNoleggio = new SqlCommand();
            cmdNoleggio.CommandType = CommandType.Text;
            cmdNoleggio.CommandText = queryNoleggio;

            cmdNoleggio.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            cmdNoleggio.Parameters.AddWithValue("@TARGA", targa);
            cmdNoleggio.Parameters.AddWithValue("@DATAINIZIO", dataInizio);

            ado.EseguiNonQuery(cmdNoleggio);

            // Aggiornare la disponibilità dell'auto
            string queryDisponibilita = "UPDATE AUTOMOBILI SET DISPONIBILE = 0 WHERE TARGA = @TARGA;";
            SqlCommand cmdDisponibilita = new SqlCommand();
            cmdDisponibilita.CommandType = CommandType.Text;
            cmdDisponibilita.CommandText = queryDisponibilita;

            cmdDisponibilita.Parameters.AddWithValue("@TARGA", targa);

            ado.EseguiNonQuery(cmdDisponibilita);
        }
        /// <summary>
        /// Termina un noleggio aggiornando la data di fine e la disponibilità dell'auto.
        /// </summary>
        /// <param name="idNoleggio">L'ID del noleggio da terminare.</param>
        /// <param name="dataFine">La data di fine del noleggio.</param>
        public void TerminaNoleggio(int idNoleggio, DateTime dataFine)
        {
            // Aggiornare la data di fine del noleggio
            string queryNoleggio = "UPDATE NOLEGGI SET DATAFINE = @DATAFINE WHERE IDNOLEGGIO = @IDNOLEGGIO;";
            SqlCommand cmdNoleggio = new SqlCommand();
            cmdNoleggio.CommandType = CommandType.Text;
            cmdNoleggio.CommandText = queryNoleggio;

            cmdNoleggio.Parameters.AddWithValue("@IDNOLEGGIO", idNoleggio);
            cmdNoleggio.Parameters.AddWithValue("@DATAFINE", dataFine);

            ado.EseguiNonQuery(cmdNoleggio);

            // Recuperare la targa dell'auto associata al noleggio
            string queryTarga = "SELECT TARGA FROM NOLEGGI WHERE IDNOLEGGIO = @IDNOLEGGIO;";
            SqlCommand cmdTarga = new SqlCommand();
            cmdTarga.CommandType = CommandType.Text;
            cmdTarga.CommandText = queryTarga;

            cmdTarga.Parameters.AddWithValue("@IDNOLEGGIO", idNoleggio);

            string targa = ado.EseguiScalar(cmdTarga).ToString();

            // Aggiornare la disponibilità dell'auto
            string queryDisponibilita = "UPDATE AUTOMOBILI SET DISPONIBILE = 1 WHERE TARGA = @TARGA;";
            SqlCommand cmdDisponibilita = new SqlCommand();
            cmdDisponibilita.CommandType = CommandType.Text;
            cmdDisponibilita.CommandText = queryDisponibilita;

            cmdDisponibilita.Parameters.AddWithValue("@TARGA", targa);

            ado.EseguiNonQuery(cmdDisponibilita);
        }

    }
}
