using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tip_produktaModel
    {
        public int Id { get; set; }
        public string Naimenovanie { get; set; }


        public Tip_produktaModel() { }
        public Tip_produktaModel(Tip_produkta tp)
        {
            Id = tp.Id;
            Naimenovanie = tp.Naimenovanie;
        }
    }
}