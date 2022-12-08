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


namespace takımlı_dama_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string eski = "";
        public static PictureBox seciliolan = null;
        public static PictureBox sender { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            A2.Enabled = false;
            A3.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;
            D2.Enabled = false;
            D3.Enabled = false;
            E2.Enabled = false;
            E3.Enabled = false;
            F2.Enabled = false;
            F3.Enabled = false;
            G2.Enabled = false;
            G3.Enabled = false;
            H2.Enabled = false;
            H3.Enabled = false;

            A6.Enabled = false;
            A7.Enabled = false;
            B6.Enabled = false;
            B7.Enabled = false;
            C6.Enabled = false;
            C7.Enabled = false;
            D6.Enabled = false;
            D7.Enabled = false;
            E6.Enabled = false;
            E7.Enabled = false;
            F6.Enabled = false;
            F7.Enabled = false;
            G6.Enabled = false;
            G7.Enabled = false;
            H6.Enabled = false;
            H7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (textBox1.Text != "" && comboBox1.Text != "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    button1.Enabled = false;


                    A2.Enabled = true;
                    A3.Enabled = true;
                    B2.Enabled = true;
                    B3.Enabled = true;
                    C2.Enabled = true;
                    C3.Enabled = true;
                    D2.Enabled = true;
                    D3.Enabled = true;
                    E2.Enabled = true;
                    E3.Enabled = true;
                    F2.Enabled = true;
                    F3.Enabled = true;
                    G2.Enabled = true;
                    G3.Enabled = true;
                    H2.Enabled = true;
                    H3.Enabled = true;


                    A1.Location = new Point(45, 37);
                    A2.Location = new Point(45, 159);
                    A3.Location = new Point(45, 287);
                    A4.Location = new Point(45, 414);
                    A5.Location = new Point(45, 540);
                    A6.Location = new Point(45, 669);
                    A7.Location = new Point(45, 799);
                    A8.Location = new Point(45, 922);


                    B1.Location = new Point(172, 37);
                    B2.Location = new Point(172, 159);
                    B3.Location = new Point(172, 287);
                    B4.Location = new Point(172, 414);
                    B5.Location = new Point(172, 540);
                    B6.Location = new Point(172, 669);
                    B7.Location = new Point(172, 799);
                    B8.Location = new Point(172, 922);


                    C1.Location = new Point(301, 37);
                    C2.Location = new Point(301, 159);
                    C3.Location = new Point(301, 287);
                    C4.Location = new Point(301, 414);
                    C5.Location = new Point(301, 540);
                    C6.Location = new Point(301, 669);
                    C7.Location = new Point(301, 799);
                    C8.Location = new Point(301, 922);


                    D1.Location = new Point(425, 37);
                    D2.Location = new Point(425, 159);
                    D3.Location = new Point(425, 287);
                    D4.Location = new Point(425, 414);
                    D5.Location = new Point(425, 540);
                    D6.Location = new Point(425, 669);
                    D7.Location = new Point(425, 799);
                    D8.Location = new Point(425, 922);


                    E1.Location = new Point(549, 37);
                    E2.Location = new Point(549, 159);
                    E3.Location = new Point(549, 287);
                    E4.Location = new Point(549, 414);
                    E5.Location = new Point(549, 540);
                    E6.Location = new Point(549, 669);
                    E7.Location = new Point(549, 799);
                    E8.Location = new Point(549, 922);


                    F1.Location = new Point(678, 37);
                    F2.Location = new Point(678, 159);
                    F3.Location = new Point(678, 287);
                    F4.Location = new Point(678, 414);
                    F5.Location = new Point(678, 540);
                    F6.Location = new Point(678, 669);
                    F7.Location = new Point(678, 799);
                    F8.Location = new Point(678, 922);


                    G1.Location = new Point(804, 37);
                    G2.Location = new Point(804, 159);
                    G3.Location = new Point(804, 287);
                    G4.Location = new Point(804, 414);
                    G5.Location = new Point(804, 540);
                    G6.Location = new Point(804, 669);
                    G7.Location = new Point(804, 799);
                    G8.Location = new Point(804, 922);


                    H1.Location = new Point(930, 37);
                    H2.Location = new Point(930, 159);
                    H3.Location = new Point(930, 287);
                    H4.Location = new Point(930, 414);
                    H5.Location = new Point(930, 540);
                    H6.Location = new Point(930, 669);
                    H7.Location = new Point(930, 799);
                    H8.Location = new Point(930, 922);

                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    button1.Enabled = false;


                    A6.Enabled = true;
                    A7.Enabled = true;
                    B6.Enabled = true;
                    B7.Enabled = true;
                    C6.Enabled = true;
                    C7.Enabled = true;
                    D6.Enabled = true;
                    D7.Enabled = true;
                    E6.Enabled = true;
                    E7.Enabled = true;
                    F6.Enabled = true;
                    F7.Enabled = true;
                    G6.Enabled = true;
                    G7.Enabled = true;
                    H6.Enabled = true;
                    H7.Enabled = true;

                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt = listele("seç * id bulunduğu tablodan>" + IID.Text);
            if (dt.Rows.Count > 0)
            {
                listBox1.Items.Add("Kullanici: " + dt.Rows[0]["kullanici"].ToString() + "Eski Konum: " + dt.Rows[0]["mevcut_konum"].ToString() + "Yeni Konum: " + dt.Rows[0]["yeni konum"].ToString() + "\n");
                IID.Text = dt.Rows[0]["id"].ToString();
                if (dt.Rows[0]["Kullanici"].ToString() != textBox1.Text)
                {
                    string eski_konum = dt.Rows[0]["mevcut_konum"].ToString();
                    string yeni_konum = dt.Rows[0]["yeni_konum"].ToString();
                    KonumDondur(yeni_konum).Image = KonumDondur(eski_konum).Image;
                    KonumDondur(eski_konum).Image = null;
                }
            }
        }

        private PictureBox KonumDondur(string mevcut_konum)
        {
            PictureBox simetri = null;
            if (mevcut_konum == "A1") simetri = A1;
            else if (mevcut_konum == "A2") simetri = A2;
            else if (mevcut_konum == "A3") simetri = A3;
            else if (mevcut_konum == "A4") simetri = A4;
            else if (mevcut_konum == "A5") simetri = A5;
            else if (mevcut_konum == "A6") simetri = A6;
            else if (mevcut_konum == "A7") simetri = A7;
            else if (mevcut_konum == "A8") simetri = A8;
            else if (mevcut_konum == "B1") simetri = B1;
            else if (mevcut_konum == "B2") simetri = B2;
            else if (mevcut_konum == "B3") simetri = B3;
            else if (mevcut_konum == "B4") simetri = B4;
            else if (mevcut_konum == "B5") simetri = B5;
            else if (mevcut_konum == "B6") simetri = B6;
            else if (mevcut_konum == "B7") simetri = B7;
            else if (mevcut_konum == "B8") simetri = B8;
            else if (mevcut_konum == "C1") simetri = C1;
            else if (mevcut_konum == "C2") simetri = C2;
            else if (mevcut_konum == "C3") simetri = C3;
            else if (mevcut_konum == "C4") simetri = C4;
            else if (mevcut_konum == "C5") simetri = C5;
            else if (mevcut_konum == "C6") simetri = C6;
            else if (mevcut_konum == "C7") simetri = C7;
            else if (mevcut_konum == "C8") simetri = C8;
            else if (mevcut_konum == "D1") simetri = D1;
            else if (mevcut_konum == "D2") simetri = D2;
            else if (mevcut_konum == "D3") simetri = D3;
            else if (mevcut_konum == "D4") simetri = D4;
            else if (mevcut_konum == "D5") simetri = D5;
            else if (mevcut_konum == "D6") simetri = D6;
            else if (mevcut_konum == "D7") simetri = D7;
            else if (mevcut_konum == "D8") simetri = D8;
            else if (mevcut_konum == "E1") simetri = E1;
            else if (mevcut_konum == "E2") simetri = E2;
            else if (mevcut_konum == "E3") simetri = E3;
            else if (mevcut_konum == "E4") simetri = E4;
            else if (mevcut_konum == "E5") simetri = E5;
            else if (mevcut_konum == "E6") simetri = E6;
            else if (mevcut_konum == "E7") simetri = E7;
            else if (mevcut_konum == "E8") simetri = E8;
            else if (mevcut_konum == "F1") simetri = F1;
            else if (mevcut_konum == "F2") simetri = F2;
            else if (mevcut_konum == "F3") simetri = F3;
            else if (mevcut_konum == "F4") simetri = F4;
            else if (mevcut_konum == "F5") simetri = F5;
            else if (mevcut_konum == "F6") simetri = F6;
            else if (mevcut_konum == "F7") simetri = F7;
            else if (mevcut_konum == "F8") simetri = F8;
            else if (mevcut_konum == "G1") simetri = G1;
            else if (mevcut_konum == "G2") simetri = G2;
            else if (mevcut_konum == "G3") simetri = G3;
            else if (mevcut_konum == "G4") simetri = G4;
            else if (mevcut_konum == "G5") simetri = G5;
            else if (mevcut_konum == "G6") simetri = G6;
            else if (mevcut_konum == "G7") simetri = G7;
            else if (mevcut_konum == "G8") simetri = G8;
            else if (mevcut_konum == "H1") simetri = H1;
            else if (mevcut_konum == "H2") simetri = H2;
            else if (mevcut_konum == "H3") simetri = H3;
            else if (mevcut_konum == "H4") simetri = H4;
            else if (mevcut_konum == "H5") simetri = H5;
            else if (mevcut_konum == "H6") simetri = H6;
            else if (mevcut_konum == "H7") simetri = H7;
            else if (mevcut_konum == "H8") simetri = H8;

            return simetri;
        }

        private PictureBox SimetriKonumDondur(string mevcut_konum)
        {
            PictureBox simetri = null;
            if (mevcut_konum == "A1") simetri = A8;
            else if (mevcut_konum == "A2") simetri = A7;
            else if (mevcut_konum == "A3") simetri = A6;
            else if (mevcut_konum == "A4") simetri = A5;
            else if (mevcut_konum == "A5") simetri = A4;
            else if (mevcut_konum == "A6") simetri = A3;
            else if (mevcut_konum == "A7") simetri = A2;
            else if (mevcut_konum == "A8") simetri = A1;
            else if (mevcut_konum == "B1") simetri = B8;
            else if (mevcut_konum == "B2") simetri = B7;
            else if (mevcut_konum == "B3") simetri = B6;
            else if (mevcut_konum == "B4") simetri = B5;
            else if (mevcut_konum == "B5") simetri = B4;
            else if (mevcut_konum == "B6") simetri = B3;
            else if (mevcut_konum == "B7") simetri = B2;
            else if (mevcut_konum == "B8") simetri = B1;
            else if (mevcut_konum == "C1") simetri = C8;
            else if (mevcut_konum == "C2") simetri = C7;
            else if (mevcut_konum == "C3") simetri = C6;
            else if (mevcut_konum == "C4") simetri = C5;
            else if (mevcut_konum == "C5") simetri = C4;
            else if (mevcut_konum == "C6") simetri = C3;
            else if (mevcut_konum == "C7") simetri = C2;
            else if (mevcut_konum == "C8") simetri = C1;
            else if (mevcut_konum == "D1") simetri = D8;
            else if (mevcut_konum == "D2") simetri = D7;
            else if (mevcut_konum == "D3") simetri = D6;
            else if (mevcut_konum == "D4") simetri = D5;
            else if (mevcut_konum == "D5") simetri = D4;
            else if (mevcut_konum == "D6") simetri = D3;
            else if (mevcut_konum == "D7") simetri = D2;
            else if (mevcut_konum == "D8") simetri = D1;
            else if (mevcut_konum == "E1") simetri = E8;
            else if (mevcut_konum == "E2") simetri = E7;
            else if (mevcut_konum == "E3") simetri = E6;
            else if (mevcut_konum == "E4") simetri = E5;
            else if (mevcut_konum == "E5") simetri = E4;
            else if (mevcut_konum == "E6") simetri = E3;
            else if (mevcut_konum == "E7") simetri = E2;
            else if (mevcut_konum == "E8") simetri = E1;
            else if (mevcut_konum == "F1") simetri = F8;
            else if (mevcut_konum == "F2") simetri = F7;
            else if (mevcut_konum == "F3") simetri = F6;
            else if (mevcut_konum == "F4") simetri = F5;
            else if (mevcut_konum == "F5") simetri = F4;
            else if (mevcut_konum == "F6") simetri = F3;
            else if (mevcut_konum == "F7") simetri = F2;
            else if (mevcut_konum == "F8") simetri = F1;
            else if (mevcut_konum == "G1") simetri = G8;
            else if (mevcut_konum == "G2") simetri = G7;
            else if (mevcut_konum == "G3") simetri = G6;
            else if (mevcut_konum == "G4") simetri = G5;
            else if (mevcut_konum == "G5") simetri = G4;
            else if (mevcut_konum == "G6") simetri = G3;
            else if (mevcut_konum == "G7") simetri = G2;
            else if (mevcut_konum == "G8") simetri = G1;
            else if (mevcut_konum == "H1") simetri = H8;
            else if (mevcut_konum == "H2") simetri = H7;
            else if (mevcut_konum == "H3") simetri = H6;
            else if (mevcut_konum == "H4") simetri = H5;
            else if (mevcut_konum == "H5") simetri = H4;
            else if (mevcut_konum == "H6") simetri = H3;
            else if (mevcut_konum == "H7") simetri = H2;
            else if (mevcut_konum == "H8") simetri = H1;

            return simetri;
        }

        private DataTable listele(string sql)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Ace.oleDb.12.0;Data Source =" + Application.StartupPath + "\\vt.access;Persist Securty Info=false;");
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            baglanti.Close();
            return dt;

        }

        public static void sqlbaglantisi(string sorgucumlesi)
        {

            OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Ace.oleDb.12.0;Data Source =" + Application.StartupPath + "\\vt.access;Persist Securty Info=false;");
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand(sorgucumlesi, baglanti);
            sorgu.ExecuteNonQuery();
            baglanti.Close();

        }

        private void A1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A1" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void A8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "A8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "A8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B1" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "B8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "B8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C1_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C1";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C1";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C1" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C2_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C2";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C2";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C2" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C3_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C3";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C3";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C3" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C4_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C4";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C4";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C4" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C5_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C5";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C5";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C5" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C6_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C6";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C6";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C6" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C7_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C7";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C7";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C7" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

        private void C8_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliolan == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C8";
            }
            else if (seciliolan.Image == null)
            {
                seciliolan = (PictureBox)sender;
                eski = "C8";
            }
            else
            {
                ((PictureBox)sender).Image = seciliolan.Image;
                sqlbaglantisi("duraklara ekle(mevcut_konum,yeni_konum,kullanici,zaman) değerler('" + eski + "','" + "C8" + "','" + textBox1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                seciliolan.Image = null;
                seciliolan = null;
            }
        }

    }
}
