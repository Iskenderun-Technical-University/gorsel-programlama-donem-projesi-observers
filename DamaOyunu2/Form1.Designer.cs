namespace DamaOyunu2
{
    partial class Form1
    {
<<<<<<< HEAD
        public class Hareket
        {
            public int startRow;
            public int startCol;
            public int toRow;
            public int toCol;

            public bool IsJump = false;

            public Hareket(int fromRow, int fromCol, int toRow, int toCol)
            {
                startRow = fromRow;
                startCol = fromCol;
                this.toRow = toRow;
                this.toCol = toCol;
            }

            public override string ToString()
            {
                return $"From: [{startRow},{startCol}] To: [{toRow},{toCol}]";
            }

            public override bool Equals(object obj)
            {
                Hareket m = (Hareket)obj;
                return startRow == m.startRow && startCol == m.startCol && toRow == m.toRow && toCol == m.toCol;
            }
        }
=======
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.C1 = new System.Windows.Forms.PictureBox();
            this.D1 = new System.Windows.Forms.PictureBox();
            this.E1 = new System.Windows.Forms.PictureBox();
            this.F1 = new System.Windows.Forms.PictureBox();
            this.G1 = new System.Windows.Forms.PictureBox();
            this.H1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.C2 = new System.Windows.Forms.PictureBox();
            this.D2 = new System.Windows.Forms.PictureBox();
            this.E2 = new System.Windows.Forms.PictureBox();
            this.F2 = new System.Windows.Forms.PictureBox();
            this.G2 = new System.Windows.Forms.PictureBox();
            this.H2 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.B3 = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.PictureBox();
            this.D3 = new System.Windows.Forms.PictureBox();
            this.E3 = new System.Windows.Forms.PictureBox();
            this.F3 = new System.Windows.Forms.PictureBox();
            this.G3 = new System.Windows.Forms.PictureBox();
            this.H3 = new System.Windows.Forms.PictureBox();
            this.A4 = new System.Windows.Forms.PictureBox();
            this.B4 = new System.Windows.Forms.PictureBox();
            this.C4 = new System.Windows.Forms.PictureBox();
            this.D4 = new System.Windows.Forms.PictureBox();
            this.E4 = new System.Windows.Forms.PictureBox();
            this.F4 = new System.Windows.Forms.PictureBox();
            this.G4 = new System.Windows.Forms.PictureBox();
            this.H4 = new System.Windows.Forms.PictureBox();
            this.A5 = new System.Windows.Forms.PictureBox();
            this.B5 = new System.Windows.Forms.PictureBox();
            this.C5 = new System.Windows.Forms.PictureBox();
            this.D5 = new System.Windows.Forms.PictureBox();
            this.E5 = new System.Windows.Forms.PictureBox();
            this.F5 = new System.Windows.Forms.PictureBox();
            this.G5 = new System.Windows.Forms.PictureBox();
            this.H5 = new System.Windows.Forms.PictureBox();
            this.A6 = new System.Windows.Forms.PictureBox();
            this.B6 = new System.Windows.Forms.PictureBox();
            this.C6 = new System.Windows.Forms.PictureBox();
            this.D6 = new System.Windows.Forms.PictureBox();
            this.E6 = new System.Windows.Forms.PictureBox();
            this.F6 = new System.Windows.Forms.PictureBox();
            this.G6 = new System.Windows.Forms.PictureBox();
            this.H6 = new System.Windows.Forms.PictureBox();
            this.A7 = new System.Windows.Forms.PictureBox();
            this.B7 = new System.Windows.Forms.PictureBox();
            this.C7 = new System.Windows.Forms.PictureBox();
            this.D7 = new System.Windows.Forms.PictureBox();
            this.E7 = new System.Windows.Forms.PictureBox();
            this.F7 = new System.Windows.Forms.PictureBox();
            this.G7 = new System.Windows.Forms.PictureBox();
            this.H7 = new System.Windows.Forms.PictureBox();
            this.A8 = new System.Windows.Forms.PictureBox();
            this.B8 = new System.Windows.Forms.PictureBox();
            this.C8 = new System.Windows.Forms.PictureBox();
            this.D8 = new System.Windows.Forms.PictureBox();
            this.E8 = new System.Windows.Forms.PictureBox();
            this.F8 = new System.Windows.Forms.PictureBox();
            this.G8 = new System.Windows.Forms.PictureBox();
            this.H8 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(626, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 498);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 319);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana Demir Spor",
<<<<<<< HEAD
            "İste Arma"});
