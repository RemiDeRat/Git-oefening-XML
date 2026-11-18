namespace GIT_oefening_XML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBoekInvoer = new Button();
            SuspendLayout();
            // 
            // btnBoekInvoer
            // 
            btnBoekInvoer.Location = new Point(49, 36);
            btnBoekInvoer.Name = "btnBoekInvoer";
            btnBoekInvoer.Size = new Size(242, 90);
            btnBoekInvoer.TabIndex = 0;
            btnBoekInvoer.Text = "Boek toevoegen";
            btnBoekInvoer.UseVisualStyleBackColor = true;
            btnBoekInvoer.Click += btnBoekInvoer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoekInvoer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoekInvoer;
    }
}
