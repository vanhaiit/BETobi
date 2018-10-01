namespace TOBI.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommentForPlayer")]
    public partial class CommentForPlayer
    {
        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(10)]
        public string User_id { get; set; }

        [StringLength(10)]
        public string UserComment_id { get; set; }

        [StringLength(10)]
        public string Contents { get; set; }

        [StringLength(10)]
        public string Comment_Date { get; set; }

        [StringLength(10)]
        public string StarVote { get; set; }
    }
}
