namespace VIKINGEdesignWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Priser")]
    public partial class Priser
    {
        [Key]
        public int PrisID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pris { get; set; }

        [Required]
        public string Gruppe { get; set; }
    }
}
