namespace ZiknCo_MoteurRechercheDeezer_V2
{
    partial class FrmRechercheAlbums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheAlbums));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEcouterExtrait = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxTitre = new System.Windows.Forms.ListBox();
            this.lstBoxAlbum = new System.Windows.Forms.ListBox();
            this.lblNomArtiste = new System.Windows.Forms.Label();
            this.linkAlbum = new System.Windows.Forms.LinkLabel();
            this.lblNomAlbum = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album recherché :";
            // 
            // txtBoxRecherche
            // 
            this.txtBoxRecherche.Location = new System.Drawing.Point(112, 21);
            this.txtBoxRecherche.Name = "txtBoxRecherche";
            this.txtBoxRecherche.Size = new System.Drawing.Size(171, 20);
            this.txtBoxRecherche.TabIndex = 1;
            this.txtBoxRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(310, 19);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.wmpLecteur);
            this.groupBox1.Controls.Add(this.btnEcouterExtrait);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstBoxTitre);
            this.groupBox1.Controls.Add(this.lstBoxAlbum);
            this.groupBox1.Controls.Add(this.lblNomArtiste);
            this.groupBox1.Controls.Add(this.linkAlbum);
            this.groupBox1.Controls.Add(this.lblNomAlbum);
            this.groupBox1.Controls.Add(this.picArtiste);
            this.groupBox1.Controls.Add(this.picAlbum);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 338);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Deezer";
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(347, 286);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(289, 46);
            this.wmpLecteur.TabIndex = 11;
            // 
            // btnEcouterExtrait
            // 
            this.btnEcouterExtrait.Location = new System.Drawing.Point(357, 240);
            this.btnEcouterExtrait.Name = "btnEcouterExtrait";
            this.btnEcouterExtrait.Size = new System.Drawing.Size(270, 29);
            this.btnEcouterExtrait.TabIndex = 10;
            this.btnEcouterExtrait.Text = "Ecouter tous les extrait de l\'album ...";
            this.btnEcouterExtrait.UseVisualStyleBackColor = true;
            this.btnEcouterExtrait.Click += new System.EventHandler(this.BtnEcouterExtrait_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Albums trouvés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titres de l\'album :";
            // 
            // lstBoxTitre
            // 
            this.lstBoxTitre.FormattingEnabled = true;
            this.lstBoxTitre.Location = new System.Drawing.Point(6, 224);
            this.lstBoxTitre.Name = "lstBoxTitre";
            this.lstBoxTitre.Size = new System.Drawing.Size(335, 108);
            this.lstBoxTitre.TabIndex = 7;
            this.lstBoxTitre.Click += new System.EventHandler(this.LstBoxTitre_Click);
            // 
            // lstBoxAlbum
            // 
            this.lstBoxAlbum.FormattingEnabled = true;
            this.lstBoxAlbum.Location = new System.Drawing.Point(6, 38);
            this.lstBoxAlbum.Name = "lstBoxAlbum";
            this.lstBoxAlbum.Size = new System.Drawing.Size(335, 160);
            this.lstBoxAlbum.TabIndex = 6;
            this.lstBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.LstBoxAlbum_SelectedIndexChanged);
            // 
            // lblNomArtiste
            // 
            this.lblNomArtiste.AutoSize = true;
            this.lblNomArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomArtiste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomArtiste.Location = new System.Drawing.Point(503, 65);
            this.lblNomArtiste.Name = "lblNomArtiste";
            this.lblNomArtiste.Size = new System.Drawing.Size(0, 15);
            this.lblNomArtiste.TabIndex = 5;
            // 
            // linkAlbum
            // 
            this.linkAlbum.AutoSize = true;
            this.linkAlbum.Location = new System.Drawing.Point(367, 185);
            this.linkAlbum.Name = "linkAlbum";
            this.linkAlbum.Size = new System.Drawing.Size(55, 13);
            this.linkAlbum.TabIndex = 4;
            this.linkAlbum.TabStop = true;
            this.linkAlbum.Text = "linkLabel1";
            // 
            // lblNomAlbum
            // 
            this.lblNomAlbum.AutoSize = true;
            this.lblNomAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAlbum.Location = new System.Drawing.Point(366, 16);
            this.lblNomAlbum.Name = "lblNomAlbum";
            this.lblNomAlbum.Size = new System.Drawing.Size(0, 20);
            this.lblNomAlbum.TabIndex = 3;
            // 
            // picArtiste
            // 
            this.picArtiste.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.photo_inconnu;
            this.picArtiste.Location = new System.Drawing.Point(410, 77);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(64, 75);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 2;
            this.picArtiste.TabStop = false;
            // 
            // picAlbum
            // 
            this.picAlbum.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.photo_inconnu;
            this.picAlbum.Location = new System.Drawing.Point(527, 38);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(109, 124);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 1;
            this.picAlbum.TabStop = false;
            this.picAlbum.Click += new System.EventHandler(this.PicAlbum_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMessage.Location = new System.Drawing.Point(112, 48);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // FrmRechercheAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(669, 425);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtBoxRecherche);
            this.Controls.Add(this.label1);
            this.Name = "FrmRechercheAlbums";
            this.Text = "FrmRechercheAlbums";
            this.Activated += new System.EventHandler(this.FrmRechercheAlbums_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxTitre;
        private System.Windows.Forms.ListBox lstBoxAlbum;
        private System.Windows.Forms.Label lblNomArtiste;
        private System.Windows.Forms.LinkLabel linkAlbum;
        private System.Windows.Forms.Label lblNomAlbum;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.Button btnEcouterExtrait;
        public AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblMessage;
    }
}