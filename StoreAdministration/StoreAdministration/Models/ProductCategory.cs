﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAdministration.Data
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}