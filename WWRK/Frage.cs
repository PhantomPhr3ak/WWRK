namespace WWRK
{
    internal class Frage
    {
        public string frage = "";
        public string KorrekteAntwort = "";
        public string Antwort1 = "", Antwort2 = "", Antwort3 = "";

        public Frage(string frageText, string korrekteAntwort, string antwort1, string antwort2, string antwort3)
        {
            frage = frageText;
            KorrekteAntwort = korrekteAntwort;
            Antwort1 = antwort1;
            Antwort2 = antwort2;
            Antwort3 = antwort3;
        }
    }
}