=======
            "Fenerbahçe"});
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.comboBox1.Location = new System.Drawing.Point(110, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takım Seçiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınızı Giriniz:";
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.Location = new System.Drawing.Point(4, 1);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(78, 63);
            this.A1.TabIndex = 7;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            this.A1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A1_MouseDown);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Location = new System.Drawing.Point(81, 1);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(78, 63);
            this.B1.TabIndex = 8;
            this.B1.TabStop = false;
            this.B1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B1_MouseDown);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Transparent;
            this.C1.Location = new System.Drawing.Point(159, 1);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(78, 63);
            this.C1.TabIndex = 9;
            this.C1.TabStop = false;
            this.C1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C1_MouseDown);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.Transparent;
            this.D1.Location = new System.Drawing.Point(237, 1);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(78, 63);
            this.D1.TabIndex = 10;
            this.D1.TabStop = false;
            this.D1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D1_MouseDown);
            // 
            // E1
            // 
            this.E1.BackColor = System.Drawing.Color.Transparent;
            this.E1.Location = new System.Drawing.Point(315, 1);
            this.E1.Name = "E1";
            this.E1.Size = new System.Drawing.Size(78, 63);
            this.E1.TabIndex = 11;
            this.E1.TabStop = false;
            this.E1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E1_MouseDown);
            // 
            // F1
            // 
            this.F1.BackColor = System.Drawing.Color.Transparent;
            this.F1.Location = new System.Drawing.Point(393, 1);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(78, 63);
            this.F1.TabIndex = 12;
            this.F1.TabStop = false;
            this.F1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F1_MouseDown);
            // 
            // G1
            // 
            this.G1.BackColor = System.Drawing.Color.Transparent;
            this.G1.Location = new System.Drawing.Point(471, 1);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(78, 63);
            this.G1.TabIndex = 13;
            this.G1.TabStop = false;
<<<<<<< HEAD
=======
            this.G1.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G1_MouseDown);
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.Transparent;
            this.H1.Location = new System.Drawing.Point(549, 1);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(78, 63);
            this.H1.TabIndex = 14;
            this.H1.TabStop = false;
            this.H1.Click += new System.EventHandler(this.H1_Click);
            this.H1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H1_MouseDown);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
            this.A2.Location = new System.Drawing.Point(4, 63);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(78, 63);
            this.A2.TabIndex = 7;
            this.A2.TabStop = false;
            this.A2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A2_MouseDown);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.Image = ((System.Drawing.Image)(resources.GetObject("B2.Image")));
            this.B2.Location = new System.Drawing.Point(81, 63);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(78, 63);
            this.B2.TabIndex = 8;
            this.B2.TabStop = false;
            this.B2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B2_MouseDown);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Transparent;
            this.C2.Image = ((System.Drawing.Image)(resources.GetObject("C2.Image")));
            this.C2.Location = new System.Drawing.Point(159, 63);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(78, 63);
            this.C2.TabIndex = 9;
            this.C2.TabStop = false;
            this.C2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C2_MouseDown);
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.Transparent;
            this.D2.Image = ((System.Drawing.Image)(resources.GetObject("D2.Image")));
            this.D2.Location = new System.Drawing.Point(237, 63);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(78, 63);
            this.D2.TabIndex = 10;
            this.D2.TabStop = false;
            this.D2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D2_MouseDown);
            // 
            // E2
            // 
            this.E2.BackColor = System.Drawing.Color.Transparent;
            this.E2.Image = ((System.Drawing.Image)(resources.GetObject("E2.Image")));
            this.E2.Location = new System.Drawing.Point(315, 63);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(78, 63);
            this.E2.TabIndex = 11;
            this.E2.TabStop = false;
            this.E2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E2_MouseDown);
            // 
            // F2
            // 
            this.F2.BackColor = System.Drawing.Color.Transparent;
            this.F2.Image = ((System.Drawing.Image)(resources.GetObject("F2.Image")));
            this.F2.Location = new System.Drawing.Point(393, 63);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(78, 63);
            this.F2.TabIndex = 12;
            this.F2.TabStop = false;
            this.F2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F2_MouseDown);
            // 
            // G2
            // 
            this.G2.BackColor = System.Drawing.Color.Transparent;
            this.G2.Image = ((System.Drawing.Image)(resources.GetObject("G2.Image")));
            this.G2.Location = new System.Drawing.Point(471, 63);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(78, 63);
            this.G2.TabIndex = 13;
            this.G2.TabStop = false;
