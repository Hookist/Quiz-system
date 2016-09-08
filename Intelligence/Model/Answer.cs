namespace Intelligence.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(128)]
        public string AnswerText { get; set; }

        public bool? isTrue { get; set; }

        public int? Questionid_Questions { get; set; }

        public virtual Question Question { get; set; }
    }
}
