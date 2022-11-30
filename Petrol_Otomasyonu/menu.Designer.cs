namespace Petrol_Otomasyonu
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.personel_islemleri_btn = new System.Windows.Forms.Button();
            this.musteri_islemleri_btn = new System.Windows.Forms.Button();
            this.akaryakit_satis_btn = new System.Windows.Forms.Button();
            this.akaryakit_depo_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logo_pictureBox.Image")));
            this.logo_pictureBox.Location = new System.Drawing.Point(286, 32);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(357, 306);
            this.logo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_pictureBox.TabIndex = 4;
            this.logo_pictureBox.TabStop = false;
            // 
            // personel_islemleri_btn
            // 
            this.personel_islemleri_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.personel_islemleri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personel_islemleri_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_islemleri_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_islemleri_btn.Image = global::Petrol_Otomasyonu.Properties.Resources._new;
            this.personel_islemleri_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personel_islemleri_btn.Location = new System.Drawing.Point(38, 266);
            this.personel_islemleri_btn.Name = "personel_islemleri_btn";
            this.personel_islemleri_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personel_islemleri_btn.Size = new System.Drawing.Size(207, 72);
            this.personel_islemleri_btn.TabIndex = 3;
            this.personel_islemleri_btn.Text = "Personel İşlemleri";
            this.personel_islemleri_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personel_islemleri_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.personel_islemleri_btn.UseVisualStyleBackColor = false;
            this.personel_islemleri_btn.Click += new System.EventHandler(this.personel_islemleri_btn_Click);
            // 
            // musteri_islemleri_btn
            // 
            this.musteri_islemleri_btn.BackColor = System.Drawing.Color.Gold;
            this.musteri_islemleri_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteri_islemleri_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteri_islemleri_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_islemleri_btn.Image = global::Petrol_Otomasyonu.Properties.Resources.customer;
            this.musteri_islemleri_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteri_islemleri_btn.Location = new System.Drawing.Point(38, 110);
            this.musteri_islemleri_btn.Name = "musteri_islemleri_btn";
            this.musteri_islemleri_btn.Size = new System.Drawing.Size(207, 72);
            this.musteri_islemleri_btn.TabIndex = 2;
            this.musteri_islemleri_btn.Text = "Müşteri İşlemleri";
            this.musteri_islemleri_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musteri_islemleri_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.musteri_islemleri_btn.UseVisualStyleBackColor = false;
            this.musteri_islemleri_btn.Click += new System.EventHandler(this.musteri_islemleri_btn_Click);
            // 
            // akaryakit_satis_btn
            // 
            this.akaryakit_satis_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.akaryakit_satis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.akaryakit_satis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akaryakit_satis_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akaryakit_satis_btn.Image = global::Petrol_Otomasyonu.Properties.Resources.pompa;
            this.akaryakit_satis_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.akaryakit_satis_btn.Location = new System.Drawing.Point(38, 32);
            this.akaryakit_satis_btn.Name = "akaryakit_satis_btn";
            this.akaryakit_satis_btn.Size = new System.Drawing.Size(207, 72);
            this.akaryakit_satis_btn.TabIndex = 1;
            this.akaryakit_satis_btn.Text = "Akaryakıt Satış İşlemleri";
            this.akaryakit_satis_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.akaryakit_satis_btn.UseVisualStyleBackColor = false;
            this.akaryakit_satis_btn.Click += new System.EventHandler(this.akaryakit_satis_btn_Click);
            // 
            // akaryakit_depo_btn
            // 
            this.akaryakit_depo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.akaryakit_depo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.akaryakit_depo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akaryakit_depo_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.akaryakit_depo_btn.Image = global::Petrol_Otomasyonu.Properties.Resources.depo;
            this.akaryakit_depo_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.akaryakit_depo_btn.Location = new System.Drawing.Point(38, 188);
            this.akaryakit_depo_btn.Name = "akaryakit_depo_btn";
            this.akaryakit_depo_btn.Size = new System.Drawing.Size(207, 72);
            this.akaryakit_depo_btn.TabIndex = 0;
            this.akaryakit_depo_btn.Text = "Akaryakıt Depo İşlemleri";
            this.akaryakit_depo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.akaryakit_depo_btn.UseVisualStyleBackColor = false;
            this.akaryakit_depo_btn.Click += new System.EventHandler(this.akaryakit_depo_btn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(676, 371);
            this.Controls.Add(this.logo_pictureBox);
            this.Controls.Add(this.personel_islemleri_btn);
            this.Controls.Add(this.musteri_islemleri_btn);
            this.Controls.Add(this.akaryakit_satis_btn);
            this.Controls.Add(this.akaryakit_depo_btn);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button akaryakit_depo_btn;
        private System.Windows.Forms.Button akaryakit_satis_btn;
        private System.Windows.Forms.Button musteri_islemleri_btn;
        private System.Windows.Forms.Button personel_islemleri_btn;
        private System.Windows.Forms.PictureBox logo_pictureBox;
    }
}