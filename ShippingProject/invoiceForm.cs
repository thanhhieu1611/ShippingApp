using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShippingProject
{

    public partial class invoiceForm : Form
    {
        //Class variables
        List<Invoice> invoicesDB;

        public static PrintDialog printDialog;
        public invoiceForm()
        {
            InitializeComponent();
        }

        //Get all invoices in tempInv folder
        private void getInvoiceBtn_Click(object sender, EventArgs e)
        {
            //Clears the listbox on click to ensure no duplicate data
            listBox1.Items.Clear();

            //Find the files in the folder but only return the file name without he directory
            var filenames = Directory
                .GetFiles(@"tempInv", "*", SearchOption.AllDirectories)
                .Select(f => Path.GetFileName(f));

            foreach (string fileName in filenames)
            {
                //Add items to list box
                listBox1.Items.Add(fileName);
            }
        }

        //Display text from tempfile to text box.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tries to prnt the text from the file
            //if it can't read from the file it assumes 
            //it's displayings the database invoices and
            //displays from the list of database invoices
            try
            {
                richTextBox1.Text = File.ReadAllText(@"tempInv\" + listBox1.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {
                    Invoice currentInvoice = invoicesDB[listBox1.SelectedIndex];
                    richTextBox1.Text = "Package # | Package Weight | Shipping Method | Shipping Co | Subtotal \n";
                    //Displays all the information for each package in the invoice
                    foreach (Package package in currentInvoice.packages)
                    {
                        richTextBox1.Text += (package.PackageID + " | " + package.PackageWeight + " | " + package.ShipMethod + " | " + package.ShipCompany + " | $" + package.SubTotal + "\n").ToString();
                    }
                    richTextBox1.Text += "Total: $" + currentInvoice.Total + " Tax: $" + currentInvoice.Tax;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

                //MessageBox.Show(ex.ToString());
            }
        }

        private void getInvDataBaseBtn_Click_1(object sender, EventArgs e)
        {
            //Clears the listbox on click to ensure no duplicate data
            listBox1.Items.Clear();
            //Creates a new list of invoices from the Database
            invoicesDB = new List<Invoice>();
            invoicesDB = DataAdapter.GetInvoice();
            //Sorts the invoices list by Invoice ID so the info is in numeric order.
            invoicesDB = invoicesDB.OrderBy(inv => inv.InvoiceID).ToList();
            //Adds each invoice from the database to the listbox 
            foreach (Invoice invoice in invoicesDB)
            {
                listBox1.Items.Add("DB Invoice # " + invoice.InvoiceID);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void printInvoiceBtn_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog = printDialog1;
                Print pr = new Print(richTextBox1.Text, 2);
            }
        }
    }
}
