using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingProject.ServiceReference1;

namespace ShippingProject
{
    /// <summary>
    /// This class sets up Invoice objects
    /// </summary>
    
    [Serializable]
    class Invoice
    {

        #region Class Variables
        private int invoiceID;
        private double tax;
        private double total;

        public List<Package> packages;

        #endregion

        #region Get Setters Properties
        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        #endregion

        public Invoice(int invoiceID, double total, double tax, List<Package>packList)
        {
            packages = new List<Package>();
            InvoiceID = invoiceID;
            Total = total;
            Tax = tax;
            for(int i =0; i<packList.Count; i++)
            {
                packages.Add(packList[i]);
            }
        }

    }
}
