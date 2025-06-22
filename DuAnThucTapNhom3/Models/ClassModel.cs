using System;

namespace DuAnThucTapNhom3.Models
{
    public class ClassModel
    {
        public int ClassID { get; set; }
        public string? ClassName { get; set; }
        public string? ClassCode { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string? DepartmentID { get; set; }

        public int SubjectID { get; set; }

       
    }
}