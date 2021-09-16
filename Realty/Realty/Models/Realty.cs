using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyProg.Models
{
    public class Realty
    {
        public Realty()
        {
            Sale = new HashSet<Sale>();
        }

        [Key]
        public int RealtyId { get; set; }

        public string Adress { get; set; }
        public int Area { get; set; }
        public int Cost { get; set; }
        
        public int? KlientId { get; set; }
        [ForeignKey("KlientId")]
        public Klient Klient { get; set; }

        public int? PropertyId { get; set; }
        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        public virtual ICollection<Sale> Sale { get; set; }

    }
}
