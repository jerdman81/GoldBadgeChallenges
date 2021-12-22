using _04_KomodoOutings.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _04_KomodoOutings.UI
{
    public class ProgramUI
    {
        // Add external repositories
        private readonly OutingRepository _outingRepository = new OutingRepository();

        // add Run method for Program.cs
        public void Run()  // everything except Run() is private so it can't be accessed
        {
            SeedContent();
            RunApplication();
        }


        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Komodo Outings!\n" +
                    "1. Add a New Outing\n" +
                    "2. See all Outings\n" +
                    "3. See Combined Outing Cost\n" +
                    "4. See Outing Cost By Type");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddNewOuting();
                        break;
                    case "2":
                        DisplayAllOutings();
                        break;
                    case "3":
                        DisplayCombinedOutingCost();
                        break;
                    case "4":
                        DisplayOutingCostByType();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        WaitForKeypress();
                        break;
                }
                Console.Clear();
            }
        }


        private void AddNewOuting()
        {
            Console.Clear();
            Outing outing = new Outing();
            Console.Write("Please Enter Outing Type (by number): \n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            string outingType = Console.ReadLine();
            int outingTypeToInt = Convert.ToInt32(outingType);
            outing.TypeOfOuting = (OutingType)outingTypeToInt;

            Console.Write("How many people attended?: ");
            string outingAttendance = Console.ReadLine();
            int outingAttendanceToInt = Convert.ToInt32(outingAttendance);
            outing.Attendance = outingAttendanceToInt;

            Console.Write("What was the date of the event (M/D/Y)?: ");
            var cultureInfo = new CultureInfo("en-US");
            string outingDate = Console.ReadLine();
            var outingDateTime = DateTime.Parse(outingDate, cultureInfo);
            outing.DateOfEvent = outingDateTime;

            Console.Write("How much did the event cost?: ");
            string outingCost = Console.ReadLine();
            decimal outingCostToDecimal = Convert.ToDecimal(outingCost);
            outing.EventCost = outingCostToDecimal;

            _outingRepository.AddAnOuting(outing);
        }

        private void DisplayAllOutings()
        {
            Console.Clear();
            Console.WriteLine("List of all Outings: ");
            List<Outing> outingList = _outingRepository.GetAllOutings();
            foreach (Outing outing in outingList)
            {
                DisplayOutingsByID(outing);
            }
            WaitForKeypress();
        }

        private void DisplayOutingsByID(Outing outing)
        {
            Console.WriteLine(
                $"Outing ID: {outing.OutingID}\n" +
                $"Outing Type: {outing.TypeOfOuting}\n" +
                $"Outing Attendance: {outing.Attendance}\n" +
                $"Outing Date: {outing.DateOfEvent}\n" +
                $"Outing Cost: {outing.EventCost}\n" +
                $"++++++++++++++++++++++++++++++++++++\n");

        }

        private void DisplayCombinedOutingCost()
        {
            Console.Clear();
            decimal totalCost = _outingRepository.TotalOutingsCost();
            Console.WriteLine($"The total cost for all outings is: ${totalCost}.");
            WaitForKeypress();
        }

        private void DisplayOutingCostByType()
        {
            Console.Clear();
            Console.WriteLine("Which outing type do you want to see: \n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");
            string outingType = Console.ReadLine();
            int outingTypeToInt = Convert.ToInt32(outingType);
            decimal outingsCost = _outingRepository.TotalOutingsCostByType((OutingType)outingTypeToInt);
            Console.WriteLine($"The total cost of the outings is ${outingsCost}.");
            WaitForKeypress();

        }
        private void WaitForKeypress()
        {
            Console.ReadKey();
        }

        private void SeedContent()
        {
            Outing outingOne = new Outing();
            outingOne.TypeOfOuting = OutingType.Golf;
            outingOne.Attendance = 12;
            outingOne.DateOfEvent = new DateTime(2021, 7, 3);
            outingOne.EventCost = 235.32m;
            _outingRepository.AddAnOuting(outingOne);

            Outing outingTwo = new Outing();
            outingTwo.TypeOfOuting = OutingType.Concert;
            outingTwo.Attendance = 25;
            outingTwo.DateOfEvent = new DateTime(2021, 8, 1);
            outingTwo.EventCost = 475.65m;
            _outingRepository.AddAnOuting(outingTwo);

            Outing outingThree = new Outing();
            outingThree.TypeOfOuting = OutingType.AmusementPark;
            outingThree.Attendance = 17;
            outingThree.DateOfEvent = new DateTime(2021, 9, 2);
            outingThree.EventCost = 322.75m;
            _outingRepository.AddAnOuting(outingThree);

            Outing outingFour = new Outing();
            outingFour.TypeOfOuting = OutingType.Golf;
            outingFour.Attendance = 5;
            outingFour.DateOfEvent = new DateTime(2021, 10, 5);
            outingFour.EventCost = 82.25m;
            _outingRepository.AddAnOuting(outingFour);


        }
    }
}