<<<<<<< HEAD
=======
            this.G2.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G2_MouseDown);
            // 
            // H2
            // 
            this.H2.BackColor = System.Drawing.Color.Transparent;
            this.H2.Image = ((System.Drawing.Image)(resources.GetObject("H2.Image")));
            this.H2.Location = new System.Drawing.Point(549, 63);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(78, 63);
            this.H2.TabIndex = 14;
            this.H2.TabStop = false;
            this.H2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H2_MouseDown);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
            this.A3.Location = new System.Drawing.Point(3, 125);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(78, 63);
            this.A3.TabIndex = 7;
            this.A3.TabStop = false;
<<<<<<< HEAD
            this.A3.Click += new System.EventHandler(this.A3_Click);
            this.A3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A3_MouseDown);
            this.A3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.A3_MouseMove);
            this.A3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.A3_MouseUp);
            this.A3.Move += new System.EventHandler(this.A3_Move);
=======
            this.A3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A3_MouseDown);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.Image = ((System.Drawing.Image)(resources.GetObject("B3.Image")));
            this.B3.Location = new System.Drawing.Point(81, 125);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(78, 63);
            this.B3.TabIndex = 8;
            this.B3.TabStop = false;
            this.B3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B3_MouseDown);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Transparent;
            this.C3.Image = ((System.Drawing.Image)(resources.GetObject("C3.Image")));
            this.C3.Location = new System.Drawing.Point(159, 125);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(78, 63);
            this.C3.TabIndex = 9;
            this.C3.TabStop = false;
            this.C3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C3_MouseDown);
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.Transparent;
            this.D3.Image = ((System.Drawing.Image)(resources.GetObject("D3.Image")));
            this.D3.Location = new System.Drawing.Point(237, 125);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(78, 63);
            this.D3.TabIndex = 10;
            this.D3.TabStop = false;
            this.D3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D3_MouseDown);
            // 
            // E3
            // 
            this.E3.BackColor = System.Drawing.Color.Transparent;
            this.E3.Image = ((System.Drawing.Image)(resources.GetObject("E3.Image")));
            this.E3.Location = new System.Drawing.Point(315, 125);
            this.E3.Name = "E3";
            this.E3.Size = new System.Drawing.Size(78, 63);
            this.E3.TabIndex = 11;
            this.E3.TabStop = false;
            this.E3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E3_MouseDown);
            // 
            // F3
            // 
            this.F3.BackColor = System.Drawing.Color.Transparent;
            this.F3.Image = ((System.Drawing.Image)(resources.GetObject("F3.Image")));
            this.F3.Location = new System.Drawing.Point(393, 125);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(78, 63);
            this.F3.TabIndex = 12;
            this.F3.TabStop = false;
            this.F3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F3_MouseDown);
            // 
            // G3
            // 
            this.G3.BackColor = System.Drawing.Color.Transparent;
            this.G3.Image = ((System.Drawing.Image)(resources.GetObject("G3.Image")));
            this.G3.Location = new System.Drawing.Point(471, 125);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(78, 63);
            this.G3.TabIndex = 13;
            this.G3.TabStop = false;
