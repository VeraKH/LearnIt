//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCtest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.UserTables = new HashSet<UserTable>();
        }
    
        public int courseId { get; set; }
        public string courseName { get; set; }
        public System.DateTime courseDate { get; set; }
        public string CoursePhoto { get; set; }
        public string courseAbout { get; set; }
        public int categoryId { get; set; }
        public int usersId { get; set; }
    
        public virtual CourseCategory CourseCategory { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTable> UserTables { get; set; }
    }
}
