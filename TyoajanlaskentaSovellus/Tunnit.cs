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
    
    public partial class Tunnit
    {
        public int TuntiId { get; set; }
        public int HenkiloId { get; set; }
        public int TyoId { get; set; }
        public Nullable<System.TimeSpan> Tuntimäärä { get; set; }
    
        public virtual Henkilot Henkilot { get; set; }
        public virtual Tyot Tyot { get; set; }
    }
}