<<<<<<< HEAD
=======
            this.G3.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G3_MouseDown);
            // 
            // H3
            // 
            this.H3.BackColor = System.Drawing.Color.Transparent;
            this.H3.Image = ((System.Drawing.Image)(resources.GetObject("H3.Image")));
            this.H3.Location = new System.Drawing.Point(549, 125);
            this.H3.Name = "H3";
            this.H3.Size = new System.Drawing.Size(78, 63);
            this.H3.TabIndex = 14;
            this.H3.TabStop = false;
            this.H3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H3_MouseDown);
            // 
            // A4
            // 
            this.A4.BackColor = System.Drawing.Color.Transparent;
            this.A4.Location = new System.Drawing.Point(3, 187);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(78, 63);
            this.A4.TabIndex = 7;
            this.A4.TabStop = false;
            this.A4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A4_MouseDown);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.Transparent;
            this.B4.Location = new System.Drawing.Point(81, 187);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(78, 63);
            this.B4.TabIndex = 8;
            this.B4.TabStop = false;
            this.B4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B4_MouseDown);
            // 
            // C4
            // 
            this.C4.BackColor = System.Drawing.Color.Transparent;
            this.C4.Location = new System.Drawing.Point(159, 187);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(78, 63);
            this.C4.TabIndex = 9;
            this.C4.TabStop = false;
            this.C4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C4_MouseDown);
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.Transparent;
            this.D4.Location = new System.Drawing.Point(237, 187);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(78, 63);
            this.D4.TabIndex = 10;
            this.D4.TabStop = false;
            this.D4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D4_MouseDown);
            // 
            // E4
            // 
            this.E4.BackColor = System.Drawing.Color.Transparent;
            this.E4.Location = new System.Drawing.Point(315, 187);
            this.E4.Name = "E4";
            this.E4.Size = new System.Drawing.Size(78, 63);
            this.E4.TabIndex = 11;
            this.E4.TabStop = false;
            this.E4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E4_MouseDown);
            // 
            // F4
            // 
            this.F4.BackColor = System.Drawing.Color.Transparent;
            this.F4.Location = new System.Drawing.Point(393, 187);
            this.F4.Name = "F4";
            this.F4.Size = new System.Drawing.Size(78, 63);
            this.F4.TabIndex = 12;
            this.F4.TabStop = false;
            this.F4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F4_MouseDown);
            // 
            // G4
            // 
            this.G4.BackColor = System.Drawing.Color.Transparent;
            this.G4.Location = new System.Drawing.Point(471, 187);
            this.G4.Name = "G4";
            this.G4.Size = new System.Drawing.Size(78, 63);
            this.G4.TabIndex = 13;
            this.G4.TabStop = false;
<<<<<<< HEAD
=======
            this.G4.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G4_MouseDown);
            // 
            // H4
            // 
            this.H4.BackColor = System.Drawing.Color.Transparent;
            this.H4.Location = new System.Drawing.Point(549, 187);
            this.H4.Name = "H4";
            this.H4.Size = new System.Drawing.Size(78, 63);
            this.H4.TabIndex = 14;
            this.H4.TabStop = false;
            this.H4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H4_MouseDown);
            // 
            // A5
            // 
            this.A5.BackColor = System.Drawing.Color.Transparent;
            this.A5.Location = new System.Drawing.Point(3, 250);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(78, 63);
            this.A5.TabIndex = 7;
            this.A5.TabStop = false;
            this.A5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A5_MouseDown);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.Transparent;
            this.B5.Location = new System.Drawing.Point(81, 250);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(78, 63);
            this.B5.TabIndex = 8;
            this.B5.TabStop = false;
            this.B5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B5_MouseDown);
            // 
            // C5
            // 
            this.C5.BackColor = System.Drawing.Color.Transparent;
            this.C5.Location = new System.Drawing.Point(159, 250);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(78, 63);
            this.C5.TabIndex = 9;
            this.C5.TabStop = false;
            this.C5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C5_MouseDown);
            // 
            // D5
            // 
            this.D5.BackColor = System.Drawing.Color.Transparent;
            this.D5.Location = new System.Drawing.Point(237, 250);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(78, 63);
            this.D5.TabIndex = 10;
            this.D5.TabStop = false;
            this.D5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D5_MouseDown);
            // 
            // E5
            // 
            this.E5.BackColor = System.Drawing.Color.Transparent;
            this.E5.Location = new System.Drawing.Point(315, 250);
            this.E5.Name = "E5";
            this.E5.Size = new System.Drawing.Size(78, 63);
            this.E5.TabIndex = 11;
            this.E5.TabStop = false;
            this.E5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E5_MouseDown);
            // 
            // F5
            // 
            this.F5.BackColor = System.Drawing.Color.Transparent;
            this.F5.Location = new System.Drawing.Point(393, 250);
            this.F5.Name = "F5";
            this.F5.Size = new System.Drawing.Size(78, 63);
            this.F5.TabIndex = 12;
            this.F5.TabStop = false;
            this.F5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F5_MouseDown);
            // 
            // G5
            // 
            this.G5.BackColor = System.Drawing.Color.Transparent;
            this.G5.Location = new System.Drawing.Point(471, 250);
            this.G5.Name = "G5";
            this.G5.Size = new System.Drawing.Size(78, 63);
            this.G5.TabIndex = 13;
            this.G5.TabStop = false;
