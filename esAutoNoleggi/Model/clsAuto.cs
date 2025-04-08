using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES32noleggioAuto.Model
{
    public class clsAuto
    {
        string targa;
        int km;
        string colore;
        bool cambioAutomatico;
        bool disponibile;
        int idModello;
        int idAl;

        public string Targa { get => targa; set => targa = value; }
        public int Km { get => km; set => km = value; }
        public string Colore { get => colore; set => colore = value; }
        public bool CambioAutomatico { get => cambioAutomatico; set => cambioAutomatico = value; }
        public bool Disponibile { get => disponibile; set => disponibile = value; }
        public int IdModello { get => idModello; set => idModello = value; }
        public int IdAl { get => idAl; set => idAl = value; }

        //x compito controllare i dati
    }
}
