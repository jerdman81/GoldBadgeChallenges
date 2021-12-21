using System.Collections.Generic;

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

        //Read - Return Outings by Type
        public List<Outing> GetOutingsByType()  // Return type is the list
        {
            return _outingsContext;
        }



    }
}
