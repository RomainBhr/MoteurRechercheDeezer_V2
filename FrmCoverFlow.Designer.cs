namespace ZiknCo_MoteurRechercheDeezer_V2
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.iC3DAlbums = new CDI.IndexCard3D.IC3D();
            this.panListeTitres = new System.Windows.Forms.Panel();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.panListeTitres.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(1, 316);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(590, 45);
            this.wmpLecteur.TabIndex = 9;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.WmpLecteur_CurrentItemChange);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(12, 297);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "Titre";
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Location = new System.Drawing.Point(503, 297);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(41, 13);
            this.lblXsurY.TabIndex = 11;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.LblXsurY_MouseHover);
            // 
            // iC3DAlbums
            // 
            this.iC3DAlbums.DisplayCards = 8;
            this.iC3DAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbums.Location = new System.Drawing.Point(1, -96);
            this.iC3DAlbums.Name = "iC3DAlbums";
            this.iC3DAlbums.Size = new System.Drawing.Size(574, 390);
            this.iC3DAlbums.TabIndex = 12;
            this.iC3DAlbums.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.IC3DAlbums_RenderText);
            this.iC3DAlbums.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.IC3DAlbums_IndexCardChanged);
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.Controls.Add(this.label1);
            this.panListeTitres.Location = new System.Drawing.Point(422, -3);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(153, 297);
            this.panListeTitres.TabIndex = 15;
            this.panListeTitres.Visible = false;
            // 
            // lstTitres
            // 
            this.lstTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(12, 27);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(129, 251);
            this.lstTitres.TabIndex = 1;
            this.lstTitres.Click += new System.EventHandler(this.LstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.LstTitres_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titres de l\'Album";
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.iC3DAlbums);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.wmpLecteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "Zik\'nCo : Affichage \"Cover Flow\"";
            this.Load += new System.EventHandler(this.FrmCoverFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblXsurY;
        private CDI.IndexCard3D.IC3D iC3DAlbums;
        private System.Windows.Forms.Panel panListeTitres;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label label1;
    }
}