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
    
    public partial class Product
    {
        public Product()
        {
            this.PromotionProducts = new HashSet<PromotionProduct>();
        }
    
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<PromotionProduct> PromotionProducts { get; set; }
        public virtual User User { get; set; }
    }
}
