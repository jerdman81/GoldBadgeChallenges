using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadge_Repository
{
    public class BadgeRepository
    {
        // This is the Badge Database
        // HINT  Use a Dictionary
        Dictionary<int, Badge> badgeDictionary = new Dictionary<int, Badge>();

        private int _badgeID;
        
        //Create A New Badge
        public bool AddBadge(Badge badge)
        {
            if (badge == null)
            {
                return false;
            }
            else
            {
                _badgeID++;
                badge.BadgeID = _badgeID;
                badgeDictionary.Add(_badgeID, badge);
                return true;
            }
        }

        //Read  -  Return Dictionary<int, badge>
        public Dictionary<int, Badge>  GetAllBadges()
        {
            return badgeDictionary;
        }

        //Read - Return Badge by ID
        public Badge GetBadgeByID(int key)
        {
            foreach (var badge in badgeDictionary)
            {
                if (badge.Key == key)
                {
                    return badge.Value;
                }

            }
            return null;
        }

        //Update


        //Delete Badge
        


        //Delete Doors from Existing Badge



    }
}
