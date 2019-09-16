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
            this.L_Affiche_info_Sall.Location = new System.Drawing.Point(526, 91);
            this.L_Affiche_info_Sall.Name = "L_Affiche_info_Sall";
            this.L_Affiche_info_Sall.Size = new System.Drawing.Size(183, 13);
            this.L_Affiche_info_Sall.TabIndex = 3;
            this.L_Affiche_info_Sall.Text = "affiche Les info de la salle rechercher";
            this.L_Affiche_info_Sall.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 566);
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
    }
}

