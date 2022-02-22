using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project.Models
{
    [Table("Assignments")]
    public class Assignment
    {
        [Display(Name = "Assignment Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Assignment_Id { get; set; }


        [Display(Name = "Assignment Title")]
        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string Assignment_Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }


        

        [Display(Name = "Assignment StartingDate")]
        [Required]
        public DateTime Assignment_StartingDate { get; set; }

        [Display(Name = "Assignment EndingDate")]
        [Required]
        public DateTime Assignment_EndingDate { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }


    }
}
