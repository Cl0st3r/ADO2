using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDatenbank1
{
    internal class Artiel
    {
        private Int32 artikelOid;
        private String artikelNr;
        private Int32 artikelGruppe;
        private String bezeichnung;
        private int bestand;
        private int meldebestand;
        private Int32 verpackung;
        private Decimal vkPreis;
        private DateTime letzteEntnahme;

        public Artiel()
        {
            this.ArtikelNr = String.Empty;
            this.ArtikelGruppe = 0;
            this.bezeichnung = String.Empty;
            this.Verpackung = 0;
            this.Meldebestand = 0;
            this.vkPreis = 0m;
            this.LetzteEntnahme = DateTime.MaxValue;
            this.Bestand = 0;
        }
        public int ArtikelOid
        {
            get
            {
                return artikelOid;
            }

            set
            {
                artikelOid = value;
            }
        }

        public string ArtikelNr
        {
            get
            {
                return artikelNr;
            }

            set
            {
                artikelNr = value;
            }
        }

        public int ArtikelGruppe
        {
            get
            {
                return artikelGruppe;
            }

            set
            {
                artikelGruppe = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }

      
        

        public int Verpackung
        {
            get
            {
                return verpackung;
            }

            set
            {
                verpackung = value;
            }
        }

        public decimal VkPreis
        {
            get
            {
                return vkPreis;
            }

            set
            {
                vkPreis = value;
            }
        }

        public DateTime LetzteEntnahme
        {
            get
            {
                return letzteEntnahme;
            }

            set
            {
                letzteEntnahme = value;
            }
        }

        public int Bestand
        {
            get
            {
                return bestand;
            }

            set
            {
                bestand = value;
            }
        }

        public int Meldebestand
        {
            get
            {
                return meldebestand;
            }

            set
            {
                meldebestand = value;
            }
        }

        override
        public String ToString()
        {
            return artikelNr + " " + bezeichnung + " " + bestand; 
        }
    }
}
