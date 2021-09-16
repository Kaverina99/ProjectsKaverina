using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PokProdModel
    {
        public int Id { get; set; }
        public int Pokypka_FK { get; set; }
        public int Produkt_FK { get; set; }
        
        public PokProdModel() { }
        public PokProdModel(PokProd PP)
        {
            Id = PP.Id;
            Pokypka_FK = PP.Pokypka_FK;
            Produkt_FK = PP.Produkt_FK;
        }
    }
}
