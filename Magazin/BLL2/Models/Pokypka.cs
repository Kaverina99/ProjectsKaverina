using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PokypkaModel
    {
        public int Id { get; set; }
        public decimal Stoimost { get; set; }
        public DateTime Date { get; set; }
        public int Id_Sotrydnik_Fk { get; set; }

        public List<int> SpisokProduktov { get; set; }

        public PokypkaModel() { }
        public PokypkaModel(Pokypka p)
        {
            Id = p.Id;
            Stoimost = p.Stoimost;
            Date = p.Date;
            Id_Sotrydnik_Fk = p.Id_Sotrydnik_Fk;
            SpisokProduktov = p.PokProd.Select(i => i.ProduktId).ToList();
        }
    }
}