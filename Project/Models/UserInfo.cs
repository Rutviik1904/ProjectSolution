using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace Project.Models
{
    [Table("UserInfo")]
    public class UserInfo
    {



        [Display(Name = "User ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more that {1} character")]
        [MinLength(4, ErrorMessage = "{0} need minimum {1} characters")]
        public string UserName { get; set; }

        [Display(Name = "email address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [Range(minimum: 7, maximum: 100, ErrorMessage = "{0} needss to be between {1} {2}")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [Range(minimum: 1, maximum: 1000, ErrorMessage = "{0} needss to be between {1} {2}")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [Display(Name = "Confirm Password")]
        [StringLength(30, ErrorMessage = "cannot empty")]
        [Range(minimum: 7, maximum: 100, ErrorMessage = "{0} needss to be between {1} {2}")]
        public string CnfPassword { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(5, ErrorMessage = "{0} cannot be more that {1} character")]
        [MinLength(4, ErrorMessage = "{0} need minimum {1} characters")]
        public string Gender { get; set; }


        [Display(Name = "Mobile Number")]
        [Required]
        [StringLength(30)]
        public int Mobile_no { get; set; }

        [Display(Name = "User Type")]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        public string UserType { get; set; }





    }
}
