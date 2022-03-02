using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovelandAthena
{
   class LoincEntry
   {
      public Entry entry { get; set; }
      public string description { get; set; }
      public string loinc { get; set; }
      public string result { get; set; }
      public override string ToString()
      {
         var d = ',';
         return $"{entry},'{description}'{d}'{loinc}'{d}'{result}'{d}'204'";
      }
   }
}
