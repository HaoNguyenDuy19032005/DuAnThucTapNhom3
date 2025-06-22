using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DuAnThucTapNhom3.Models
{
    public class SubjectType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        public string SubjectTypeName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]
        public ICollection<Subject>? Subjects { get; set; }
    }
}
