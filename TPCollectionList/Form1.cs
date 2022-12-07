using System.Diagnostics;

namespace TPCollectionList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> maListe = new List<int>();
        private void buttonCreerList_Click(object sender, EventArgs e)
        {
            List<int> maListe2 = new List<int> { 1, 2, 3, 5, 7 };
            maListe.AddRange(maListe2);
        }

        private void buttonCreerListString_Click(object sender, EventArgs e)
        {
            List<string> maListe3 = new List<string> {"bonjour","hello","nico","soleil","toto" };
        }

        private void buttonFusionnerQ1_Click(object sender, EventArgs e)
        {
            List<int> maListe2 = new List<int> { 11, 13, 17, 19, 23 };
            maListe.AddRange(maListe2);
        }

        private void buttonMoyenne_Click(object sender, EventArgs e)
        {
            int moyenne = 0;
            for (int i =0;i<maListe.Count;i++)
            {
                moyenne += Convert.ToInt32(maListe[i]);
            }
            moyenne = moyenne / maListe.Count;
            MessageBox.Show("la moyenne est de " + moyenne);
        }

        private void buttonMoyenneForeach_Click(object sender, EventArgs e)
        {
            int moyenne = 0;
            foreach (int i  in maListe)
            {
                moyenne += Convert.ToInt32(i);
            }
            moyenne = moyenne / maListe.Count;
            MessageBox.Show("la moyenne est de " + moyenne);
        }

        private void buttonMoyenneLinq_Click(object sender, EventArgs e)
        {
            int moyenne = 0;
            //LINQ
            maListe.ForEach(elt =>  moyenne += elt);
            moyenne = moyenne / maListe.Count;
            MessageBox.Show("la moyenne est de " + moyenne);
        }

        private void buttonInsererDebut_Click(object sender, EventArgs e)
        {
            string input = textBoxInserer.Text;
            int insererNbre;
            bool convertResult = int.TryParse(input, out insererNbre);

            if (convertResult)
            {
                maListe.Insert(0, insererNbre);
                textBoxInserer.Text = "";
            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
            }
        }

        private void buttonSupprimerIndice3_Click(object sender, EventArgs e)
        {
            maListe.RemoveAt(3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool present3 = false;
            bool present7 = false;
            for (int i = 0; i < maListe.Count; i++)
            {
                if (Convert.ToInt32(maListe[i]) == 3)
                {
                    present3 = true;
                }
                if (Convert.ToInt32(maListe[i]) == 7)
                {
                    present7 = true;
                }
            }
            if (present3)
            {
                MessageBox.Show("le chiffre 3 est présent");
            }
            if (present7)
            {
                MessageBox.Show("le chiffre 7 est présent");
            }
        }
    }
}