using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DuAnThucTapNhom3.Models
{
    public class Teacher
    {
        [Key]
        [Column("TeacherID")]
        public int Id { get; set; }

        public string TeacherCode { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Ethnicity { get; set; }

        public DateTime HireDate { get; set; }

        public string Nationality { get; set; }

        public string Religion { get; set; }

        public string Status { get; set; }

        public string Alias { get; set; }

        public string Address_ProvinceCity { get; set; }

        public string Address_Ward { get; set; }

        public string Address_District { get; set; }

        public string Address_Street { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? DateOfJoiningTheParty { get; set; }

        public DateTime? DateOfJoiningGroup { get; set; }

        public bool IsPartyMember { get; set; }

        // Foreign Keys
        public int? DepartmentID { get; set; }
        public int? SubjectID { get; set; }
        public int? SchoolYearID { get; set; }
        public int? ContactID { get; set; }

        // Navigation Properties
        [ForeignKey("DepartmentID")]
        [JsonIgnore]
        public Department Department { get; set; }

        [ForeignKey("SubjectID")]
        [JsonIgnore]
        public Subject Subject { get; set; }

        [ForeignKey("SchoolYearID")]
        [JsonIgnore]
        public SchoolYear SchoolYear { get; set; }

        [ForeignKey("ContactID")]
        [JsonIgnore]
        public Contact Contact { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "timestamp without time zone")]
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
