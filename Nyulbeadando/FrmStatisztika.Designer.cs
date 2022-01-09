
namespace Nyulbeadando
{
    partial class FrmStatisztika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVStat = new System.Windows.Forms.DataGridView();
            this.CBMunkasSTAT = new System.Windows.Forms.ComboBox();
            this.tojasok = new System.Windows.Forms.TextBox();
            this.Honapossztojassulya = new System.Windows.Forms.TextBox();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUDhonap = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDhonap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkás neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiválasztott hónap sorszáma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termelési napló:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hónap legtöbbet gyártott tojás szine:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adott hónapban termelt tojások összsúlya:";
            // 
            // DGVStat
            // 
            this.DGVStat.AllowUserToAddRows = false;
            this.DGVStat.AllowUserToDeleteRows = false;
            this.DGVStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Szin,
            this.Menny});
            this.DGVStat.Location = new System.Drawing.Point(16, 100);
            this.DGVStat.Name = "DGVStat";
            this.DGVStat.ReadOnly = true;
            this.DGVStat.RowHeadersVisible = false;
            this.DGVStat.Size = new System.Drawing.Size(772, 240);
            this.DGVStat.TabIndex = 5;
            // 
            // CBMunkasSTAT
            // 
            this.CBMunkasSTAT.FormattingEnabled = true;
            this.CBMunkasSTAT.Location = new System.Drawing.Point(93, 22);
            this.CBMunkasSTAT.Name = "CBMunkasSTAT";
            this.CBMunkasSTAT.Size = new System.Drawing.Size(121, 21);
            this.CBMunkasSTAT.TabIndex = 6;
            this.CBMunkasSTAT.SelectedIndexChanged += new System.EventHandler(this.CBMunkasSTAT_SelectedIndexChanged);
            // 
            // tojasok
            // 
            this.tojasok.Enabled = false;
            this.tojasok.Location = new System.Drawing.Point(500, 368);
            this.tojasok.Name = "tojasok";
            this.tojasok.Size = new System.Drawing.Size(269, 20);
            this.tojasok.TabIndex = 8;
            // 
            // Honapossztojassulya
            // 
            this.Honapossztojassulya.Enabled = false;
            this.Honapossztojassulya.Location = new System.Drawing.Point(500, 411);
            this.Honapossztojassulya.Name = "Honapossztojassulya";
            this.Honapossztojassulya.Size = new System.Drawing.Size(269, 20);
            this.Honapossztojassulya.TabIndex = 9;
            // 
            // Datum
            // 
            this.Datum.FillWeight = 45F;
            this.Datum.HeaderText = "Dátum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Szin
            // 
            this.Szin.FillWeight = 33F;
            this.Szin.HeaderText = "Szin";
            this.Szin.Name = "Szin";
            this.Szin.ReadOnly = true;
            // 
            // Menny
            // 
            this.Menny.FillWeight = 33F;
            this.Menny.HeaderText = "Mennyiség";
            this.Menny.Name = "Menny";
            this.Menny.ReadOnly = true;
            // 
            // NUDhonap
            // 
            this.NUDhonap.Location = new System.Drawing.Point(704, 11);
            this.NUDhonap.Name = "NUDhonap";
            this.NUDhonap.Size = new System.Drawing.Size(41, 20);
            this.NUDhonap.TabIndex = 10;
            this.NUDhonap.ValueChanged += new System.EventHandler(this.NUDhonap_ValueChanged);
            // 
            // FrmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUDhonap);
            this.Controls.Add(this.Honapossztojassulya);
            this.Controls.Add(this.tojasok);
            this.Controls.Add(this.CBMunkasSTAT);
            this.Controls.Add(this.DGVStat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStatisztika";
            this.Text = "FrmStatisztika";
            this.Load += new System.EventHandler(this.FrmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDhonap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVStat;
        private System.Windows.Forms.ComboBox CBMunkasSTAT;
        private System.Windows.Forms.TextBox tojasok;
        private System.Windows.Forms.TextBox Honapossztojassulya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menny;
        private System.Windows.Forms.NumericUpDown NUDhonap;
    }
}