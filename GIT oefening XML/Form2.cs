using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace GIT_oefening_XML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        XmlReader reader;

        static void laadlsbBoeken(List<boek> boeken, ListBox listBox)
        {
            listBox.Items.Clear();
            for (int i = 0; i < boeken.Count; i++)
            {
                listBox.Items.Add(boeken[i].titel);
            }
        }

        class boek
        {
            public string titel;
            public string auteur;
            public int jaar;
            public boek(string Titel, string Auteur, int Jaar)
            {
                titel = Titel;
                auteur = Auteur;
                jaar = Jaar;
            }
        }

        List<boek> boeken;
        private void Form2_Load(object sender, EventArgs e)
        {
            reader = XmlReader.Create("C:\\Users\\remi.vanquaethem\\OneDrive - College O.-L.-V.-ten-Doorn\\Schooljaar 2026-2027\\AO\\Oefeningen\\GIT oefening XML\\GIT oefening XML\\bibliotheek.xml");
            boeken = new List<boek>();

            string titel = "";
            string auteur = "";
            int jaar = 0;

            while (reader.Read())
            {
                if (reader.Name == "titel" && reader.NodeType == XmlNodeType.Element)
                {
                    titel = reader.ReadElementContentAsString();
                }
                if (reader.Name == "auteur" && reader.NodeType == XmlNodeType.Element)
                {
                    auteur = reader.ReadElementContentAsString();
                }
                if (reader.Name == "jaar" && reader.NodeType == XmlNodeType.Element)
                {
                    jaar = reader.ReadElementContentAsInt();
                }
                if (reader.Name == "boek" && reader.NodeType == XmlNodeType.EndElement)
                {
                    boeken.Add(new boek(titel, auteur, jaar));
                }
            }

            for (int i = 0; i < boeken.Count; i++)
            {
                lsbBoeken.Items.Add(boeken[i].titel);
            }
        }

        private void lbBoeken_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbBoeken.SelectedIndex >= 0)
            {
                txtTitel.Text = boeken[lsbBoeken.SelectedIndex].titel;
                txtAuteur.Text = boeken[lsbBoeken.SelectedIndex].auteur;
                txtJaar.Text = boeken[lsbBoeken.SelectedIndex].jaar.ToString();
            }


        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (txtTitel.Text != null &&
                txtAuteur.Text != null &&
                txtJaar.Text != null &&
                int.Parse(txtJaar.Text) > 1450 &&
                int.Parse(txtJaar.Text) <= DateTime.Now.Year)
            {
                boeken.Add(new boek(txtTitel.Text, txtAuteur.Text, int.Parse(txtJaar.Text)));
                lsbBoeken.Items.Add(txtTitel.Text);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (txtTitel.Text != null &&
                txtAuteur.Text != null &&
                txtJaar.Text != null &&
                int.Parse(txtJaar.Text) > 1450 &&
                int.Parse(txtJaar.Text) <= DateTime.Now.Year)
            {
                boeken[lsbBoeken.SelectedIndex] = new boek(txtTitel.Text, txtAuteur.Text, int.Parse(txtJaar.Text));
                laadlsbBoeken(boeken, lsbBoeken);
            }
        }

        private void btnVerwijderen_Click_1(object sender, EventArgs e)
        {
            boeken.Remove(boeken[lsbBoeken.SelectedIndex]);
            laadlsbBoeken(boeken, lsbBoeken);
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("C:\\Users\\remi.vanquaethem\\OneDrive - College O.-L.-V.-ten-Doorn\\Schooljaar 2026-2027\\AO\\Oefeningen\\GIT oefening XML\\GIT oefening XML\\tijdelijk.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("boeken");
            for (int i = 0; i < boeken.Count; i++)
            {
                writer.WriteStartElement("boek");
                writer.WriteElementString("titel", boeken[i].titel);
                writer.WriteElementString("auteur", boeken[i].auteur);
                writer.WriteElementString("jaar", boeken[i].jaar.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
            writer.Dispose();
            reader.Close();
            reader.Dispose();
            File.Delete("C:\\Users\\remi.vanquaethem\\OneDrive - College O.-L.-V.-ten-Doorn\\Schooljaar 2026-2027\\AO\\Oefeningen\\GIT oefening XML\\GIT oefening XML\\bibliotheek.xml");
            File.Move("C:\\Users\\remi.vanquaethem\\OneDrive - College O.-L.-V.-ten-Doorn\\Schooljaar 2026-2027\\AO\\Oefeningen\\GIT oefening XML\\GIT oefening XML\\tijdelijk.xml",
                "C:\\Users\\remi.vanquaethem\\OneDrive - College O.-L.-V.-ten-Doorn\\Schooljaar 2026-2027\\AO\\Oefeningen\\GIT oefening XML\\GIT oefening XML\\bibliotheek.xml");


        }
    }
}