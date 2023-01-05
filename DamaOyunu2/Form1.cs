using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Linq;
<<<<<<< HEAD
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

namespace DamaOyunu2
{


    
=======


namespace DamaOyunu2
{
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string eski = "";
        public static  PictureBox seciliOlan = null;
        private static string Simetri;
        private DataTable dt;
<<<<<<< HEAD
       



        public static PictureBox sender { get; set; }

        //Taþlarýn Hareket Etmemesi

        private void Form1_Load(object sender, EventArgs e)
        {
            if (seciliOlan==null)
            {
                A2.Enabled = false;
                B2.Enabled = false;
                C2.Enabled = false;
                D2.Enabled = false;
                E2.Enabled = false;
                F2.Enabled = false;
                G2.Enabled = false;
                H2.Enabled = false;


                A3.Enabled = false;
                B3.Enabled = false;
                C3.Enabled = false;
                D3.Enabled = false;
                E3.Enabled = false;
                F3.Enabled = false;
                G3.Enabled = false;
                H3.Enabled = false;

                A6.Enabled = false;
                B6.Enabled = false;
                C6.Enabled = false;
                D6.Enabled = false;
                E6.Enabled = false;
                F6.Enabled = false;
                G6.Enabled = false;
                H6.Enabled = false;

                A7.Enabled = false;
                B7.Enabled = false;
                C7.Enabled = false;
                D7.Enabled = false;
                E7.Enabled = false;
                F7.Enabled = false;
                G7.Enabled = false;
                H7.Enabled = false;
                
            }
            else 
           
                A2.Enabled = true;
                B2.Enabled = true;
                C2.Enabled = true;
                D2.Enabled = true;
                E2.Enabled = true;
                F2.Enabled = true;
                G2.Enabled = true;
                H2.Enabled = true;
                             
                A3.Enabled = true;
                B3.Enabled = true;
                C3.Enabled = true;
                D3.Enabled = true;
                E3.Enabled = true;
                F3.Enabled = true;
                G3.Enabled = true;
                H3.Enabled = true;
                            
                A6.Enabled = true;
                B6.Enabled = true;
                C6.Enabled = true;
                D6.Enabled = true;
                E6.Enabled = true;
                F6.Enabled = true;
                G6.Enabled = true;
                H6.Enabled = true;
                             
                A7.Enabled = true;
                B7.Enabled = true;
                C7.Enabled = true;
                D7.Enabled = true;
                E7.Enabled = true;
                F7.Enabled = true;
                G7.Enabled = true;
                H7.Enabled = true;
          





        }

       //Seçilen takýma göre taþlarýn hareket etmesi
=======

