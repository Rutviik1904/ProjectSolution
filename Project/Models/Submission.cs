using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Project.Models
{
    [Table("Submissions")]
    public class Submission
    {
        [Display(Name = "Submission Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Submission_Id { get; set; }


        [Display(Name = "Submission Time")]
        [Required]
        public DateTime Submission_Time { get; set; }

        [Display(Name = "Submission Document")]
        [StringLength(50)]
        [Required]
        public string Submission_Document { get; set; }

        [Display(Name = "Comment")]
        [StringLength(200)]
        public string Comment { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }
    }
}
