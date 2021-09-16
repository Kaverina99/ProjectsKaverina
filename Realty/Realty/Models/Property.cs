using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyProg.Models
{
    public class Property
    {
        public Property()
        {
            Realty = new HashSet<Realty>();
        }

        [Key]
        public int PropertyId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Realty> Realty { get; set; }
    }
}
