namespace Intelligence.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Journal")]
    public partial class Journal
    {
        public int id { get; set; }

        public int? Userid_Users { get; set; }

        public int? Testsid_Tests { get; set; }

        public int? Score { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
