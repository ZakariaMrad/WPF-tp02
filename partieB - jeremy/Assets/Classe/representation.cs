using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.partieB___jeremy.Assets.Classe
{
    public class Representation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duree { get; set; }
        public int TempsPublicitaire { get; set; }

        public Representation(int id, string name, string duree, int tempsPublicitaire)
        {
            Id = id;
            Name = name;
            Duree = duree;
            TempsPublicitaire = tempsPublicitaire;
        }
    }

}
