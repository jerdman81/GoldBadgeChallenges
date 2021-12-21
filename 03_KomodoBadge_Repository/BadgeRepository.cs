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

        private int _badgeID = 100;

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
        public Dictionary<int, Badge> GetAllBadges()  // Return type is the dictionary
        {
            return badgeDictionary;  // Need Helper method below in order to return full dictionary.
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

        //Update - Remove a door from existing badge

        public void RemoveDoorFromExistingBadge(int key, string doorToRemove)
        {
            // find the existing content
            Badge existingBadge = GetBadgeByID(key);

            // Remove the Door
            existingBadge.DoorNames.Remove(doorToRemove); 
        }

        //Update - Add a door to existing badge
        public void AddDoorToExistingBadge(int key, string doorToAdd)
        {
            // Find the existing content
            Badge existingBadge = GetBadgeByID(key);
            // add the door
            existingBadge.DoorNames.Add(doorToAdd);
        }
    }
}