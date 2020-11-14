using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ShippingProject;

namespace Serialization
{
    /// <summary>
    /// This class serializes and deserializes data going to and coming from the database respectively.
    /// </summary>
    static class Serializer
    {
        public static void SerializeNow(Invoice myInvoice)
        {
            int invID = myInvoice.InvoiceID;
            //setup a memory stream object that is needed
            //to hold the obj in memory during the
            //format and transformation process
            MemoryStream myStream = new MemoryStream();

            //setup the binary formatting obj that
            //performs the format process
            BinaryFormatter myFormat = new BinaryFormatter();

            //we call the serialize method, passing the
            //stream so we know where to save and obj it
            //will transform
            myFormat.Serialize(myStream, myInvoice);

            //now that the obj is serialized, covert to
            //Base64 for encoding and easy storage
            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            //call the Insert method of the DA class
            DataAdapter.Insert(invID, serializedValue);

            //close the stream
            myStream.Close();

        }


        public static object DeSerializeNow(string encodedData)
        {
            //Create a generic object to hold the object since we don't know the type of the obj yet
            object type;
            Invoice myInvoice;

            //Create a stream and binary formatter to reverse the encoding and give the stream the incoming data
            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(encodedData));
            BinaryFormatter myFormat = new BinaryFormatter();

            //Deserialize what we have in memory into the generic object
            type = myFormat.Deserialize(myStream);

            //Test what type of object it is
            if (type.GetType().Name == "Invoice")
            {
                myInvoice = (Invoice)type;

                //Close the stream
                myStream.Close();
                return myInvoice;
            }
            else
            {
                //Close the stream
                myStream.Close();
                return type;
            }
                        
        }

    }
}