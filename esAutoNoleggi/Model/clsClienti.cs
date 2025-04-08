using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES32noleggioAuto.Model
{
    public class clsClienti
    {
        int idCliente;
        string cognome;
        string nome;
        string telefono;
        string eMail;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string EMail { get => eMail; set => eMail = value; }
  //compito
    }
}
