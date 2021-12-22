using System;

namespace _04_KomodoOutings.Repository
{
    public enum OutingType { Golf=1, Bowling, AmusementPark, Concert }
    public class Outing
    {
        // Pocos

        /* Here are parts of an outing
         * Event Type: Golf, Bowling, Amusement Park, Concert  - ENUM
         * Number of People that attended - Property
         * Date - Property
         * Total Cost per person for the event  - Calculated in Repository
         * Total cost for the event - Property */

        public Outing() { }

        public Outing(int outingID, OutingType outingType, int attendance, DateTime dateOfEvent, decimal eventCost)
        {
            OutingID = outingID;
            TypeOfOuting = outingType;
            Attendance = attendance;
            DateOfEvent = dateOfEvent;
            EventCost = eventCost;
        }


        // Outing ID
        public int OutingID { get; set; }

        // Outing Type
        public OutingType TypeOfOuting { get; set; }

        // Number of People Attended
        public int Attendance { get; set; }

        // Date of event
        public DateTime DateOfEvent { get; set; }

        // Event Cost
        public decimal EventCost { get; set; }

        // Event Cost Per Person
        public decimal EventCostPerPerson => Convert.ToDecimal(EventCost / Attendance);
        

    }
}
