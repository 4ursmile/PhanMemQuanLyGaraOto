//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanMemQuanLyGaraOto.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIENCONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIENCONG()
        {
            this.CHITIET_PSC = new HashSet<CHITIET_PSC>();
        }
    
        public int MANDTC { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<decimal> TIENCONG1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_PSC> CHITIET_PSC { get; set; }
    }
}
