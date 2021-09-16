namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkt")]
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            PokProd = new HashSet<PokProd>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazvanie { get; set; }

        public DateTime Date_Birth { get; set; }

        public DateTime Date_Death { get; set; }

        public int Kolichestvo { get; set; }

        public double Cost { get; set; }

        public int Id_Tip_produkta_FK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PokProd> PokProd { get; set; }

        public virtual Tip_produkta Tip_produkta { get; set; }
    }
}
