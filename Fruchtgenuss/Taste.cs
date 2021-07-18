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
                    int auswahl= Convert.ToInt32(f.getDisplay().getTextbox()) - 1;

                    int x = auswahl % 7;
                    int y = (int)Math.Floor((double)auswahl / 7.0);

                    if (auswahl > 7 * 5)
                        return;

                    Box currentbox = f.getboxen(x, y);
                    Produkte prod = currentbox.getproduct();
                    
                    if (prod == null)
                        return;

                    f.getDisplay().AddWarenkorb(currentbox);
                    f.getDisplay().ClearEingabe();


                    break;
                case "Kaufen":
                    double preis = f.getDisplay().getPreis();
                    preis *= 1.0 - 0.2 * Convert.ToDouble(f.karte.isFilled());
                    if (f.geldbeutel.minusGuthaben(preis))
                    {
                        if (f.karte.isFilled())
                            f.karte.ClearPoints();
                        f.karte.AddPoint();
                        List<Box> warenkorb = f.getDisplay().GetWarenkorb();
                        foreach (var ware in warenkorb)
                        {
                            f.korb.Add(ware.getproduct());
                            ware.setproduct(null);
                        }

                        f.getDisplay().ClearWarenkorb();
                    }
                    break;
                case "Abbruch":
                    f.getDisplay().ClearWarenkorb();
                    f.getDisplay().ClearWarenkorb();
                    break;
            }
            
        }
    }
}
