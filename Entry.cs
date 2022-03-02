using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace athenaUpload
{
    class Entry
    {
        public string patient_id_type { get; set; }
        public string ssn { get; set; }
        public string wellness_id { get; set; }
        public string location { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string dos { get; set; }
        public string fasting { get; set; }

        public override string ToString()
        {
            var d = ',';
            return $"'AltID'{d}'{ssn}'{d}'{wellness_id}'{d}'{location}'{d}'{firstName}'{d}'{lastName}'{d}'{dob}'{d}'{gender}'{d}'{phone}'{d}'{email}'{d}'{dos}'{d}'{fasting}'";
        }
    }
}
