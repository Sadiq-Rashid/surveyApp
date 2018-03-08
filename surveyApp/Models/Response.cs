using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace surveyApp.Models
{
    public class Response
    {
        [Key]
        public Guid ResponseId { get; set; }

        [DisplayName("Response Date")]
        [Required(ErrorMessage ="Response date is required")]
        public DateTime ResponseDate { get; set; }

        [DisplayName("Response Complete")]
        [Required(ErrorMessage ="ResponseComplete")]
        public bool ResponseComplete { get; set; }

        public Guid PersonId { get; set; }

        public Guid SurveyId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Survey Survey { get; set; }


    }
}