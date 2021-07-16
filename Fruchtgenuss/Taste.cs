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
            
            Tastatur t = (Tastatur)Parent;
            Fruchtgenuss f = (Fruchtgenuss)t.Parent;
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
                    f.getDisplay().FuegeZifferHinzu(Text);
                    break;
                case "Löschen":
                    f.getDisplay().LoescheLetzteZiffer();
                    break;
                case "Bestätigen":

                    int auswahl= Convert.ToInt32(f.getDisplay().getTextbox());

                    int Reihe = auswahl / 7;
                    int Spalte = auswahl % 7;



                    f.getDisplay().AddlistboxItem();
                    break;
            
            }
            
        }
    }
}
