using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class Question
    {
        [Key]
        public Guid QuestionId { get; set; }

        [Display(Name ="Question Name")]
        [Required(ErrorMessage ="Qustion name required")]
        public string QuestionName { get; set; }
        [Display(Name = "Question Text")]
        [Required(ErrorMessage = "Qustion text required")]
        public string QuestionText { get; set; }

        [Display(Name = "Question Answer")]
        [Required(ErrorMessage = "Qustion Answer required")]
        public string QuestionAnswer { get; set; }
        [Display(Name = "Survey")]
        [Required(ErrorMessage = "Survey is required")]
        public Guid SurveyId { get; set; }
        [Display(Name = "Question Type")]
        [Required(ErrorMessage = "Qustion type required")]
        public Guid QuestionTyepeId { get; set; }

        public virtual Survey Surveys { get; set; }
        public virtual QuestionType QuestionTypes { get; set; }
    }
}