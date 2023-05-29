namespace ChopesGames
{
    partial class FormModifierProduits
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
            this.lbProduits = new System.Windows.Forms.ListBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.tbxLibelle = new System.Windows.Forms.TextBox();
            this.tbxDetail = new System.Windows.Forms.TextBox();
            this.tbxPrixHT = new System.Windows.Forms.TextBox();
            this.tbxTauxTVA = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblTauxTVA = new System.Windows.Forms.Label();
            this.cbxDisponibiliteOui = new System.Windows.Forms.CheckBox();
            this.cbxDisponibiliteNon = new System.Windows.Forms.CheckBox();
            this.lblDisponibilite = new System.Windows.Forms.Label();
            this.nudQuantiteEnStock = new System.Windows.Forms.NumericUpDown();
            this.lblQuantiteEnStock = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantiteEnStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProduits
            // 
            this.lbProduits.FormattingEnabled = true;
            this.lbProduits.Location = new System.Drawing.Point(0, 0);
            this.lbProduits.Name = "lbProduits";
            this.lbProduits.Size = new System.Drawing.Size(267, 446);
            this.lbProduits.TabIndex = 0;
            this.lbProduits.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(375, 39);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(147, 21);
            this.cmbCategorie.TabIndex = 7;
            // 
            // cmbMarque
            // 
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.Location = new System.Drawing.Point(375, 74);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.Size = new System.Drawing.Size(147, 21);
            this.cmbMarque.TabIndex = 8;
            // 
            // tbxLibelle
            // 
            this.tbxLibelle.Location = new System.Drawing.Point(375, 114);
            this.tbxLibelle.Name = "tbxLibelle";
            this.tbxLibelle.Size = new System.Drawing.Size(147, 20);
            this.tbxLibelle.TabIndex = 9;
            // 
            // tbxDetail
            // 
            this.tbxDetail.Location = new System.Drawing.Point(375, 150);
            this.tbxDetail.Multiline = true;
            this.tbxDetail.Name = "tbxDetail";
            this.tbxDetail.Size = new System.Drawing.Size(147, 116);
            this.tbxDetail.TabIndex = 10;
            // 
            // tbxPrixHT
            // 
            this.tbxPrixHT.Location = new System.Drawing.Point(375, 302);
            this.tbxPrixHT.Name = "tbxPrixHT";
            this.tbxPrixHT.Size = new System.Drawing.Size(147, 20);
            this.tbxPrixHT.TabIndex = 11;
            this.tbxPrixHT.TextChanged += new System.EventHandler(this.tbxPrixHT_TextChanged);
            // 
            // tbxTauxTVA
            // 
            this.tbxTauxTVA.Location = new System.Drawing.Point(375, 337);
            this.tbxTauxTVA.Name = "tbxTauxTVA";
            this.tbxTauxTVA.Size = new System.Drawing.Size(147, 20);
            this.tbxTauxTVA.TabIndex = 12;
            this.tbxTauxTVA.TextChanged += new System.EventHandler(this.tbxTauxTVA_TextChanged_1);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(317, 42);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 14;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(326, 77);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 15;
            this.lblMarque.Text = "Marque";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(332, 117);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(37, 13);
            this.lblLibelle.TabIndex = 16;
            this.lblLibelle.Text = "Libellé";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(335, 153);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 17;
            this.lblDetail.Text = "Détail";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(327, 309);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(42, 13);
            this.lblPrixHT.TabIndex = 18;
            this.lblPrixHT.Text = "Prix HT";
            // 
            // lblTauxTVA
            // 
            this.lblTauxTVA.AutoSize = true;
            this.lblTauxTVA.Location = new System.Drawing.Point(314, 344);
            this.lblTauxTVA.Name = "lblTauxTVA";
            this.lblTauxTVA.Size = new System.Drawing.Size(55, 13);
            this.lblTauxTVA.TabIndex = 19;
            this.lblTauxTVA.Text = "Taux TVA";
            // 
            // cbxDisponibiliteOui
            // 
            this.cbxDisponibiliteOui.AutoSize = true;
            this.cbxDisponibiliteOui.Location = new System.Drawing.Point(375, 373);
            this.cbxDisponibiliteOui.Name = "cbxDisponibiliteOui";
            this.cbxDisponibiliteOui.Size = new System.Drawing.Size(42, 17);
            this.cbxDisponibiliteOui.TabIndex = 22;
            this.cbxDisponibiliteOui.Text = "Oui";
            this.cbxDisponibiliteOui.UseVisualStyleBackColor = true;
            // 
            // cbxDisponibiliteNon
            // 
            this.cbxDisponibiliteNon.AutoSize = true;
            this.cbxDisponibiliteNon.Location = new System.Drawing.Point(476, 373);
            this.cbxDisponibiliteNon.Name = "cbxDisponibiliteNon";
            this.cbxDisponibiliteNon.Size = new System.Drawing.Size(46, 17);
            this.cbxDisponibiliteNon.TabIndex = 23;
            this.cbxDisponibiliteNon.Text = "Non";
            this.cbxDisponibiliteNon.UseVisualStyleBackColor = true;
            // 
            // lblDisponibilite
            // 
            this.lblDisponibilite.AutoSize = true;
            this.lblDisponibilite.Location = new System.Drawing.Point(306, 373);
            this.lblDisponibilite.Name = "lblDisponibilite";
            this.lblDisponibilite.Size = new System.Drawing.Size(63, 13);
            this.lblDisponibilite.TabIndex = 25;
            this.lblDisponibilite.Text = "Disponibilité";
            // 
            // nudQuantiteEnStock
            // 
            this.nudQuantiteEnStock.Location = new System.Drawing.Point(375, 272);
            this.nudQuantiteEnStock.Name = "nudQuantiteEnStock";
            this.nudQuantiteEnStock.Size = new System.Drawing.Size(147, 20);
            this.nudQuantiteEnStock.TabIndex = 26;
            // 
            // lblQuantiteEnStock
            // 
            this.lblQuantiteEnStock.AutoSize = true;
            this.lblQuantiteEnStock.Location = new System.Drawing.Point(275, 279);
            this.lblQuantiteEnStock.Name = "lblQuantiteEnStock";
            this.lblQuantiteEnStock.Size = new System.Drawing.Size(94, 13);
            this.lblQuantiteEnStock.TabIndex = 27;
            this.lblQuantiteEnStock.Text = "Quantité En Stock";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(401, 412);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(121, 23);
            this.btnValider.TabIndex = 28;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // FormModifierProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 447);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblQuantiteEnStock);
            this.Controls.Add(this.nudQuantiteEnStock);
            this.Controls.Add(this.lblDisponibilite);
            this.Controls.Add(this.cbxDisponibiliteNon);
            this.Controls.Add(this.cbxDisponibiliteOui);
            this.Controls.Add(this.lblTauxTVA);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.tbxTauxTVA);
            this.Controls.Add(this.tbxPrixHT);
            this.Controls.Add(this.tbxDetail);
            this.Controls.Add(this.tbxLibelle);
            this.Controls.Add(this.cmbMarque);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.lbProduits);
            this.Name = "FormModifierProduits";
            this.Text = "Modifier Produits";
            this.Load += new System.EventHandler(this.FormModifierProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantiteEnStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProduits;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbMarque;
        private System.Windows.Forms.TextBox tbxLibelle;
        private System.Windows.Forms.TextBox tbxDetail;
        private System.Windows.Forms.TextBox tbxPrixHT;
        private System.Windows.Forms.TextBox tbxTauxTVA;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblTauxTVA;
        private System.Windows.Forms.CheckBox cbxDisponibiliteOui;
        private System.Windows.Forms.CheckBox cbxDisponibiliteNon;
        private System.Windows.Forms.Label lblDisponibilite;
        private System.Windows.Forms.NumericUpDown nudQuantiteEnStock;
        private System.Windows.Forms.Label lblQuantiteEnStock;
        private System.Windows.Forms.Button btnValider;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
    }
}