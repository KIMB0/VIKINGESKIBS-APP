namespace VIKINGEdesignWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int BookingID { get; set; }

        public int KundeID { get; set; }

        public int BilletID { get; set; }

        public virtual Billeter Billeter { get; set; }

        public virtual Kunder Kunder { get; set; }
    }
}
