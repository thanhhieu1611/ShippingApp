using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace ShippingProject
{
    class Print
    {
        //Class variables
        private Font printFont;
        private StreamReader streamtoPrint;
        private static string filePath;
        int invoiceNum;
        bool invoicePrint;
        public string pText;
        public PrintDocument pd;

        public string sender = "Sender's name and address";
        public string receiver = "Receiver's name and address";
        public DateTime invoiceDate = DateTime.Today;
        public string barCodeNumber = "11111";

        //Constructor for Invoice Printing from file
        public Print(int newInvoiceNum, int formNum)
        {
            //Set invoice num and call printing class in constructor
            invoicePrint = true;
            invoiceNum = newInvoiceNum;
            Printing(formNum);
        }
        //Use this constructor to print string values.
        //Used for Labels
        public Print(string text, int formNum)
        {
            AddLabelInformation();
            pText += text;
            invoicePrint = false;
            try
            {
                printFont = new Font("Arial", 16);
                pd = new PrintDocument();
                //Pass print page method to event that handles printing in print document class
                pd.PrintPage += new PrintPageEventHandler(printPage);
                //Finally print the page
                if (formNum == 1)
                {
                    pd.PrinterSettings = Form1.printDialog.PrinterSettings;
                }
                else
                {
                    pd.PrinterSettings = invoiceForm.printDialog.PrinterSettings;
                }
                pd.Print();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        //Sets up print page including margins, height, etc.
        private void printPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage;
            float y;
            float leftMarg = ev.MarginBounds.Left;
            float topMarg = ev.MarginBounds.Top;

            int count = 0;
            string line = null;
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            if (invoicePrint == true)
            {
                while (count < linesPerPage && ((line = streamtoPrint.ReadLine()) != null))
                {
                    y = topMarg + (count * printFont.GetHeight(ev.Graphics));

                    ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMarg, y, new StringFormat());

                    count++;
                }
            }
            else
            {
                y = topMarg + (count * printFont.GetHeight(ev.Graphics));                  
                ev.Graphics.DrawString(pText, printFont, Brushes.Black, leftMarg, y, new StringFormat());
            }
            //Checks if more lines still need to be printed or not
            if(line != null)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
        //Method that handles printing from the text file
        public void Printing(int formNum)
        {
            try
            {
                filePath = @"tempInv/invoice" + (invoiceNum) + ".txt";
                streamtoPrint = new StreamReader(filePath);
                try
                {
                    printFont = new Font("Arial", 16);
                    pd = new PrintDocument();
                    //Pass print page method to event that handles printing in print document class
                    pd.PrintPage += new PrintPageEventHandler(printPage);
                    if (formNum == 1)
                    {
                        pd.PrinterSettings = Form1.printDialog.PrinterSettings;
                    }
                    else
                    {
                        pd.PrinterSettings = invoiceForm.printDialog.PrinterSettings;
                    }
                    //Finally print the page
                    pd.Print();
                }
                finally
                {
                    streamtoPrint.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        //Add label information
        //add sender, receiver info, ...
        private void AddLabelInformation()
        {
            //Add sender and receiver
            pText += "Sender: " + sender + Environment.NewLine;
            pText += "Receiver: " + receiver + Environment.NewLine;
            pText += "Date: " + Convert.ToString(invoiceDate) + Environment.NewLine;
            pText += "" + Environment.NewLine;
            pText += "Bar Code Number: " + barCodeNumber + Environment.NewLine;
            pText += "" + Environment.NewLine;
        }
    }
}
