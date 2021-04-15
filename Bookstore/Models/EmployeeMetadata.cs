using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class EmployeeMetadata
    {
        

        [Required]
        [StringLength(9)]
        [Display(Name = "Employee's id")]
        [RegularExpression("[A-Z][A-Z][A-Z][1-9][0-9][0-9][0-9][0-9][FM]+$",
            ErrorMessage = "ID example: ZZZxyyyyF or ZZZxyyyyM where Z is capital A-Z, x is a number from 1-9 and y from 0-9.")]
        public string emp_id;

        [Required]
        [StringLength(20, ErrorMessage = "The maxlenght of your input is 20 chars")]
        [Display(Name = "Firstname")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string fname;

        [StringLength(1, ErrorMessage = "The maxlenght of your input is 1 char")]
        [Display(Name = "Minit")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string minit;

        [Required]
        [StringLength(30,ErrorMessage = "The maxlenght of your input is 30 chars")]
        [Display(Name = "Lastname")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string lname;

        [Required]
        [Display(Name = "Job id")]
        public int job_id;

        //[Required]
        [StringLength(4)]
        [Display(Name = "Pub id")]
        public string pub_id;
    }
}