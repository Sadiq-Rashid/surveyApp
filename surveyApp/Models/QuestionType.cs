using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class QuestionType
    {
        [Key]
        public Guid QuestionTypeId { get; set; }

        [Display(Name ="Question Type Name")]
        [Required(ErrorMessage ="Question Type Name")]
        public string QuestionTypeName { get; set; }
        [Display(Name = "QuestionType Choices")]
        [Required(ErrorMessage = "QuestionTypeChoices")]
        public string QuestionTypeChoices { get; set; }
    }
}