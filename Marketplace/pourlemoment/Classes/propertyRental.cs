using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Marketplace.pourlemoment.Classes
{
    public class propertyRental:Offer
    {
        public int NombresDeChambre = 0;
        public int NombresDeSalleDeBain = 0;
        public enum TypeDePropirété {
            apartment,
            house,
            RoomOnly
        }
    }
    
}
