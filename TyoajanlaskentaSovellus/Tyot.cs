//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TyoajanlaskentaSovellus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tyot
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tyot()
        {
            this.Tunnit = new HashSet<Tunnit>();
        }
    
        public int TyoId { get; set; }
        public string Tyotunniste { get; set; }
        public string Kuvaus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tunnit> Tunnit { get; set; }
    }
}
