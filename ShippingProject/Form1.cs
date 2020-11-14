using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add webservice
using ShippingProject.ServiceReference1;
//Read/Write Files
using System.IO;
using Serialization;

namespace ShippingProject
{
    public partial class Form1 : Form
    {
        #region CLASS VARIABLES
        //List of package ID to track each package
        private List<int> idList = new List<int>();

        //Initial counter for ID list to manage ID declaration
        private int idCount = 0;

        //Intial value for subTotal of all orders
        private double orderSubTotal = 0.0;

        //Tax rate
        private double taxRate = 0.08;

        //Temprorary invoice counter for local invoice
        int tempInvoices;

        //Temp data to pass to invoice class
        private double subt;
        private double tax;
        private double tot;

        //Declare a Print Dialog object
        public static PrintDialog printDialog;

        //List of local invoices
        private List<Invoice> invoices = new List<Invoice>();
        private List<Invoice> tempInv = new List<Invoice>();

        //Int for keeping track of number of database invoices
        int dbInvoices;

        //List of temporary packages info
        List<Package> tempPackages = new List<Package>();

        #endregion

        public Form1()
        {
            InitializeComponent();

            //Add function before form1 is closed
            FormClosing += Form1_FormClosing;

            //Add initial labels for Order Box
            SetLabelsForOrderBox();

        }

