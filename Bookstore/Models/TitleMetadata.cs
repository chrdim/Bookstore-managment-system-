using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class TitleMetadata
    {
       

        [Required]
        [StringLength(6)]
        [Display(Name = "Id")]
        public string title_id;

        [Required]
        [StringLength(80)]
        [Display(Name = "Title")]
        public string title1;

        [Required]
        [StringLength(12, ErrorMessage = "The maxlenght of your input is 12 chars")]
        [RegularExpression("^[a-zA-Z _]+$", ErrorMessage = "Only letters accepted.")]
        [Display(Name = "Type")]
        public string type;

        [MaxLength(12)]
        [Display(Name = "Price")]
        
        public Decimal price;

        [MaxLength(12)]
        [Display(Name = "Advance")]
       
        public Decimal advance;

        [StringLength(200, ErrorMessage = "The maxlenght of your input is 200 chars")]
        [Display(Name = "Notes")]
        public string notes;
    }
}