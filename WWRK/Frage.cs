using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWRK
{
    class Frage
    {
        public string frage = "";
        public string korrekteAntwort = "";
        public string antwort1 = "", antwort2 = "", antwort3 = "";

        public Frage(string _FrageText, string _korrekteAntwort, string _antwort1, string _antwort2, string _antwort3)
        {
            frage = _FrageText;
            korrekteAntwort = _korrekteAntwort;
            antwort1 = _antwort1;
            antwort2 = _antwort2;
            antwort3 = _antwort3;
        }
    }
}
