namespace GIT_oefening_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBoekInvoer_Click(object sender, EventArgs e)
        {
            Form newform = new Form2();
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lees_form newForm = new lees_form();
            newForm.ShowDialog();

        }
    }
}
