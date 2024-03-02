namespace DemoExamYM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Agents
    {
        [Key]
        public string AgentType { get; set; }

        [StringLength(100)]
        public string AgentName { get; set; }

        [Column("e-mail")]
        [StringLength(255)]
        public string e_mail { get; set; }

        [Column("Phone number")]
        [StringLength(100)]
        public string Phone_number { get; set; }

        [StringLength(100)]
        public string AgentLogo { get; set; }

        [StringLength(100)]
        public string Adress { get; set; }

        [StringLength(100)]
        public string Priority { get; set; }

        [StringLength(100)]
        public string Director { get; set; }

        [StringLength(100)]
        public string TIN { get; set; }

        [StringLength(100)]
        public string Checkpoint { get; set; }

        public string Image { get; set; }
    }
}
