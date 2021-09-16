using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtyProg.Models
{
    public class Agent
    {
        public Agent()
        {
            Sale = new HashSet<Sale>();
        }

        [Key]
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }


        public virtual ICollection<Sale> Sale { get; set; }

    }
}
