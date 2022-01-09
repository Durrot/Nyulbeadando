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
    public partial class FrmStatisztika : Form
    {
        public string ConnectionString { get; set; } //connectionstring, sql connection-t biztosit.
        public FrmStatisztika()
        {
            ConnectionString =
               "Server = (localdb)\\MSSQLLocalDB; " +
                "Database = TojasGyartas;";
            InitializeComponent();
        }

        private void FrmStatisztika_Load(object sender, EventArgs e) //betöltéskor ezek a függvények hivodnak meg
        {
            FillCBmunkas(); 
            FillDGV();
            Legtobbtojasszin();
            legtobbsuly();
        }

        private void Legtobbtojasszin()
        {

            if (DGVStat.Rows.Count != 0)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r = new SqlCommand(
                    "SELECT TOP 1 Szin, SUM(Mennyiseg) " + //Top a legelsőt választ ki, az alsó order by adja meg hogy a legtöbb sum-os kerüljön ugye legfelülre és azt választja ki a top 1 igy kapunk jó eredményt.
                    "FROM Nyul,Termeles,Tojas " +
                    "WHERE Termeles.NyulId=Nyul.Id " +
                    "AND Termeles.TipusId=Tojas.Id " +
                    $"AND Nev LIKE '{CBMunkasSTAT.Text}' " +
                    $"AND MONTH(Datum) = { NUDhonap.Value} " +
                    "GROUP BY Szin "+
                    "ORDER BY SUM(Mennyiseg) DESC;",
                     c).ExecuteReader();
                    r.Read();
                    tojasok.Text = $"{r[0]} ({r[1]}) db"; //boxba való kiiratás,azért van az r-nek két értéke, mert két dolgot selectelünk
                    r.Close();
                }


            }

        }

        private void legtobbsuly()
        {
            if (DGVStat.Rows.Count != 0)
            {
                using (var c = new SqlConnection(ConnectionString))
                {
                    c.Open();
                    var r = new SqlCommand(
                    "SELECT SUM(Suly * Mennyiseg) " +
                    "FROM Nyul,Termeles,Tojas " +
                    "WHERE Termeles.NyulId=Nyul.Id " +
                    "AND Termeles.TipusId=Tojas.Id " +
                    $"AND Nev LIKE '{CBMunkasSTAT.Text}' " +
                    $"AND MONTH(Datum) = {NUDhonap.Value};",
                    c).ExecuteReader();
                    r.Read();
                    Honapossztojassulya.Text = $"{r.GetInt32(0) / 1000F} Kg"; //boxba való kiiratás
                    r.Close();
                }
                
            }





        }

        private void FillCBmunkas() //textboxot feltölti illetve a hónap választót limitálja
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                //Comboboxhoz adatbázisból való legördülő lista feltöltése
                var r = new SqlCommand("Select Nyul.Nev " +
                "FROM Nyul;", c).ExecuteReader();

                while (r.Read())
                {
                    CBMunkasSTAT.Items.Add(r[0]);
                }





                r.Close();
                //Numericupdown értékeinek rögzitése
                NUDhonap.Maximum = 12;
                NUDhonap.Minimum = 1;
            }
        }

        private void FillDGV() //a datagridview feltöltése.
        {
            DGVStat.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string nyulId = $"{CBMunkasSTAT.SelectedIndex + 1}";
                string Honap = NUDhonap.Value.ToString();

                //Datagridview feltöltése
               var r = new SqlCommand("Select Termeles.Datum, Tojas.szin, Termeles.Mennyiseg " +
                  "FROM Termeles, Tojas, Nyul " +
                  "WHERE Termeles.NyulId=Nyul.Id " +
                  "AND Termeles.TipusId=Tojas.Id " +
                  $"AND Termeles.NyulId = {nyulId} " + //Vizsgálja mi van kiválasztva a munkások közt.
                  $" AND MONTH(Termeles.Datum) LIKE {Honap} "+//vizsgálja melyik hónapot válassza az updown alapján.
                  "ORDER BY Termeles.Datum;", c).ExecuteReader(); 


                while (r.Read()) //maga a datagridview feltöltése a megfelelő adatokkal.
                {
                    DGVStat.Rows.Add(

                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " Db"
                        );

                }

                r.Close(); //idáig


                c.Close();

            }

        }

        private void CBMunkasSTAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV(); //azért van meghivva hogy folyamatosan frissüljön az action után az adatbázist megjelenitő datagridview. Nagyon fontos hogy akkor müködik jól ha ennek a függvénynek az elején van egy clear.
            Legtobbtojasszin(); //Szintén azért van meghivva hogy bármi változik ez a textboxnak a kiirása is változzon. Ha nem igy lenne egyszer kap egy értéket és úgy maradna.
            legtobbsuly();  //Szintén azért van meghivva hogy bármi változik ez a textboxnak a kiirása is változzon. Ha nem igy lenne egyszer kap egy értéket és úgy maradna.
        }

        private void NUDhonap_ValueChanged(object sender, EventArgs e)
        {
            FillDGV(); //azért van meghivva hogy folyamatosan frissüljön az action után az adatbázist megjelenitő datagridview. Nagyon fontos hogy akkor müködik jól ha ennek a függvénynek az elején van egy clear.
            Legtobbtojasszin();  //Szintén azért van meghivva hogy bármi változik ez a textboxnak a kiirása is változzon. Ha nem igy lenne egyszer kap egy értéket és úgy maradna.
            legtobbsuly();  //Szintén azért van meghivva hogy bármi változik ez a textboxnak a kiirása is változzon. Ha nem igy lenne egyszer kap egy értéket és úgy maradna.
        }
    }
}
