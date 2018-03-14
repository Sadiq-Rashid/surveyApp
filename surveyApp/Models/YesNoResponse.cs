using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class YesNoResponse
    {
        [Key]
        public Guid YesNoResponseId { get; set; }

        [Display(Name = "Response")]
        [Required(ErrorMessage = "Response is required")]
        public Guid ResponseId { get; set; }
        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public Guid QuestionIdId { get; set; }
        [Display(Name = "Response Value")]
        [Required(ErrorMessage = "Response Value is required")]
        public String YesNoResponseValue { get; set; }

        public virtual Response Responses { get; set; }
        public virtual Question Questions { get; set; }
    }
}