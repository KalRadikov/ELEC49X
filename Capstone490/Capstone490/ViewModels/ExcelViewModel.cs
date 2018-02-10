using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Capstone490.ViewModels
{
    public class ExcelViewModel
    {

        public string Tag { get; set; }

        public double Openness { get; set; }

        public double Conscientiousness { get; set; }

        public double Extraversion { get; set; }

        public double Agreeableness { get; set; }

        public double Neuroticism { get; set; }

        [Display(Name = "General: Sports")]
        public int Q1 { get; set; }

        [Display(Name = "Fresh Water Sports")]
        public int Q2 { get; set; }


        [Display(Name = "Ocean Water Sports")]
        public int Q3 { get; set; }


        [Display(Name = "Hockey")]
        public int Q4 { get; set; }


        [Display(Name = "Martial Arts/Combat Sports")]
        public int Q5 { get; set; }


        [Display(Name = "Yoga")]
        public int Q6 { get; set; }


        [Display(Name = "Winter Mountain Sports")]
        public int Q7 { get; set; }


        [Display(Name = "Summer Mountain Sports")]
        public int Q8 { get; set; }


        [Display(Name = "Water Sports")]
        public int Q9 { get; set; }


        [Display(Name = "Volleyball")]
        public int Q10 { get; set; }


        [Display(Name = "American Football")]
        public int Q11 { get; set; }


        [Display(Name = "Soccer (Football)")]
        public int Q12 { get; set; }


        [Display(Name = "Baseball/Softball")]
        public int Q13 { get; set; }


        [Display(Name = "Basketball")]
        public int Q14 { get; set; }


        [Display(Name = "Cricket")]
        public int Q15 { get; set; }


        [Display(Name = "Dance/Figure Skating/Gymnastics")]
        public int Q16 { get; set; }


        [Display(Name = "Wight Lifting")]
        public int Q17 { get; set; }


        [Display(Name = "Rugby")]
        public int Q18 { get; set; }


        [Display(Name = "Lacrosse")]
        public int Q19 { get; set; }


        [Display(Name = "Hunting")]
        public int Q20 { get; set; }


        [Display(Name = "Archery")]
        public int Q21 { get; set; }


        [Display(Name = "Cardiovascular sports (running, swimming, biking etc.)")]
        public int Q22 { get; set; }


        [Display(Name = "Golf")]
        public int Q23 { get; set; }


        [Display(Name = "Raquet Sports")]
        public int Q24 { get; set; }


        [Display(Name = "General: Games")]
        public int Q25 { get; set; }


        [Display(Name = "Board Games")]
        public int Q26 { get; set; }


        [Display(Name = "Card Games")]
        public int Q27 { get; set; }


        [Display(Name = "Video Games")]
        public int Q28 { get; set; }


        [Display(Name = "Phone Games")]
        public int Q29 { get; set; }


        [Display(Name = "Trivia Games")]
        public int Q30 { get; set; }


        [Display(Name = "Word Games")]
        public int Q31 { get; set; }


        [Display(Name = "Hours a week playing games")]
        public int Q32 { get; set; }


        [Display(Name = "General: Entertainment")]
        public int Q33 { get; set; }


        [Display(Name = "Books: Fiction")]
        public int Q34 { get; set; }


        [Display(Name = "Books: Non-fiction")]
        public int Q35 { get; set; }


        [Display(Name = "Movies")]
        public int Q36 { get; set; }


        [Display(Name = "T.V.")]
        public int Q37 { get; set; }


        [Display(Name = "Youtube/Twitch")]
        public int Q38 { get; set; }


        [Display(Name = "Theatre/Concerts")]
        public int Q39 { get; set; }


        [Display(Name = "Hours a week consuming entertainment")]
        public int Q40 { get; set; }


        [Display(Name = "General: Personal Interests")]
        public int Q41 { get; set; }


        [Display(Name = "Science")]
        public int Q42 { get; set; }


        [Display(Name = "Technology")]
        public int Q43 { get; set; }


        [Display(Name = "Business")]
        public int Q44 { get; set; }


        [Display(Name = "Self Improvement")]
        public int Q45 { get; set; }


        [Display(Name = "Art")]
        public int Q46 { get; set; }


        [Display(Name = "Music")]
        public int Q47 { get; set; }


        [Display(Name = "Cooking")]
        public int Q48 { get; set; }


        [Display(Name = "Meditation")]
        public int Q49 { get; set; }


        [Display(Name = "Gardening")]
        public int Q50 { get; set; }


        [Display(Name = "Theatre")]
        public int Q51 { get; set; }


        [Display(Name = "Film")]
        public int Q52 { get; set; }


        [Display(Name = "Socializing")]
        public int Q53 { get; set; }


        [Display(Name = "Event Planning")]
        public int Q54 { get; set; }


        [Display(Name = "Drinking")]
        public int Q55 { get; set; }


        [Display(Name = "Partying")]
        public int Q56 { get; set; }


        [Display(Name = "Drug Use")]
        public int Q57 { get; set; }


        [Display(Name = "Are you male or Female?")]
        public int Q58 { get; set; }


        [Display(Name = "How old are you?")]
        public int Q59 { get; set; }


        [Display(Name = "Relationship Status")]
        public int Q60 { get; set; }
    }
}