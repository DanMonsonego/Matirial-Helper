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
    
    public partial class tbSupportedInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbSupportedInfo()
        {
            this.tbContextVolunteerSupporteds = new HashSet<tbContextVolunteerSupported>();
        }
    
        public int Id { get; set; }
        public string strRequest { get; set; }
        public int Supported_Id { get; set; }
        public Nullable<System.TimeSpan> Hours { get; set; }
        public int Active_Id { get; set; }
    
        public virtual tbActivity tbActivity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbContextVolunteerSupported> tbContextVolunteerSupporteds { get; set; }
        public virtual tbUser tbUser { get; set; }
    }
}
