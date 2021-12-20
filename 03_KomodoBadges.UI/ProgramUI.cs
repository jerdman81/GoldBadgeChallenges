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
        }

        private void EditAnExistingBadge()
        {

        }

        private void ListAllExistingBadges()
        {

        }


        private void WaitForKeypress()
        {
            Console.ReadKey();
        }
    }
}
