namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.ComponentModel;

    [Table("Produkt")]
    public partial class Produkt
    {
        //[DisplayName("Номер")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazvanie { get; set; }

        public DateTime Date_Birth { get; set; }

        public DateTime Date_Death { get; set; }

        public int Kolichestvo { get; set; }

        public decimal Cost { get; set; }

        public int Id_Tip_produkta_FK { get; set; }

        public virtual Tip_produkta Tip_produkta { get; set; }
    }
}
