namespace Barinak
{
    partial class ListeleForm
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
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwHayvanlar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbResim.Location = new System.Drawing.Point(195, 175);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(101, 74);
            this.pbResim.TabIndex = 19;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(280, 139);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(15, 14);
            this.cbEngel.TabIndex = 18;
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(111, 105);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(185, 21);
            this.cmbTur.TabIndex = 17;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(111, 67);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(185, 20);
            this.txtYas.TabIndex = 16;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(111, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 20);
            this.txtAd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Engel Durumu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yaşı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adı :";
            // 
            // dgwHayvanlar
            // 
            this.dgwHayvanlar.AllowUserToAddRows = false;
            this.dgwHayvanlar.AllowUserToDeleteRows = false;
            this.dgwHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHayvanlar.Location = new System.Drawing.Point(27, 303);
            this.dgwHayvanlar.Name = "dgwHayvanlar";
            this.dgwHayvanlar.ReadOnly = true;
            this.dgwHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHayvanlar.Size = new System.Drawing.Size(519, 140);
            this.dgwHayvanlar.TabIndex = 20;
            this.dgwHayvanlar.SelectionChanged += new System.EventHandler(this.dgwHayvanlar_SelectionChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(398, 35);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(169, 83);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(398, 140);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(169, 83);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 496);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgwHayvanlar);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListeleForm";
            this.Text = "ListeleForm";
            this.Load += new System.EventHandler(this.ListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.CheckBox cbEngel;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwHayvanlar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}