        public static PictureBox sender { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            A2.Enabled = false;
            B2.Enabled = false;
            C2.Enabled = false;
            D2.Enabled = false;
            E2.Enabled = false;
            F2.Enabled = false;
            G2.Enabled = false;
            H2.Enabled = false;


            A3.Enabled = false;
            B3.Enabled = false;
            C3.Enabled = false;
            D3.Enabled = false;
            E3.Enabled = false;
            F3.Enabled = false;
            G3.Enabled = false;
            H3.Enabled = false;

            A6.Enabled = false;
            B6.Enabled = false;
            C6.Enabled = false;
            D6.Enabled = false;
            E6.Enabled = false;
            F6.Enabled = false;
            G6.Enabled = false;
            H6.Enabled = false;

            A7.Enabled = false;
            B7.Enabled = false;
            C7.Enabled = false;
            D7.Enabled = false;
            E7.Enabled = false;
            F7.Enabled = false;
            G7.Enabled = false;
            H7.Enabled = false;


        }
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if(textBox1.Text !="" && comboBox1.Text !="")
            {

                if (comboBox1.SelectedIndex == 0)
                {
<<<<<<< HEAD
                   
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    button1.Enabled = false;


                    A2.Enabled = true;
                    B2.Enabled = true;
                    C2.Enabled = true;
                    D2.Enabled = true;
                    E2.Enabled = true;
                    F2.Enabled = true;
                    G2.Enabled = true;
                    H2.Enabled = true;

                    A3.Enabled = true;
                    B3.Enabled = true;
                    C3.Enabled = true;
                    D3.Enabled = true;
                    E3.Enabled = true;
                    F3.Enabled = true;
                    G3.Enabled = true;
                    H3.Enabled = true;

<<<<<<< HEAD
                   




                }
               // else if(seciliOlan.Image==null)
                  //  {
                  //  A3.Location=new Point(A3.Location.X+78, A3.Location.Y+62);

                 //   }
                
                else if   (comboBox1.SelectedIndex == 1)
=======

                    A1.Location = new Point(3, 437);
                    A2.Location = new Point(3, 374);
                    A3.Location = new Point(3, 312);
                    A4.Location = new Point(3, 250);
                    A5.Location = new Point(3, 187);
                    A6.Location = new Point(3, 125);
                    A7.Location = new Point(3, 63);
                    A8.Location = new Point(3, 1);

                    B1.Location = new Point(81, 437);
                    B2.Location = new Point(81, 374);
                    B3.Location = new Point(81, 312);
                    B4.Location = new Point(81, 250);
                    B5.Location = new Point(81, 187);
                    B6.Location = new Point(81, 125);
                    B7.Location = new Point(81, 63);
                    B8.Location = new Point(81, 1);

                    C1.Location = new Point(159, 437);
                    C2.Location = new Point(159, 374);
                    C3.Location = new Point(159, 312);
                    C4.Location = new Point(159, 250);
                    C5.Location = new Point(159, 187);
                    C6.Location = new Point(159, 125);
                    C7.Location = new Point(159, 63);
                    C8.Location = new Point(159, 1);

                    D1.Location = new Point(237, 437);
                    D2.Location = new Point(237, 374);
                    D3.Location = new Point(237, 312);
                    D4.Location = new Point(237, 250);
                    D5.Location = new Point(237, 187);
                    D6.Location = new Point(237, 125);
                    D7.Location = new Point(237, 63);
                    D8.Location = new Point(237, 1);

                    E1.Location = new Point(315, 437);
                    E2.Location = new Point(315, 374);
                    E3.Location = new Point(315, 312);
                    E4.Location = new Point(315, 250);
                    E5.Location = new Point(315, 187);
                    E6.Location = new Point(315, 125);
                    E7.Location = new Point(315, 63);
                    E8.Location = new Point(315, 1);

                    F1.Location = new Point(393, 437);
                    F2.Location = new Point(393, 374);
                    F3.Location = new Point(393, 312);
                    F4.Location = new Point(393, 250);
                    F5.Location = new Point(393, 187);
                    F6.Location = new Point(393, 125);
                    F7.Location = new Point(393, 63);
                    F8.Location = new Point(393, 1);

                    G1.Location = new Point(471, 437);
                    G2.Location = new Point(471, 374);
                    G3.Location = new Point(471, 312);
                    G4.Location = new Point(471, 250);
                    G5.Location = new Point(471, 187);
                    G6.Location = new Point(471, 125);
                    G7.Location = new Point(471, 63);
                    G8.Location = new Point(471, 1);

                    H1.Location = new Point(549, 437);
                    H2.Location = new Point(549, 374);
                    H3.Location = new Point(549, 312);
                    H4.Location = new Point(549, 250);
                    H5.Location = new Point(549, 187);
                    H6.Location = new Point(549, 125);
                    H7.Location = new Point(549, 63);
                    H8.Location = new Point(549, 1);
                }
                else if (comboBox1.SelectedIndex == 1)
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
                {
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    button1.Enabled = false;

<<<<<<< HEAD
                    A2.Enabled = false;
                    B2.Enabled = false;
                    C2.Enabled = false;
                    D2.Enabled = false;
                    E2.Enabled = false;
                    F2.Enabled = false;
                    G2.Enabled = false;
                    H2.Enabled = false;


                    A3.Enabled = false;
                    B3.Enabled = false;
                    C3.Enabled = false;
                    D3.Enabled = false;
                    E3.Enabled = false;
                    F3.Enabled = false;
                    G3.Enabled = false;
                    H3.Enabled = false;
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17

                    A6.Enabled = true;
                    B6.Enabled = true;
                    C6.Enabled = true;
                    D6.Enabled = true;
                    E6.Enabled = true;
                    F6.Enabled = true;
                    G6.Enabled = true;
                    H6.Enabled = true;

                    A7.Enabled = true;
                    B7.Enabled = true;
                    C7.Enabled = true;
                    D7.Enabled = true;
                    E7.Enabled = true;
                    F7.Enabled = true;
                    G7.Enabled = true;
                    H7.Enabled = true;

                
                }
            }

        }
