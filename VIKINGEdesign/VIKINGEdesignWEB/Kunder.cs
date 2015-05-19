namespace VIKINGEdesignWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kunder")]
    public partial class Kunder
    {
        public Kunder()
        {
            Billeters = new HashSet<Billeter>();
        }

        [Key]
        public int KundeID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Navn { get; set; }

        [Required]
        public string Telefon { get; set; }

        public virtual ICollection<Billeter> Billeters { get; set; }
    }
}
