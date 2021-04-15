using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class TitleauthorMetadata
    {
        
        [Display(Name = "Au ord")]
        [Range(0, 255, ErrorMessage = "Values must be betweeen 0 and 255")]
        public Byte au_ord;
    }
}