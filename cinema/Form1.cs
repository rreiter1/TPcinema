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

        public void InfoALLsalle()
        {
            string text = "";
            double chiffreaffaire = 0;
            foreach (SalleCinema LaSalle in LesSalles)
            {
                text += "\n\n\nVoici les informations pour la Salle n° " + LaSalle.getNumSalle() + "\n";
                text += LaSalle.toString();
                text += "\n La Salle est occuper a " + LaSalle.tauxRemplissage() + " et obtien un chiffre d'affaire de " + LaSalle.chiffreAffaires();
                chiffreaffaire += LaSalle.chiffreAffaires();                    
            }
            text += "\n\n\nLe Chiffre d'affaire total est de " + chiffreaffaire;
            Lb_All_salle.Text = text;

        }

        public Form1()
        {
            InitializeComponent();
            SalleCinema uneSalle = new SalleCinema("LeFilme", 80, 1.99,1);
            SalleCinema deuxSalle = new SalleCinema("LaCodeuse", 20, 0.99,2);
            SalleCinema troisSalle = new SalleCinema("LesCodeure", 120, 2.99,3);
            LesSalles = new List<SalleCinema>();
            LesSalles.Add(uneSalle);
            LesSalles.Add(deuxSalle);
            LesSalles.Add(troisSalle);
            InfoALLsalle();
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
                        L_numSalle.Text = "Voici les caracteristique de la salle n°"+numSalleSaisie;
                        L_Affiche_info_Sall.Text = LaSalle.toString();
                        L_numSalle.Visible = true;
                        L_Affiche_info_Sall.Visible = true;
                        L_saisie_nbPerso.Visible = true;
                        tb_nb_Personne.Visible = true;
                        ck_tarifred.Visible = true;
                        Valider_Add_Personne.Visible = true;
                        break;
                    }
                    else
                    {
                        L_numSalle.Visible = false;
                        L_Affiche_info_Sall.Visible = false;
                        L_saisie_nbPerso.Visible = false;
                        tb_nb_Personne.Visible = false;
                        ck_tarifred.Visible = false;
                        Valider_Add_Personne.Visible = false;
                        //MessageBox.Show("Cette Salle n'existe Pas ");
                    }
                }
                
            }
            else
            {
                L_numSalle.Visible = false;
                L_Affiche_info_Sall.Visible = false;
                L_saisie_nbPerso.Visible = false;
                tb_nb_Personne.Visible = false;
                ck_tarifred.Visible = false;
                Valider_Add_Personne.Visible = false;
                MessageBox.Show("indique un n° de salle avant de valider");
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
                        MessageBox.Show(LaSalle.vendrePlaces(Convert.ToInt32(tb_nb_Personne.Text), ck_tarifred.Checked));                        
                        L_Affiche_info_Sall.Text = LaSalle.toString();
                        break;
                    }
                }
                InfoALLsalle();
            }
        }
    }
}
