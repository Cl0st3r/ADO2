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
        public Insert()
        {
            InitializeComponent();
        }

        public Insert(OleDbConnection con, Artiel artikel):this()
        {
            OleDbConnection cmd = con.CreateCommand();
        }

        public void Insertion()
        {

        }
    }
}
