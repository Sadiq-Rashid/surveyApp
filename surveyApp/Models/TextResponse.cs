using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class TextResponse
    {
        [Key]
        public Guid TextResponseId { get; set; }

        [Display(Name = "Response")]
        [Required(ErrorMessage = "Response is required")]
        public Guid ResponseId { get; set; }
        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public Guid QuestionIdId { get; set; }
        [Display(Name = "Text Response Value")]
        [Required(ErrorMessage = "Text ResponseValue is required")]
        public String TextResponseValue { get; set; }

        public virtual Response Responses { get; set; }
        public virtual Question Questions { get; set; }
    }
}