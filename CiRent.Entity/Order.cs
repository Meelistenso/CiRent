﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiRent.Entity
{
    [Table("tOrder")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("cId")]
        public int Id { get; set; }

        [Column("cDescription")]
        public string Description { get; set; }

        [Column("cTotalPrice")]
        public decimal TotalPrice { get; set; }

        [Column("cIdUser")]
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        [Column("cState")]
        public string State { get; set; }
    }
}
