//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaterialLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbActivity()
        {
            this.tbSupportedInfoes = new HashSet<tbSupportedInfo>();
            this.tbVolunteerInfoes = new HashSet<tbVolunteerInfo>();
        }
    
        public int Id { get; set; }
        public string strDescription_Activity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSupportedInfo> tbSupportedInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbVolunteerInfo> tbVolunteerInfoes { get; set; }
    }
}