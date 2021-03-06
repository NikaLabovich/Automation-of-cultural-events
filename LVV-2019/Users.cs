//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LVV_2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.UserEvents = new HashSet<UserEvents>();
            this.UserInterests = new HashSet<UserInterests>();
        }
    
        public int Id { get; set; }
        public int CredentialsId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime Birthday { get; set; }
        public int RoleId { get; set; }
        public int AddressId { get; set; }
    
        public virtual Addresses Addresses { get; set; }
        public virtual Credentials Credentials { get; set; }
        public virtual Roles Roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserEvents> UserEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInterests> UserInterests { get; set; }
    }
}
