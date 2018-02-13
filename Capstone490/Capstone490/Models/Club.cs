using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Capstone490.Models
{
    //[Table("xClub")]
    public class Club
    {
        public int ClubID { get; set; }

        public string Name { get; set; }

        public string Category1 { get; set; }

        public string Category2 { get; set; }

        public string Category3 { get; set; }

        public double O_Max { get; set; }

        public double O_Min { get; set; }

        public double C_Max { get; set; }

        public double C_Min { get; set; }

        public double E_Max { get; set; }

        public double E_Min { get; set; }

        public double A_Max { get; set; }

        public double A_Min { get; set; }

        public double N_Max { get; set; }

        public double N_Min { get; set; }
    }
}