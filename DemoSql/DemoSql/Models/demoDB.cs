using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoSql.Models
{
    public class demoDB
    {
        [Key]

        public int id { get; set; }
        [Required(ErrorMessage ="Enter Date")]
        [Display(Name ="Date")]
        public string date { get; set; }
        [Required(ErrorMessage = "Enter Trade Code")]
        [Display(Name = "Trade Code")]
        public string trade_code { get; set; }
        [Required(ErrorMessage = "Enter High")]
        [Display(Name = "High")]
        public string high { get; set; }
        [Required(ErrorMessage = "Enter Low")]
        [Display(Name = "Low")]
        public string low { get; set; }
        [Required(ErrorMessage = "Enter Open")]
        [Display(Name = "Open")]
        public string open { get; set; }
        [Required(ErrorMessage = "Enter Close")]
        [Display(Name = "Close")]
        public string close { get; set; }
        [Required(ErrorMessage = "Volume")]
        [Display(Name = "Volume")]
        public string volume { get; set; }
    }
}
