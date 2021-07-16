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
        float preis;
        string name;
        string path;
        public Produkte(int id, float preis, string name, string path)
        {
            this.id = id;
            this.preis = preis;
            this.name = name;
            this.path = path;
        }
    }
}
