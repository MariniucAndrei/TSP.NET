//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelDesignFist_L1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int OrderId { get; set; }
        public decimal TotalValue { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerCustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
