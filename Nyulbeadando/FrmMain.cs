using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nyulbeadando
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; } //connectionstring, sql connection-t biztosit.

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

       

        private void btn_kilep_Click(object sender, EventArgs e) //bezárási gomb
        {
            this.Close();
        }

        private void btn_term_Click(object sender, EventArgs e) //Termelés ablak megnyitása
        {
            FrmTermeles frmTermeles = new FrmTermeles();
            frmTermeles.ShowDialog();
        }

        private void btn_stat_Click(object sender, EventArgs e) // statisztika ablak megnyitása
        {
            FrmStatisztika frmStatisztika = new FrmStatisztika();
            frmStatisztika.ShowDialog();
        }
    }
}
