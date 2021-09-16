using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProduktModel
    {
        public int Id { get; set; }
        public string Nazvanie { get; set; }
        public DateTime Date_Birth { get; set; }
        public DateTime Date_Death { get; set; }
        public int Kolichestvo { get; set; }
        public double Cost { get; set; }
        public int Id_Tip_produkta_FK { get; set; }

        public ProduktModel() { }
        public ProduktModel(Produkt pr)
        {
            Id = pr.Id;
            Nazvanie = pr.Nazvanie;
            Date_Birth = pr.Date_Birth;
            Date_Death = pr.Date_Death;
            Kolichestvo = pr.Kolichestvo;
            Cost = pr.Cost;
            Id_Tip_produkta_FK = pr.Id_Tip_produkta_FK;
        }
    }
}