//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartRetailSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop
    {
        public string ShopID { get; set; }
        public string ShopName { get; set; }
        public string ProID { get; set; }
        public string ShopDescription { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
