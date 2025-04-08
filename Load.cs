using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWA_Expense_Tracking
{
    public class Load
    {
        private int loadId;
        private DateTime date;
        private string origin;
        private string destination;
        private int loadedMiles;
        private int emptyMiles;
        private float loadRevenue;
        private float totalPay;
        private readonly float payRate;

        public int LoadId
        {
            get { return loadId; }
            set { loadId = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int LoadedMiles
        {
            get { return loadedMiles; }
            set { loadedMiles = value; }
        }

        public int EmptyMiles
        {
            get { return emptyMiles; }
            set { emptyMiles = value; }
        }

        public float LoadRevenue
        {
            get { return loadRevenue; }
            set { loadRevenue = value; }
        }

        public float TotalPay
        {
            get { return totalPay; }
            set { totalPay = value; }
        }

        public float PayRate
        {
            get { return payRate; }
        }
    }
}
