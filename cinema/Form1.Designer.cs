namespace cinema
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Cherch_Salle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Cherche_salle = new System.Windows.Forms.Button();
            this.L_Affiche_info_Sall = new System.Windows.Forms.Label();
            this.L_saisie_nbPerso = new System.Windows.Forms.Label();
            this.tb_nb_Personne = new System.Windows.Forms.TextBox();
            this.ck_tarifred = new System.Windows.Forms.CheckBox();
            this.Valider_Add_Personne = new System.Windows.Forms.Button();
            this.L_numSalle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_All_salle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Cherch_Salle
            // 
            this.tb_Cherch_Salle.Location = new System.Drawing.Point(151, 88);
            this.tb_Cherch_Salle.Name = "tb_Cherch_Salle";
            this.tb_Cherch_Salle.Size = new System.Drawing.Size(100, 20);
            this.tb_Cherch_Salle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisir le N° de la Salle :";
            // 
            // B_Cherche_salle
            // 
            this.B_Cherche_salle.Location = new System.Drawing.Point(303, 86);
            this.B_Cherche_salle.Name = "B_Cherche_salle";
            this.B_Cherche_salle.Size = new System.Drawing.Size(75, 23);
            this.B_Cherche_salle.TabIndex = 2;
            this.B_Cherche_salle.Text = "Valider";
            this.B_Cherche_salle.UseVisualStyleBackColor = true;
            this.B_Cherche_salle.Click += new System.EventHandler(this.B_Cherche_salle_Click);
            // 
            // L_Affiche_info_Sall
            // 
            this.L_Affiche_info_Sall.AutoSize = true;
            this.L_Affiche_info_Sall.Location = new System.Drawing.Point(410, 53);
            this.L_Affiche_info_Sall.Name = "L_Affiche_info_Sall";
            this.L_Affiche_info_Sall.Size = new System.Drawing.Size(183, 13);
            this.L_Affiche_info_Sall.TabIndex = 3;
            this.L_Affiche_info_Sall.Text = "affiche Les info de la salle rechercher";
            this.L_Affiche_info_Sall.Visible = false;
            // 
            // L_saisie_nbPerso
            // 
            this.L_saisie_nbPerso.AutoSize = true;
            this.L_saisie_nbPerso.Location = new System.Drawing.Point(12, 266);
            this.L_saisie_nbPerso.Name = "L_saisie_nbPerso";
            this.L_saisie_nbPerso.Size = new System.Drawing.Size(229, 13);
            this.L_saisie_nbPerso.TabIndex = 4;
            this.L_saisie_nbPerso.Text = "Nombre de Personne Voulant allez voir ce film :";
            this.L_saisie_nbPerso.Visible = false;
            // 
            // tb_nb_Personne
            // 
            this.tb_nb_Personne.Location = new System.Drawing.Point(262, 263);
            this.tb_nb_Personne.Name = "tb_nb_Personne";
            this.tb_nb_Personne.Size = new System.Drawing.Size(100, 20);
            this.tb_nb_Personne.TabIndex = 5;
            this.tb_nb_Personne.Visible = false;
            // 
            // ck_tarifred
            // 
            this.ck_tarifred.AutoSize = true;
            this.ck_tarifred.Location = new System.Drawing.Point(381, 266);
            this.ck_tarifred.Name = "ck_tarifred";
            this.ck_tarifred.Size = new System.Drawing.Size(86, 17);
            this.ck_tarifred.TabIndex = 6;
            this.ck_tarifred.Text = "tarif Reduit ?";
            this.ck_tarifred.UseVisualStyleBackColor = true;
            this.ck_tarifred.Visible = false;
            // 
            // Valider_Add_Personne
            // 
            this.Valider_Add_Personne.Location = new System.Drawing.Point(502, 261);
            this.Valider_Add_Personne.Name = "Valider_Add_Personne";
            this.Valider_Add_Personne.Size = new System.Drawing.Size(75, 23);
            this.Valider_Add_Personne.TabIndex = 7;
            this.Valider_Add_Personne.Text = "Valider";
            this.Valider_Add_Personne.UseVisualStyleBackColor = true;
            this.Valider_Add_Personne.Visible = false;
            this.Valider_Add_Personne.Click += new System.EventHandler(this.Valider_Add_Personne_Click);
            // 
            // L_numSalle
            // 
            this.L_numSalle.AutoSize = true;
            this.L_numSalle.Location = new System.Drawing.Point(410, 40);
            this.L_numSalle.Name = "L_numSalle";
            this.L_numSalle.Size = new System.Drawing.Size(109, 13);
            this.L_numSalle.TabIndex = 8;
            this.L_numSalle.Text = "Le numero de la Salle";
            this.L_numSalle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Information sur toute les Salle";
            // 
            // Lb_All_salle
            // 
            this.Lb_All_salle.AutoSize = true;
            this.Lb_All_salle.Location = new System.Drawing.Point(676, 53);
            this.Lb_All_salle.Name = "Lb_All_salle";
            this.Lb_All_salle.Size = new System.Drawing.Size(145, 13);
            this.Lb_All_salle.TabIndex = 10;
            this.Lb_All_salle.Text = "Affche tout les info des ronde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 566);
            this.Controls.Add(this.Lb_All_salle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_numSalle);
            this.Controls.Add(this.Valider_Add_Personne);
            this.Controls.Add(this.ck_tarifred);
            this.Controls.Add(this.tb_nb_Personne);
            this.Controls.Add(this.L_saisie_nbPerso);
            this.Controls.Add(this.L_Affiche_info_Sall);
            this.Controls.Add(this.B_Cherche_salle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Cherch_Salle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Cherch_Salle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Cherche_salle;
        private System.Windows.Forms.Label L_Affiche_info_Sall;
        private System.Windows.Forms.Label L_saisie_nbPerso;
        private System.Windows.Forms.TextBox tb_nb_Personne;
        private System.Windows.Forms.CheckBox ck_tarifred;
        private System.Windows.Forms.Button Valider_Add_Personne;
        private System.Windows.Forms.Label L_numSalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_All_salle;
    }
}

