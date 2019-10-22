using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SmartRetailSystem.Models
{
    public class ProductModel
    {
        public string ProID { get; set; }
        public string ProName { get; set; }

        public string ProDescription { get; set; }

        public string ProPrice { get; set; }

        public string ProStock { get; set; }
    }
}