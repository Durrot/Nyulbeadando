
namespace Nyulbeadando
{
    partial class FrmMain
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
            this.btn_term = new System.Windows.Forms.Button();
            this.btn_stat = new System.Windows.Forms.Button();
            this.btn_kimut = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_term
            // 
            this.btn_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_term.Location = new System.Drawing.Point(12, 12);
            this.btn_term.Name = "btn_term";
            this.btn_term.Size = new System.Drawing.Size(389, 70);
            this.btn_term.TabIndex = 1;
            this.btn_term.Text = "Termelés";
            this.btn_term.UseVisualStyleBackColor = true;
            this.btn_term.Click += new System.EventHandler(this.btn_term_Click);
            // 
            // btn_stat
            // 
            this.btn_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stat.Location = new System.Drawing.Point(12, 88);
            this.btn_stat.Name = "btn_stat";
            this.btn_stat.Size = new System.Drawing.Size(389, 70);
            this.btn_stat.TabIndex = 2;
            this.btn_stat.Text = "Statisztika";
            this.btn_stat.UseVisualStyleBackColor = true;
            this.btn_stat.Click += new System.EventHandler(this.btn_stat_Click);
            // 
            // btn_kimut
            // 
            this.btn_kimut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kimut.Location = new System.Drawing.Point(12, 164);
            this.btn_kimut.Name = "btn_kimut";
            this.btn_kimut.Size = new System.Drawing.Size(389, 70);
            this.btn_kimut.TabIndex = 3;
            this.btn_kimut.Text = "Kimutatás";
            this.btn_kimut.UseVisualStyleBackColor = true;
            // 
            // btn_kilep
            // 
            this.btn_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.Location = new System.Drawing.Point(12, 240);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(389, 70);
            this.btn_kilep.TabIndex = 4;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Nyulbeadando.Properties.Resources.nyul;
            this.pictureBox1.Location = new System.Drawing.Point(420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(829, 322);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_kimut);
            this.Controls.Add(this.btn_stat);
            this.Controls.Add(this.btn_term);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_term;
        private System.Windows.Forms.Button btn_stat;
        private System.Windows.Forms.Button btn_kimut;
        private System.Windows.Forms.Button btn_kilep;
    }
}

