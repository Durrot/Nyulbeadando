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
    public partial class FrmTermeles : Form
    {

        public string ConnectionString { get; set; } //connectionstring, sql connection-t biztosit.
        public FrmTermeles()
        {
            ConnectionString =
                "Server = (localdb)\\MSSQLLocalDB; " +
                 "Database = TojasGyartas;";
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e)
        {

            FillDGV();
            Fillinputs(); //inputokat tölti fel, 4 darabot.
        }

        

        private void FillDGV()
        {
            DGV.Rows.Clear();
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var r = new SqlCommand("Select Termeles.Datum, Tojas.szin, Termeles.Mennyiseg, Nyul.Nev " +
                   "FROM Termeles, Tojas, Nyul " +
                   "WHERE Termeles.NyulId=Nyul.Id "+
                   "AND Termeles.TipusId=Tojas.Id " +
                   "ORDER BY Termeles.Datum;", c).ExecuteReader(); //datagridview lekérdezése


                while (r.Read())
                {
                    DGV.Rows.Add(
                   
                        r.GetDateTime(0).ToString("yyyy-MM-dd"),
                        r[1],
                        r[2] + " Db",
                        r[3]);
                        
                }
                //datagridviewba való kiiratás
                c.Close();
            }



        }
        private void Fillinputs()
        {

            using (var c = new SqlConnection(ConnectionString))
            {

                c.Open();

                var r = new SqlCommand("Select Tojas.szin " + //kis inputoknak saját lekérdezést kell irni hogy feltöltödjön a kiválasztható adatokból.
                    "FROM Tojas;", c).ExecuteReader();

                while (r.Read())
                {
                    CBTojas.Items.Add(r[0]);
                }
                r.Close();

                r = new SqlCommand("Select Nyul.Nev " + //kis inputoknak saját lekérdezést kell irni hogy feltöltödjön a kiválasztható adatokból.
                    "FROM Nyul;", c).ExecuteReader();

                while (r.Read())
                {
                    CBMunkas.Items.Add(r[0]);
                }

                r.Close();
            }




        }

        private void btn_ujbejegy_Click(object sender, EventArgs e)
        {

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string ErrorMsg = ""; //erros message

                string Tojszin =CBTojas.Text;
                string Munkasnev = CBMunkas.Text;

                string datum = DTP.Value.ToString("yyyy-MM-dd"); 
                string tojasszine = CBTojas.SelectedIndex + 1+"";
                string Munkasneve= CBMunkas.SelectedIndex +1+"";
                string Menny = $"{NMD.Value}";
                //ez a 4 érték lesz rögzitve az adatbázisban a gomb megnyomása után

                try //egy hibakezelés
                {
                    if (string.IsNullOrWhiteSpace(Tojszin))
                    {
                        ErrorMsg += "Nem maradhat üresen a tojás színe! \n"; //ne lehessen tojásszin nélkül bármit is hozzáadni
                    }
                    if (int.Parse(Menny)<=0)
                    {
                        ErrorMsg += "Nem lehet 0 vagy kisebb szám a mennyiség! \n"; // ne lehessen a darabszám 0 vagy kevesebb.
                    }
                    if (string.IsNullOrWhiteSpace(Munkasnev))
                    {
                        ErrorMsg += "Nem maradhat üresen a Munkás neve! \n"; // ne lehessen név nélkül bármit is hozzáadni
                    }
                    if (!string.IsNullOrEmpty(ErrorMsg))
                    {
                        throw new Exception(ErrorMsg);
                    }


                    new SqlCommand($"INSERT INTO Termeles VALUES ('{datum}', {tojasszine}, {Munkasneve}, {Menny});", c).ExecuteNonQuery();
                    FillDGV();
                    MessageBox.Show("Sikeres feltöltés!"); // inzertálás az adatbázisba
                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message); //bármiféle hibakezelésen kivül esett hiba kiirása.
                }
                

                
                


            }






        }
    }
}
