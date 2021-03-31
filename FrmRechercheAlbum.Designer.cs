namespace ZiknCo_MoteurRechercheDeezer_V2
{
    partial class FrmRechercheAlbum
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
            this.btnRecherches = new System.Windows.Forms.Button();
            this.txtBoxRecherche = new System.Windows.Forms.TextBox();
            this.lblARecherche = new System.Windows.Forms.Label();
            this.GBRechercheAlbum = new System.Windows.Forms.GroupBox();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLienDeezer = new System.Windows.Forms.LinkLabel();
            this.lblTitreAlbum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.GBRechercheAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecherches
            // 
            this.btnRecherches.Location = new System.Drawing.Point(344, 39);
            this.btnRecherches.Name = "btnRecherches";
            this.btnRecherches.Size = new System.Drawing.Size(75, 23);
            this.btnRecherches.TabIndex = 0;
            this.btnRecherches.Text = "Go !";
            this.btnRecherches.UseVisualStyleBackColor = true;
            this.btnRecherches.Click += new System.EventHandler(this.BtnRecherches_Click);
            // 
            // txtBoxRecherche
            // 
            this.txtBoxRecherche.Location = new System.Drawing.Point(172, 39);
            this.txtBoxRecherche.Name = "txtBoxRecherche";
            this.txtBoxRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRecherche.TabIndex = 1;
            this.txtBoxRecherche.TextChanged += new System.EventHandler(this.TxtBoxRecherche_TextChanged);
            // 
            // lblARecherche
            // 
            this.lblARecherche.AutoSize = true;
            this.lblARecherche.Location = new System.Drawing.Point(39, 46);
            this.lblARecherche.Name = "lblARecherche";
            this.lblARecherche.Size = new System.Drawing.Size(87, 13);
            this.lblARecherche.TabIndex = 2;
            this.lblARecherche.Text = "Album recherché";
            // 
            // GBRechercheAlbum
            // 
            this.GBRechercheAlbum.Controls.Add(this.lstTitres);
            this.GBRechercheAlbum.Controls.Add(this.lstAlbums);
            this.GBRechercheAlbum.Controls.Add(this.lblArtiste);
            this.GBRechercheAlbum.Controls.Add(this.pictureBox2);
            this.GBRechercheAlbum.Controls.Add(this.pictureBox1);
            this.GBRechercheAlbum.Controls.Add(this.lblLienDeezer);
            this.GBRechercheAlbum.Controls.Add(this.lblTitreAlbum);
            this.GBRechercheAlbum.Controls.Add(this.label2);
            this.GBRechercheAlbum.Controls.Add(this.lblAlbums);
            this.GBRechercheAlbum.Location = new System.Drawing.Point(42, 94);
            this.GBRechercheAlbum.Name = "GBRechercheAlbum";
            this.GBRechercheAlbum.Size = new System.Drawing.Size(733, 344);
            this.GBRechercheAlbum.TabIndex = 3;
            this.GBRechercheAlbum.TabStop = false;
            this.GBRechercheAlbum.Text = "Informations DEEZER";
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(41, 218);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(251, 95);
            this.lstTitres.TabIndex = 8;
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(32, 72);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(260, 95);
            this.lstAlbums.TabIndex = 7;
            // 
            // lblArtiste
            // 
            this.lblArtiste.AutoSize = true;
            this.lblArtiste.Location = new System.Drawing.Point(559, 50);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(35, 13);
            this.lblArtiste.TabIndex = 6;
            this.lblArtiste.Text = "label1";
            this.lblArtiste.Click += new System.EventHandler(this.LblArtiste_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(562, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 58);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(399, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 84);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblLienDeezer
            // 
            this.lblLienDeezer.AutoSize = true;
            this.lblLienDeezer.Location = new System.Drawing.Point(407, 169);
            this.lblLienDeezer.Name = "lblLienDeezer";
            this.lblLienDeezer.Size = new System.Drawing.Size(106, 13);
            this.lblLienDeezer.TabIndex = 3;
            this.lblLienDeezer.TabStop = true;
            this.lblLienDeezer.Text = "http://www.deezer.fr";
            // 
            // lblTitreAlbum
            // 
            this.lblTitreAlbum.AutoSize = true;
            this.lblTitreAlbum.Location = new System.Drawing.Point(396, 50);
            this.lblTitreAlbum.Name = "lblTitreAlbum";
            this.lblTitreAlbum.Size = new System.Drawing.Size(10, 13);
            this.lblTitreAlbum.TabIndex = 2;
            this.lblTitreAlbum.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titres de l\'album :";
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(38, 50);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(85, 13);
            this.lblAlbums.TabIndex = 0;
            this.lblAlbums.Text = "Albums trouvés :";
            // 
            // FrmRechercheAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBRechercheAlbum);
            this.Controls.Add(this.lblARecherche);
            this.Controls.Add(this.txtBoxRecherche);
            this.Controls.Add(this.btnRecherches);
            this.Name = "FrmRechercheAlbum";
            this.Text = "Recherche d\'Albums";
            this.GBRechercheAlbum.ResumeLayout(false);
            this.GBRechercheAlbum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecherches;
        private System.Windows.Forms.TextBox txtBoxRecherche;
        private System.Windows.Forms.Label lblARecherche;
        private System.Windows.Forms.GroupBox GBRechercheAlbum;
        private System.Windows.Forms.Label lblArtiste;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblLienDeezer;
        private System.Windows.Forms.Label lblTitreAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.ListBox lstAlbums;
    }
}