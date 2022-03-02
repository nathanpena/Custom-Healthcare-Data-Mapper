using System;
using System.Collections.Generic;
using System.IO;

namespace athenaUpload
{
    class Program
    {
      static void Main(string[] args)
      {
         Dictionary<string, string> loinc = new Dictionary<string, string>();
         loinc.Add("hdl cholesterol", "2085-9");
         loinc.Add("bpdiastolic", "8462-4");
         loinc.Add("bpsystolic", "8480-6");
         loinc.Add("triglycerides", "2571-8");
         loinc.Add("ldl cholesterol", "13457-7");
         loinc.Add("a1c", "4548-4");
         loinc.Add("glucose", "1558-6");
         loinc.Add("bmi", "39156-5");
         loinc.Add("total cholesterol", "2093-3");
         loinc.Add("albumin", "1751-7");
         loinc.Add("ag ratio", "1759-0");
         loinc.Add("aspartate aminotransferase", "1920-8");
         loinc.Add("bun", "3094-0");
         loinc.Add("carbon dioxide", "2028-9");
         loinc.Add("cbc", "58410-2");
         loinc.Add("cotinine", "59646-0");
         loinc.Add("globulin", "10834-0");
         loinc.Add("estimated chd risk", "56469-0");
         loinc.Add("lactate dehydrogenase", "14805-6");
         loinc.Add("ldlhdl ratio", "11054-4");
         loinc.Add("sodium", "2951-2");
         loinc.Add("phosphorus", "2777-1");
         loinc.Add("alanine aminotransferase", "1742-6");
         loinc.Add("total bilirubin", "1975-2");
         loinc.Add("alkaline phosphatase", "6768-6");
         loinc.Add("total cholesterol HDLRatio", "9830-1");
         loinc.Add("calcium", "17861-6");
         loinc.Add("very low density lipoprotein", "13458-5");
         loinc.Add("creatinine", "2160-0");
         loinc.Add("BCratio", "3097-3");
         loinc.Add("gamma-glutamyl transferase", "2324-2");
         loinc.Add("chloride", "2075-0");
         loinc.Add("total protein", "2885-2");
         loinc.Add("iron", "2498-4");
         loinc.Add("uric acid", "3084-1");
         loinc.Add("psa", "2857-1");
         loinc.Add("potassium", "2823-3");
         loinc.Add("thyroid stimulating hormone", "11579-0");
         loinc.Add("platelets", "777-3");

         string[] bioData = File.ReadAllLines(@"C:\Users\nathan\Documents\APPS\athenaUpload\athenaUpload\docs\LastEdition.csv"); ;
         string path = @"C:\Users\nathan\Documents\APPS\athenaUpload\athenaUpload\docs\LastEdition_MAPPED.csv";
            foreach (var entry in bioData)
            {
                string[] rawData = entry.Split(",");
                Entry tmpEntry = new Entry();
                tmpEntry.ssn = rawData[4];
                tmpEntry.location = rawData[3];
                tmpEntry.firstName = rawData[0];
                tmpEntry.lastName   = rawData[1];
                tmpEntry.gender = "NULL";
                tmpEntry.fasting = "TRUE";
                tmpEntry.dos = rawData[5];
                tmpEntry.email = rawData[2];
                tmpEntry.dob = "NULL";
                tmpEntry.phone = "NULL";
                List<LoincEntry> lGrp = new List<LoincEntry>();

                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "hdl cholesterol", loinc = loinc["hdl cholesterol"], result = rawData[6] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bpdiastolic", loinc = loinc["bpdiastolic"], result = rawData[7] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bpsystolic", loinc = loinc["bpsystolic"], result = rawData[8] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "triglycerides", loinc = loinc["triglycerides"], result = rawData[9] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "ldl cholesterol", loinc = loinc["ldl cholesterol"], result = rawData[10] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "a1c", loinc = loinc["a1c"], result = rawData[11] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "glucose", loinc = loinc["glucose"], result = rawData[12] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bmi", loinc = loinc["bmi"], result = rawData[13] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "total cholesterol", loinc = loinc["total cholesterol"], result = rawData[14] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "albumin", loinc = loinc["albumin"], result = rawData[15] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "ag ratio", loinc = loinc["ag ratio"], result = rawData[16] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "aspartate aminotransferase", loinc = loinc["aspartate aminotransferase"], result = rawData[17] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "bun", loinc = loinc["bun"], result = rawData[18] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "carbon dioxide", loinc = loinc["carbon dioxide"], result = rawData[19] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "cbc", loinc = loinc["cbc"], result = rawData[20] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "cotinine", loinc = loinc["cotinine"], result = rawData[21] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "globulin", loinc = loinc["globulin"], result = rawData[22] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "estimated chd risk", loinc = loinc["estimated chd risk"], result = rawData[23] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "lactate dehydrogenase", loinc = loinc["lactate dehydrogenase"], result = rawData[24] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "ldlhdl ratio", loinc = loinc["ldlhdl ratio"], result = rawData[25] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "sodium", loinc = loinc["sodium"], result = rawData[26] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "phosphorus", loinc = loinc["phosphorus"], result = rawData[27] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "alanine aminotransferase", loinc = loinc["alanine aminotransferase"], result = rawData[28] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "total bilirubin", loinc = loinc["total bilirubin"], result = rawData[29] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "alkaline phosphatase", loinc = loinc["alkaline phosphatase"], result = rawData[30] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "total cholesterol HDLRatio", loinc = loinc["total cholesterol HDLRatio"], result = rawData[31] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "calcium", loinc = loinc["calcium"], result = rawData[32] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "very low density lipoprotein", loinc = loinc["very low density lipoprotein"], result = rawData[33] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "creatinine", loinc = loinc["creatinine"], result = rawData[34] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "BCratio", loinc = loinc["BCratio"], result = rawData[35] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "gamma-glutamyl transferase", loinc = loinc["gamma-glutamyl transferase"], result = rawData[36] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "chloride", loinc = loinc["chloride"], result = rawData[37] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "total protein", loinc = loinc["total protein"], result = rawData[38] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "iron", loinc = loinc["iron"], result = rawData[39] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "uric acid", loinc = loinc["uric acid"], result = rawData[40] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "psa", loinc = loinc["psa"], result = rawData[41] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "potassium", loinc = loinc["potassium"], result = rawData[42] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "thyroid stimulating hormone", loinc = loinc["thyroid stimulating hormone"], result = rawData[43] });
                  lGrp.Add(new LoincEntry { entry = tmpEntry, description = "platelets", loinc = loinc["platelets"], result = rawData[44] });


            foreach (var lent in lGrp)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        if(!(String.IsNullOrEmpty(lent.result)))
                           {
                              sw.WriteLine(lent);
                           }
                    }
                }
            }
        }
    }
}
