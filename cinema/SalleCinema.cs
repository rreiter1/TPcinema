using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class SalleCinema
    {
        private string titre;
        private int nbPlaces;
        private double prixUnormal;
        private int nbPlacesSelln;
        private int nbPlacesSellr;


        public SalleCinema(string t, int nbP, double prix)
        {
            this.titre = t;
            this.nbPlaces = nbP;
            this.prixUnormal = prix;
            this.nbPlacesSelln = 0;
            this.nbPlacesSellr = 0;
        }
        public int nbPlacesDisponibles()
        {
            return this.nbPlaces - (this.nbPlacesSelln + this.nbPlacesSellr);
        }
        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            if ((this.nbPlacesDisponibles() - nbre) >= 0)
            {
                string textPrixaPayer;
                if(tarifReduit)
                {
                    this.nbPlacesSellr += nbre;
                    textPrixaPayer = "Le Prix a Payer est de "+((this.prixUnormal*0.8)*nbre);
                }
                else
                {
                    this.nbPlacesSelln += nbre;
                    textPrixaPayer = "Le prix a Payer est de " + (this.prixUnormal * nbre);
                }
            }
            else
            {
                string rejet = "Nous ne disposont pas assez de place pour tous ces gens nous avont "+ this.nbPlacesDisponibles() + " de disponible";
            }
        }        public void remiseAZero()
        {
            this.nbPlacesSelln = 0;
            this.nbPlacesSellr = 0;
        }        public double chiffreAffaires()
        {
            return ((this.prixUnormal * 0.8) * this.nbPlacesSellr) + (this.prixUnormal * this.nbPlacesSelln);
        }        public double tauxRemplissage()
        {
            int nbplaceVendu = (nbPlacesSelln + nbPlacesSellr);
            return nbplaceVendu / this.nbPlaces * 100;
        }        public String toString()
        {
            return "Pour une salle de " + this.nbPlaces + " places jouant le film '" + this.titre + "' dont " + this.nbPlacesSelln + " places ont été vendues au tarif normal" + this.prixUnormal+ " et " + this.nbPlacesSellr + " places ont été vendues au tarif réduit";        }
    }
}
