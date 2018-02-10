using Capstone490.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone490.Helpers
{
    public class OCEAN
    {
        private static Capstone490Context db = new Capstone490Context();


        public static Double[] GetOCEANTraits(string tag)
        {

            List<object> iList = new List<object>();
            List<int> result = new List<int>();

            var query = db.Surveys.Where(m => m.Tag == tag).ToList();

            if (tag == null)
            {
                return new[] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            }

            iList.Add(query.Select(m => m.Q1).Single());
            iList.Add(query.Select(m => m.Q2).Single());
            iList.Add(query.Select(m => m.Q3).Single());
            iList.Add(query.Select(m => m.Q4).Single());
            iList.Add(query.Select(m => m.Q5).Single());
            iList.Add(query.Select(m => m.Q6).Single());
            iList.Add(query.Select(m => m.Q7).Single());
            iList.Add(query.Select(m => m.Q8).Single());
            iList.Add(query.Select(m => m.Q9).Single());
            iList.Add(query.Select(m => m.Q10).Single());
            iList.Add(query.Select(m => m.Q11).Single());
            iList.Add(query.Select(m => m.Q12).Single());
            iList.Add(query.Select(m => m.Q13).Single());
            iList.Add(query.Select(m => m.Q14).Single());
            iList.Add(query.Select(m => m.Q15).Single());
            iList.Add(query.Select(m => m.Q16).Single());
            iList.Add(query.Select(m => m.Q17).Single());
            iList.Add(query.Select(m => m.Q18).Single());
            iList.Add(query.Select(m => m.Q19).Single());
            iList.Add(query.Select(m => m.Q20).Single());
            iList.Add(query.Select(m => m.Q21).Single());
            iList.Add(query.Select(m => m.Q22).Single());
            iList.Add(query.Select(m => m.Q23).Single());
            iList.Add(query.Select(m => m.Q24).Single());
            iList.Add(query.Select(m => m.Q25).Single());
            iList.Add(query.Select(m => m.Q26).Single());
            iList.Add(query.Select(m => m.Q27).Single());
            iList.Add(query.Select(m => m.Q28).Single());
            iList.Add(query.Select(m => m.Q29).Single());
            iList.Add(query.Select(m => m.Q30).Single());
            iList.Add(query.Select(m => m.Q31).Single());
            iList.Add(query.Select(m => m.Q32).Single());
            iList.Add(query.Select(m => m.Q33).Single());
            iList.Add(query.Select(m => m.Q34).Single());
            iList.Add(query.Select(m => m.Q35).Single());
            iList.Add(query.Select(m => m.Q36).Single());
            iList.Add(query.Select(m => m.Q37).Single());
            iList.Add(query.Select(m => m.Q38).Single());
            iList.Add(query.Select(m => m.Q39).Single());
            iList.Add(query.Select(m => m.Q40).Single());
            iList.Add(query.Select(m => m.Q41).Single());
            iList.Add(query.Select(m => m.Q42).Single());
            iList.Add(query.Select(m => m.Q43).Single());
            iList.Add(query.Select(m => m.Q44).Single());

            List<int> qList = iList.Cast<int>().ToList();

            //Extraversion
            qList[5] = 6 - qList[5];
            qList[20] = 6 - qList[20];
            qList[30] = 6 - qList[30];

            //Agreeableness
            qList[1] = 6 - qList[1];
            qList[11] = 6 - qList[11];
            qList[26] = 6 - qList[26];
            qList[36] = 6 - qList[36];

            //Conscientiousness
            qList[7] = 6 - qList[7];
            qList[17] = 6 - qList[17];
            qList[22] = 6 - qList[22];
            qList[42] = 6 - qList[42];

            //Neuroticism
            qList[8] = 6 - qList[8];
            qList[23] = 6 - qList[23];
            qList[33] = 6 - qList[33];

            //Openness
            qList[34] = 6 - qList[34];
            qList[40] = 6 - qList[40];

            int extraversion = qList[0] + qList[5] + qList[10] + qList[15] + qList[20] + qList[25] + qList[30] + qList[35];
            int agreeableness = qList[1] + qList[6] + qList[11] + qList[16] + qList[21] + qList[26] + qList[31] + qList[36] + qList[41];
            int conscientiousness = qList[2] + qList[7] + qList[12] + qList[17] + qList[22] + qList[27] + qList[32] + qList[37] + qList[42];
            int neuroticism = qList[3] + qList[8] + qList[13] + qList[18] + qList[23] + qList[28] + qList[33] + qList[38];
            int openness = qList[4] + qList[9] + qList[14] + qList[19] + qList[24] + qList[29] + qList[34] + qList[39] + qList[40] + qList[43];

            double Extraversion = extraversion / 8.0;
            double Agreeableness = agreeableness / 9.0;
            double Conscientiousness = conscientiousness / 9.0;
            double Neuroticism = neuroticism / 8.0;
            double Openness = openness / 10.0;

            return new[] { Openness, Conscientiousness, Extraversion, Agreeableness, Neuroticism };

        }
        public static Double GetOpenness(string tag)
        {
            Double Opennness = GetOCEANTraits(tag)[0];
            return Opennness;
        }
        public static Double GetConscientiousness(string tag)
        {
            Double Opennness = GetOCEANTraits(tag)[1];
            return Opennness;
        }
        public static Double GetExtraversion(string tag)
        {
            Double Opennness = GetOCEANTraits(tag)[2];
            return Opennness;
        }
        public static Double GetAgreeableness(string tag)
        {
            Double Opennness = GetOCEANTraits(tag)[3];
            return Opennness;
        }
        public static Double GetNeuroticism(string tag)
        {
            Double Opennness = GetOCEANTraits(tag)[4];
            return Opennness;
        }
    }
}