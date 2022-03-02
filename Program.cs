using System;
using System.Collections.Generic;
using System.IO;

namespace LovelandAthena
{
   class Program
   {
      static void Main(string[] args)
      {
         Dictionary<string, string> loinc = new Dictionary<string, string>();
         loinc.Add("bpdiastolic", "8462-4");
         loinc.Add("bpsystolic", "8480-6");
         loinc.Add("bmi", "39156-5");
         loinc.Add("height", "3137-7");
         loinc.Add("weight", "3141-9");
         loinc.Add("waist", "56086-2");
         loinc.Add("pregnancy", "11449-6");

         string[] bioData = File.ReadAllLines(@"C:\Users\nathan\Documents\APPS\LovelandAthena\LovelandAthena\docs\02252022_LovelandBiometricsUpload.csv"); ;
         string path = @"C:\Users\nathan\Documents\APPS\LovelandAthena\LovelandAthena\docs\02252022_LovelandBiometricsUpload.csv_MAPPED.csv";
         foreach (var entry in bioData)
         {
            string[] rawData = entry.Split(",");
            Entry tmpEntry = new Entry();
            tmpEntry.wellness_id = rawData[0];
            tmpEntry.ssn = "NULL";
            tmpEntry.location = rawData[5];
            tmpEntry.firstName = rawData[1];
            tmpEntry.lastName = rawData[2];
            tmpEntry.gender = rawData[4];
            var fast = rawData[12];
            if(fast.ToLower() == "y")
            {
               fast = "TRUE";
            } else
            {
               fast = "FALSE";
            }
            tmpEntry.fasting = fast;
            tmpEntry.dos = rawData[6];
            tmpEntry.email = "NULL";
            tmpEntry.dob = rawData[3];
            tmpEntry.phone = "NULL";

            List<LoincEntry> lGrp = new List<LoincEntry>();

            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bpdiastolic", loinc = loinc["bpdiastolic"], result = rawData[8] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bpsystolic", loinc = loinc["bpsystolic"], result = rawData[7] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bmi", loinc = loinc["bmi"], result = rawData[9] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "height", loinc = loinc["height"], result = rawData[10] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "weight", loinc = loinc["weight"], result = rawData[11] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "waist", loinc = loinc["waist"], result = rawData[13] });
            lGrp.Add(new LoincEntry { entry = tmpEntry, description = "pregnancy", loinc = loinc["pregnancy"], result = rawData[14] });


            foreach (var lent in lGrp)
            {
               using (StreamWriter sw = File.AppendText(path))
               {
                  if (!(String.IsNullOrEmpty(lent.result)))
                  {
                     if (lent.entry.location.Contains("@"))
                     {
                        var loc = lent.entry.location.Replace("@", ",");
                        lent.entry.location = "\"" + loc + "\"";
                     }
                     sw.WriteLine("(" + lent + "),");
                  }
               }
            }
         }
      }
   }
}
