using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValentinMarie;
namespace ZiknCo_MoteurRechercheDeezer_V2
{
    partial class FrmPlaylist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnDroite = new System.Windows.Forms.Button();
            this.btnTousDroite = new System.Windows.Forms.Button();
            this.btnUnGauche = new System.Windows.Forms.Button();
            this.btnTousGauche = new System.Windows.Forms.Button();
            this.btnJouerExtraits = new System.Windows.Forms.Button();
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morceaux de l\'album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morceaux choisis (playlist)";
            // 
            // btnUnDroite
            // 
            this.btnUnDroite.Location = new System.Drawing.Point(314, 83);
            this.btnUnDroite.Name = "btnUnDroite";
            this.btnUnDroite.Size = new System.Drawing.Size(75, 23);
            this.btnUnDroite.TabIndex = 2;
            this.btnUnDroite.Text = ">Un";
            this.btnUnDroite.UseVisualStyleBackColor = true;
            this.btnUnDroite.Click += new System.EventHandler(this.BtnUnDroite_Click);
            // 
            // btnTousDroite
            // 
            this.btnTousDroite.Location = new System.Drawing.Point(314, 112);
            this.btnTousDroite.Name = "btnTousDroite";
            this.btnTousDroite.Size = new System.Drawing.Size(75, 23);
            this.btnTousDroite.TabIndex = 3;
            this.btnTousDroite.Text = ">>Tous";
            this.btnTousDroite.UseVisualStyleBackColor = true;
            this.btnTousDroite.Click += new System.EventHandler(this.BtnTousDroite_Click);
            // 
            // btnUnGauche
            // 
            this.btnUnGauche.Location = new System.Drawing.Point(314, 217);
            this.btnUnGauche.Name = "btnUnGauche";
            this.btnUnGauche.Size = new System.Drawing.Size(75, 23);
            this.btnUnGauche.TabIndex = 4;
            this.btnUnGauche.Text = "<Un";
            this.btnUnGauche.UseVisualStyleBackColor = true;
            this.btnUnGauche.Click += new System.EventHandler(this.BtnUnGauche_Click);
            // 
            // btnTousGauche
            // 
            this.btnTousGauche.Location = new System.Drawing.Point(314, 246);
            this.btnTousGauche.Name = "btnTousGauche";
            this.btnTousGauche.Size = new System.Drawing.Size(75, 23);
            this.btnTousGauche.TabIndex = 5;
            this.btnTousGauche.Text = "<<Tous";
            this.btnTousGauche.UseVisualStyleBackColor = true;
            this.btnTousGauche.Click += new System.EventHandler(this.BtnTousGauche_Click);
            // 
            // btnJouerExtraits
            // 
            this.btnJouerExtraits.Location = new System.Drawing.Point(438, 308);
            this.btnJouerExtraits.Name = "btnJouerExtraits";
            this.btnJouerExtraits.Size = new System.Drawing.Size(212, 38);
            this.btnJouerExtraits.TabIndex = 6;
            this.btnJouerExtraits.Text = "Jouer les extraits ...";
            this.btnJouerExtraits.UseVisualStyleBackColor = true;
            this.btnJouerExtraits.Click += new System.EventHandler(this.BtnJouerExtraits_Click);
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(43, 83);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(250, 186);
            this.lstGauche.TabIndex = 7;
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(438, 83);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(230, 186);
            this.lstDroite.TabIndex = 8;
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 379);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Controls.Add(this.btnJouerExtraits);
            this.Controls.Add(this.btnTousGauche);
            this.Controls.Add(this.btnUnGauche);
            this.Controls.Add(this.btnTousDroite);
            this.Controls.Add(this.btnUnDroite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des extraits de l\'album ...";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnDroite;
        private System.Windows.Forms.Button btnTousDroite;
        private System.Windows.Forms.Button btnUnGauche;
        private System.Windows.Forms.Button btnTousGauche;
        private System.Windows.Forms.Button btnJouerExtraits;
        private ListBox lstDroite;
        public ListBox lstGauche;
    }
}