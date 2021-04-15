using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class PublisherMetadata
    {
       

        [Required]
        [StringLength(4)]
        [RegularExpression("99[0-9][0-9]", ErrorMessage = "ID example: 99xx, where x is number.")]
        [Display(Name = "Pub id")]
        public string pub_id;

        [StringLength(40, ErrorMessage = "The maxlenght of your input is 40 chars")]
        [Display(Name = "Pub name")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string pub_name;

        [StringLength(20, ErrorMessage = "The maxlenght of your input is 20 chars")]
        [Display(Name = "City")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string city;

        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be 2-char word")]
        [Display(Name = "State")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string state;

        [StringLength(30, ErrorMessage = "The maxlenght of your input is 30 chars")]
        [Display(Name = "Country")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        public string country;
    }
}