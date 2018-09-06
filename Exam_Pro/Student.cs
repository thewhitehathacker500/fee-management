namespace Exam_Pro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(10)]
        public string id { get; set; }

        [StringLength(3)]
        public string Marks { get; set; }
    }
}
