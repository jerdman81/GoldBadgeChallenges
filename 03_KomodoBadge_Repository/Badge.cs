using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadge_Repository
{
    public class Badge
    {
        // POCOs
        //  Badge  will have badge number that gives access to a specific list of dors.

        public Badge() { }

        public Badge(int badgeID, List<string> doorName)
        {
            BadgeID = badgeID;
            DoorNames = doorName;
        }

        public int BadgeID { get; set; }

        public List<string> DoorNames { get; set; }
    }
}
