//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StadiaProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastNames { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Score { get; set; }
        public string Group { get; set; }
        public Nullable<int> Course { get; set; }
    
        public virtual course course1 { get; set; }
    }
}
