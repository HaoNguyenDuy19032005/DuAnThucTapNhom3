using System;
using DuAnThucTapNhom3;

namespace DuAnThucTapNhom3.Models
{
    public class SubjectModel
    {
        public int SubjectID { get; set; } // Khóa chính
        public string? SubjectName { get; set; }
        public string? SubjectCode { get; set; }

        public int DefaultPeriodsSem1 { get; set; }
        public int DefaultPeriodsSem2 { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string? DepartmentID { get; set; }

        // Foreign key
        public int SubjectTypeID { get; set; }

        // Navigation property – liên kết với SubjectTypeModel
        public virtual SubjectTypeModel? SubjectType { get; set; }
    }
}
