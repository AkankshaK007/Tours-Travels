//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DestinationDream
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransportCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTransportCompany()
        {
            this.tblTransportServices = new HashSet<tblTransportService>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> CityId { get; set; }
        public string HQAddress { get; set; }
        public Nullable<int> CompanyTypeId { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsPartner { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual tbl_Cities tbl_Cities { get; set; }
        public virtual tblCompanyType tblCompanyType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransportService> tblTransportServices { get; set; }
    }
}
