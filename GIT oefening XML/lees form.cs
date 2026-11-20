using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO; 
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GIT_oefening_XML
{
    public partial class lees_form : Form
    {
        DataTable boeken = new DataTable();


        public lees_form()
        {
            InitializeComponent();

            boeken.Columns.Add("Titel");
            boeken.Columns.Add("Auteur");
            boeken.Columns.Add("Jaar");

            dgvBoeken.DataSource = boeken;

            btnLaden.Click += btnLaden_Click;
            txtZoeken.TextChanged += txtZoeken_TextChanged;
        }

        private void LaadBoeken()
        {
            string bestand = @"C:\Users\isaacbasoahowusu.ja\Documents\Git-oefening-XML\GIT oefening XML\bibliotheek.xml";

            if (File.Exists(bestand))
            {
                boeken.Rows.Clear();

                XmlReader reader = XmlReader.Create(bestand);

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "boek")
                    {
                        string titel = "";
                        string auteur = " ";
                        string jaar = "";

                        if (reader.ReadToDescendant("titel"))
                        {
                            titel = reader.ReadElementContentAsString("titel", "");

                            reader.MoveToContent();

                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "auteur")
                            {
                                auteur = reader.ReadElementContentAsString("auteur", "");
                            }

                            reader.MoveToContent();

                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "jaar")
                            {
                                jaar = reader.ReadElementContentAsString("jaar", "");
                            }

                            boeken.Rows.Add(titel, auteur, jaar);
                        }
                    }
                }

                reader.Close();

                ZoekBoeken();
            }
            else
            {
                MessageBox.Show("Het bestand boeken.xml bestaat niet.");
            }
        }

        private void ZoekBoeken()
        {
            string zoektekst = txtZoeken.Text.ToLower();

            int aantal = 0;

            foreach (DataRow rij in boeken.Rows)
            {
                string titel = rij["Titel"].ToString().ToLower();
                string auteur = rij["Auteur"].ToString().ToLower();

                if (titel.Contains(zoektekst) || auteur.Contains(zoektekst))
                {
                    aantal++;
                }
            }

            lblAantal.Text = "Aantal boeken: " + aantal;

            boeken.DefaultView.RowFilter ="Titel LIKE '%" + zoektekst.Replace("'", "''") + "%' OR Auteur LIKE '%" + zoektekst.Replace("'", "''") + "%'";
        }
        private void btnLaden_Click(object sender, EventArgs e)
        {
            LaadBoeken();
        }

        private void txtZoeken_TextChanged(object sender, EventArgs e)
        {
            ZoekBoeken();
        }
    }
}
