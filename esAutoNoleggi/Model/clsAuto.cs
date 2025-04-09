using System;

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

        public string Targa
        {
            get => targa;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 7)
                    throw new ArgumentException("Targa must be a non-empty string with exactly 7 characters.");
                targa = value;
            }
        }

        public int Km
        {
            get => km;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Km cannot be negative.");
                km = value;
            }
        }

        public string Colore
        {
            get => colore;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Colore cannot be null or empty.");
                colore = value;
            }
        }

        public bool CambioAutomatico
        {
            get => cambioAutomatico;
            set => cambioAutomatico = value; // No specific validation needed
        }

        public bool Disponibile
        {
            get => disponibile;
            set => disponibile = value; // No specific validation needed
        }

        public int IdModello
        {
            get => idModello;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("IdModello must be a positive integer.");
                idModello = value;
            }
        }

        public int IdAl
        {
            get => idAl;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("IdAl must be a positive integer.");
                idAl = value;
            }
        }

        // Optional: Method to validate all properties at once
        public void Validate()
        {
            Targa = Targa; // Triggers validation
            Km = Km;
            Colore = Colore;
            IdModello = IdModello;
            IdAl = IdAl;
        }
    }
}
