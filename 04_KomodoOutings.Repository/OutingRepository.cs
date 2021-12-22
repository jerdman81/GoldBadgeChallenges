using System.Collections.Generic;
using System.Linq;

namespace _04_KomodoOutings.Repository
{
    public class OutingRepository
    {

        private readonly List<Outing> _outingsContext = new List<Outing>();
        private int _outingID;

        //Create -- Add an Individual Outing
        public bool AddAnOuting(Outing outing)
        {

            if (outing == null)
            {
                return false;
            }
            else
            {
                _outingID++;
                outing.OutingID = _outingID;
                _outingsContext.Add(outing);
                return true;
            }
        }

        //Read  - Return All Outings
        public List<Outing> GetAllOutings()  // Return type is the list
        {
            return _outingsContext;
        }
                

        // Read - Total outings cost
        public decimal TotalOutingsCost()
        {
            return _outingsContext.Sum(p => p.EventCost);
        }

        // Read - Total outings cost by Type

       public decimal TotalOutingsCostByType(OutingType outingType)
        {
            decimal totalOutingsCost = 0;
            foreach (var outing in _outingsContext)
            {
                if (outing.TypeOfOuting == outingType)
                {
                    totalOutingsCost += outing.EventCost;
                }
            }
            return totalOutingsCost;
        }
    }
}
