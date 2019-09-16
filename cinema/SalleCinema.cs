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
        private int numeroSalle;

        public SalleCinema(string t, int nbP, double prix, int numSalle)
        {
            this.titre = t;
            this.nbPlaces = nbP;
            this.prixUnormal = prix;
            this.nbPlacesSelln = 0;
            this.nbPlacesSellr = 0;
            this.numeroSalle = numSalle;
        }
        public int getNumSalle()
        {
            return this.numeroSalle;
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
            return "Film Joué : " + this.titre + ",\nNombre de Place : " + this.nbPlaces + ",\nPrix d'une Place : " + this.prixUnormal + "€,\n" + this.nbPlacesSelln + " places vendues au tarif normal,\n"+ this.nbPlacesSellr + " places vendues au tarif réduit.";        }
    }
}
