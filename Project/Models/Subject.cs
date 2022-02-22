using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace Project.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }



        [Display(Name = "Subject Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]

        public string SubjectName { get; set; }
    }
}
