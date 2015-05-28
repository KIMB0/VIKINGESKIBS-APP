namespace VIKINGEdesignWEB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VikingeSkibe")]
    public partial class VikingeSkibe
    {
        public int VikingeSkibeID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int AntalPladser { get; set; }

        [Required]
        public string Beskrivelse { get; set; }

        [Required]
        public string YderligereInformationer { get; set; }

        [Required]
        public string Billede { get; set; }
    }
}
