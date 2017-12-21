using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsAppDatenbank1
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbConnectionStringBuilder builder = null;
        OleDbCommand command = null;
        OleDbDataReader reader = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection();
            builder = new OleDbConnectionStringBuilder();
            builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            builder.DataSource = "Bestellung.accdb";
            con.ConnectionString = builder.ConnectionString;
            try
            {
                con.Open();
                toolStripStatusLabel.Text = "Verbindung aufgebaut!";
            } catch(Exception)
            {
                toolStripStatusLabel.Text = "Verbindung nicht möglich";
            }
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT * FROM tArtikel";
            try
            {
                reader = command.ExecuteReader();
            } catch(Exception)
            {
                MessageBox.Show("Zugriff auf tArtikel nicht möglich");
            }
        }

        private void buttonAuslesen_Click(object sender, EventArgs e)
        {
            while(reader.Read())
            {
                //String bez = reader.GetString(3);
                Artiel a = mkArtikelObjekt(reader);
                listBoxAusgabe.Items.Add(a);
            }
            reader.Close();
        }

        private Artiel mkArtikelObjekt(OleDbDataReader reader)
        {
            int i = 0;
            Artiel a = new Artiel();
            try
            {
                a.ArtikelOid = Convert.ToInt32(pruefen(reader[i]));
                a.ArtikelNr = Convert.ToString(pruefen(reader[i++]));
                a.ArtikelGruppe = Convert.ToInt16(pruefen(reader[i++]));
                a.Bezeichnung = Convert.ToString(pruefen(reader[i++]));
                a.Bestand = Convert.ToInt32(pruefen(reader[i++]));
                a.Meldebestand = Convert.ToInt32(pruefen(reader[i++]));
                a.Verpackung = Convert.ToInt32(pruefen(reader[i++]));
                a.VkPreis = Convert.ToDecimal(pruefen(reader[i++]));
                a.LetzteEntnahme = Convert.ToDateTime(pruefen(reader[i++]));
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler beim Einlesen");
            }
            return a;
        }

        private Object pruefen(Object o)
        {
            if(o == DBNull.Value)
            {
                return null;
            }
            else
            {
                return o;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(listBoxAusgabe.SelectedItem != null)
            {
                Artiel a = (Artiel)listBoxAusgabe.SelectedItem;
                FormUpdate update1 = new FormUpdate();
                update1.Visible = true;
                if(update1.Result == DialogResult.OK)
                {

                    //Command Object
                    //Conn Open
                    //Parameter Generieren
                    //Commandtext: SQL
                    //Command ausführen
                    updateArtikel(update1.SelArtikel);
                }
                else
                {
                    toolStripLabel1.Text = "Abgebrochen";
                }
            }
        }

        private void updateArtikel(Artiel a)
        {
            //TODO: Command-Object
            OleDbCommand cmd = con.CreateCommand();
            //TODO: Conn open
            cmd.Parameters.AddWithValue("ANR", a.ArtikelNr);
            cmd.Parameters.AddWithValue("BEZ", a.Bezeichnung);
            cmd.Parameters.AddWithValue("BEST", a.Bestand);
            cmd.Parameters.AddWithValue("MBEST", a.Meldebestand);
            cmd.Parameters.AddWithValue("VkPr", a.VkPreis);
            cmd.Parameters.AddWithValue("LENT", a.LetzteEntnahme);
            //TODO: Parameter Generieren
            String sql = "UPDATE tArtikel SET ArtikelNR = ANR, Bezeichnung = BEZ, Bestand = BEST, Meldebestand = MBEST, Verkaufspreis = VKPR, LetzteEntnahme = LENT";
            sql += "Where ArtikelOID = " + a.ArtikelOid;
            //TODO: Commandtext SQL
            con.Open();
            //TODO: Command ausführen
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("Fehler beim Update");
                toolStripStatusLabel.Text = "Fehler beim Update";
            }
        }
    }
}
