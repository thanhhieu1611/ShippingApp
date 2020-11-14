using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProject
{
    /// <summary>
    /// This class sets up Package objects
    /// </summary>
     
    [Serializable]
    class Package
    {

        #region Private Variables
        private int packageID;
        private string shipMethod;
        private string shipCompany;
        private double packageWeight;
        private double subTotal;
        #endregion

        #region Get Setters
        public int PackageID
        {
            get { return packageID; }
            set { packageID = value; }
        }

        public string ShipMethod
        {
            get { return shipMethod; }
            set { shipMethod = value; }
        }

        public string ShipCompany
        {
            get { return shipCompany; }
            set { shipCompany = value; }
        }

        public double PackageWeight
        {
            get { return packageWeight; }
            set { packageWeight = value; }
        }

        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        #endregion

        public Package(int packageID, string shipMethod, string shipCompany, double packageWeight, double subTotal)
        {
            PackageID = packageID;
            ShipMethod = shipMethod;
            ShipCompany = shipCompany;
            PackageWeight = packageWeight;
            SubTotal = subTotal;
        }
    }
}
