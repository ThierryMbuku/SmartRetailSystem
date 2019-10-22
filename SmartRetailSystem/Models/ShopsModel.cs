using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRetailSystem.Models
{
    [Table("Product")]
    public class ShopsModel
    {
        public string ShopID { get; set; }
        public string ShopName { get; set; }

        public string ShopDescription { get; set; }

        public string ProID { get; set; }

        public List<Product> products { get; set; }
    }
}