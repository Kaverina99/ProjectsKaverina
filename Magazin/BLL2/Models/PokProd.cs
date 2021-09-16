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
        public int PokypkaId { get; set; }
        public int ProduktId { get; set; }
        
        public PokProdModel() { }
        public PokProdModel(PokProd PP)
        {
            Id = PP.Id;
            PokypkaId = PP.PokypkaId;
            ProduktId = PP.ProduktId;
        }
    }
}
