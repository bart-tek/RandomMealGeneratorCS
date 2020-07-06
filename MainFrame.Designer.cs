namespace RandomMealApp
{
    partial class MainFrame
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
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.ingredientsLbl = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.Label();
            this.areaTxt = new System.Windows.Forms.Label();
            this.ingredientsTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tagsTxt = new System.Windows.Forms.Label();
            this.tagsLbl = new System.Windows.Forms.Label();
            this.youtube = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_getMealButton
            // 
            this.m_getMealButton.Location = new System.Drawing.Point(574, 87);
            this.m_getMealButton.Name = "m_getMealButton";
            this.m_getMealButton.Size = new System.Drawing.Size(100, 36);
            this.m_getMealButton.TabIndex = 0;
            this.m_getMealButton.Text = "Get meal";
            this.m_getMealButton.UseVisualStyleBackColor = true;
            this.m_getMealButton.Click += new System.EventHandler(this.GetMealButton_Click);
            // 
            // feelHungryLbl
            // 
            this.feelHungryLbl.AutoSize = true;
            this.feelHungryLbl.Location = new System.Drawing.Point(569, 12);
            this.feelHungryLbl.Name = "feelHungryLbl";
            this.feelHungryLbl.Size = new System.Drawing.Size(114, 17);
            this.feelHungryLbl.TabIndex = 1;
            this.feelHungryLbl.Text = "Feeling hungry ?";
            // 
            // getRdmMealLbl
            // 
            this.getRdmMealLbl.AutoSize = true;
            this.getRdmMealLbl.Location = new System.Drawing.Point(507, 42);
            this.getRdmMealLbl.Name = "getRdmMealLbl";
            this.getRdmMealLbl.Size = new System.Drawing.Size(238, 17);
            this.getRdmMealLbl.TabIndex = 2;
            this.getRdmMealLbl.Text = "Get a random meal by clicking below";
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(12, 154);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(567, 393);
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(598, 165);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(394, 33);
            this.name.TabIndex = 4;
            this.name.Text = "label1";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(-3, -2);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(594, 347);
            this.instructions.TabIndex = 5;
            this.instructions.Text = "label2";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(12, 562);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(73, 17);
            this.categoryLbl.TabIndex = 6;
            this.categoryLbl.Text = "Category :";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(12, 579);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(46, 17);
            this.areaLbl.TabIndex = 7;
            this.areaLbl.Text = "Area :";
            // 
            // ingredientsLbl
            // 
            this.ingredientsLbl.AutoSize = true;
            this.ingredientsLbl.Location = new System.Drawing.Point(12, 627);
            this.ingredientsLbl.Name = "ingredientsLbl";
            this.ingredientsLbl.Size = new System.Drawing.Size(78, 17);
            this.ingredientsLbl.TabIndex = 8;
            this.ingredientsLbl.Text = "Ingredients";
            // 
            // categoryTxt
            // 
            this.categoryTxt.AutoSize = true;
            this.categoryTxt.Location = new System.Drawing.Point(83, 562);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(46, 17);
            this.categoryTxt.TabIndex = 9;
            this.categoryTxt.Text = "label6";
            // 
            // areaTxt
            // 
            this.areaTxt.AutoSize = true;
            this.areaTxt.Location = new System.Drawing.Point(83, 579);
            this.areaTxt.Name = "areaTxt";
            this.areaTxt.Size = new System.Drawing.Size(46, 17);
            this.areaTxt.TabIndex = 10;
            this.areaTxt.Text = "label7";
            // 
            // ingredientsTxt
            // 
            this.ingredientsTxt.AutoSize = true;
            this.ingredientsTxt.Location = new System.Drawing.Point(3, 0);
            this.ingredientsTxt.Name = "ingredientsTxt";
            this.ingredientsTxt.Size = new System.Drawing.Size(46, 17);
            this.ingredientsTxt.TabIndex = 11;
            this.ingredientsTxt.Text = "label8";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ingredientsTxt);
            this.panel1.Location = new System.Drawing.Point(15, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 226);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.instructions);
            this.panel2.Location = new System.Drawing.Point(601, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 347);
            this.panel2.TabIndex = 13;
            // 
            // tagsTxt
            // 
            this.tagsTxt.AutoSize = true;
            this.tagsTxt.Location = new System.Drawing.Point(83, 596);
            this.tagsTxt.Name = "tagsTxt";
            this.tagsTxt.Size = new System.Drawing.Size(46, 17);
            this.tagsTxt.TabIndex = 15;
            this.tagsTxt.Text = "label8";
            // 
            // tagsLbl
            // 
            this.tagsLbl.AutoSize = true;
            this.tagsLbl.Location = new System.Drawing.Point(12, 596);
            this.tagsLbl.Name = "tagsLbl";
            this.tagsLbl.Size = new System.Drawing.Size(48, 17);
            this.tagsLbl.TabIndex = 14;
            this.tagsLbl.Text = "Tags :";
            // 
            // youtube
            // 
            this.youtube.Location = new System.Drawing.Point(131, 948);
            this.youtube.MinimumSize = new System.Drawing.Size(20, 20);
            this.youtube.Name = "youtube";
            this.youtube.Size = new System.Drawing.Size(950, 520);
            this.youtube.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 912);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Video Recipe";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1224, 894);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.youtube);
            this.Controls.Add(this.tagsTxt);
            this.Controls.Add(this.tagsLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.areaTxt);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.ingredientsLbl);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.name);
            this.Controls.Add(this.thumbnail);
            this.Controls.Add(this.getRdmMealLbl);
            this.Controls.Add(this.feelHungryLbl);
            this.Controls.Add(this.m_getMealButton);
            this.Name = "MainFrame";
            this.Text = "Random Meal Generator";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_getMealButton;
        private System.Windows.Forms.Label feelHungryLbl;
        private System.Windows.Forms.Label getRdmMealLbl;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label ingredientsLbl;
        private System.Windows.Forms.Label categoryTxt;
        private System.Windows.Forms.Label areaTxt;
        private System.Windows.Forms.Label ingredientsTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tagsTxt;
        private System.Windows.Forms.Label tagsLbl;
        private System.Windows.Forms.WebBrowser youtube;
        private System.Windows.Forms.Label label1;
    }
}

