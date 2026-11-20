namespace GIT_oefening_XML
{
    partial class lees_form
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
            lblZoeken = new Label();
            txtZoeken = new TextBox();
            btnLaden = new Button();
            dgvBoeken = new DataGridView();
            lblAantal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoeken).BeginInit();
            SuspendLayout();
            // 
            // lblZoeken
            // 
            lblZoeken.AutoSize = true;
            lblZoeken.Location = new Point(107, 73);
            lblZoeken.Name = "lblZoeken";
            lblZoeken.Size = new Size(99, 25);
            lblZoeken.TabIndex = 0;
            lblZoeken.Text = "Zoek Boek:";
            // 
            // txtZoeken
            // 
            txtZoeken.Location = new Point(221, 73);
            txtZoeken.Name = "txtZoeken";
            txtZoeken.Size = new Size(669, 31);
            txtZoeken.TabIndex = 1;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(407, 140);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(212, 34);
            btnLaden.TabIndex = 2;
            btnLaden.Text = "Boeken Laden";
            btnLaden.UseVisualStyleBackColor = true;
            // 
            // dgvBoeken
            // 
            dgvBoeken.AllowUserToAddRows = false;
            dgvBoeken.AllowUserToDeleteRows = false;
            dgvBoeken.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBoeken.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoeken.Location = new Point(107, 197);
            dgvBoeken.Name = "dgvBoeken";
            dgvBoeken.ReadOnly = true;
            dgvBoeken.RowHeadersWidth = 62;
            dgvBoeken.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoeken.Size = new Size(783, 187);
            dgvBoeken.TabIndex = 3;
            // 
            // lblAantal
            // 
            lblAantal.AutoSize = true;
            lblAantal.Location = new Point(107, 416);
            lblAantal.Name = "lblAantal";
            lblAantal.Size = new Size(145, 25);
            lblAantal.TabIndex = 4;
            lblAantal.Text = "Aantal boeken: 0";
            // 
            // lees_form
            // 
            ClientSize = new Size(1012, 493);
            Controls.Add(lblAantal);
            Controls.Add(dgvBoeken);
            Controls.Add(btnLaden);
            Controls.Add(txtZoeken);
            Controls.Add(lblZoeken);
            Name = "lees_form";
            ((System.ComponentModel.ISupportInitialize)dgvBoeken).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion


        private Label lblZoeken;
        private TextBox txtZoeken;
        private Button btnLaden;
        private DataGridView dgvBoeken;
        private Label lblAantal;
    }
}