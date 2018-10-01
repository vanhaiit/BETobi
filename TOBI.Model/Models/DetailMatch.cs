namespace TOBI.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailMatch")]
    public partial class DetailMatch
    {
        [StringLength(256)]
        public string Match_id { get; set; }

        [Key]
        public Guid MatchDetail_id { get; set; }

        [StringLength(256)]
        public string User_id { get; set; }

        [StringLength(256)]
        public string GameAccount_id { get; set; }

        [StringLength(256)]
        public string Team { get; set; }
    }
}
