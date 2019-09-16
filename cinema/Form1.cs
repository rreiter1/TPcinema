using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form1 : Form
    {
        private List<SalleCinema> LesSalles;
        private int numSalleSaisie;
        public Form1()
        {
            InitializeComponent();
            SalleCinema uneSalle = new SalleCinema("LeFilme", 80, 1.99,1);
            SalleCinema deuxSalle = new SalleCinema("LaCodeuse", 20, 0.99,2);
            SalleCinema troisSalle = new SalleCinema("LesCodeure", 120, 2.99,3);
            SalleCinema quatreSalle = new SalleCinema("toto", 45, 8.49,4);
            SalleCinema cinqSalle = new SalleCinema("Laclef", 354, 4.99,5);
            SalleCinema sixSalle = new SalleCinema("LaChose", 10, 10.99,6);
            SalleCinema septSalle = new SalleCinema("LaTomate", 1, 1.99,7);
            LesSalles = new List<SalleCinema>();
            LesSalles.Add(uneSalle);
            LesSalles.Add(deuxSalle);
            LesSalles.Add(troisSalle);
            LesSalles.Add(quatreSalle);
            LesSalles.Add(cinqSalle);
            LesSalles.Add(sixSalle);
            LesSalles.Add(septSalle);
        }

        private void B_Cherche_salle_Click(object sender, EventArgs e)
        {
            if(tb_Cherch_Salle.Text != "")
            {
                foreach(SalleCinema LaSalle in LesSalles)
                {
                    if(LaSalle.getNumSalle()==Convert.ToInt32(tb_Cherch_Salle.Text))
                    {
                        numSalleSaisie = Convert.ToInt32(tb_Cherch_Salle.Text);
                        L_Affiche_info_Sall.Text = LaSalle.toString();
                        L_Affiche_info_Sall.Visible = true;
                        L_saisie_nbPerso.Visible = true;
                        tb_nb_Personne.Visible = true;
                        ck_tarifred.Visible = true;
                        Valider_Add_Personne.Visible = true;
                        break;
                    }
                }
            }
        }
        private void Valider_Add_Personne_Click(object sender, EventArgs e)
        {
            if(tb_nb_Personne.Text != "")
            {
                foreach (SalleCinema LaSalle in LesSalles)
                {
                    if (LaSalle.getNumSalle() == numSalleSaisie)
                    {
                        if(LaSalle.nbPlacesDisponibles()==)

                        L_Affiche_info_Sall.Text = LaSalle.toString();
                        break;
                    }
                }
            }
        }
    }
}
