using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class Survey
    {
        [Key]
        public Guid SurveyId { get; set; }

        [DisplayName("Survey Name")]
        [Required(ErrorMessage = "Survey name is required")]
        public string SurveyName { get; set; }

        [DisplayName("Survey Description")]
        [Required(ErrorMessage = "Survey Description is required")]
        public string SurveyDescription { get; set; }

        [DisplayName("Survey Description")]
        [Required(ErrorMessage = "Survey Description is required")]
        public string SurveyWelcome { get; set; }

        [DisplayName("Survey welcome message")]
        [Required(ErrorMessage = "Survey exit messsage is required")]
        public string SurveyExit { get; set; }

        [DisplayName("Survey Start Date")]
        [Required(ErrorMessage = "Survey StartDate is required")]
        public DateTime SurveyStartDate { get; set; }

        [DisplayName("Survey publication Date")]
        [Required(ErrorMessage = "Survey publication date is required")]
        public DateTime SurveyPublicationDate { get; set; }



        [DisplayName("Survey End Date")]
        [Required(ErrorMessage = "Survey EndDate is required")]
         public DateTime SurveyEndDate { get; se; }
    }
}