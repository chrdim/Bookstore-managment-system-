using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class SaleMetadata
    {

       
        [Required]
        [StringLength(4)]
        [Display(Name = "Store id")]
        public string stor_id;

        [Required]
        [StringLength(20, ErrorMessage = "The maxlenght of your input is 20 chars")]
        [Display(Name = "Ord num")]
        public string ord_num;

        [Required]
        [Display(Name = "Ord date")]
        public DateTime ord_date;

        [Required]
        [Range(0, 32767, ErrorMessage = "Quantity values starts from 0.")]
        [Display(Name = "Quantity")]
        public string qty;

        [Required]
        [StringLength(12, ErrorMessage = "The maxlenght of your input is 12 chars")]
        [Display(Name = "Payterms")]
        public string payterms;

        [Required]
        [StringLength(6)]
        [Display(Name = "Title id")]
        public string title_id;
    }
}