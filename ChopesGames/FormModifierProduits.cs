using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChopesGames
{
    public partial class FormModifierProduits : Form
    {
        private MySqlConnection maCnx;
        private Regex regexPrixHTTauxTVA = new Regex(@"^-?(?:\d+|\d{1,3}(?:,\d{3})+)(?:(\.|,)\d+)?$");
        private bool prixHTEstValide, tauxTVAEstValide; // controle

        public FormModifierProduits()
        {
            InitializeComponent();
            maCnx = new MySqlConnection("SERVER=127.0.0.1; DATABASE=ppe_chopesgames; UID=root; PASSWORD=;");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void lbProduits_DoubleClick(object sender, EventArgs e)
        {
            Produit produitSelectionné = (Produit)this.lbProduits.SelectedItem;
            foreach (Categorie categorie in cmbCategorie.Items)
            {
                if (categorie.GetNoCategorie() == produitSelectionné.GetNoCategorie())
                {
                    cmbCategorie.SelectedItem = categorie;
                }
            }
            foreach (Marque marque in cmbMarque.Items)
            {
                if (marque.GetNoMarque() == produitSelectionné.GetNoMarque())
                {
                    cmbMarque.SelectedItem = marque;
                }
            }
            tbxLibelle.Text = produitSelectionné.GetLibelle();
            tbxDetail.Text = produitSelectionné.GetDetail();
            tbxPrixHT.Text = produitSelectionné.GetPrixHT().ToString();
            tbxTauxTVA.Text = produitSelectionné.GetTauxTVA().ToString();
            nudQuantiteEnStock.Value = produitSelectionné.GetQuantite();
            if (produitSelectionné.GetDisponibilite()) 
            {
                cbxDisponibiliteNon.Checked = false;
                cbxDisponibiliteOui.Checked = true;
            }
            else
            {
                cbxDisponibiliteNon.Checked = true;
                cbxDisponibiliteOui.Checked = false;
            }
        }

        private void FormModifierProduits_Load(object sender, EventArgs e)
        {
            try
            {
                string requête;
                int noCategorie;
                string libelle;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    libelle = jeuEnr.GetString("LIBELLE");
                    cmbCategorie.Items.Add(new Categorie(noCategorie, libelle));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement catégories : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

            // Chargement des marques dans cmbMarque
            try
            {
                string requête;
                int noMarque;
                string nom;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Marque";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    nom = jeuEnr.GetString("NOM");
                    cmbMarque.Items.Add(new Marque(noMarque, nom));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement marques : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            try
            {
                string requête;
                int noProduit, noCategorie, noMarque, quantiteEnStock;
                bool disponibilite;
                string libelle, detail;
                double prixHT, tauxTVA;
                MySqlDataReader jeuEnr = null;
                maCnx.Open(); // on se connecte
                requête = "Select * from Produit";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    noProduit = jeuEnr.GetInt32("NOPRODUIT");
                    noCategorie = jeuEnr.GetInt32("NOCATEGORIE");
                    noMarque = jeuEnr.GetInt32("NOMARQUE");
                    quantiteEnStock = jeuEnr.GetInt32("QUANTITEENSTOCK");
                    libelle = jeuEnr.GetString("LIBELLE");
                    detail = jeuEnr.GetString("DETAIL");
                    prixHT = jeuEnr.GetDouble("PRIXHT");
                    tauxTVA = jeuEnr.GetDouble("TAUXTVA");
                    disponibilite = jeuEnr.GetBoolean("DISPONIBLE");
                    lbProduits.Items.Add(new Produit(noProduit, noCategorie, noMarque, quantiteEnStock, libelle, detail, prixHT, tauxTVA, disponibilite));
                }
            }
            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur chargement produits : " + erreur.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
            lbProduits.DoubleClick += new EventHandler(lbProduits_DoubleClick);
        }

        private void tbxPrixHT_TextChanged(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxPrixHT.Text).Success & tbxPrixHT.Text != "")
            {
                prixHTEstValide = true;
                tbxPrixHT.BackColor = SystemColors.Window;
            }
            else
            {
                tbxPrixHT.BackColor = Color.Red;
                prixHTEstValide = false;
            }
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            if (cmbCategorie.SelectedItem is object && cmbMarque.SelectedItem is object && prixHTEstValide && tauxTVAEstValide)
            {
                try
                {
                    string requete;
                    int noProduit = ((Produit)(lbProduits.SelectedItem)).GetNoProduit();
                    maCnx.Open(); // on se connecte
                    requete = "UPDATE produit SET NOCATEGORIE = @noCategorie," +
                                                 "NOMARQUE = @noMarque," +
                                                 "LIBELLE = @libelle," +
                                                 "DETAIL = @detail," +
                                                 "PRIXHT = @prixHT," +
                                                 "TAUXTVA = @tauxTVA," +
                                                 "QUANTITEENSTOCK = @quantiteenstock," +
                                                 "DISPONIBLE = @disponible" +
                              " WHERE NOPRODUIT = " + noProduit + ";";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Prepare();
                    int noCategorie = ((Categorie)(cmbCategorie.SelectedItem)).GetNoCategorie();
                    int noMarque = ((Marque)(cmbMarque.SelectedItem)).GetNoMarque();
                    maCde.Parameters.AddWithValue("@noCategorie", noCategorie);
                    maCde.Parameters.AddWithValue("@noMarque", noMarque);
                    maCde.Parameters.AddWithValue("@libelle", tbxLibelle.Text);
                    maCde.Parameters.AddWithValue("@detail", tbxDetail.Text);
                    maCde.Parameters.AddWithValue("@prixHT", tbxPrixHT.Text);
                    maCde.Parameters.AddWithValue("@tauxTVA", tbxTauxTVA.Text);
                    maCde.Parameters.AddWithValue("@quantiteenstock", nudQuantiteEnStock.Value);
                    if (cbxDisponibiliteOui.Checked == true)
                    {
                        maCde.Parameters.AddWithValue("@disponible", 1);
                    }
                    else
                    {
                        maCde.Parameters.AddWithValue("@disponible", 0);
                    }
                    int nbLigneAffectées = maCde.ExecuteNonQuery();
                    MessageBox.Show(nbLigneAffectées.ToString() + " produit modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException erreur)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + erreur.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (maCnx is object & maCnx.State == ConnectionState.Open)
                    {
                        maCnx.Close(); // on se déconnecte
                    }
                } // try
            }
            else
            {
                MessageBox.Show("Saisie incomplète ou incorrecte.", "Erreur : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxTauxTVA_TextChanged_1(object sender, EventArgs e)
        {
            if (regexPrixHTTauxTVA.Match(tbxTauxTVA.Text).Success & tbxTauxTVA.Text != "")
            {
                tauxTVAEstValide = true;
                tbxTauxTVA.BackColor = SystemColors.Window;
            }
            else
            {
                tbxTauxTVA.BackColor = Color.Red;
                tauxTVAEstValide = false;
            }
        }
    }
}
