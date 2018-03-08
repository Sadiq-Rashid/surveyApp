using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace surveyApp.Models
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        [Required(ErrorMessage ="Middle name is required ")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required ")]
        public string LastName { get; set; }


        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required ")]
        public string Gender { get; set; }

        [DisplayName("BirthDate")]
        [Required(ErrorMessage = "BirthDate is required ")]
        public DateTime BirthDate { get; set; }


    }
}