namespace VIKINGEdesignWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Billeter")]
    public partial class Billeter
    {
        public Billeter()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int BilletID { get; set; }

        public int KundeID { get; set; }

        public int AntalBorn { get; set; }

        public int AntalSuderende { get; set; }

        public int AntalVoksen { get; set; }

        public DateTime Dato { get; set; }

        public double Pris { get; set; }

        public bool? Sejltur { get; set; }

        public virtual Kunder Kunder { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
