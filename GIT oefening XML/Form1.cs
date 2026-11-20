namespace GIT_oefening_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lees_form newForm = new lees_form();
            newForm.ShowDialog();
        }
    }
}
