using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parties.Core.Models
{
    public class Repository
    {
        public static List<string> PartiesList = new List<string>();

        public static IEnumerable<string> PartiesEnumerable
        {
            get { return PartiesList; }
        }

        public static void AddParties(string WathedParties)
        {
            PartiesList.Add(WathedParties);
            PartiesList.Reverse();
        }


    }
}