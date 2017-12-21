using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDatenbank1
{
    public partial class FormUpdate : Form
    {
        private DialogResult result = DialogResult.OK;
        private Artiel selArtikel;
        public FormUpdate()
        {
            InitializeComponent();
        }

        FormUpdate(Artiel artiel)
        {
            SelArtikel = artiel;
            InitializeControls();
            //asdf
        }

        public DialogResult Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        internal Artiel SelArtikel
        {
            get
            {
                return selArtikel;
            }

            set
            {
                selArtikel = value;
            }
        }

        public void InitializeControls()
        {
            this.textBoxArtikelOID.Text = SelArtikel.ArtikelOid.ToString();
            this.textBoxArtikelNummer.Text = SelArtikel.ArtikelNr.ToString();
            this.textBoxArtikelgruppe.Text = SelArtikel.ArtikelGruppe.ToString();
            this.textBoxArtikelbezeichnung.Text = SelArtikel.ArtikelGruppe.ToString();
            this.textBoxBestand.Text = SelArtikel.Bestand.ToString();
            this.textBoxMeldebestand.Text = SelArtikel.Meldebestand.ToString();
            this.textBoxVerpackung.Text = SelArtikel.Verpackung.ToString();
            this.textBoxVkPreis.Text = SelArtikel.VkPreis.ToString();
            this.textBoxLetzteEntnahme.Text = SelArtikel.LetzteEntnahme.ToString();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SelArtikel.ArtikelNr = textBoxArtikelNummer.Text;
            SelArtikel.Bezeichnung = textBoxArtikelbezeichnung.Text;
            selArtikel.Bestand = Convert.ToInt16(textBoxBestand.Text);
            selArtikel.Meldebestand = Convert.ToInt32(textBoxMeldebestand.Text);
            selArtikel.VkPreis = Convert.ToDecimal(textBoxVkPreis.Text);
            selArtikel.LetzteEntnahme = Convert.ToDateTime(textBoxLetzteEntnahme.Text);
            this.Close();
        }
    }
}