        #region EVENTS
        private void addBtn_Click(object sender, EventArgs e)
        {
            //check to see if all user inputs in update
            //Prevent user errors with try-catch
            try
            {
                if((CheckSelectShipMethod() != "") && (CheckPackageWeight() > 0.0) && (CheckSelectShipCompany() != ""))
                {
                    //Default values
                    string shipMethod = "Two Day";
                    double packageWeight = Convert.ToDouble(weightBox.Text);
                    string shipCompany = companySelectBox.SelectedItem.ToString();

                    //Check to see if customer want overnight service
                    if (overnightBtn.Checked)
                    {
                        shipMethod = "Overnight";
                    }

                    //Calculate subTotal for each package
                    double subTotal = CalculateSubTotalForEachPackageBeforeTax(shipMethod, packageWeight, shipCompany);

                    //Add new item into order list
                    string packageInfo = AddNewPackageIntoList(shipMethod, packageWeight, shipCompany, subTotal);

                    //Show into order list
                    lstBoxOrder.Items.Add(packageInfo);

                    //Update order summary
                    UpdateOrderSummary();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var item = lstBoxOrder.SelectedItem;
                if (item != null)
                {
                    //remove an item from order list
                    lstBoxOrder.Items.Remove(item);

                    //Update orderSubTotal
                    int dollarSignIndex = item.ToString().IndexOf("$");
                    double subTotalOfRemovedItem = Convert.ToDouble(item.ToString().Substring(dollarSignIndex + 1));
                    orderSubTotal -= subTotalOfRemovedItem;

                    //Remove Temp Package from tempPackages list
                    tempPackages.RemoveAt(lstBoxOrder.SelectedIndex + 1);
                    //Update order summary
                    UpdateOrderSummary();
                }
                else
                {
                    MessageBox.Show("Please select an item in order list to remove!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Finish button event to write order list into file and create invoice
        //This one need to prevent same order but more than one time click Finish Order button
        //Which will create same invoices
        private void finishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Testing
                //MessageBox.Show("Finish button clicked" + invoices.Count);

                WriteToFile();
                CreateNewInvoice();

                //Check to see if users want to print labels
                //If yes Direct user to select Print Label button
                //If No clear the order list to create a new one
                DialogResult input = MessageBox.Show("Would you like to print some labels?", "Print Label", MessageBoxButtons.YesNo);
                
                if (input == DialogResult.Yes)
                {
                    //Print labels
                    MessageBox.Show("Please select each package and then click Print Label button");
                }
                else
                {
                    //Reset the order list box
                    lstBoxOrder.Items.Clear();

                    //Add initial labels for Order Box
                    SetLabelsForOrderBox();
                }

                //Inactive finish button, remove and add order button
                finishBtn.Enabled = false;
                addBtn.Enabled = false;
                removeBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Click to reset order list form to ready for a new order
        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            //Reset the listbox order
            lstBoxOrder.Items.Clear();

            //Clear tempPackages and Pack ID count
            tempPackages.Clear();
            idCount = 0;

            //Add initial labels for Order Box
            SetLabelsForOrderBox();

            //Active Finish Order, Remove and Add Order Buttons again
            finishBtn.Enabled = true;
            addBtn.Enabled = true;
            removeBtn.Enabled = true;
        }

        //Will be used to print the label of the selected item from the invoice
        private void printLabelBtn_Click_1(object sender, EventArgs e)
        {
            PrintLabel();
        }

        //Gets the invoices from the database and populates the invoices list.
        private void Form1_Load(object sender, EventArgs e)
        {
            invoices = DataAdapter.GetInvoice();
            dbInvoices = invoices.Count + 1;
            //Count number of invoices in database
            //tempInvoices = invoices.Count + 1;
            //MessageBox.Show("Number of invoice in database" + tempInvoices);

            //Increase tempInvoices number by 1
            //tempInvoices += 1;
            //MessageBox.Show("NUmber of first invoice number" + tempInvoices);

            ////Writes some test info to the console to ensure it's being converted properly.
            //foreach (Invoice invoice in invoices)
            //{
            //    foreach (Package package in invoice.packages)
            //    {
            //        Console.WriteLine(package.ShipCompany);
            //    }
            //    Console.WriteLine(invoice.InvoiceID);
            //}
        }
        //Deletes temp invoice files when form is closed and moves the local invoices to the database
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i =0; i < tempInv.Count; i++)
            {
                try
                {
                    //MessageBox.Show(tempInv[i].InvoiceID.ToString());
                    Serializer.SerializeNow(tempInv[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }               

            }

            for (int i = 0; i < tempInvoices; i++)
            {
                try
                {
                    //File.Delete(@"tempInv/invoice" + i + ".txt");
                    DirectoryInfo di = new DirectoryInfo("tempInv");
                    foreach(FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                }
                catch (IOException ioE)
                {
                    MessageBox.Show(ioE.Message);
                }
            }
        }
        #endregion

        #region METHODS
        //Add initial labels for Order Box
        private void SetLabelsForOrderBox()
        {
            //lstBoxOrder.Items.Add($"Package # | Package Weight  | Shipping Method | Shipping Co | Subtotal");

            lstBoxOrder.Items.Add(String.Format("{0} | {1} | {2} | {3} | {4} ", "Package #", "Package Weight", "Shipping Method", "Shipping Co", "Subtotal"));
        }

        //Check Select Shipping Method
        //Return true if customer has selected an Shipping Method
        private string CheckSelectShipMethod()
        {
            if (twoDayBtn.Checked)
            {
                return "Two Days";
            }
            else if(overnightBtn.Checked)
            {
                return "Overnight";
            }
            else
            {
                MessageBox.Show("Please select shipping method");
                return "";
            }
        }

        //Check Package Weigth
        //Return weight if customer has entered package weight
        private double CheckPackageWeight()
        {
            double weight;
            if(weightBox.Text != "" && double.TryParse(weightBox.Text, out weight))
            {
                if (weight > 0)
                {
                    return weight;
                }
                else
                {
                    MessageBox.Show("Please enter a positive package weight!");
                    return 0.00;
                }
            }
            else
            {
                MessageBox.Show("Please enter numeric package weight!");
                return 0.00;
            } 
        }

        //Check Select Shipping Company
        //Return weight if customer has select a shipping company for a package
        private string CheckSelectShipCompany()
        {
            //Check to see if customer want to select different one
            if (companySelectBox.SelectedItem != null)
            {
                return companySelectBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a shipping company!");
                return "";
            }
            
        }

        //Add new item into order list
        //Format of order list: Package ID - Weight - Shipping Method - Shipping Company
        private string AddNewPackageIntoList(string shipMethod, double packageWeight, string shipCompany, double subTotal)
        {
            //Increase idCount, then update to ID list
            idCount++;
            idList.Add(idCount);

            //Update orderSubTotal variable and inside Order List Box
            orderSubTotal += subTotal;

            //Add Order Information to the Packages list to be sent to the invoice class
            Package p = new Package(idCount, shipMethod, shipCompany, packageWeight, subTotal);
            tempPackages.Add(p);

            return $"     {Convert.ToString(idCount).PadRight(8)}| {packageWeight.ToString().PadLeft(12)}        | {shipMethod.PadLeft(15)}     | {shipCompany.PadLeft(10)}    | {("$"+subTotal.ToString()).PadLeft(5)}";
        }

        //Calculate subtotal for each package before tax
        private double CalculateSubTotalForEachPackageBeforeTax(string shipMethod, double packageWeight, string shipCompany)
        {
            //Create WebServiceSoapClient object
            WebService1SoapClient myClient = new WebService1SoapClient();
            double subTotal = myClient.CalcTotal(shipCompany, shipMethod, packageWeight);

            return subTotal;
        }

        //Calculate Total Tax of orders
        private double CalculateTotalTaxOfOrder()
        {
            return orderSubTotal * taxRate;
        }

        //Calculate Total of orders
        private double CalculateTotalOfOrder()
        {
            return orderSubTotal + CalculateTotalTaxOfOrder();
        }

        //Update Order Summary
        //Used after add or remove an item
        private void UpdateOrderSummary()
        {
            //Reset summary box
            lstBoxOrderSummary.Items.Clear();

            //Update summany order information
            subt = orderSubTotal;
            tax = CalculateTotalTaxOfOrder();
            tot = CalculateTotalOfOrder();
            lstBoxOrderSummary.Items.Add($"SubTotal: ${orderSubTotal}");
            lstBoxOrderSummary.Items.Add($"Tax: ${tax}");
            lstBoxOrderSummary.Items.Add($"Total: ${tot}");
        }

        //Write Invoice to temporary invoice file in bin/debug folder
        private void WriteToFile()
        {
            if (!Directory.Exists(@"tempInv"))
            {
                Directory.CreateDirectory(@"tempInv");
            }

            //MessageBox.Show("Invoice to name a new invoice" + tempInvoices);

            StreamWriter newFile = new StreamWriter(@"tempInv/invoice" + tempInvoices + ".txt", true);
            for (int i = 0; i < lstBoxOrder.Items.Count; i++)
            {
                newFile.WriteLine("" + lstBoxOrder.Items[i]);
            }
            newFile.WriteLine("Subtotal: $" + subt + " Tax: $" + tax + " Total: $" + tot);
            newFile.Close();

            DialogResult input = MessageBox.Show("Would you like to print this invoice?", "Print Invoice", MessageBoxButtons.YesNo);
            if (input == DialogResult.Yes)
            {
                //Checks print dialog result, if it is an ok it will print document
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDialog = printDialog1;
                    Print pr = new Print(tempInvoices, 1);
                }
            }

            //Increase invoice number for the next order
            tempInvoices++;
        }
        

        //Retrieve invoice button that pulls up the invoiceForm for displaying of all invoices in the temp folder and database.
        private void retrieveInvBtn_Click(object sender, EventArgs e)
        {
            var invForm = new invoiceForm();
            invForm.Show();
        }

        //Create new invoice
        private void CreateNewInvoice()
        {
            Invoice newInv = new Invoice(dbInvoices+1, tot, tax,tempPackages);
            tempInv.Add(newInv);
            dbInvoices++;
            //Reset subTotal for each order
            orderSubTotal = 0.0;
        }

        //Print label
        private void PrintLabel()
        {
            if (lstBoxOrder.SelectedItem != null)
            {
                //Checks print dialog result, if it is an ok it will print document
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDialog = printDialog1;
                    Print pr = new Print(lstBoxOrder.SelectedItem.ToString(), 1);
                }
            }
            else
            {
                MessageBox.Show("Please select and label to print.");
            }
        }

        #endregion
    }
}
