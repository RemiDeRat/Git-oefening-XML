namespace GIT_oefening_XML
{
    partial class Form2
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
            txtTitel = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAuteur = new TextBox();
            label3 = new Label();
            txtJaar = new TextBox();
            lsbBoeken = new ListBox();
            btnToevoegen = new Button();
            btnAanpassen = new Button();
            btnVerwijderen = new Button();
            btnOpslaan = new Button();
            SuspendLayout();
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(32, 51);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(225, 31);
            txtTitel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 1;
            label1.Text = "Titel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 3;
            label2.Text = "Auteur:";
            // 
            // txtAuteur
            // 
            txtAuteur.Location = new Point(32, 131);
            txtAuteur.Name = "txtAuteur";
            txtAuteur.Size = new Size(225, 31);
            txtAuteur.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 191);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 5;
            label3.Text = "Jaar:";
            // 
            // txtJaar
            // 
            txtJaar.Location = new Point(32, 219);
            txtJaar.Name = "txtJaar";
            txtJaar.Size = new Size(225, 31);
            txtJaar.TabIndex = 4;
            // 
            // lsbBoeken
            // 
            lsbBoeken.FormattingEnabled = true;
            lsbBoeken.Location = new Point(39, 274);
            lsbBoeken.Name = "lsbBoeken";
            lsbBoeken.Size = new Size(324, 129);
            lsbBoeken.TabIndex = 6;
            lsbBoeken.SelectedIndexChanged += lbBoeken_SelectedIndexChanged;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(517, 21);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(242, 79);
            btnToevoegen.TabIndex = 7;
            btnToevoegen.Text = "Toevoegen";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // btnAanpassen
            // 
            btnAanpassen.Location = new Point(517, 106);
            btnAanpassen.Name = "btnAanpassen";
            btnAanpassen.Size = new Size(242, 79);
            btnAanpassen.TabIndex = 9;
            btnAanpassen.Text = "Aanpassen";
            btnAanpassen.UseVisualStyleBackColor = true;
            btnAanpassen.Click += btnVerwijderen_Click;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(517, 191);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(242, 79);
            btnVerwijderen.TabIndex = 10;
            btnVerwijderen.Text = "Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click_1;
            // 
            // btnOpslaan
            // 
            btnOpslaan.Location = new Point(517, 324);
            btnOpslaan.Name = "btnOpslaan";
            btnOpslaan.Size = new Size(242, 79);
            btnOpslaan.TabIndex = 11;
            btnOpslaan.Text = "Opslaan";
            btnOpslaan.UseVisualStyleBackColor = true;
            btnOpslaan.Click += btnOpslaan_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpslaan);
            Controls.Add(btnVerwijderen);
            Controls.Add(btnAanpassen);
            Controls.Add(btnToevoegen);
            Controls.Add(lsbBoeken);
            Controls.Add(label3);
            Controls.Add(txtJaar);
            Controls.Add(label2);
            Controls.Add(txtAuteur);
            Controls.Add(label1);
            Controls.Add(txtTitel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitel;
        private Label label1;
        private Label label2;
        private TextBox txtAuteur;
        private Label label3;
        private TextBox txtJaar;
        private ListBox lsbBoeken;
        private Button btnToevoegen;
        private Button btnAanpassen;
        private Button btnVerwijderen;
        private Button btnOpslaan;
    }
}