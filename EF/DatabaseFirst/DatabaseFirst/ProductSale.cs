//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public int SaleId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> QuantitySold { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
