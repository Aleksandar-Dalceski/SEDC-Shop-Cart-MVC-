using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomasnaShoppingCart.Models.ShoppAdmin
{
    public class Shopping
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Boot Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Boot Price")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Boot Quantity")]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Expiry Date")]
        public DateTime Expiry { get; set; }

        [Required]
        [DisplayName("Boot Category")]
        public string Category { get; set; }

        [Required]
        [DisplayName("Boot Brand")]
        public string Brand { get; set; }

        [Required]
        [DisplayName("Boot Logo")]
        public string LogoUrl { get; set; }

    }
}
