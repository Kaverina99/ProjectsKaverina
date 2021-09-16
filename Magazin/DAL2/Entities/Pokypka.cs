namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pokypka")]
    public partial class Pokypka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pokypka()
        {
            PokProd = new HashSet<PokProd>();
        }

        public int Id { get; set; }

        public decimal Stoimost { get; set; }

        public DateTime Date { get; set; }

        public int Id_Sotrydnik_Fk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PokProd> PokProd { get; set; }

        public virtual Sotrydnik Sotrydnik { get; set; }
    }
}
