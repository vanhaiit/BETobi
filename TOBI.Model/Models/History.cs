namespace TOBI.Model.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("History")]
    public partial class History
    {
        [Key]
        [StringLength(10)]
        public string History_id { get; set; }

        [StringLength(10)]
        public string User_id { get; set; }

        [StringLength(10)]
        public string DateHistory { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(10)]
        public string Contents { get; set; }
    }
}
