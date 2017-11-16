using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone490.Models
{
    public class Survey
    {
        public int SurveyID { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is talkative")]
        [Range(1,5, ErrorMessage = "Score must be 1 - 5")]
        public int Q1 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tends to find faults with others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
        public int Q6 { get; set; }
        public int Q7 { get; set; }
        public int Q8 { get; set; }
        public int Q9 { get; set; }
        public int Q10 { get; set; }

    }
}