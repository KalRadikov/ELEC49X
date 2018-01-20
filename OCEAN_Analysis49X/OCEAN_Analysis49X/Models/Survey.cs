using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCEAN_Analysis49X.Models
{
    public class Survey
    {
        public int SurveyID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Unique Tag or Name")]
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

        [Required(ErrorMessage = "Required")]
        [Display(Name = "General: Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q45 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Fresh Water Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q46 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Ocean Water Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q47 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Hockey")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q48 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Martial Arts/Combat Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q49 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Yoga")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q50 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Winter Mountain Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q51 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Summer Mountain Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q52 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Water Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q53 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Volleyball")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q54 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "American Football")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q55 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Soccer (Football)")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q56 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Baseball/Softball")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q57 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Basketball")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q58 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Cricket")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q59 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Dance/Figure Skating/Gymnastics")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q60 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Wight Lifting")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q61 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Rugby")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q62 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Lacrosse")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q63 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Hunting")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q64 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Archery")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q65 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Cardiovascular sports (running, swimming, biking etc.)")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q66 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Golf")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q67 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Raquet Sports")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q68 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "General: Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q69 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Board Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q70 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Card Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q71 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Video Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q72 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Phone Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q73 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Trivia Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q74 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Word Games")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q75 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Hours a week playing games: 1 = 0-4, 2 = 5-9, 3 = 10-15, 4 = 20-24, 5 = 25+")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q76 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "General: Entertainment")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q77 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Books: Fiction")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q78 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Books: Non-fiction")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q79 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Movies")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q80 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "T.V.")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q81 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Youtube/Twitch")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q82 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Theatre/Concerts")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q83 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Hours a week consuming entertainment: 1 = 0-4, 2 = 5-9, 3 = 10-15, 4 = 20-24, 5 = 25+")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q84 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "General: Personal Interests (how often do you pursue outside interests/hobbies?")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q85 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Science")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q86 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Technology")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q87 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Business")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q88 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Self Improvement")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q89 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Art")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q90 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Music")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q91 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Cooking")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q92 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Meditation")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q93 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Gardening")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q94 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Theatre")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q95 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Film")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q96 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Socializing")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q97 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Event Planning")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q98 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Drinking")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q99 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Partying")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q100 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Drug Use")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q101 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Are you male or Female? 1 = male, 5 = female, 3 = other")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q102 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "How old are you? 1 = 10-15, 2 = 16-20, 3 = 21-30, 4 = 31-50, 5 = 51+")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q103 { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Relationship Status: 1 = Single, 2 = Dating, 3 = Married, 4 = Divorced, 5 = Widdowed")]
        [Range(1, 5, ErrorMessage = "Score must be 1 - 5")]

        public int Q104 { get; set; }
    }
}