//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_ContentColumn
    {
        public hcc_ContentColumn()
        {
            this.hcc_ContentBlock = new HashSet<hcc_ContentBlock>();
        }
    
        public System.Guid bvin { get; set; }
        public string DisplayName { get; set; }
        public int SystemColumn { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
    
        public virtual ICollection<hcc_ContentBlock> hcc_ContentBlock { get; set; }
    }
}