using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore2.Models.Repository
{
    public class LayoutRepository
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
