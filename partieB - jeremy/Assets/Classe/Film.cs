using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace tp2.partieB___jeremy.Assets.Classe
{ 
    public class Film
    {
        public int Id { get; set; }
        public Representation Representation { get; set; }
        public string Classement { get; set; }
        public string Version { get; set; }
        public bool IsESV { get; set; }
        public bool Is3D { get; set; }
        public string Image { get; set; }
        public List<string> Temps { get; set; }

    
    //public Film(int id, Representation res, string classement, string version, bool isESV, bool is3D, string image)
    //    {
    //        Id = id;
    //        Classement = classement;
    //        Representation = res;
    //        Version = version;
    //        IsESV = isESV;
    //        Is3D = is3D;
    //        Image = image;
    //    }

    }
}
