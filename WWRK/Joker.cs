using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWRK
{
    internal class Joker
    {
        Form1 form = new Form1();

        private bool _team1FiftyFifty = false;
        private bool _team1Publikum = false;
        private bool _team2FiftyFifty = false;
        private bool _team12Publikum = false;

        private Random _derZufallZweiPunktNull = new Random();

        public void Fiftyfifty()
        {
            int btn1;
            int btn2;
            do
            {
                btn1 = _derZufallZweiPunktNull.Next(0, 4);
                btn2 = _derZufallZweiPunktNull.Next(0, 4);
            } while (btn1 != btn2 /*!= richtigeAntwortInt*/);

            if (btn1 == 1 || btn2 == 1)
            {
                form.btnAntwort1.Enabled = false;
            }else if (btn1 == 2 || btn2 == 2)
            {
                form.btnAntwort2.Enabled = false;
            }
            else if (btn1 == 3 || btn2 == 3)
            {
                form.btnAntwort3.Enabled = false;
            }
            else if (btn1 == 4 || btn2 == 4)
            {
                form.btnAntwort4.Enabled = false;
            }
        }

        public void Publikum()
        {
            int chanceRight = _derZufallZweiPunktNull.Next(25, 75);
            int chance1 = _derZufallZweiPunktNull.Next(0, (100 - chanceRight + 15));
            int chance2 = _derZufallZweiPunktNull.Next(0, (100 - chanceRight + 15));
            int chance3 = 100 - chanceRight + chance1 + chance2;
            if ((chanceRight + chance1 + chance2 + chance3) > 100)
            {
                int rdm = _derZufallZweiPunktNull.Next(0, 3);
                switch (rdm)
                {
                    case 1:
                        chance1 = chance1 - ((chanceRight + chance1 + chance2 + chance3) - 100);
                        break;
                    case 2:
                        chance2 = chance2 - ((chanceRight + chance1 + chance2 + chance3) - 100);
                        break;
                    case 3:
                        chance3 = chance3 - ((chanceRight + chance1 + chance2 + chance3) - 100);
                        break;
                    default:
                        break;
                }
            }

            MessageBox.Show("Das Publikum hat folgendermaßen abgestimmt: " + Environment.NewLine +
                            "Antwort 1: XXX%" + Environment.NewLine +
                            "Antwort 2: XXX%" + Environment.NewLine +
                            "Antwort 3: XXX%" + Environment.NewLine + 
                            "Antwort 4: XXX%", 
                            "Publikumsjoker", MessageBoxButtons.OK);
        }
    }
}