<<<<<<< HEAD
=======
            this.G5.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G5_MouseDown);
            // 
            // H5
            // 
            this.H5.BackColor = System.Drawing.Color.Transparent;
            this.H5.Location = new System.Drawing.Point(549, 250);
            this.H5.Name = "H5";
            this.H5.Size = new System.Drawing.Size(78, 63);
            this.H5.TabIndex = 14;
            this.H5.TabStop = false;
            this.H5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H5_MouseDown);
            // 
            // A6
            // 
            this.A6.BackColor = System.Drawing.Color.Transparent;
            this.A6.Image = ((System.Drawing.Image)(resources.GetObject("A6.Image")));
            this.A6.Location = new System.Drawing.Point(3, 312);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(78, 63);
            this.A6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A6.TabIndex = 7;
            this.A6.TabStop = false;
            this.A6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A6_MouseDown);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.Color.Transparent;
            this.B6.Image = ((System.Drawing.Image)(resources.GetObject("B6.Image")));
            this.B6.Location = new System.Drawing.Point(81, 312);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(78, 63);
            this.B6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B6.TabIndex = 8;
            this.B6.TabStop = false;
            this.B6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B6_MouseDown);
            // 
            // C6
            // 
            this.C6.BackColor = System.Drawing.Color.Transparent;
            this.C6.Image = ((System.Drawing.Image)(resources.GetObject("C6.Image")));
            this.C6.Location = new System.Drawing.Point(159, 312);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(78, 63);
            this.C6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C6.TabIndex = 9;
            this.C6.TabStop = false;
            this.C6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C6_MouseDown);
            // 
            // D6
            // 
            this.D6.BackColor = System.Drawing.Color.Transparent;
            this.D6.Image = ((System.Drawing.Image)(resources.GetObject("D6.Image")));
            this.D6.Location = new System.Drawing.Point(237, 312);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(78, 63);
            this.D6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D6.TabIndex = 10;
            this.D6.TabStop = false;
            this.D6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D6_MouseDown);
            // 
            // E6
            // 
            this.E6.BackColor = System.Drawing.Color.Transparent;
            this.E6.Image = ((System.Drawing.Image)(resources.GetObject("E6.Image")));
            this.E6.Location = new System.Drawing.Point(315, 312);
            this.E6.Name = "E6";
            this.E6.Size = new System.Drawing.Size(78, 63);
            this.E6.TabIndex = 11;
            this.E6.TabStop = false;
            this.E6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E6_MouseDown);
            // 
            // F6
            // 
            this.F6.BackColor = System.Drawing.Color.Transparent;
            this.F6.Image = ((System.Drawing.Image)(resources.GetObject("F6.Image")));
            this.F6.Location = new System.Drawing.Point(393, 312);
            this.F6.Name = "F6";
            this.F6.Size = new System.Drawing.Size(78, 63);
            this.F6.TabIndex = 12;
            this.F6.TabStop = false;
            this.F6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F6_MouseDown);
            // 
            // G6
            // 
            this.G6.BackColor = System.Drawing.Color.Transparent;
            this.G6.Image = ((System.Drawing.Image)(resources.GetObject("G6.Image")));
            this.G6.Location = new System.Drawing.Point(471, 312);
            this.G6.Name = "G6";
            this.G6.Size = new System.Drawing.Size(78, 63);
            this.G6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G6.TabIndex = 13;
            this.G6.TabStop = false;
