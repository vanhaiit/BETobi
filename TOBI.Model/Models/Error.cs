namespace TOBI.Model.Models
{
    using System;

    public partial class Error
    {
        public int ID { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
