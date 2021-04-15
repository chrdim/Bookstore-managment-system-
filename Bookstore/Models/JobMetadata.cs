using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class JobMetadata
    {
       
        [Required]
        [Display(Name = "Job id")]
        public Int16 job_id;

        //[Required]
        [Display(Name = "Job desc")]
        [StringLength(50)]
        public string job_desc;

        [Required]
        [Display(Name = "Min lvl")]
        [Range(10, 250)]
        public Byte min_lvl;


        [Required]
        [Display(Name = "Max lvl")]
        [Range(10, 250)]
        public Byte max_lvl;
    }
}