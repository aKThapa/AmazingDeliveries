//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmazingDeliveries.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Parcels = new HashSet<Parcel>();
        }

        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please Enter your first name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please Enter your phone no")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter your email")]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parcel> Parcels { get; set; }
    }
}
