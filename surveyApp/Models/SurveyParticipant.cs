using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class SurveyParticipant
    {
        [Key]
        public Guid SurveyParticipantId { get; set; }

       [Display(Name ="Person")]
       [Required(ErrorMessage ="Person is required")]
       public Guid personId { get; set; }

        [Display(Name = "Survey")]
        [Required(ErrorMessage = "Survey is required")]
        public Guid SurveyId { get; set; }

        [Display(Name = "Enail Address")]
        [Required(ErrorMessage = "Email Adress is required")]
        public String Email { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date Adress is required")]
        public DateTime ParticipationDate { get; set; }

        public virtual Person People { get; set; }

        public virtual Survey Surveys { get; set; }
    }
}