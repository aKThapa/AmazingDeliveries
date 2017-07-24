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

    public partial class Parcel
    {
        public int ParcelID { get; set; }

        [Required(ErrorMessage = "Please enter a name for the parcel")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a weight")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Please enter a type, box or letter")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Please enter a time")]
        public Nullable<System.TimeSpan> Time { get; set; }

        public int CustomID { get; set; }

        public virtual Customer Customer { get; set; }
    }
}