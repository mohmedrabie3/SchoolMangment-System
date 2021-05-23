namespace school
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public int PassWord { get; set; }

        public int? Phone { get; set; }

        [StringLength(10)]
        public string City { get; set; }
    }
}
