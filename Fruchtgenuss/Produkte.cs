using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruchtgenuss
{
    class Produkte
    {
        int id;
        double preis;
        string name;
     
        public Produkte(int id, double preis, string name)
        {
            this.id = id;
            this.preis = preis;
            this.name = name;
            
        }

       

        public double getpreis()
        {
            return preis;
        }

        public string getname()
        {
            return name;
        }

        public int getid()
        {
            return id;
        }



    }
}
