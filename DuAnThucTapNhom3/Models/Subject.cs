using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DuAnThucTapNhom3.Models
{
    public class Subject
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

        public int DefaultPeriodsSem1 { get; set; }
        public int DefaultPeriodsSem2 { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; }

        public int? DepartmentID { get; set; }

        [JsonIgnore]
        public Department Department { get; set; }

        public int? SubjectTypeID { get; set; }

        [JsonIgnore]
        public SubjectType SubjectType { get; set; }
    }
}
