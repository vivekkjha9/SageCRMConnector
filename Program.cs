using System;
using System.Collections.Generic;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace CreateSalesInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            // Create a new instance of a salesInvoice
            salesInvoiceFeedEntry salesInvoice = new salesInvoiceFeedEntry();

            // Find a customer to associate with the new sales invoice
            salesInvoice.tradingAccount = GetCustomer();

            if (salesInvoice.tradingAccount == null)
            {
                // No customer record means we can go no further
                Console.WriteLine("Unable to find a customer record");
                Console.ReadKey(true);
                return;
            }

            // Lookup a commodity to use on the new sales invoice
            commodityFeedEntry commodity = GetCommodity();
            if (commodity == null)
            {
                // No commodity record means we go no further
                Console.WriteLine("Unable to find a commodity record");
                Console.ReadKey(true);
                return;
            }
            commodityFeedEntry commodityReference = new commodityFeedEntry();
            commodityReference.UUID = commodity.UUID;

            // Lookup a commodity to use on the new sales invoice
            taxCodeFeedEntry taxCode = GetTaxCode();
            if (taxCode == null)
            {
                // No record means we go no further
                Console.WriteLine("Unable to find a tax code record");
                Console.ReadKey(true);
                return;
            }

            // Example of creating a historical invoice
            //salesInvoice.date = salesInvoice.taxDate = DateTime.UtcNow.AddDays(-2);

            // NOTE: This example omits the use of tax code for brevity.
            // Not specifying tax codes means that appropriate defaults will be used automatically.
            // However it is strongly recommended that tax codes are explicitly set to ensure expected results
            taxCodeFeedEntry taxReference = new taxCodeFeedEntry();
            taxReference.UUID = taxCode.UUID;

            salesInvoice.taxCodes = new taxCodeFeed();
            salesInvoice.taxCodes.Entries.Add(taxReference);

            salesInvoice.carrierTotalPrice = 100;
            salesInvoice.carrierTaxPrice = 20;
            salesInvoice.carrierNetPrice = 80;

            // Create a new sale invoice line using the commodity we just looked up
            salesInvoiceLineFeedEntry orderLine = new salesInvoiceLineFeedEntry();
            orderLine.type = "Standard";
            orderLine.text = commodity.description;
            orderLine.commodity = commodityReference;
            orderLine.quantity = 2;
            orderLine.netTotal = 50;
            orderLine.taxTotal = 10;
            orderLine.grossTotal = 60;
            orderLine.taxCodes = new taxCodeFeed();
            orderLine.taxCodes.Entries.Add(taxReference);

            // Create another invoice line this time as free text
            salesInvoiceLineFeedEntry freetextOrderLine = new salesInvoiceLineFeedEntry();
            freetextOrderLine.type = "Free Text"; // Equivalent to S1 stock code
            freetextOrderLine.text = "An example product";
            freetextOrderLine.quantity = 5;
            freetextOrderLine.netTotal = 100;
            freetextOrderLine.taxTotal = 20;
            freetextOrderLine.grossTotal = 120;
            freetextOrderLine.taxCodes = new taxCodeFeed();
            freetextOrderLine.taxCodes.Entries.Add(taxReference);

            // Create a 3rd invoice line this time as a message
            salesInvoiceLineFeedEntry messageOrderLine = new salesInvoiceLineFeedEntry();
            messageOrderLine.type = "Commentary"; // Equivalent to S1 stock code
            messageOrderLine.text = "A message line created via Sdata";


            // Associate the lines with our invoice
            salesInvoice.salesInvoiceLines = new salesInvoiceLineFeed();
            salesInvoice.salesInvoiceLines.Entries.Add(orderLine);
            salesInvoice.salesInvoiceLines.Entries.Add(freetextOrderLine);
            salesInvoice.salesInvoiceLines.Entries.Add(messageOrderLine);

            // Now we have constructed our new invoice we can submit it using the HTTP POST verb  
            Sage.Common.Syndication.SDataUri salesInvoiceUri = new Sage.Common.Syndication.SDataUri();
            salesInvoiceUri.BuildLocalPath("Accounts50", "GCRM", "-", "salesInvoices");

            SDataRequest invoiceRequest = new SDataRequest(salesInvoiceUri.Uri, salesInvoice, Sage.Integration.Messaging.Model.RequestVerb.POST);
            invoiceRequest.Username = "MANAGER";
            invoiceRequest.Password = "";

            // IF successful the POST operation will provide us with a the newly created sales invoice
            salesInvoiceFeedEntry savedSalesInvoice = new salesInvoiceFeedEntry();
            invoiceRequest.RequestFeedEntry<salesInvoiceFeedEntry>(savedSalesInvoice);

            if (invoiceRequest.IsStatusValidForVerb)
            {
                Console.WriteLine(string.Format("Successfully created sales invoice {0}", savedSalesInvoice.reference));
            }
            else
            {
                // There was a problem
                Console.WriteLine("Create failed. Response was {0}", invoiceRequest.HttpStatusCode.ToString());
                if (invoiceRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in invoiceRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }
            }

            Console.ReadKey(true);
        }

        static tradingAccountFeedEntry GetCustomer()
        {
            // Look up the first customer record 
            Sage.Common.Syndication.SDataUri accountUri = new Sage.Common.Syndication.SDataUri();
            accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            accountUri.Where = "customerSupplierFlag eq 'Customer'";
            accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri);
            accountRequest.AllowPromptForCredentials = false;
            accountRequest.Username = "MANAGER";
            accountRequest.Password = "";

            tradingAccountFeed accounts = new tradingAccountFeed();
            accountRequest.RequestFeed<tradingAccountFeedEntry>(accounts);

            // If we found a customer record return it
            if (accountRequest.IsStatusValidForVerb && accounts.Entries != null && accounts.Entries.Count > 0)
                return accounts.Entries[0];
            else
            {
                // There was a problem
                Console.WriteLine("Account lookup failed. Response was {0}", accountRequest.HttpStatusCode.ToString());
                if (accountRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in accountRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
        }

        static commodityFeedEntry GetCommodity()
        {
            // Look up the first commodity (product) record 
            Sage.Common.Syndication.SDataUri commodityUri = new Sage.Common.Syndication.SDataUri();
            commodityUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodities");
            commodityUri.Count = 1;

            SDataRequest commodityRequest = new SDataRequest(commodityUri.Uri);
            commodityRequest.Username = "MANAGER";
            commodityRequest.Password = "";

            commodityFeed commodities = new commodityFeed();
            commodityRequest.RequestFeed<commodityFeedEntry>(commodities);

            // If we found a record return it
            if (commodityRequest.IsStatusValidForVerb && commodities.Entries != null && commodities.Entries.Count > 0)
                return commodities.Entries[0];
            else
            {
                // There was a problem
                Console.WriteLine("Commodity lookup failed. Response was {0}", commodityRequest.HttpStatusCode.ToString());
                if (commodityRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in commodityRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
        }

        static taxCodeFeedEntry GetTaxCode()
        {
            // Look up the tax code record 
            Sage.Common.Syndication.SDataUri taxCodeUri = new Sage.Common.Syndication.SDataUri();
            taxCodeUri.BuildLocalPath("Accounts50", "GCRM", "-", "taxCodes");
            taxCodeUri.Where = "reference eq 'T1'";

            SDataRequest taxcodeRequest = new SDataRequest(taxCodeUri.Uri);
            taxcodeRequest.Username = "MANAGER";
            taxcodeRequest.Password = "";

            taxCodeFeed taxcodes = new taxCodeFeed();
            taxcodeRequest.RequestFeed<taxCodeFeedEntry>(taxcodes);

            // If we found a customer record return it
            if (taxcodeRequest.IsStatusValidForVerb && taxcodes.Entries != null && taxcodes.Entries.Count > 0)
                return taxcodes.Entries[0];
            else
            {
                // There was a problem
                Console.WriteLine("Tax code lookup failed. Response was {0}", taxcodeRequest.HttpStatusCode.ToString());
                if (taxcodeRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in taxcodeRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
        }
    }
}