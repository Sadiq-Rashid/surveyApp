using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class SingleChoiceResponse
    {
        [Key]
        public Guid SingleChoiceResponseId { get; set; }
        [Display(Name = "Response")]
        [Required(ErrorMessage = "Response required")]
        public Guid ResponseId { get; set; }
        [Display(Name = "Question")]
        [Required(ErrorMessage = "Question is required")]
        public Guid QuestionId { get; set; }
        [Display(Name = "Choice")]
        [Required(ErrorMessage = "Choice is required")]
        public Guid ChoiceId { get; set; }


        public virtual Response Responses { get; set; }
        public virtual Question Question { get; set; }
        public virtual Choice Choice { get; set; }
    }
}