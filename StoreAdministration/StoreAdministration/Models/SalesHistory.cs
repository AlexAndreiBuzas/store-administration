﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAdministration.Data
{
    [Table("SalesHistories")]
    public class SalesHistory
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime? SaleDate { get; set; }


        public virtual Product Product { get; set; }
    }
}