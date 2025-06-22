using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DuAnThucTapNhom3.Models
{
    public class SchoolYear
    {
        public int Id { get; set; }
        public string SchoolYearName { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime StartYear { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime EndYear { get; set; }

        [JsonIgnore]
        [Column(TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }

        [JsonIgnore]
        [Column(TypeName = "timestamp without time zone")]
        public DateTime UpdatedAt { get; set; }
    }
}
