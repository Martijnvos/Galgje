using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje_WinForms
{
    class Galgje
    {
        private int _gokkenOver = 12;

        private List<char> lettersGuessedRight = new List<char>();
        private List<char> lettersGuessedWrong = new List<char>();

        private String galgjeWoord;

        public String GetGalgjeWoord()
        {
            return galgjeWoord; 
        }

        Woord woord = new Woord();

        public int GokkenOver { get { return _gokkenOver; } }

        public void instantiateWoordClass(string galgjeWoord)
        {
            this.galgjeWoord = galgjeWoord;
            woord.initializeGalgjeWoord(galgjeWoord);
        }

        public bool checkIfGuessedLetterIsRight(char letter)
        {
            if (woord.GalgjeWoord.Contains(letter))
            {
                lettersGuessedRight.Add(letter);
                return true;
            } else
            {
                lettersGuessedWrong.Add(letter);
                _gokkenOver--;
                return false;
            }
        }

        public string checkLists()
        {

            if (woord.GalgjeWoord.Length == lettersGuessedRight.Count)
            {
                return "gewonnen";
            } else if (lettersGuessedWrong.Count == 12)
            {
                return "verloren";
            } else
            {
                return null;
            }
        }

    }
}
