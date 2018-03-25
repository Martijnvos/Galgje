using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Galgje_WinForms
{
    public partial class GalgjeWinForms : Form
    {

        Galgje galgjeKlasse;

        public GalgjeWinForms()
        {
            InitializeComponent();
            initializeWoord();
        }

        private void initializeWoord()
        {
            try
            {
                string teRadenWoord = File.ReadAllText(@"../../galgje.txt");
                galgjeKlasse = new Galgje();
                galgjeKlasse.instantiateWoordClass(teRadenWoord);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Could not find directory of file, please try with another path.");
            }
            catch (IOException)
            {
                MessageBox.Show("An error occured when opening the file. Please retry...");
            }
            catch (UnauthorizedAccessException)
            {
               MessageBox.Show("You have no access to that file. Please try a different location");
            }
        }

        private void buttonRaadLetter_Click(object sender, EventArgs e)
        {
            if (textBoxRaadLetterInput.Text.Count() == 1 && Regex.IsMatch(textBoxRaadLetterInput.Text, @"^[a-zA-Z]+$"))
            {
                char letter = Convert.ToChar(textBoxRaadLetterInput.Text);
                bool rightLetter = galgjeKlasse.checkIfGuessedLetterIsRight(letter);

                if (rightLetter)
                {
                    labelRightLettersValues.Text += letter.ToString();
                    MessageBox.Show("De letter '" + letter + "' is aanwezig in het woord!");
                } else
                {
                    labelWrongLetterValues.Text += letter.ToString();
                    MessageBox.Show("De letter '" + letter + "' is niet aanwezig in het woord!");
                    labelNogTeGokken.Text = "Je kan nog " + galgjeKlasse.GokkenOver + " keer verkeerd gokken.";
                }

                textBoxRaadLetterInput.Clear();

                string afgelopenWaarde = galgjeKlasse.checkLists();

                if (afgelopenWaarde != null)
                {
                    if (afgelopenWaarde == "gewonnen")
                    {
                        MessageBox.Show("Gefeliciteerd, je hebt gewonnen! Het woord was '" + galgjeKlasse.GetGalgjeWoord() + "'");
                        Close();
                    }

                    if (afgelopenWaarde == "verloren")
                    {
                        MessageBox.Show("Je hangt... Probeer het opnieuw!");
                        Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Je kan maar één karakter invulllen.");
            }

            
        }
    }
}
