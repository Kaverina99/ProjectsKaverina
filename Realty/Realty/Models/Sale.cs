using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyProg.Models
{
    public class Sale
    {
        public Sale()
        {
        }

        [Key]
        public int SaleId { get; set; }
        public DateTime Data { get; set; }

        public int? RealtyId { get; set; }
        [ForeignKey("RealtyId")]
        public Realty Realty { get; set; }

        public int? AgentId { get; set; }
        [ForeignKey("AgentId")]
        public Agent Agent { get; set; }
        
    }
}
