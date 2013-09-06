//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promotion
    {
        public Promotion()
        {
            this.PromotionProducts = new HashSet<PromotionProduct>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Countryid { get; set; }
        public int BranchId { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public decimal Price { get; set; }
        public bool Isdeleted { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
    }
}