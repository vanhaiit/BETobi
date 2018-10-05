namespace TOBI.Model.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Match")]
    public partial class Match
    {
        [Key]
        public Guid Match_id { get; set; }

        [StringLength(256)]
        public string NameMatch { get; set; }

        public string Contents { get; set; }

        public int? BettingPrice { get; set; }

        [StringLength(256)]
        public string User_id { get; set; }

        [StringLength(256)]
        public string UserConfirmed { get; set; }

        public int? Startus { get; set; }

        [StringLength(256)]
        public string UserWin { get; set; }

        public int? Type { get; set; }
    }
}
