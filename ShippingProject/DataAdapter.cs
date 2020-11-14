using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using Serialization;

namespace ShippingProject
{
    /// <summary>
    /// This class is used for gathering data from the database and removing data from the database. Any interaction with the database will be happening in here. 
    /// </summary>
    static class DataAdapter
    {
        #region Class Variables
        //Connection to the database 
        static SqlConnection oConn = new SqlConnection("Data Source=cis.ckwia8qkgyyj.us-east-1.rds.amazonaws.com ;Initial Catalog=bn0188034;User ID=bn0188034; Password=188034");
        //List of invoices
        static List<Invoice> responseInv;
        #endregion

        //Functions for connecting and disconnecting from the database
        #region Database connection functions
        //Connect to DB
        public static void Initialize()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Disconnect from DB
        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        #endregion

        //Queries the DB and returns a set of data
        #region Get Functions
        public static List<Invoice> GetInvoice()
        {

            responseInv = new List<Invoice>();

            string sqlSelect = "SELECT * FROM shippingInvoices";

            SqlCommand cmdSelect = new SqlCommand(sqlSelect, oConn);

            Initialize();
            SqlDataReader readerSelect = cmdSelect.ExecuteReader();

            Invoice myInvoice;

            while (readerSelect.Read())
            {
                myInvoice = (Invoice)Serializer.DeSerializeNow(readerSelect["Data"].ToString());

                responseInv.Add(myInvoice);
            }

            Disconnect();

            return responseInv;
        }

        #endregion

        //Adds data into the Database
        public static void Insert(int invID, string data)
        {
            string sqlIns = "INSERT INTO shippingInvoices(invoiceID, data) VALUES(@invID, @data)";

            try
            {
                Initialize();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@invID", invID);
                cmdIns.Parameters.AddWithValue("@data", data);

                cmdIns.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
