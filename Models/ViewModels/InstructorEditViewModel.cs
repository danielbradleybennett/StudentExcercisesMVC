using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorEditViewModel
    {
        public int InstructorId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        [MinLength(2, ErrorMessage = "First Name should be at least 2 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [MinLength(2, ErrorMessage = "Last Name should be at least 2 characters")]
        public string LastName { get; set; }
        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }

        [Display(Name = "Specialty")]
        [Required(ErrorMessage = "Specialty is Required")]
        [MinLength(2, ErrorMessage = "Specialty should be at least 2 characters")]
        public string Specialty { get; set; }

        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }


    }
}
