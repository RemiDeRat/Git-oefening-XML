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
            dataGridView1 = new DataGridView();
            lblAantal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblZoeken
            // 
            lblZoeken.AutoSize = true;
            lblZoeken.Location = new Point(174, 107);
            lblZoeken.Name = "lblZoeken";
            lblZoeken.Size = new Size(100, 25);
            lblZoeken.TabIndex = 0;
            lblZoeken.Text = "Zoek boek:";
            lblZoeken.Click += label1_Click;
            // 
            // txtZoeken
            // 
            txtZoeken.Location = new Point(298, 107);
            txtZoeken.Name = "txtZoeken";
            txtZoeken.ScrollBars = ScrollBars.Horizontal;
            txtZoeken.Size = new Size(441, 31);
            txtZoeken.TabIndex = 1;
            // 
            // btnLaden
            // 
            btnLaden.Location = new Point(402, 181);
            btnLaden.Name = "btnLaden";
            btnLaden.Size = new Size(219, 41);
            btnLaden.TabIndex = 2;
            btnLaden.Text = "Boek laden";
            btnLaden.UseVisualStyleBackColor = true;
            btnLaden.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(174, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(669, 236);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblAantal
            // 
            lblAantal.AutoSize = true;
            lblAantal.Location = new Point(174, 537);
            lblAantal.Name = "lblAantal";
            lblAantal.Size = new Size(145, 25);
            lblAantal.TabIndex = 4;
            lblAantal.Text = "Aantal boeken: 0";
            // 
            // lees_form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 619);
            Controls.Add(lblAantal);
            Controls.Add(dataGridView1);
            Controls.Add(btnLaden);
            Controls.Add(txtZoeken);
            Controls.Add(lblZoeken);
            Name = "lees_form";
            Text = "lees form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZoeken;
        private TextBox txtZoeken;
        private Button btnLaden;
        private DataGridView dataGridView1;
        private Label lblAantal;
    }
}