<<<<<<< HEAD
      // Taþlarý hareket ettirdiðimizde yeni konumuna iletip eski konumu boþaltmasý
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = Listele(" select * from ProHamle where id> " + label3.Text);
            if(dt.Rows.Count > 0)
            {
                listBox1.Items.Add("kullanici:" + dt.Rows[0]["kullanici"].ToString() + "eski konum:" + dt.Rows[0]["mevcut_konum"].ToString() + "Yeni konum" + dt.Rows[0]["yeni_konum"].ToString() + " /n");
                    label3.Text = dt.Rows[0]["id"].ToString();
                if (dt.Rows[0]["kullanici"].ToString() != textBox1.Text)
                {
                    
                    string eski_konum = dt.Rows[0]["mevcut_konum"].ToString();
                    string yeni_konum = dt.Rows[0]["yeni_konum"].ToString();

                    KonumDondur(yeni_konum).Image = KonumDondur(eski_konum).Image;
                    KonumDondur(eski_konum).Image = null;
                }

            }
        }
<<<<<<< HEAD
        //seçilen takýma göre yeniden konum isimlendirme
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private  PictureBox KonumDondur(string mevcut_konum)
        {

             PictureBox Simetri = null;
            if (mevcut_konum == "A1") Simetri = A1;
            else if (mevcut_konum == "A2") Simetri = A2;
            else if (mevcut_konum == "A3") Simetri = A3;
            else if (mevcut_konum == "A4") Simetri = A4;
            else if (mevcut_konum == "A5") Simetri = A5;
            else if (mevcut_konum == "A6") Simetri = A6;
            else if (mevcut_konum == "A7") Simetri = A7;
            else if (mevcut_konum == "A8") Simetri = A8;
            else if (mevcut_konum == "B1") Simetri = B1;
            else if (mevcut_konum == "B2") Simetri = B2;
            else if (mevcut_konum == "B3") Simetri = B3;
            else if (mevcut_konum == "B4") Simetri = B4;
            else if (mevcut_konum == "B5") Simetri = B5;
            else if (mevcut_konum == "B6") Simetri = B6;
            else if (mevcut_konum == "B7") Simetri = B7;
            else if (mevcut_konum == "B8") Simetri = B8;
            else if (mevcut_konum == "C1") Simetri = C1;
            else if (mevcut_konum == "C2") Simetri = C2;
            else if (mevcut_konum == "C3") Simetri = C3;
            else if (mevcut_konum == "C4") Simetri = C4;
            else if (mevcut_konum == "C5") Simetri = C5;
            else if (mevcut_konum == "C6") Simetri = C6;
            else if (mevcut_konum == "C7") Simetri = C7;
            else if (mevcut_konum == "C8") Simetri = C8;
            else if (mevcut_konum == "D1") Simetri = D1;
            else if (mevcut_konum == "D2") Simetri = D2;
            else if (mevcut_konum == "D3") Simetri = D3;
            else if (mevcut_konum == "D4") Simetri = D4;
            else if (mevcut_konum == "D5") Simetri = D5;
            else if (mevcut_konum == "D6") Simetri = D6;
            else if (mevcut_konum == "D7") Simetri = D7;
            else if (mevcut_konum == "D8") Simetri = D8;
            else if (mevcut_konum == "E1") Simetri = E1;
            else if (mevcut_konum == "E2") Simetri = E2;
            else if (mevcut_konum == "E3") Simetri = E3;
            else if (mevcut_konum == "E4") Simetri = E4;
            else if (mevcut_konum == "E5") Simetri = E5;
            else if (mevcut_konum == "E6") Simetri = E6;
            else if (mevcut_konum == "E7") Simetri = E7;
            else if (mevcut_konum == "E8") Simetri = E8;
            else if (mevcut_konum == "F1") Simetri = F1;
            else if (mevcut_konum == "F2") Simetri = F2;
            else if (mevcut_konum == "F3") Simetri = F3;
            else if (mevcut_konum == "F4") Simetri = F4;
            else if (mevcut_konum == "F5") Simetri = F5;
            else if (mevcut_konum == "F6") Simetri = F6;
            else if (mevcut_konum == "F7") Simetri = F7;
            else if (mevcut_konum == "F8") Simetri = F8;
            else if (mevcut_konum == "G1") Simetri = G1;
            else if (mevcut_konum == "G2") Simetri = G2;
            else if (mevcut_konum == "G3") Simetri = G3;
            else if (mevcut_konum == "G4") Simetri = G4;
            else if (mevcut_konum == "G5") Simetri = G5;
            else if (mevcut_konum == "G6") Simetri = G6;
            else if (mevcut_konum == "G7") Simetri = G7;
            else if (mevcut_konum == "G8") Simetri = G8;
            else if (mevcut_konum == "H1") Simetri = H1;
            else if (mevcut_konum == "H2") Simetri = H2;
            else if (mevcut_konum == "H3") Simetri = H3;
            else if (mevcut_konum == "H4") Simetri = H4;
            else if (mevcut_konum == "H5") Simetri = H5;
            else if (mevcut_konum == "H6") Simetri = H6;
            else if (mevcut_konum == "H7") Simetri = H7;
            else if (mevcut_konum == "H8") Simetri = H8;


            return (PictureBox)Simetri;


        }
