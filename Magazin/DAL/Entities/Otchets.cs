using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities

{
    public class OtchetProspochka
    {
        public int Id { get; set; }
        public DateTime Date_Death { get; set; }
        public string Nazvanie { get; set; }
        public string Tip { get; set; }
        public double Cost { get; set; }
        public int Kolichestvo { get; set; }
        public double TotalCost { get; set; }
    }

    public class OtchetTipov
    {
        public int Id { get; set; }
        public string Nazvanie { get; set; }
        public double Cost { get; set; }
        public int Kolichestvo { get; set; }
        public DateTime Date_Birth { get; set; }
        public DateTime Date_Death { get; set; }
    }
}