<<<<<<< HEAD
=======
            this.G6.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G6_MouseDown);
            // 
            // H6
            // 
            this.H6.BackColor = System.Drawing.Color.Transparent;
            this.H6.Image = ((System.Drawing.Image)(resources.GetObject("H6.Image")));
            this.H6.Location = new System.Drawing.Point(549, 312);
            this.H6.Name = "H6";
            this.H6.Size = new System.Drawing.Size(78, 63);
            this.H6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H6.TabIndex = 14;
            this.H6.TabStop = false;
            this.H6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H6_MouseDown);
            // 
            // A7
            // 
            this.A7.BackColor = System.Drawing.Color.Transparent;
            this.A7.Image = ((System.Drawing.Image)(resources.GetObject("A7.Image")));
            this.A7.Location = new System.Drawing.Point(3, 374);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(78, 63);
            this.A7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A7.TabIndex = 7;
            this.A7.TabStop = false;
            this.A7.Click += new System.EventHandler(this.A7_Click);
            this.A7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A7_MouseDown);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.Color.Transparent;
            this.B7.Image = ((System.Drawing.Image)(resources.GetObject("B7.Image")));
            this.B7.Location = new System.Drawing.Point(81, 374);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(78, 63);
            this.B7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.B7.TabIndex = 8;
            this.B7.TabStop = false;
            this.B7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B7_MouseDown);
            // 
            // C7
            // 
            this.C7.BackColor = System.Drawing.Color.Transparent;
            this.C7.Image = ((System.Drawing.Image)(resources.GetObject("C7.Image")));
            this.C7.Location = new System.Drawing.Point(159, 374);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(78, 63);
            this.C7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C7.TabIndex = 9;
            this.C7.TabStop = false;
            this.C7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C7_MouseDown);
            // 
            // D7
            // 
            this.D7.BackColor = System.Drawing.Color.Transparent;
            this.D7.Image = ((System.Drawing.Image)(resources.GetObject("D7.Image")));
            this.D7.Location = new System.Drawing.Point(237, 374);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(78, 63);
            this.D7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.D7.TabIndex = 10;
            this.D7.TabStop = false;
            this.D7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D7_MouseDown);
            // 
            // E7
            // 
            this.E7.BackColor = System.Drawing.Color.Transparent;
            this.E7.Image = ((System.Drawing.Image)(resources.GetObject("E7.Image")));
            this.E7.Location = new System.Drawing.Point(315, 374);
            this.E7.Name = "E7";
            this.E7.Size = new System.Drawing.Size(78, 63);
            this.E7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.E7.TabIndex = 11;
            this.E7.TabStop = false;
            this.E7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E7_MouseDown);
            // 
            // F7
            // 
            this.F7.BackColor = System.Drawing.Color.Transparent;
            this.F7.Image = ((System.Drawing.Image)(resources.GetObject("F7.Image")));
            this.F7.Location = new System.Drawing.Point(393, 374);
            this.F7.Name = "F7";
            this.F7.Size = new System.Drawing.Size(78, 63);
            this.F7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.F7.TabIndex = 12;
            this.F7.TabStop = false;
            this.F7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F7_MouseDown);
            // 
            // G7
            // 
            this.G7.BackColor = System.Drawing.Color.Transparent;
            this.G7.Image = ((System.Drawing.Image)(resources.GetObject("G7.Image")));
            this.G7.Location = new System.Drawing.Point(471, 374);
            this.G7.Name = "G7";
            this.G7.Size = new System.Drawing.Size(78, 63);
            this.G7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G7.TabIndex = 13;
            this.G7.TabStop = false;
<<<<<<< HEAD
=======
            this.G7.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G7_MouseDown);
            // 
            // H7
            // 
            this.H7.BackColor = System.Drawing.Color.Transparent;
            this.H7.Image = ((System.Drawing.Image)(resources.GetObject("H7.Image")));
            this.H7.Location = new System.Drawing.Point(549, 374);
            this.H7.Name = "H7";
            this.H7.Size = new System.Drawing.Size(78, 63);
            this.H7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.H7.TabIndex = 14;
            this.H7.TabStop = false;
            this.H7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H7_MouseDown);
            // 
            // A8
            // 
            this.A8.BackColor = System.Drawing.Color.Transparent;
            this.A8.Location = new System.Drawing.Point(3, 437);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(78, 63);
            this.A8.TabIndex = 7;
            this.A8.TabStop = false;
            this.A8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A8_MouseDown);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.Color.Transparent;
            this.B8.Location = new System.Drawing.Point(81, 437);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(78, 63);
            this.B8.TabIndex = 8;
            this.B8.TabStop = false;
            this.B8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B8_MouseDown);
            // 
            // C8
            // 
            this.C8.BackColor = System.Drawing.Color.Transparent;
            this.C8.Location = new System.Drawing.Point(159, 437);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(78, 63);
            this.C8.TabIndex = 9;
            this.C8.TabStop = false;
            this.C8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.C8_MouseDown);
            // 
            // D8
            // 
            this.D8.BackColor = System.Drawing.Color.Transparent;
            this.D8.Location = new System.Drawing.Point(237, 437);
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(78, 63);
            this.D8.TabIndex = 10;
            this.D8.TabStop = false;
            this.D8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D8_MouseDown);
            // 
            // E8
            // 
            this.E8.BackColor = System.Drawing.Color.Transparent;
            this.E8.Location = new System.Drawing.Point(315, 437);
            this.E8.Name = "E8";
            this.E8.Size = new System.Drawing.Size(78, 63);
            this.E8.TabIndex = 11;
            this.E8.TabStop = false;
            this.E8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E8_MouseDown);
            // 
            // F8
            // 
            this.F8.BackColor = System.Drawing.Color.Transparent;
            this.F8.Location = new System.Drawing.Point(393, 437);
            this.F8.Name = "F8";
            this.F8.Size = new System.Drawing.Size(78, 63);
            this.F8.TabIndex = 12;
            this.F8.TabStop = false;
            this.F8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F8_MouseDown);
            // 
            // G8
            // 
            this.G8.BackColor = System.Drawing.Color.Transparent;
            this.G8.Location = new System.Drawing.Point(471, 437);
            this.G8.Name = "G8";
            this.G8.Size = new System.Drawing.Size(78, 63);
            this.G8.TabIndex = 13;
            this.G8.TabStop = false;
