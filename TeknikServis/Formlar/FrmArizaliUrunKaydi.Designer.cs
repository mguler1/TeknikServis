namespace TeknikServis.Formlar
{
    partial class FrmArizaliUrunKaydi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArizaliUrunKaydi));
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Lmusteri = new DevExpress.XtraEditors.LookUpEdit();
            this.Lpersonel = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lmusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpersonel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.EditValue = "Ürün Seri No";
            this.txtSeriNo.Location = new System.Drawing.Point(39, 176);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSeriNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.txtSeriNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSeriNo.Properties.Mask.EditMask = "AAAAA";
            this.txtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSeriNo.Size = new System.Drawing.Size(197, 18);
            this.txtSeriNo.TabIndex = 73;
            this.txtSeriNo.EditValueChanged += new System.EventHandler(this.txtSeriNo_EditValueChanged);
            this.txtSeriNo.Click += new System.EventHandler(this.txtSeriNo_Click);
            // 
            // panelControl10
            // 
            this.panelControl10.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl10.Appearance.Options.UseBackColor = true;
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl10.Location = new System.Drawing.Point(42, 196);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(200, 3);
            this.panelControl10.TabIndex = 84;
            // 
            // textEdit8
            // 
            this.textEdit8.EditValue = "YENİ ARIZA KAYDI EKLEME";
            this.textEdit8.Location = new System.Drawing.Point(39, 24);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit8.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit8.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit8.Size = new System.Drawing.Size(197, 18);
            this.textEdit8.TabIndex = 83;
            this.textEdit8.EditValueChanged += new System.EventHandler(this.textEdit8_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(139, 245);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 44);
            this.simpleButton1.TabIndex = 82;
            this.simpleButton1.Text = "VAZGEÇ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(29, 245);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 44);
            this.btnKaydet.TabIndex = 81;
            this.btnKaydet.Text = "KAYIT YAP";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = "Tarih";
            this.txtTarih.Location = new System.Drawing.Point(42, 141);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTarih.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtTarih.Properties.Appearance.Options.UseBackColor = true;
            this.txtTarih.Properties.Appearance.Options.UseForeColor = true;
            this.txtTarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTarih.Properties.Mask.EditMask = "d";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTarih.Size = new System.Drawing.Size(197, 18);
            this.txtTarih.TabIndex = 72;
            this.txtTarih.Click += new System.EventHandler(this.txtTarih_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl4.Location = new System.Drawing.Point(39, 163);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(200, 3);
            this.panelControl4.TabIndex = 75;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl3.Location = new System.Drawing.Point(39, 128);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(200, 3);
            this.panelControl3.TabIndex = 73;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Location = new System.Drawing.Point(39, 89);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 3);
            this.panelControl1.TabIndex = 69;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(83, 302);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(104, 44);
            this.simpleButton2.TabIndex = 85;
            this.simpleButton2.Text = "TEMİZLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Lmusteri
            // 
            this.Lmusteri.EditValue = "Değer Seçiniz";
            this.Lmusteri.Location = new System.Drawing.Point(39, 67);
            this.Lmusteri.Name = "Lmusteri";
            this.Lmusteri.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Lmusteri.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Lmusteri.Properties.Appearance.Options.UseBackColor = true;
            this.Lmusteri.Properties.Appearance.Options.UseForeColor = true;
            this.Lmusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lmusteri.Properties.DisplayMember = "Ad";
            this.Lmusteri.Properties.ValueMember = "ID";
            this.Lmusteri.Size = new System.Drawing.Size(200, 20);
            this.Lmusteri.TabIndex = 86;
            // 
            // Lpersonel
            // 
            this.Lpersonel.EditValue = "Değer Seçiniz";
            this.Lpersonel.Location = new System.Drawing.Point(39, 106);
            this.Lpersonel.Name = "Lpersonel";
            this.Lpersonel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Lpersonel.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Lpersonel.Properties.Appearance.Options.UseBackColor = true;
            this.Lpersonel.Properties.Appearance.Options.UseForeColor = true;
            this.Lpersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lpersonel.Properties.DisplayMember = "AD";
            this.Lpersonel.Properties.ValueMember = "ID";
            this.Lpersonel.Size = new System.Drawing.Size(200, 20);
            this.Lpersonel.TabIndex = 87;
            // 
            // FrmArizaliUrunKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(286, 358);
            this.Controls.Add(this.Lpersonel);
            this.Controls.Add(this.Lmusteri);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.panelControl10);
            this.Controls.Add(this.textEdit8);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArizaliUrunKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArizaliUrunKaydi";
            this.Load += new System.EventHandler(this.FrmArizaliUrunKaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lmusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lpersonel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LookUpEdit Lmusteri;
        private DevExpress.XtraEditors.LookUpEdit Lpersonel;
    }
}