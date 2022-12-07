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
    }
}