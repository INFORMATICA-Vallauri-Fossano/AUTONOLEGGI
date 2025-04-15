using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace esAutoNoleggi.Model
    {
        internal class clsNoleggi
        {
            private int idNoleggio;
            private int idCliente;
            private string targa;
            private DateTime dataInizio;
            private DateTime? dataFine;

            public int IdNoleggio
            {
                get => idNoleggio;
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("IdNoleggio must be a positive integer.");
                    idNoleggio = value;
                }
            }

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

            public string Targa
            {
                get => targa;
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Length != 7)
                        throw new ArgumentException("Targa must be a non-empty string with exactly 7 characters.");
                    targa = value.Trim().ToUpper();
                }
            }

            public DateTime DataInizio
            {
                get => dataInizio;
                set
                {
                    if (value.CompareTo(default)>0)
                        throw new ArgumentException("DataInizio must be a valid date.");
                    dataInizio = value;
                }
            }

            public DateTime? DataFine
            {
                get => dataFine;
                set
                {
                    if (value.HasValue && value.Value < dataInizio)
                        throw new ArgumentException("DataFine cannot be earlier than DataInizio.");
                    dataFine = value;
                }
            }

            /// <summary>
            /// Validates all properties of the rental object.
            /// </summary>
            public void Validate()
            {
                IdNoleggio = IdNoleggio; // Triggers validation
                IdCliente = IdCliente;
                Targa = Targa;
                DataInizio = DataInizio;
                DataFine = DataFine;
            }
        }
    }
