//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace warehousemanagementACE.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.buying_invoice_p = new HashSet<buying_invoice_p>();
            this.selling_invoice_p = new HashSet<selling_invoice_p>();
        }
    
        public int P_Id { get; set; }
        public string Measuring_unit { get; set; }
        public string p_Name { get; set; }
        public string W_name { get; set; }
        public Nullable<int> amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buying_invoice_p> buying_invoice_p { get; set; }
        public virtual Warehouses Warehouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<selling_invoice_p> selling_invoice_p { get; set; }
    }
}