<<<<<<< HEAD
        // seçilen takýma göre simetri konum dönderme
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private  PictureBox simetriKonumDondur(string mevcut_konum)
        {
             PictureBox Simetri = null;

            if (mevcut_konum == "A1") Simetri = A8;
            else if (mevcut_konum == "A2") Simetri = A7;
            else if (mevcut_konum == "A3") Simetri = A6;
            else if (mevcut_konum == "A4") Simetri = A5;
            else if (mevcut_konum == "A5") Simetri = A4;
            else if (mevcut_konum == "A6") Simetri = A3;
            else if (mevcut_konum == "A7") Simetri = A2;
            else if (mevcut_konum == "A8") Simetri = A1;
            else if (mevcut_konum == "B1") Simetri = B8;
            else if (mevcut_konum == "B2") Simetri = B7;
            else if (mevcut_konum == "B3") Simetri = B6;
            else if (mevcut_konum == "B4") Simetri = B5;
            else if (mevcut_konum == "B5") Simetri = B4;
            else if (mevcut_konum == "B6") Simetri = B3;
            else if (mevcut_konum == "B7") Simetri = B2;
            else if (mevcut_konum == "B8") Simetri = B1;
            else if (mevcut_konum == "C1") Simetri = C8;
            else if (mevcut_konum == "C2") Simetri = C7;
            else if (mevcut_konum == "C3") Simetri = C6;
            else if (mevcut_konum == "C4") Simetri = C5;
            else if (mevcut_konum == "C5") Simetri = C4;
            else if (mevcut_konum == "C6") Simetri = C3;
            else if (mevcut_konum == "C7") Simetri = C2;
            else if (mevcut_konum == "C8") Simetri = C1;
            else if (mevcut_konum == "D1") Simetri = D8;
            else if (mevcut_konum == "D2") Simetri = D7;
            else if (mevcut_konum == "D3") Simetri = D6;
            else if (mevcut_konum == "D4") Simetri = D5;
            else if (mevcut_konum == "D5") Simetri = D4;
            else if (mevcut_konum == "D6") Simetri = D3;
            else if (mevcut_konum == "D7") Simetri = D2;
            else if (mevcut_konum == "D8") Simetri = D1;
            else if (mevcut_konum == "E1") Simetri = E8;
            else if (mevcut_konum == "E2") Simetri = E7;
            else if (mevcut_konum == "E3") Simetri = E6;
            else if (mevcut_konum == "E4") Simetri = E5;
            else if (mevcut_konum == "E5") Simetri = E4;
            else if (mevcut_konum == "E6") Simetri = E3;
            else if (mevcut_konum == "E7") Simetri = E2;
            else if (mevcut_konum == "E8") Simetri = E1;
            else if (mevcut_konum == "F1") Simetri = F8;
            else if (mevcut_konum == "F2") Simetri = F7;
            else if (mevcut_konum == "F3") Simetri = F6;
            else if (mevcut_konum == "F4") Simetri = F5;
            else if (mevcut_konum == "F5") Simetri = F4;
            else if (mevcut_konum == "F6") Simetri = F3;
            else if (mevcut_konum == "F7") Simetri = F2;
            else if (mevcut_konum == "F8") Simetri = F1;
            else if (mevcut_konum == "G1") Simetri = G8;
            else if (mevcut_konum == "G2") Simetri = G7;
            else if (mevcut_konum == "G3") Simetri = G6;
            else if (mevcut_konum == "G4") Simetri = G5;
            else if (mevcut_konum == "G5") Simetri = G4;
            else if (mevcut_konum == "G6") Simetri = G3;
            else if (mevcut_konum == "G7") Simetri = G2;
            else if (mevcut_konum == "G8") Simetri = G1;
            else if (mevcut_konum == "H1") Simetri = H8;
            else if (mevcut_konum == "H2") Simetri = H7;
            else if (mevcut_konum == "H3") Simetri = H6;
            else if (mevcut_konum == "H4") Simetri = H5;
            else if (mevcut_konum == "H5") Simetri = H4;
            else if (mevcut_konum == "H6") Simetri = H3;
            else if (mevcut_konum == "H7") Simetri = H2;
            else if (mevcut_konum == "H8") Simetri = H1;
            return Simetri;


        }

