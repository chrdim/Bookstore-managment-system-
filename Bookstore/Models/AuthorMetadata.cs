using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class AuthorMetadata
    {
        

        [Required]
        [RegularExpression(@"[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]",
        ErrorMessage = "The ID should be as the example.ex:156-80-6070.")]
        [Display(Name = "Id")]
        public object au_id;


        [Required]
        [StringLength(40, ErrorMessage = "The maxlenght of your input is 40 chars")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        [Display(Name = "Last name")]
        public string au_lname;


        [Required]
        [StringLength(20, ErrorMessage = "The maxlenght of your input is 20 chars")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        [Display(Name = "First name")]
        public string au_fname;

        [StringLength(12, ErrorMessage = "The maxlenght of your input is 12 chars")]
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only digits accepted.")]
        [Display(Name = "Phone")]
        public string phone;

        [StringLength(40,ErrorMessage ="The maxlenght of your input is 20 chars")]
        [Display(Name = "Address")]
        public string address;

        [StringLength(20,ErrorMessage ="The maxlenght of your input is 20 chars")]
        [Display(Name = "City")]
        public string city;

        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be 2-char word")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        [Display(Name = "State")]
        public string state;

        [StringLength(5,MinimumLength =5, ErrorMessage = "Zip must be 5-digit number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only digits accepted.")]
        [Display(Name = "Zip")]
        public string zip;


        [Required]
        [Display(Name = "Contract")]
        public string contract;
    }
}