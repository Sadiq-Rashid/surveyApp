using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class MultipleChoiceResponse
    {
        [Key]
        public Guid MultipleChoiceResponseId { get; set; }
        [Display(Name="Response")]
        [Required(ErrorMessage ="Response is required")]
        public Guid ResponseId { get; set; }

        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is a required ")]
        public Guid Questionid { get; set; }

        public virtual Response Responses { get; set; }
        public virtual Question Questions { get; set; }
    }
}