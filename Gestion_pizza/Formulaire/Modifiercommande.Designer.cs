namespace Gestion_pizza.Formulaire
{
    partial class Modifiercommande
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
            this.labelerreurmodi = new System.Windows.Forms.Label();
            this.dataGridViewcommande = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.Button();
            this.labeldatecommande = new System.Windows.Forms.Label();
            this.textBoxcommandeID = new System.Windows.Forms.TextBox();
            this.labelcommandeID = new System.Windows.Forms.Label();
            this.labelerreurdate = new System.Windows.Forms.Label();
            this.dateTimePickermodifier = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcommande)).BeginInit();
            this.SuspendLayout();
            // 
            // labelerreurmodi
            // 
            this.labelerreurmodi.AutoSize = true;
            this.labelerreurmodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerreurmodi.ForeColor = System.Drawing.Color.Red;
            this.labelerreurmodi.Location = new System.Drawing.Point(215, 57);
            this.labelerreurmodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelerreurmodi.Name = "labelerreurmodi";
            this.labelerreurmodi.Size = new System.Drawing.Size(71, 25);
            this.labelerreurmodi.TabIndex = 29;
            this.labelerreurmodi.Text = "Erreur";
            this.labelerreurmodi.Visible = false;
            // 
            // dataGridViewcommande
            // 
            this.dataGridViewcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcommande.Location = new System.Drawing.Point(137, 99);
            this.dataGridViewcommande.Name = "dataGridViewcommande";
            this.dataGridViewcommande.Size = new System.Drawing.Size(512, 253);
            this.dataGridViewcommande.TabIndex = 30;
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.Modifier.Location = new System.Drawing.Point(284, 379);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(183, 44);
            this.Modifier.TabIndex = 31;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // labeldatecommande
            // 
            this.labeldatecommande.AutoSize = true;
            this.labeldatecommande.Location = new System.Drawing.Point(381, 26);
            this.labeldatecommande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldatecommande.Name = "labeldatecommande";
            this.labeldatecommande.Size = new System.Drawing.Size(86, 13);
            this.labeldatecommande.TabIndex = 34;
            this.labeldatecommande.Text = "Date Commande";
            // 
            // textBoxcommandeID
            // 
            this.textBoxcommandeID.Location = new System.Drawing.Point(183, 23);
            this.textBoxcommandeID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcommandeID.Name = "textBoxcommandeID";
            this.textBoxcommandeID.Size = new System.Drawing.Size(150, 20);
            this.textBoxcommandeID.TabIndex = 33;
            // 
            // labelcommandeID
            // 
            this.labelcommandeID.AutoSize = true;
            this.labelcommandeID.Location = new System.Drawing.Point(108, 26);
            this.labelcommandeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcommandeID.Name = "labelcommandeID";
            this.labelcommandeID.Size = new System.Drawing.Size(71, 13);
            this.labelcommandeID.TabIndex = 32;
            this.labelcommandeID.Text = "CommandeID";
            // 
            // labelerreurdate
            // 
            this.labelerreurdate.AutoSize = true;
            this.labelerreurdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelerreurdate.ForeColor = System.Drawing.Color.Red;
            this.labelerreurdate.Location = new System.Drawing.Point(484, 57);
            this.labelerreurdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelerreurdate.Name = "labelerreurdate";
            this.labelerreurdate.Size = new System.Drawing.Size(71, 25);
            this.labelerreurdate.TabIndex = 36;
            this.labelerreurdate.Text = "Erreur";
            this.labelerreurdate.Visible = false;
            // 
            // dateTimePickermodifier
            // 
            this.dateTimePickermodifier.Location = new System.Drawing.Point(472, 23);
            this.dateTimePickermodifier.Name = "dateTimePickermodifier";
            this.dateTimePickermodifier.Size = new System.Drawing.Size(247, 20);
            this.dateTimePickermodifier.TabIndex = 37;
            // 
            // Modifiercommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickermodifier);
            this.Controls.Add(this.labelerreurdate);
            this.Controls.Add(this.labeldatecommande);
            this.Controls.Add(this.textBoxcommandeID);
            this.Controls.Add(this.labelcommandeID);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.dataGridViewcommande);
            this.Controls.Add(this.labelerreurmodi);
            this.Name = "Modifiercommande";
            this.Text = "Modifier commande";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelerreurmodi;
        private System.Windows.Forms.DataGridView dataGridViewcommande;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label labeldatecommande;
        private System.Windows.Forms.TextBox textBoxcommandeID;
        private System.Windows.Forms.Label labelcommandeID;
        private System.Windows.Forms.Label labelerreurdate;
        private System.Windows.Forms.DateTimePicker dateTimePickermodifier;
    }
}