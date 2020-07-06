namespace RandomMealApp
{
    partial class SecondFrame
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
            this.m_getMealButton = new System.Windows.Forms.Button();
            this.feelHungryLbl = new System.Windows.Forms.Label();
            this.getRdmMealLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_getMealButton
            // 
            this.m_getMealButton.Location = new System.Drawing.Point(139, 99);
            this.m_getMealButton.Name = "m_getMealButton";
            this.m_getMealButton.Size = new System.Drawing.Size(100, 36);
            this.m_getMealButton.TabIndex = 0;
            this.m_getMealButton.Text = "Get meal";
            this.m_getMealButton.UseVisualStyleBackColor = true;
            this.m_getMealButton.Click += new System.EventHandler(this.m_getMealButton_Click);
            // 
            // feelHungryLbl
            // 
            this.feelHungryLbl.AutoSize = true;
            this.feelHungryLbl.Location = new System.Drawing.Point(134, 24);
            this.feelHungryLbl.Name = "feelHungryLbl";
            this.feelHungryLbl.Size = new System.Drawing.Size(114, 17);
            this.feelHungryLbl.TabIndex = 1;
            this.feelHungryLbl.Text = "Feeling hungry ?";
            this.feelHungryLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // getRdmMealLbl
            // 
            this.getRdmMealLbl.AutoSize = true;
            this.getRdmMealLbl.Location = new System.Drawing.Point(72, 54);
            this.getRdmMealLbl.Name = "getRdmMealLbl";
            this.getRdmMealLbl.Size = new System.Drawing.Size(238, 17);
            this.getRdmMealLbl.TabIndex = 2;
            this.getRdmMealLbl.Text = "Get a random meal by clicking below";
            this.getRdmMealLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 147);
            this.Controls.Add(this.getRdmMealLbl);
            this.Controls.Add(this.feelHungryLbl);
            this.Controls.Add(this.m_getMealButton);
            this.Name = "Form1";
            this.Text = "Random Meal Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_getMealButton;
        private System.Windows.Forms.Label feelHungryLbl;
        private System.Windows.Forms.Label getRdmMealLbl;
    }
}

