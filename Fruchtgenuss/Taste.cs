using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruchtgenuss
{
    class Taste : Button
    {
        public Taste()
        {
            this.Width = 40;
            this.Height = 40;
            Click += Taste_Click;
        }

        private void Taste_Click(object sender, EventArgs e)
        {
            /*
            Tastatur t = (Tastatur)Parent;
            Bankautomat b = (Bankautomat)t.Parent;
            //b.screen.FügeZifferHinzu(Text); //Funkionalität in Screen noch hinzufügen bzw. zu finden
            switch (Text)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    b.getDisplay().FuegeZifferHinzu(Text);
                    break;
                case "Löschen":
                    b.getDisplay().LoescheLetzteZiffer();
                    break;
                case "Bestätigen":
                    switch (b.getDisplay().getZustand())
                    {
                        case 1: //Pin-Abfrage
                            string eingabe = b.getDisplay().getEingabe();
                            bool jn = b.getKartenlesegerät().checkPin(eingabe);
                            if (jn)
                            {
                                b.getDisplay().ReagiereAufJaNein(jn);
                            }
                            else
                            {
                                MessageBox.Show("PIN ist falsch");
                            }
                            break;
                        case 2://Betrags-Abfrage
                            int betrag = Convert.ToInt32(b.getDisplay().getEingabe());
                            b.getSchacht().GeldAuszahlen(betrag);
                            b.getDisplay().ZumGeldEntnehmenAuffodern();
                            break;
                    }
                    break;
            
            }
            */
        }
    }
}
