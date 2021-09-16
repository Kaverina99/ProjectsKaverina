using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyProg.Models
{
    public class Klient
    {
        public Klient()
        {
            Realty = new HashSet<Realty>();
        }

        [Key]
        public int KlientId { get; set; }

        public string Name { get; set; }
        public string Passport { get; set; }
        public string Tell { get; set; }


        public virtual ICollection<Realty> Realty { get; set; }
    }
}