<<<<<<< HEAD
        // veri tabanýndan ýd, eski konum, yeni konum ve isim çekme
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private DataTable Listele(string sql)
        {
            //OleDbConnection baglanti = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|StaffingSystem_DB.mdb" + );
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DamaP1.accdb;Persist Security Info=false;");
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            baglanti.Close();
            return dt;
        }
<<<<<<< HEAD

=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        public static void sqlbaglantisi(string sorgucumlesi)
        {
            OleDbConnection  baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DamaP1.accdb;Persist Security Info=false;");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand( sorgucumlesi, baglanti);
             sorgu.ExecuteNonQuery();
            baglanti.Close();
             
        }

<<<<<<< HEAD
       // her bir konumun mause ile oynatýrken ki hareket etme ve pictureboxlarýn diðer bloklarý doldurmasý ve bulunduðu bloðu boþaltmasý

        private void A1_MouseDown(object sender, MouseEventArgs e)
        {
          
             if (seciliOlan== null)
=======
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void A1_MouseDown(object sender, MouseEventArgs e)
        {
            if(seciliOlan == null)
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            {
                seciliOlan=  (PictureBox)sender;
                eski = "A1";
            }
            else if(seciliOlan.Image==null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
<<<<<<< HEAD
                

=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A1" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
            seciliOlan.Image= null;
                seciliOlan = null;
            }
        }
        private void A2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
<<<<<<< HEAD
       
        private void A3_MouseDown(object sender, MouseEventArgs e)
        {
          
=======
        private void A3_MouseDown(object sender, MouseEventArgs e)
        {
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A3";
            }
            else if (seciliOlan.Image == null)
            {
<<<<<<< HEAD

                seciliOlan = (PictureBox)sender;

               
                eski = "A3";
            }
          
           
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                
=======
                seciliOlan = (PictureBox)sender;
                eski = "A3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void A4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void A5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void A6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void A7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void A8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "A8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "A8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "B8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "B8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "C8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "C8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void D8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "D8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "D8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E3";
            }
<<<<<<< HEAD
           
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E3";
            }
<<<<<<< HEAD
            
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void E8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "E8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "E8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void F8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "F8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "F8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void G8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "G8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "G8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H1";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H1" + "','" + textBox1.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H2";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H3";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H4";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H5";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H6";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H7";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }
        private void H8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliOlan == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H8";
            }
            else if (seciliOlan.Image == null)
            {
                seciliOlan = (PictureBox)sender;
                eski = "H8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliOlan.Image;
                sqlbaglantisi("insert into ProHamle(mevcut_konum,yeni_konum,kullanici,zaman)values('" + eski + "','" + "H8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliOlan.Image = null;
                seciliOlan = null;
            }
        }

<<<<<<< HEAD
      
        //form kapandýðýnda sql baðlantýsýný sýfýrlýyor
=======
        private void A1_Click(object sender, EventArgs e)
        {

        }

        private void H1_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private void Form1_FormClosed(object sender ,FormClosedEventArgs e)
        {
            sqlbaglantisi("Delete from ProHamle");
        }

<<<<<<< HEAD



















=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void A7_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void A3_Click(object sender, EventArgs e)
        {
           

            }

        private void A3_Move(object sender, EventArgs e)
        { 
      
           
        }

        private void A3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void A3_MouseUp(object sender, MouseEventArgs e)
        {
        }


        private void A1_Click(object sender, EventArgs e)
        {

        }

        private void H1_Click(object sender, EventArgs e)
        {

        }

    }
        }
 
=======
    }
}
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
