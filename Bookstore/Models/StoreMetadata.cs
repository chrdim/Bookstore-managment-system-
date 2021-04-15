using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class StoreMetadata
    {
        

        [Required]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "The id must be 4-digit number")]
        [Display(Name = "Id")]
        public string stor_id;

        [StringLength(40)]
        [Display(Name = "Name")]
        public string stor_name;

        [StringLength(40)]
        [Display(Name = "Address")]
        public string stor_address;

        [StringLength(20)]
        [Display(Name = "City")]
        public string city;

        [StringLength(2)]
        [Display(Name = "State")]
        public string state;

        [StringLength(5)]
        [Display(Name = "Zip")]
        public string zip;
    }
}