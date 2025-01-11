using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreAdministration.Data
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }


        public virtual ProductCategory ProductCategory { get; set; }
    }
}
