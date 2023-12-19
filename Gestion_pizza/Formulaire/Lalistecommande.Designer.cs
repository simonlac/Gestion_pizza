namespace Gestion_pizza.Formulaire
{
    partial class Affichercommande
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
            this.dataGridViewafficher = new System.Windows.Forms.DataGridView();
            this.dateTimePickerafficher = new System.Windows.Forms.DateTimePicker();
            this.labelafficher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewafficher)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewafficher
            // 
            this.dataGridViewafficher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewafficher.Location = new System.Drawing.Point(139, 114);
            this.dataGridViewafficher.Name = "dataGridViewafficher";
            this.dataGridViewafficher.Size = new System.Drawing.Size(462, 310);
            this.dataGridViewafficher.TabIndex = 0;
            // 
            // dateTimePickerafficher
            // 
            this.dateTimePickerafficher.Location = new System.Drawing.Point(541, 56);
            this.dateTimePickerafficher.Name = "dateTimePickerafficher";
            this.dateTimePickerafficher.Size = new System.Drawing.Size(247, 20);
            this.dateTimePickerafficher.TabIndex = 1;
            // 
            // labelafficher
            // 
            this.labelafficher.AutoSize = true;
            this.labelafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelafficher.Location = new System.Drawing.Point(12, 51);
            this.labelafficher.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.labelafficher.Name = "labelafficher";
            this.labelafficher.Size = new System.Drawing.Size(496, 25);
            this.labelafficher.TabIndex = 2;
            this.labelafficher.Text = "Afficher la liste de commande publier après la date";
            // 
            // Affichercommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelafficher);
            this.Controls.Add(this.dateTimePickerafficher);
            this.Controls.Add(this.dataGridViewafficher);
            this.Name = "Affichercommande";
            this.Text = "Afficher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewafficher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewafficher;
        private System.Windows.Forms.DateTimePicker dateTimePickerafficher;
        private System.Windows.Forms.Label labelafficher;
    }
}