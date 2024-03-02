namespace DemoExamYM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSale")]
    public partial class ProductSale
    {
        [StringLength(100)]
        public string Products { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [StringLength(100)]
        public string Date { get; set; }

        [StringLength(100)]
        public string Quantity { get; set; }

        public int? Sale { get; set; }
    }
}
