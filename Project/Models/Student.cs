using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Project.Models
{
    [Table("Students")]
    public class Student
    {
        [Display(Name = "Student Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Student_Id { get; set; }

        [Display(Name = "Enrollment Number")]
        [Required]
        [StringLength(20)]
        public string Enroll_No { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        [PersonalData]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateOfBirth { get; set; }



        [Display(Name = "Semester")]
        [Required]
        public int Semester { get; set; }

        

        


    }
}
