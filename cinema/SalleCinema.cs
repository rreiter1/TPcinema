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

    }
}
