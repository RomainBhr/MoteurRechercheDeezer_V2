using System;

namespace ZiknCo_MoteurRechercheDeezer_V2
{
    partial class FrmDemarrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recherchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.picIpod = new System.Windows.Forms.PictureBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tbpDiscographie = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpLecteurDisco = new AxWMPLib.AxWindowsMediaPlayer();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTracks = new System.Windows.Forms.ListBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picDisco = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.notifyIconEtat = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tbpDiscographie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteurDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            this.contextMenuStripNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.recherchesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimédiaToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // lecteurMultimédiaToolStripMenuItem
            // 
            this.lecteurMultimédiaToolStripMenuItem.Name = "lecteurMultimédiaToolStripMenuItem";
            this.lecteurMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimédiaToolStripMenuItem.Text = "&Lecteur Multimédia";
            this.lecteurMultimédiaToolStripMenuItem.Click += new System.EventHandler(this.LecteurMultimédiaToolStripMenuItem_Click);
            // 
            // recherchesToolStripMenuItem
            // 
            this.recherchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheAlbumsToolStripMenuItem});
            this.recherchesToolStripMenuItem.Name = "recherchesToolStripMenuItem";
            this.recherchesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recherchesToolStripMenuItem.Text = "&Recherches";
            // 
            // rechercheAlbumsToolStripMenuItem
            // 
            this.rechercheAlbumsToolStripMenuItem.Name = "rechercheAlbumsToolStripMenuItem";
            this.rechercheAlbumsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rechercheAlbumsToolStripMenuItem.Text = "Recherche Albums";
            this.rechercheAlbumsToolStripMenuItem.Click += new System.EventHandler(this.RechercheAlbumsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aproposToolStripMenuItem
            // 
            this.aproposToolStripMenuItem.Name = "aproposToolStripMenuItem";
            this.aproposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aproposToolStripMenuItem.Text = "A &propos...";
            this.aproposToolStripMenuItem.Click += new System.EventHandler(this.AproposToolStripMenuItem_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(13, 143);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(93, 13);
            this.lblArtisteRecherche.TabIndex = 3;
            this.lblArtisteRecherche.Text = "Artiste recherché :";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(112, 140);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(148, 20);
            this.txtArtisteRecherche.TabIndex = 4;
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(276, 138);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tbpDiscographie);
            this.tbc.Location = new System.Drawing.Point(16, 195);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(576, 224);
            this.tbc.TabIndex = 6;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(568, 198);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.picIpod);
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.label1);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Location = new System.Drawing.Point(6, 9);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(556, 186);
            this.grbArtisteInfos.TabIndex = 7;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Informations DEEZER";
            this.grbArtisteInfos.Visible = false;
            // 
            // picIpod
            // 
            this.picIpod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIpod.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.ipod;
            this.picIpod.Location = new System.Drawing.Point(172, 141);
            this.picIpod.Name = "picIpod";
            this.picIpod.Size = new System.Drawing.Size(62, 39);
            this.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIpod.TabIndex = 8;
            this.picIpod.TabStop = false;
            this.picIpod.Click += new System.EventHandler(this.PicIpod_Click);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.Enabled = false;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(7, 141);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(159, 45);
            this.btnEcouterExtraits.TabIndex = 7;
            this.btnEcouterExtraits.Text = "&Ecouter tous les extraits musicaux...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.BtnEcouterExtraits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Artiste trouvés : ";
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(6, 40);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(228, 95);
            this.lstArtistes.TabIndex = 5;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.LstArtistes_SelectedIndexChanged);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(333, 170);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(74, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien DEEZER";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklDeezerLien_LinkClicked);
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(311, 16);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(54, 24);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "Nom";
            // 
            // picArtiste
            // 
            this.picArtiste.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.photo_inconnu;
            this.picArtiste.Location = new System.Drawing.Point(316, 43);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(109, 124);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // tbpDiscographie
            // 
            this.tbpDiscographie.Controls.Add(this.panel1);
            this.tbpDiscographie.Location = new System.Drawing.Point(4, 22);
            this.tbpDiscographie.Name = "tbpDiscographie";
            this.tbpDiscographie.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiscographie.Size = new System.Drawing.Size(568, 198);
            this.tbpDiscographie.TabIndex = 1;
            this.tbpDiscographie.Text = "Discographie";
            this.tbpDiscographie.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wmpLecteurDisco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lstTracks);
            this.panel1.Controls.Add(this.lstAlbums);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picDisco);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 186);
            this.panel1.TabIndex = 0;
            // 
            // wmpLecteurDisco
            // 
            this.wmpLecteurDisco.Enabled = true;
            this.wmpLecteurDisco.Location = new System.Drawing.Point(39, 129);
            this.wmpLecteurDisco.Name = "wmpLecteurDisco";
            this.wmpLecteurDisco.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteurDisco.OcxState")));
            this.wmpLecteurDisco.Size = new System.Drawing.Size(495, 44);
            this.wmpLecteurDisco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titres :";
            // 
            // lstTracks
            // 
            this.lstTracks.FormattingEnabled = true;
            this.lstTracks.Location = new System.Drawing.Point(331, 22);
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(220, 95);
            this.lstTracks.TabIndex = 3;
            this.lstTracks.Click += new System.EventHandler(this.LstTracks_Click);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(119, 22);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(206, 95);
            this.lstAlbums.TabIndex = 2;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.LstAlbums_SelectedIndexChanged);
            this.lstAlbums.DoubleClick += new System.EventHandler(this.LstAlbums_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Albums :";
            // 
            // picDisco
            // 
            this.picDisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDisco.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.photo_inconnu;
            this.picDisco.Location = new System.Drawing.Point(14, 9);
            this.picDisco.Name = "picDisco";
            this.picDisco.Size = new System.Drawing.Size(91, 115);
            this.picDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisco.TabIndex = 0;
            this.picDisco.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(112, 167);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // picDeezer
            // 
            this.picDeezer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeezer.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.deezer;
            this.picDeezer.Location = new System.Drawing.Point(468, 136);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(119, 53);
            this.picDeezer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDeezer.TabIndex = 2;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.PicDeezer_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.banniere_ZiKnCo;
            this.picBanniere.Location = new System.Drawing.Point(12, 39);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(575, 65);
            this.picBanniere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBanniere.TabIndex = 1;
            this.picBanniere.TabStop = false;
            // 
            // notifyIconEtat
            // 
            this.notifyIconEtat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEtat.Icon")));
            this.notifyIconEtat.Text = "Zik\'nCo - Moteur de recherche DEEZER";
            this.notifyIconEtat.Visible = true;
            this.notifyIconEtat.BalloonTipShown += new System.EventHandler(this.NotifyIconEtat_BalloonTipShown);
            // 
            // contextMenuStripNotifications
            // 
            this.contextMenuStripNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.masquerToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.contextMenuStripNotifications.Name = "contextMenuStripNotifications";
            this.contextMenuStripNotifications.Size = new System.Drawing.Size(166, 70);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // masquerToolStripMenuItem
            // 
            this.masquerToolStripMenuItem.Image = global::ZiknCo_MoteurRechercheDeezer_V2.Properties.Resources.MasqueZ;
            this.masquerToolStripMenuItem.Name = "masquerToolStripMenuItem";
            this.masquerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+M";
            this.masquerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masquerToolStripMenuItem.Text = "Masquer";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem1.Image")));
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+F4";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.QuitterToolStripMenuItem1_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmDemarrage";
            this.ShowIcon = false;
            this.Text = "Moteur de recherche DEEZER : Version 5";
            this.Activated += new System.EventHandler(this.FrmDemarrage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tbpDiscographie.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteurDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            this.contextMenuStripNotifications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aproposToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.ToolStripMenuItem recherchesToolStripMenuItem;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TabPage tbpDiscographie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picDisco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTracks;
        private System.Windows.Forms.ListBox lstAlbums;
        public AxWMPLib.AxWindowsMediaPlayer wmpLecteurDisco;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem rechercheAlbumsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIpod;
        private System.Windows.Forms.NotifyIcon notifyIconEtat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifications;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masquerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}