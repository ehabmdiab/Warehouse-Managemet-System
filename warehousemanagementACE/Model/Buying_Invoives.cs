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
    
    public partial class Buying_Invoives
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buying_Invoives()
        {
            this.buying_invoice_p = new HashSet<buying_invoice_p>();
        }
    
        public Nullable<System.DateTime> P_Date { get; set; }
        public Nullable<System.DateTime> buying_Date { get; set; }
        public Nullable<int> Expiry { get; set; }
        public int Order_Number { get; set; }
        public string W_Name { get; set; }
        public int S_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<buying_invoice_p> buying_invoice_p { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Warehouses Warehouses { get; set; }
    }
}
