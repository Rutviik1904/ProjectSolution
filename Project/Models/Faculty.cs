using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project.Models
{
    [Table("Faculties")]
    public class Faculty
    {
        [Display(Name = "User ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "Faculty Type")]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        public string FacultyType { get; set; }

        [Display(Name = "Subjects")]
        [Required(ErrorMessage = "{0} cannot be empty")]

        public string Subject { get; set; }


    }
}
