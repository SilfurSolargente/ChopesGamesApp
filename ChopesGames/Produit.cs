using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopesGames
{
    class Produit
    {
        // NOPRODUIT, QUANTITEENSTOCK, LIBELLE, DETAIL, NOMIMAGE, PRIXHT, TAUXTVA, DISPONIBLE, VITRINE, DATEAJOUT
        private int noProduit, noCategorie, noMarque, quantiteEnStock;
        private string libelle, detail;
        private double prixHT, tauxTVA;
        bool disponibilite;

        public Produit(int noProduit, int noCategorie, int noMarque, int quantiteEnStock, string libelle, string detail, double prixHT, double tauxTVA, bool disponibilite)
        {
            this.noProduit = noProduit;
            this.noCategorie = noCategorie;
            this.noMarque = noMarque;
            this.quantiteEnStock = quantiteEnStock;
            this.libelle = libelle;
            this.detail = detail;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
            this.disponibilite = disponibilite;
        }
        public int GetNoProduit()
        {
            return noProduit;
        }
        public int GetNoCategorie()
        {
            return noCategorie;
        }
        public int GetNoMarque()
        {
            return noMarque;
        }
        public int GetQuantite()
        {
            return quantiteEnStock;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public string GetDetail()
        {
            return detail;
        }
        public double GetPrixHT()
        {
            return prixHT;
        }
        public double GetTauxTVA()
        {
            return tauxTVA;
        }
        public bool GetDisponibilite()
        {
            return disponibilite;
        }
        public override string ToString()
        {
            return noProduit.ToString() + " - " + libelle + " - " + prixHT.ToString();
        }
    }
}
