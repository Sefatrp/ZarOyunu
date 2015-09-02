namespace ZarOyunu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pcbZarBir = new System.Windows.Forms.PictureBox();
            this.pcbZarIki = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbTercih = new System.Windows.Forms.GroupBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.gbBahis = new System.Windows.Forms.GroupBox();
            this.rbOtuz = new System.Windows.Forms.RadioButton();
            this.rbYirmi = new System.Windows.Forms.RadioButton();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.lblOyunAdeti = new System.Windows.Forms.Label();
            this.lblBilgPara = new System.Windows.Forms.Label();
            this.lblOyuncuPara = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.tmrOyunZamani = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZarBir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZarIki)).BeginInit();
            this.gbTercih.SuspendLayout();
            this.gbBahis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbZarBir
            // 
            this.pcbZarBir.Location = new System.Drawing.Point(52, 119);
            this.pcbZarBir.Name = "pcbZarBir";
            this.pcbZarBir.Size = new System.Drawing.Size(136, 76);
            this.pcbZarBir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbZarBir.TabIndex = 0;
            this.pcbZarBir.TabStop = false;
            // 
            // pcbZarIki
            // 
            this.pcbZarIki.Location = new System.Drawing.Point(232, 119);
            this.pcbZarIki.Name = "pcbZarIki";
            this.pcbZarIki.Size = new System.Drawing.Size(130, 76);
            this.pcbZarIki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbZarIki.TabIndex = 1;
            this.pcbZarIki.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(232, 238);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Oyna";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // gbTercih
            // 
            this.gbTercih.Controls.Add(this.rbKucuk);
            this.gbTercih.Controls.Add(this.rbBuyuk);
            this.gbTercih.Location = new System.Drawing.Point(475, 86);
            this.gbTercih.Name = "gbTercih";
            this.gbTercih.Size = new System.Drawing.Size(131, 100);
            this.gbTercih.TabIndex = 3;
            this.gbTercih.TabStop = false;
            this.gbTercih.Text = "Tercih";
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(16, 58);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 1;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(16, 20);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // gbBahis
            // 
            this.gbBahis.Controls.Add(this.rbOtuz);
            this.gbBahis.Controls.Add(this.rbYirmi);
            this.gbBahis.Controls.Add(this.rbOn);
            this.gbBahis.Location = new System.Drawing.Point(475, 229);
            this.gbBahis.Name = "gbBahis";
            this.gbBahis.Size = new System.Drawing.Size(131, 100);
            this.gbBahis.TabIndex = 4;
            this.gbBahis.TabStop = false;
            this.gbBahis.Text = "Bahis";
            // 
            // rbOtuz
            // 
            this.rbOtuz.AutoSize = true;
            this.rbOtuz.Location = new System.Drawing.Point(23, 69);
            this.rbOtuz.Name = "rbOtuz";
            this.rbOtuz.Size = new System.Drawing.Size(37, 17);
            this.rbOtuz.TabIndex = 2;
            this.rbOtuz.TabStop = true;
            this.rbOtuz.Text = "30";
            this.rbOtuz.UseVisualStyleBackColor = true;
            // 
            // rbYirmi
            // 
            this.rbYirmi.AutoSize = true;
            this.rbYirmi.Location = new System.Drawing.Point(23, 42);
            this.rbYirmi.Name = "rbYirmi";
            this.rbYirmi.Size = new System.Drawing.Size(37, 17);
            this.rbYirmi.TabIndex = 1;
            this.rbYirmi.TabStop = true;
            this.rbYirmi.Text = "20";
            this.rbYirmi.UseVisualStyleBackColor = true;
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Location = new System.Drawing.Point(23, 19);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(37, 17);
            this.rbOn.TabIndex = 0;
            this.rbOn.TabStop = true;
            this.rbOn.Text = "10";
            this.rbOn.UseVisualStyleBackColor = true;
            // 
            // lblOyunAdeti
            // 
            this.lblOyunAdeti.AutoSize = true;
            this.lblOyunAdeti.Location = new System.Drawing.Point(475, 37);
            this.lblOyunAdeti.Name = "lblOyunAdeti";
            this.lblOyunAdeti.Size = new System.Drawing.Size(13, 13);
            this.lblOyunAdeti.TabIndex = 5;
            this.lblOyunAdeti.Text = "0";
            // 
            // lblBilgPara
            // 
            this.lblBilgPara.AutoSize = true;
            this.lblBilgPara.Location = new System.Drawing.Point(99, 86);
            this.lblBilgPara.Name = "lblBilgPara";
            this.lblBilgPara.Size = new System.Drawing.Size(39, 13);
            this.lblBilgPara.TabIndex = 6;
            this.lblBilgPara.Text = "bilPara";
            // 
            // lblOyuncuPara
            // 
            this.lblOyuncuPara.AutoSize = true;
            this.lblOyuncuPara.Location = new System.Drawing.Point(83, 49);
            this.lblOyuncuPara.Name = "lblOyuncuPara";
            this.lblOyuncuPara.Size = new System.Drawing.Size(66, 13);
            this.lblOyuncuPara.TabIndex = 7;
            this.lblOyuncuPara.Text = "OyuncuPara";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(583, 37);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(13, 13);
            this.lblKasa.TabIndex = 8;
            this.lblKasa.Text = "0";
            // 
            // tmrOyunZamani
            // 
            this.tmrOyunZamani.Interval = 1500;
            this.tmrOyunZamani.Tick += new System.EventHandler(this.tmrOyunZamani_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.lblOyuncuPara);
            this.Controls.Add(this.lblBilgPara);
            this.Controls.Add(this.lblOyunAdeti);
            this.Controls.Add(this.gbBahis);
            this.Controls.Add(this.gbTercih);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pcbZarIki);
            this.Controls.Add(this.pcbZarBir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbZarBir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbZarIki)).EndInit();
            this.gbTercih.ResumeLayout(false);
            this.gbTercih.PerformLayout();
            this.gbBahis.ResumeLayout(false);
            this.gbBahis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbZarBir;
        private System.Windows.Forms.PictureBox pcbZarIki;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbTercih;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.GroupBox gbBahis;
        private System.Windows.Forms.RadioButton rbOtuz;
        private System.Windows.Forms.RadioButton rbYirmi;
        private System.Windows.Forms.RadioButton rbOn;
        private System.Windows.Forms.Label lblOyunAdeti;
        private System.Windows.Forms.Label lblBilgPara;
        private System.Windows.Forms.Label lblOyuncuPara;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Timer tmrOyunZamani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

