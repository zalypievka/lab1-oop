using System.Text;

namespace lab1_kostenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            string input = nomerzadaniya.Text;
            if (int.TryParse(input, out int number))
            {
                switch (number)
                {
                    case 1:
                        string ryadok = danie.Text;
                        int t = ryadok.IndexOf(" ");
                        int starcount = 0;
                        if (t != -1)
                        {
                            string afterspace = ryadok.Substring(t + 1);
                            int count = afterspace.Length;
                            for (int i = 0; i < afterspace.Length; i++)
                            {
                                if (afterspace[i] == '*')
                                {
                                    starcount++;
                                }
                            }
                        }
                        result.Text="Ê³ëüê³ñòü ç³ðî÷îê ï³ñëÿ ïðîá³ëó: " + starcount;
                        break;

                    case 2:
                        string ryadok1 = danie.Text;

                        string litera = danie_dlya_3_4_zadaniya.Text;

                        string newryadok;

                        if (ryadok1.IndexOf(litera) != -1) 
                        {
                            newryadok = ryadok1.Replace(litera, "???");
                            result.Text=("Ðåçóëüòàò: " + newryadok);
                        }
                            break;

                    case 3:
                        string sentence = danie.Text;

                        string[] words = sentence.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            string word = words[i];
                            if (word.Length > 1)
                            {
                                char first = word[0];
                                string rest = word.Substring(1);
                                words[i] = rest + first;
                            }
                        }

                        string resultat = string.Join(" ", words);
                        result.Text = ("Ðåçóëüòàò: " + resultat);
                        break;
                    case 4:
                        string sentence1 = danie.Text;

                        int chislo = int.Parse(danie_dlya_3_4_zadaniya.Text);
                        string[] words1 = sentence1.Split(' ');
                        chislo = chislo % words1.Length;
                        string[] shifted = new string[words1.Length];
                        int index = 0;
                        for (int i = chislo; i < words1.Length; i++)
                        {
                            shifted[index++] = words1[i];
                        }
                        for (int i = 0; i < chislo; i++)
                        {
                            shifted[index++] = words1[i];
                        }
                        string resultat1 = string.Join(" ", shifted);
                        result.Text=("Ðåçóëüòàò: " + resultat1);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Áóäü ëàñêà, ââåä³òü ÷èñëî!");
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
