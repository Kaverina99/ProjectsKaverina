namespace DAL.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Seal")]
    public partial class Seal
    {


        [ForeignKey("NameSreda")]
        public virtual Sreda Sreda { get; set; }

        [ForeignKey("TipH")]
        public virtual Tip_Hol Tip_Hol { get; set; }

        [ForeignKey("TipS")]
        public virtual Tip_Seal Tip_Seal { get; set; }

        [ForeignKey("NameMaterial")]
        public virtual Material Material { get; set; }



        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string NameSeal { get; set; }

        public int TipS { get; set; }

        public int TipH { get; set; }

        public double Dv { get; set; }

        public double D1 { get; set; }

        public double? D3 { get; set; }

        public double L2 { get; set; }

        public double L1 { get; set; }

        public double? D2 { get; set; }

        public double? Dsh { get; set; }

        public double? N { get; set; }

        public double A { get; set; }

        [StringLength(30)]
        public string Nasos { get; set; }

        public int NameSreda { get; set; }

        public double C { get; set; }

        public double Davl { get; set; }

        public int? NameMaterial { get; set; }

        public double? M_netto { get; set; }

        [StringLength(100)]
        public string Features { get; set; }

        public double? Cost1 { get; set; }

        public double? Cost6 { get; set; }

        public double? CostZ { get; set; }
    }
}
