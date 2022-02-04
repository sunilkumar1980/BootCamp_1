using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BC.Api.Helper
{
    [Table("TblStudents")]
    public class StudentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [MaxLength(500)]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [MaxLength(500)]
        public string MiddleName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [MaxLength(500)]
        public string LastName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy", ApplyFormatInEditMode = true)]
        public DateTime DateofBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [MaxLength(1)]

        public int Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "It is Mandatory Field")]
        [MaxLength(1)]
        public int Category { get; set; }
    }
}
