using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class DateResponse
    {
        [Key]
        public Guid DateResponseId { get; set; }
        [Display(Name ="Response")]
        [Required(ErrorMessage ="Response is required")]
        public Guid ResponseId { get; set; }
        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public Guid QuestionIdId { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime DateResponseValue { get; set; }

        public virtual Response Responses { get; set; }
        public virtual Question Questions { get; set; }
    }
}