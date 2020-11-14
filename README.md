# ShippingApp
Creating a software application for a shipping company using a C#, Web Service, SQL Server
In this project you will be creating a software application for a shipping company using a web service. This is a group project. You will have a group collection on TFSwhere you can all work together on this project. 

Your shipping company handles two-day and overnight packages for different shipping carriers.  This means that the customer can choose between sending their package UPS, FEDEX or USPS and how fast they need it delivered. 

Your form user interface should collect customer/recipient address information and allow the customer to choose which company, which shipping method they want, and input how heavy the package is.
Your program will call a web service that will then return the cost for this package. Your group will create this web service. 
Customers should be able to ship multiple packages using different carriers and methods on one invoice.
When a customer is finished, an invoice should be generated to show each line-item amount (the cost of each package), a subtotal, tax, and the final total
The program should allow the customer to print this invoice to the printer
The program should also allow you to print the shipping labels for each package on the order
Invoices should be saved in the program so they are viewable on-demand. The current day’s invoices should be stored in memory while older invoices will be serialized and saved to the SQL database for later retrieval.
Please use the rubric to make sure that your project meets all criteria for this assignment.

Regarding the Web Service

Your group will be creating the web service for this project that takes in which company, which shipping method they want, and input how heavy the package is. The web service should be designed to return a price.

You'll want to get out in front of the web service quickly as you'll need to deliver it to me (checked into TFS) so I can install it on the server and give you the endpoint that will be used in your application.  If you have errors once it's installed you'll want to have time to fix them. 

When your web service is ready, ping me on Discord to get it installed. 
