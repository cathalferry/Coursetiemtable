//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseTimetable
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructor_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor_Table()
        {
            this.Course_Table = new HashSet<Course_Table>();
            this.Department_Table = new HashSet<Department_Table>();
        }
    
        public decimal ID_Number { get; set; }
        public string First_Name { get; set; }
        public string Initial { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Background { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Table> Course_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department_Table> Department_Table { get; set; }
    }
}
