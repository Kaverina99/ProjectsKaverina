namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PokProd")]
    public partial class PokProd
    {
        public int Id { get; set; }

        public int PokypkaId { get; set; }

        public int ProduktId { get; set; }

        public virtual Pokypka Pokypka { get; set; }
    }
}
