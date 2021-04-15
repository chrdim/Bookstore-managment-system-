//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookstore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class title
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public title()
        {
            this.sales = new HashSet<sale>();
            this.titleauthors = new HashSet<titleauthor>();
        }
    
        public string title_id { get; set; }
        public string title1 { get; set; }
        public string type { get; set; }
        public string pub_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> advance { get; set; }
        public Nullable<int> royalty { get; set; }
        public Nullable<int> ytd_sales { get; set; }
        public string notes { get; set; }
        public System.DateTime pubdate { get; set; }
    
        public virtual publisher publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sale> sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<titleauthor> titleauthors { get; set; }
        public virtual roysched roysched { get; set; }
    }
}