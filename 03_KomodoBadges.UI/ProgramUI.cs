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
            SeedContent();
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

            List<string> doorNames = new List<string>();

            bool hasAddedAllDoors = false;
            while (hasAddedAllDoors == false)
            {
                Console.WriteLine("List a door that it needs access to: ");
                string doorName = Console.ReadLine();
                doorNames.Add(doorName);
                Console.WriteLine(" Are there any other doors (y/n)");
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
            Console.Clear();
            Console.WriteLine("What is the badge number to update: ");
            string badgeNumber = Console.ReadLine();
            int badgeNumberInt = Convert.ToInt32(badgeNumber);
            Badge badgeToFind = _badgeRepo.GetBadgeByID(badgeNumberInt);
            DisplayBadgeDetails(badgeToFind);
            Console.WriteLine("What would you like to do? \n" +
                "1. Remove a door\n" +
                "2. Add a door\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Which door would you like to remove?");
                    string userInputRemove = Console.ReadLine();
                    _badgeRepo.RemoveDoorFromExistingBadge(badgeNumberInt, userInputRemove);
                    Console.WriteLine("Door Removed\n");
                    break;
                case "2":
                    Console.WriteLine("Which door would you like to add?");
                    string userInputAdd = Console.ReadLine();
                    _badgeRepo.AddDoorToExistingBadge(badgeNumberInt, userInputAdd);
                    Console.WriteLine("Door Added\n");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    WaitForKeypress();
                    break;
            }
            Console.WriteLine("Updated Badge Details:");
            DisplayBadgeDetails(badgeToFind);
            WaitForKeypress();
        }

        private void ListAllExistingBadges()
        {
            Console.Clear();
            Console.WriteLine("List of Existing Badges: \n");
            var badges = _badgeRepo.GetAllBadges();
            foreach (var badge in badges.Values)
            {
                DisplayBadgeDetails(badge);   // Helper Method
            }
            WaitForKeypress();

        }
        private void DisplayBadgeDetails(Badge badge)  //Helper Method
        {
            Console.WriteLine($"Badge #:\n {badge.BadgeID}\n");
            Console.WriteLine("Door Access:");
            foreach (var door in badge.DoorNames)
            {
                Console.WriteLine(door);
            }
            Console.WriteLine("\n=============================\n");
        }
        private void WaitForKeypress()
        {
            Console.ReadKey();
        }

        private void SeedContent()  // doesn't work
        {
            Badge badgeOne = new Badge();
            badgeOne.DoorNames = new List<string>();
            badgeOne.DoorNames.Add("A5");
            badgeOne.DoorNames.Add("A1");
            badgeOne.DoorNames.Add("B1");
            _badgeRepo.AddBadge(badgeOne);

            Badge badgeTwo = new Badge();
            badgeTwo.DoorNames = new List<string>();
            badgeTwo.DoorNames.Add("A1");
            badgeTwo.DoorNames.Add("A2");
            badgeTwo.DoorNames.Add("A3");
            _badgeRepo.AddBadge(badgeTwo);

            Badge badgeThree = new Badge();
            badgeThree.DoorNames = new List<string>();
            badgeThree.DoorNames.Add("B1");
            badgeThree.DoorNames.Add("B2");
            badgeThree.DoorNames.Add("B3");
            _badgeRepo.AddBadge(badgeThree);
        }
    }
}
