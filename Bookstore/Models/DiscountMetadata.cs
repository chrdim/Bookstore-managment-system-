using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class DiscountMetadata
    {
       
        [Required]
        [StringLength(40, ErrorMessage = "The maxlenght of your input is 40 chars")]
        [Display(Name = "Discount Type")]
        public string discounttype;

        [StringLength(4,MinimumLength =4,ErrorMessage ="The id must be 4-digit number")]
        [Display(Name = "Store's id")]
        public string stor_id;

        [Display(Name = "Low quantity")]
        [Range(-32768, 32767)]
        public string lowqty;

        [Display(Name = "High quantity")]
        [Range(-32768, 32767)]
        public string highqty;

        [Required]
        [Display(Name = "Discount")]
        [RegularExpression("^[0-9]{1,2}(.[0-9]{2})?$", ErrorMessage = "Acceptable number is a decimal one with a precision of two.")]
        public float discount1;
    }
}