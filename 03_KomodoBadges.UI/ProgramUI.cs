using _03_KomodoBadge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadge.UI
{
    public class ProgramUI
    {
        // add links to existing repositories  (Badges Repository)
        private readonly BadgeRepository _badgeRepo = new BadgeRepository();


        // add Run method for Program.cs
        public void Run()  // everything except Run() is private so it can't be accessed
        {
            RunApplication();
        }

        private void RunApplication()
        {
            // Three options - add a badge, edit an existing badge, list all badges
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all Badges\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditAnExistingBadge();
                        break;
                    case "3":
                        ListAllExistingBadges();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        WaitForKeypress();
                        break;
                }
                Console.Clear();
            }
        }

        private void AddABadge()
        {
            Console.Clear();  // clear the console
            Badge badge = new Badge();

            Console.WriteLine("What is the number on the badge: ");
            int badgeNumber = Convert.ToInt32(Console.ReadLine());
            badge.BadgeID = badgeNumber;

            List<string> doorNames = new List<string>();

            bool hasAddedAllDoors = false;
            while (hasAddedAllDoors == false)
            {
                Console.WriteLine("List a door that it needs access to: ");
                string doorName = Console.ReadLine();
                doorNames.Add(doorName);
                Console.WriteLine(" Are there any other doors (y/n>");
                string userInput = Console.ReadLine();
                if (userInput == "Y".ToLower())
                {
                    continue;
                }
                else
                {
                    hasAddedAllDoors = true;
                    badge.DoorNames = doorNames;
                }
            }

            _badgeRepo.AddBadge(badge);
            
        }

        private void EditAnExistingBadge()
        {

        }

        private void ListAllExistingBadges()
        {
            Console.Clear();
            Console.WriteLine("List of Existing Badges: ");
            _ = _badgeRepo.GetAllBadges();

        }
        private void DisplayBadgeDetails(Badge badge)
        {
            Console.WriteLine($"Badge #: {badge.BadgeID}\n" +
                $"Door Access: {badge.DoorNames}\n");
        }


        private void WaitForKeypress()
        {
            Console.ReadKey();
        }
    }
}
