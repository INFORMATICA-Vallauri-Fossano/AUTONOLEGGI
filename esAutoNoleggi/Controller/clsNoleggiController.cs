using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esAutoNoleggi.Controller
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
        public void InserisciNoleggio(int idCliente, string targa, DateTime dataInizio, DateTime? dataFine)
        {
            //controllare la disponibilità
            string queryDisponibile = "SELECT COUNT(*) FROM AUTOMOBILI WHERE TARGA=@targa AND DISPONIBILE=1";

            SqlCommand cmdDisponibile = new SqlCommand();
            cmdDisponibile.CommandType = CommandType.Text;
            cmdDisponibile.CommandText = queryDisponibile;

            cmdDisponibile.Parameters.AddWithValue("@targa", targa);

            if (Convert.ToInt32(ado.EseguiScalar(cmdDisponibile)) == 0) throw new Exception("L'auto non è disponibile per il noleggio");
            // Inserire il noleggio
            string queryNoleggio = "INSERT INTO NOLEGGI (IDCLIENTE, TARGA, DATAINIZIO, DATAFINE) " +
                                   "VALUES (@IDCLIENTE, @TARGA, @DATAINIZIO, @DATAFINE);";

            SqlCommand cmdNoleggio = new SqlCommand();
            cmdNoleggio.CommandType = CommandType.Text;
            cmdNoleggio.CommandText = queryNoleggio;

            cmdNoleggio.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            cmdNoleggio.Parameters.AddWithValue("@TARGA", targa);
            cmdNoleggio.Parameters.AddWithValue("@DATAINIZIO", dataInizio);
            cmdNoleggio.Parameters.AddWithValue("@DATAFINE", dataFine);

            ado.EseguiNonQuery(cmdNoleggio);

            // Aggiornare la disponibilità dell'auto se la datafine  è nulla
            if (dataFine == null)
            {
                string queryDisponibilita = "UPDATE AUTOMOBILI SET DISPONIBILE = 0 WHERE TARGA = @TARGA;";
                SqlCommand cmdDisponibilita = new SqlCommand();
                cmdDisponibilita.CommandType = CommandType.Text;
                cmdDisponibilita.CommandText = queryDisponibilita;

                cmdDisponibilita.Parameters.AddWithValue("@TARGA", targa);
                ado.EseguiNonQuery(cmdDisponibilita);
            }

        }
        public DataTable GetQuery(string query, Dictionary<string, string> args)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            if (args != null)
                foreach (KeyValuePair<string, string> parameter in args)
                {
                    sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            DataTable dt = ado.EseguiQuery(sqlCommand);
            return dt;
        }
        /// <summary>
        /// Termina un noleggio aggiornando la data di fine e la disponibilità dell'auto.
        /// </summary>
        /// <param name="idNoleggio">L'ID del noleggio da terminare.</param>
        /// <param name="dataFine">La data di fine del noleggio.</param>
        public void TerminaNoleggio(int idNoleggio, DateTime? dataFine)
        {
            //controllare se il noleggio era già terminato
            string queryControllo = "SELECT COUNT(*) FROM NOLEGGI WHERE IDNOLEGGIO=@IDNOLEGGIO AND DATAFINE IS NOT NULL";
            SqlCommand cmdControllo = new SqlCommand();
            cmdControllo.CommandType = CommandType.Text;
            cmdControllo.CommandText = queryControllo;

            cmdControllo.Parameters.AddWithValue("@IDNOLEGGIO", idNoleggio);

            if (Convert.ToInt32(ado.EseguiScalar(cmdControllo)) > 0) throw new Exception("Il noleggio è già terminato");

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

        internal object GetAllAutoDisponibili()
        {
            string query = "SELECT TARGA FROM AUTOMOBILI WHERE DISPONIBILE = 1;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable dt = ado.EseguiQuery(cmd);
            return dt;
        }
        internal object GetAllAuto()
        {
            string query = "SELECT TARGA FROM AUTOMOBILI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable dt = ado.EseguiQuery(cmd);
            return dt;
        }

        internal object GetAllClienti()
        {
            string query = "SELECT IDCLIENTE, COGNOME + ' ' + NOME AS NOME FROM CLIENTI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable dt = ado.EseguiQuery(cmd);
            return dt;
        }

        internal DataTable GetAllNoleggi()
        {
            string query = "SELECT * FROM NOLEGGI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable dt = ado.EseguiQuery(cmd);
            return dt;
        }

        internal void Paga(int idNoleggio)
        {
            //diminuzione del saldo del cliente altrimenti errore
            string queryPrezzo = "SELECT PREZZO FROM AUTOMOBILI A RIGHT JOIN NOLEGGI N ON A.TARGA=N.TARGA WHERE N.IDNOLEGGIO=@id";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = queryPrezzo;

            cmd.Parameters.AddWithValue("@id", idNoleggio);

            decimal prezzo = Convert.ToDecimal(ado.EseguiScalar(cmd));

            string querySaldo = "SELECT SALDO FROM CLIENTI C RIGHT JOIN NOLEGGI N ON C.IDCLIENTE=N.IDCLIENTE WHERE N.IDNOLEGGIO=@id";
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = querySaldo;

            cmd2.Parameters.AddWithValue("@id", idNoleggio);

            decimal saldo = Convert.ToDecimal(ado.EseguiScalar(cmd2));

            decimal nuovoSaldo = saldo - prezzo;

            if(nuovoSaldo<0) throw new Exception("Il saldo del cliente non è sufficiente per pagare il noleggio");

            // Aggiornare il saldo del cliente
            string queryAggiornamento= "UPDATE CLIENTI SET SALDO=@nuovoSaldo WHERE IDCLIENTE=(SELECT IDCLIENTE FROM NOLEGGI WHERE IDNOLEGGIO=@id)";
            // AGGIORNO LO STATO DEL NOLEGGIO TO PAGATO=1
            string queryNoleggio = "UPDATE NOLEGGI SET PAGATO=1 WHERE IDNOLEGGIO=@id";
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = queryAggiornamento;
            cmd3.Parameters.AddWithValue("@nuovoSaldo", nuovoSaldo);
            cmd3.Parameters.AddWithValue("@id", idNoleggio);
            ado.EseguiNonQuery(cmd3);
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = queryNoleggio;
            cmd4.Parameters.AddWithValue("@id", idNoleggio);
            ado.EseguiNonQuery(cmd4);

        }

        internal DataTable GetNoleggiByIdCliente(int idCliente)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NOLEGGI WHERE IDCLIENTE=@IDCLIENTE;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            dt = ado.EseguiQuery(cmd);
            return dt;
        }

        internal DataTable GetNoleggiNonTerminatiByIdCliente(int idCliente)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM NOLEGGI WHERE IDCLIENTE=@IDCLIENTE AND DATAFINE IS NULL;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            dt = ado.EseguiQuery(cmd);
            return dt;
        }
    }
}
