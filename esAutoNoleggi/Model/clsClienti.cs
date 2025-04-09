using System;
using System.Text.RegularExpressions;

namespace ES32noleggioAuto.Model
{
    public class clsClienti
    {
        int idCliente;
        string cognome;
        string nome;
        string telefono;
        string eMail;

        public int IdCliente
        {
            get => idCliente;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("IdCliente must be a positive integer.");
                idCliente = value;
            }
        }

        public string Cognome
        {
            get => cognome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Cognome cannot be null or empty.");
                cognome = value;
            }
        }

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome cannot be null or empty.");
                nome = value;
            }
        }

        public string Telefono
        {
            get => telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\+?[0-9]{7,15}$"))
                    throw new ArgumentException("Telefono must be a valid phone number (7-15 digits, optional '+' prefix).");
                telefono = value;
            }
        }

        public string EMail
        {
            get => eMail;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("EMail must be a valid email address.");
                eMail = value;
            }
        }

        // Optional: Method to validate all properties at once
        public void Validate()
        {
            IdCliente = IdCliente; // Triggers validation
            Cognome = Cognome;
            Nome = Nome;
            Telefono = Telefono;
            EMail = EMail;
        }
    }
}
