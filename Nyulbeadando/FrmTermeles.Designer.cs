
namespace Nyulbeadando
{
    partial class FrmTermeles
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eggcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBMunkas = new System.Windows.Forms.ComboBox();
            this.CBTojas = new System.Windows.Forms.ComboBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ujbejegy = new System.Windows.Forms.Button();
            this.NMD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMD)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.eggcolor,
            this.mennyiseg,
            this.munkas});
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(704, 296);
            this.DGV.TabIndex = 0;
            // 
            // date
            // 
            this.date.FillWeight = 85F;
            this.date.HeaderText = "Dátum";
            this.date.Name = "date";
            // 
            // eggcolor
            // 
            this.eggcolor.FillWeight = 40F;
            this.eggcolor.HeaderText = "Tojás színe";
            this.eggcolor.Name = "eggcolor";
            // 
            // mennyiseg
            // 
            this.mennyiseg.FillWeight = 40F;
            this.mennyiseg.HeaderText = "Mennyiség";
            this.mennyiseg.Name = "mennyiseg";
            // 
            // munkas
            // 
            this.munkas.HeaderText = "Munkás";
            this.munkas.Name = "munkas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.NMD);
            this.groupBox1.Controls.Add(this.CBMunkas);
            this.groupBox1.Controls.Add(this.CBTojas);
            this.groupBox1.Controls.Add(this.DTP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ujbejegy);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új bejegyzés";
            // 
            // CBMunkas
            // 
            this.CBMunkas.FormattingEnabled = true;
            this.CBMunkas.Location = new System.Drawing.Point(454, 125);
            this.CBMunkas.Name = "CBMunkas";
            this.CBMunkas.Size = new System.Drawing.Size(219, 21);
            this.CBMunkas.TabIndex = 7;
            // 
            // CBTojas
            // 
            this.CBTojas.FormattingEnabled = true;
            this.CBTojas.Location = new System.Drawing.Point(198, 125);
            this.CBTojas.Name = "CBTojas";
            this.CBTojas.Size = new System.Drawing.Size(121, 21);
            this.CBTojas.TabIndex = 6;
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(27, 126);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(149, 20);
            this.DTP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(451, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Munkás:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(335, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(195, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tojás:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dátum:";
            // 
            // btn_ujbejegy
            // 
            this.btn_ujbejegy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ujbejegy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ujbejegy.Location = new System.Drawing.Point(8, 209);
            this.btn_ujbejegy.Name = "btn_ujbejegy";
            this.btn_ujbejegy.Size = new System.Drawing.Size(690, 46);
            this.btn_ujbejegy.TabIndex = 0;
            this.btn_ujbejegy.Text = "Új bejegyzés felvétele";
            this.btn_ujbejegy.UseVisualStyleBackColor = true;
            this.btn_ujbejegy.Click += new System.EventHandler(this.btn_ujbejegy_Click);
            // 
            // NMD
            // 
            this.NMD.Location = new System.Drawing.Point(338, 126);
            this.NMD.Name = "NMD";
            this.NMD.Size = new System.Drawing.Size(74, 20);
            this.NMD.TabIndex = 8;
            // 
            // FrmTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(728, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmTermeles";
            this.Text = "FrmTermeles";
            this.Load += new System.EventHandler(this.FrmTermeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ujbejegy;
        private System.Windows.Forms.ComboBox CBMunkas;
        private System.Windows.Forms.ComboBox CBTojas;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn eggcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkas;
        private System.Windows.Forms.NumericUpDown NMD;
    }
}