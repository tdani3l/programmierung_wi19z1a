//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bsp_ef_wpf
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nutzer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nutzer()
        {
            this.NachrichtenGesendet = new HashSet<Nachricht>();
            this.NachrichtenEmpfangen = new HashSet<Nachricht>();
        }
    
        public int ID_Nutzer { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nachricht> NachrichtenGesendet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nachricht> NachrichtenEmpfangen { get; set; }
    }
}
