using DuAnThucTapNhom3.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DuAnThucTapNhom3.Models
{
    public class SubjectTypeModel
    {
        public int SubjectTypeID { get; set; }            // Khóa chính
        public string? SubjectTypeName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation property – Liên kết 1-n với SubjectModel
        [JsonIgnore]
        public virtual ICollection<SubjectModel>? Subjects { get; set; }
    }
}
