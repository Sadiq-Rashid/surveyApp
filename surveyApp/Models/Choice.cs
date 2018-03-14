using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class Choice
    {
        [Key]
        public Guid ChoiceId { get; set; }

        [Display(Name = "Choice")]
        [Required(ErrorMessage ="Choice is required")]
        public string ChoiceText { get; set; }

        [Display(Name = "Choice Value")]
        [Required(ErrorMessage = "Choice Value is required")]
        public string ChoiceValue { get; set; }

        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public Guid QuestionId { get; set; }
         public virtual Question Questions { get; set; }

    }
}