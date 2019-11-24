namespace CountryStateDDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("State")]
    public partial class State
    {
        public int StateId { get; set; }

        [StringLength(100)]
        public string StateName { get; set; }

        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