<<<<<<< HEAD
=======
            this.G8.Click += new System.EventHandler(this.pictureBox7_Click);
>>>>>>> 8bdc47018b102b3a212ef067a7895f6edd12fe17
            this.G8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.G8_MouseDown);
            // 
            // H8
            // 
            this.H8.BackColor = System.Drawing.Color.Transparent;
            this.H8.Location = new System.Drawing.Point(549, 437);
            this.H8.Name = "H8";
            this.H8.Size = new System.Drawing.Size(78, 63);
            this.H8.TabIndex = 14;
            this.H8.TabStop = false;
            this.H8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H8_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(893, 502);
            this.Controls.Add(this.H8);
            this.Controls.Add(this.H7);
            this.Controls.Add(this.H6);
            this.Controls.Add(this.H5);
            this.Controls.Add(this.H4);
            this.Controls.Add(this.H3);
            this.Controls.Add(this.H2);
            this.Controls.Add(this.H1);
            this.Controls.Add(this.G8);
            this.Controls.Add(this.G7);
            this.Controls.Add(this.G6);
            this.Controls.Add(this.G5);
            this.Controls.Add(this.F8);
            this.Controls.Add(this.G4);
            this.Controls.Add(this.F7);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.F6);
            this.Controls.Add(this.E8);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.E7);
            this.Controls.Add(this.F5);
            this.Controls.Add(this.E6);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.E5);
            this.Controls.Add(this.F4);
            this.Controls.Add(this.D8);
            this.Controls.Add(this.E4);
            this.Controls.Add(this.D7);
            this.Controls.Add(this.F3);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.E3);
            this.Controls.Add(this.D5);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.C8);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.C7);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.C6);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.E1);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox A1;
        private PictureBox B1;
        private PictureBox C1;
        private PictureBox D1;
        private PictureBox E1;
        private PictureBox F1;
        private PictureBox G1;
        private PictureBox H1;
        private PictureBox A2;
        private PictureBox B2;
        private PictureBox C2;
        private PictureBox D2;
        private PictureBox E2;
        private PictureBox F2;
        private PictureBox G2;
        private PictureBox H2;
        private PictureBox A3;
        private PictureBox B3;
        private PictureBox C3;
        private PictureBox D3;
        private PictureBox E3;
        private PictureBox F3;
        private PictureBox G3;
        private PictureBox H3;
        private PictureBox A4;
        private PictureBox B4;
        private PictureBox C4;
        private PictureBox D4;
        private PictureBox E4;
        private PictureBox F4;
        private PictureBox G4;
        private PictureBox H4;
        private PictureBox A5;
        private PictureBox B5;
        private PictureBox C5;
        private PictureBox D5;
        private PictureBox E5;
        private PictureBox F5;
        private PictureBox G5;
        private PictureBox H5;
        private PictureBox A6;
        private PictureBox B6;
        private PictureBox C6;
        private PictureBox D6;
        private PictureBox E6;
        private PictureBox F6;
        private PictureBox G6;
        private PictureBox H6;
        private PictureBox A7;
        private PictureBox B7;
        private PictureBox C7;
        private PictureBox D7;
        private PictureBox E7;
        private PictureBox F7;
        private PictureBox G7;
        private PictureBox H7;
        private PictureBox A8;
        private PictureBox B8;
        private PictureBox C8;
        private PictureBox D8;
        private PictureBox E8;
        private PictureBox F8;
        private PictureBox G8;
        private PictureBox H8;
        private System.Windows.Forms.Timer timer1;

        public EventHandler Form1_Load_1 { get; private set; }
    }
}