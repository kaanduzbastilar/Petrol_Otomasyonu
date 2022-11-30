namespace Petrol_Otomasyonu
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.cikis_btn = new System.Windows.Forms.Button();
            this.giris_btn = new System.Windows.Forms.Button();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.kullanici_adi_textbox = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.kullanici_adi_label = new System.Windows.Forms.Label();
            this.uye_ol_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.cikis_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cikis_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.cikis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cikis_btn.Location = new System.Drawing.Point(113, 201);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(157, 42);
            this.cikis_btn.TabIndex = 11;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.giris_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.giris_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.giris_btn.Location = new System.Drawing.Point(113, 105);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(157, 42);
            this.giris_btn.TabIndex = 10;
            this.giris_btn.Text = "Giriş Yap ";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre_textbox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_textbox.Location = new System.Drawing.Point(197, 66);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.PasswordChar = '*';
            this.sifre_textbox.Size = new System.Drawing.Size(145, 21);
            this.sifre_textbox.TabIndex = 9;
            this.sifre_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifre_textbox_KeyPress);
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullanici_adi_textbox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(197, 27);
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(145, 21);
            this.kullanici_adi_textbox.TabIndex = 8;
            this.kullanici_adi_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullanici_adi_textbox_KeyPress);
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.BackColor = System.Drawing.Color.Transparent;
            this.sifre_label.Font = new System.Drawing.Font("Verdana", 12F);
            this.sifre_label.ForeColor = System.Drawing.Color.SpringGreen;
            this.sifre_label.Location = new System.Drawing.Point(110, 66);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(58, 18);
            this.sifre_label.TabIndex = 7;
            this.sifre_label.Text = "Şifre :";
            // 
            // kullanici_adi_label
            // 
            this.kullanici_adi_label.AutoSize = true;
            this.kullanici_adi_label.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_adi_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanici_adi_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi_label.ForeColor = System.Drawing.Color.SpringGreen;
            this.kullanici_adi_label.Location = new System.Drawing.Point(46, 27);
            this.kullanici_adi_label.Name = "kullanici_adi_label";
            this.kullanici_adi_label.Size = new System.Drawing.Size(122, 18);
            this.kullanici_adi_label.TabIndex = 6;
            this.kullanici_adi_label.Text = "Kullanıcı Adı :";
            // 
            // uye_ol_btn
            // 
            this.uye_ol_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.uye_ol_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uye_ol_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uye_ol_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.uye_ol_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uye_ol_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.uye_ol_btn.Location = new System.Drawing.Point(113, 153);
            this.uye_ol_btn.Name = "uye_ol_btn";
            this.uye_ol_btn.Size = new System.Drawing.Size(157, 42);
            this.uye_ol_btn.TabIndex = 12;
            this.uye_ol_btn.Text = "Üye Ol";
            this.uye_ol_btn.UseVisualStyleBackColor = false;
            this.uye_ol_btn.Click += new System.EventHandler(this.uye_ol_btn_Click);
            // 
            // mainform
            // 
            this.AcceptButton = this.giris_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cikis_btn;
            this.ClientSize = new System.Drawing.Size(377, 253);
            this.Controls.Add(this.uye_ol_btn);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kullanici_adi_textbox);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kullanici_adi_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petrol Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox kullanici_adi_textbox;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.Label kullanici_adi_label;
        private System.Windows.Forms.Button uye_ol_btn;
    }
}

