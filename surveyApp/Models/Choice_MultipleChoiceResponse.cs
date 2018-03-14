using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class Choice_MultipleChoiceResponse
    {
        [Key]
        public Guid Choice_MultipleChoiceResponseId { get; set; }

        [Display(Name ="Choice")]
        [Required(ErrorMessage ="Choice is rquired")]
        public Guid ChoiceId { get; set; }

        [Display(Name = "Response")]
        [Required(ErrorMessage = "Response is rquired")]
        public Guid ResponseId { get; set; }

        [Display(Name = "QuestionId")]
        [Required(ErrorMessage = "Question is rquired")]
        public Guid QuestionId { get; set; }

        public virtual Choice Choices { get; set; }
        public virtual Response Responses { get; set; }
        public virtual Question Questions { get; set; }
    }
}