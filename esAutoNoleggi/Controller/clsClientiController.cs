using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOSQLServer2017_ns;

namespace ES32noleggioAuto.Controller
{
    internal class clsClientiController
    {
        ADOSQLServer2017 ado;

        public clsClientiController(string dbName)
        {
            ado = new ADOSQLServer2017(dbName);
        }
        /// <summary>
        /// Inserisce un nuovo cliente nel database.
        /// </summary>
        /// <param name="idCliente">L'ID del cliente.</param>
        /// <param name="cognome">Il cognome del cliente.</param>
        /// <param name="nome">Il nome del cliente.</param>
        /// <param name="telefono">Il numero di telefono del cliente.</param>
        /// <param name="email">L'email del cliente.</param>
        public void InserisciCliente(int idCliente, string cognome, string nome, string telefono, string email)
        {
            string query = "INSERT INTO CLIENTI (IDCLIENTE, COGNOME, NOME, TELEFONO, EMAIL) " +
                           "VALUES (@IDCLIENTE, @COGNOME, @NOME, @TELEFONO, @EMAIL);";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            cmd.Parameters.AddWithValue("@COGNOME", cognome);
            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("@EMAIL", email);

            ado.EseguiNonQuery(cmd);
        }
        /// <summary>
        /// Modifica i dati di un cliente (escluso l'ID).
        /// </summary>
        /// <param name="idCliente">L'ID del cliente.</param>
        /// <param name="cognome">Il nuovo cognome del cliente.</param>
        /// <param name="nome">Il nuovo nome del cliente.</param>
        /// <param name="telefono">Il nuovo numero di telefono del cliente.</param>
        /// <param name="email">La nuova email del cliente.</param>
        public void ModificaCliente(int idCliente, string cognome, string nome, string telefono, string email)
        {
            string query = "UPDATE CLIENTI SET COGNOME = @COGNOME, NOME = @NOME, TELEFONO = @TELEFONO, EMAIL = @EMAIL " +
                           "WHERE IDCLIENTE = @IDCLIENTE;";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
            cmd.Parameters.AddWithValue("@COGNOME", cognome);
            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@TELEFONO", telefono);
            cmd.Parameters.AddWithValue("@EMAIL", email);

            ado.EseguiNonQuery(cmd);
        }
        /// <summary>
        /// Cancella un cliente solo se non ha mai noleggiato un'auto.
        /// </summary>
        /// <param name="idCliente">L'ID del cliente.</param>
        public void CancellaClienteSeMaiNoleggiato(int idCliente)
        {
            string queryVerifica = "SELECT COUNT(*) FROM NOLEGGI WHERE IDCLIENTE = @IDCLIENTE;";
            SqlCommand cmdVerifica = new SqlCommand();
            cmdVerifica.CommandType = CommandType.Text;
            cmdVerifica.CommandText = queryVerifica;
            cmdVerifica.Parameters.AddWithValue("@IDCLIENTE", idCliente);

            int numeroNoleggi = Convert.ToInt32(ado.EseguiScalar(cmdVerifica));
            if (numeroNoleggi > 0)
            {
                throw new InvalidOperationException("Non è possibile cancellare il cliente perché ha noleggiato un'auto.");
            }

            string queryCancella = "DELETE FROM CLIENTI WHERE IDCLIENTE = @IDCLIENTE;";
            SqlCommand cmdCancella = new SqlCommand();
            cmdCancella.CommandType = CommandType.Text;
            cmdCancella.CommandText = queryCancella;
            cmdCancella.Parameters.AddWithValue("@IDCLIENTE", idCliente);

            ado.EseguiNonQuery(cmdCancella);
        }
        /// <summary>
        /// Visualizza i dati di tutti i clienti.
        /// </summary>
        /// <returns>Un DataTable contenente i dati dei clienti.</returns>
        public DataTable VisualizzaTuttiClienti()
        {
            string query = "SELECT * FROM CLIENTI;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            return ado.EseguiQuery(cmd);
        }
        /// <summary>
        /// Visualizza tutti i campi di un cliente conoscendo l'ID.
        /// </summary>
        /// <param name="idCliente">L'ID del cliente.</param>
        /// <returns>Un DataTable contenente i dati del cliente.</returns>
        public DataTable VisualizzaClientePerID(int idCliente)
        {
            string query = "SELECT * FROM CLIENTI WHERE IDCLIENTE = @IDCLIENTE;";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);

            return ado.EseguiQuery(cmd);
        }

    }
}
