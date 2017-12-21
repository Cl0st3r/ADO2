using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDatenbank1
{
    public partial class Insert : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbConnectionStringBuilder builder = null;
        Artiel a;

        public Insert()
        {
            InitializeComponent();
        }

        public void Vorbereiten(OleDbConnection con, Artiel a)
        {
            this.a = a;
            if (con == null)
            {
                con = new OleDbConnection();
                builder = new OleDbConnectionStringBuilder();
                builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                builder.DataSource = "Bestellung.accdb";
                con.ConnectionString = builder.ConnectionString;
                try
                {
                    con.Open();
                    //toolStripStatusLabel.Text = "Verbindung aufgebaut!";
                }
                catch (Exception)
                {
                    //toolStripStatusLabel.Text = "Verbindung nicht möglich";
                }
            }

            cmd = con.CreateCommand();
            Insertion(cmd, a);
        }

        public void Insertion(OleDbCommand cmd, Artiel a)
        {
            cmd = con.CreateCommand();
            cmd.CommandText("INSERT INTO tArtGruppe VALUES(" + a.ArtikelNr + ")");
        }
    }
}
