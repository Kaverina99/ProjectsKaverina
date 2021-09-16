namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PokProd")]
    public partial class PokProd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int Pokypka_FK { get; set; }

        public int Produkt_FK { get; set; }

        public virtual Pokypka Pokypka { get; set; }

        public virtual Produkt Produkt { get; set; }
    }
}
