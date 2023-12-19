namespace Gestion_pizza.Formulaire
{
    partial class Ajoutpizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelprix = new System.Windows.Forms.Label();
            this.textBoxtype = new System.Windows.Forms.TextBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxprix = new System.Windows.Forms.TextBox();
            this.dataGridViewpizza = new System.Windows.Forms.DataGridView();
            this.labelerreurID = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.labelerreurtype = new System.Windows.Forms.Label();
            this.labelerreurprix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpizza)).BeginInit();
            this.SuspendLayout();
            // 
            // labelprix
            // 
            this.labelprix.AutoSize = true;
            this.labelprix.Location = new System.Drawing.Point(538, 45);
            this.labelprix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelprix.Name = "labelprix";
            this.labelprix.Size = new System.Drawing.Size(24, 13);
            this.labelprix.TabIndex = 20;
            this.labelprix.Text = "Prix";
            // 
            // textBoxtype
            // 
            this.textBoxtype.Location = new System.Drawing.Point(333, 45);
            this.textBoxtype.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtype.Name = "textBoxtype";
            this.textBoxtype.Size = new System.Drawing.Size(150, 20);
            this.textBoxtype.TabIndex = 18;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(286, 45);
            this.labeltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(31, 13);
            this.labeltype.TabIndex = 17;
            this.labeltype.Text = "Type";
            this.labeltype.Click += new System.EventHandler(this.labelPrenom_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(65, 45);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(150, 20);
            this.textBoxID.TabIndex = 16;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(32, 45);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // textBoxprix
            // 
            this.textBoxprix.Location = new System.Drawing.Point(580, 45);
            this.textBoxprix.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxprix.Name = "textBoxprix";
            this.textBoxprix.Size = new System.Drawing.Size(150, 20);
            this.textBoxprix.TabIndex = 21;
            // 
            // dataGridViewpizza
            // 
            this.dataGridViewpizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpizza.Location = new System.Drawing.Point(125, 117);
            this.dataGridViewpizza.Name = "dataGridViewpizza";
            this.dataGridViewpizza.Size = new System.Drawing.Size(512, 253);
            this.dataGridViewpizza.TabIndex = 22;
            // 
            // labelerreurID
            // 
            this.labelerreurID.AutoSize = true;
            this.labelerreurID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerreurID.ForeColor = System.Drawing.Color.Red;
            this.labelerreurID.Location = new System.Drawing.Point(77, 82);
            this.labelerreurID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelerreurID.Name = "labelerreurID";
            this.labelerreurID.Size = new System.Drawing.Size(71, 25);
            this.labelerreurID.TabIndex = 25;
            this.labelerreurID.Text = "Erreur";
            this.labelerreurID.Visible = false;
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Ajouter.Location = new System.Drawing.Point(125, 394);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(183, 44);
            this.Ajouter.TabIndex = 26;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Supprimer.Location = new System.Drawing.Point(454, 394);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(183, 44);
            this.Supprimer.TabIndex = 27;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            // 
            // labelerreurtype
            // 
            this.labelerreurtype.AutoSize = true;
            this.labelerreurtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerreurtype.ForeColor = System.Drawing.Color.Red;
            this.labelerreurtype.Location = new System.Drawing.Point(328, 82);
            this.labelerreurtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelerreurtype.Name = "labelerreurtype";
            this.labelerreurtype.Size = new System.Drawing.Size(71, 25);
            this.labelerreurtype.TabIndex = 28;
            this.labelerreurtype.Text = "Erreur";
            this.labelerreurtype.Visible = false;
            // 
            // labelerreurprix
            // 
            this.labelerreurprix.AutoSize = true;
            this.labelerreurprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerreurprix.ForeColor = System.Drawing.Color.Red;
            this.labelerreurprix.Location = new System.Drawing.Point(575, 82);
            this.labelerreurprix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelerreurprix.Name = "labelerreurprix";
            this.labelerreurprix.Size = new System.Drawing.Size(71, 25);
            this.labelerreurprix.TabIndex = 29;
            this.labelerreurprix.Text = "Erreur";
            this.labelerreurprix.Visible = false;
            // 
            // Ajoutpizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelerreurprix);
            this.Controls.Add(this.labelerreurtype);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.labelerreurID);
            this.Controls.Add(this.dataGridViewpizza);
            this.Controls.Add(this.textBoxprix);
            this.Controls.Add(this.labelprix);
            this.Controls.Add(this.textBoxtype);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "Ajoutpizza";
            this.Text = "Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelprix;
        private System.Windows.Forms.TextBox textBoxtype;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxprix;
        private System.Windows.Forms.DataGridView dataGridViewpizza;
        private System.Windows.Forms.Label labelerreurID;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Label labelerreurtype;
        private System.Windows.Forms.Label labelerreurprix;
    }
}