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
        [Display(Name = "Unique Tag or Name")]
        [StringLength(30, ErrorMessage = "Must be at less than 30 character long.")]
        public string Tag { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is talkative")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q1 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tends to find faults with others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q2 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Does a thorough job")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q3 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Feels empty, depressed, blue")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q4 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is original, comes up with new ideas")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q5 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is reserved")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q6 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is helpful and unselfish with others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q7 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Can be somewhat careless")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q8 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is relaxed, handles stress well")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q9 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is curious about many different things")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q10 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is full of energy")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q11 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Argumentative, starts quarrels with others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q12 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is a reliable worker")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q13 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Can be tense")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q14 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is ingenious, a deep thinker")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q15 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Generates a lot of enthusiasm")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q16 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Has a forgiving nature")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q17 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tends to be disorganized")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q18 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Worries a lot")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q19 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Has an active imagination")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q20 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tends to be quiet")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q21 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is generally trusting")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q22 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tends to be lazy")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q23 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is emotionally stable, not easily upset")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q24 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is inventive")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q25 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Has an assertive personality")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q26 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Can be cold and aloof")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q27 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Perseveres until the task is finished")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q28 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Can be moody")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q29 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Values artistic, aesthetic experiences")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q30 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is sometimes shy, inhibited")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q31 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is considerate and kind to almost everyone")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q32 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Does things efficiently")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q33 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Remains calm in tense situations")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q34 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Prefers work that is routine")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q35 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is outgoing, sociable")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q36 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is sometimes rude to others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q37 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Makes plans and follows through with them")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q38 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Gets nervous easily")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q39 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Likes to reflect, play with ideas")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q40 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Has few artistic interests")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q41 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Likes to cooperate with others")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q42 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is easily distracted")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q43 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Is sophisticated in art, music or literature")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q44 { get; set; }

    }
}