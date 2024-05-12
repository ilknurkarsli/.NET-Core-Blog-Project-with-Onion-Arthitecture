using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_BlogCore.DomainServices
{
    public class NormalizedUrl
    {
        public static string TurkishToEnglish(string name)
        {
            string turkishChracter = "ığüşöç ";
            string englishChracter = "igusoc-";

            for (int i = 0; i < turkishChracter.Length; i++)
            {
                name = name.ToLower().Replace(turkishChracter[i], englishChracter[i]);
            }

            return name;
        }
    }
}