using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SotrydnikModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }


        public SotrydnikModel() { }
        public SotrydnikModel(Sotrydnik s)
        {
            Id = s.Id;
            Name = s.Name;
            Position = s.Position;
        }
    }
}