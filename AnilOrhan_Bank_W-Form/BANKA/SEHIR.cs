//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BANKA
{
    using System;
    using System.Collections.Generic;
    
    public partial class SEHIR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEHIR()
        {
            this.TBL_MUSTERI = new HashSet<TBL_MUSTERI>();
        }
    
        public string plaka { get; set; }
        public string sehirad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MUSTERI> TBL_MUSTERI { get; set; }
    }
}