using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal class Customer_Information
    {
        private int _id;
        private string customer_name;
        private string billing_address;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Customer_Name
        {
            get { return customer_name; }
            set { customer_name = value; }
        }

        public string Billing_Address
        {
            get { return billing_address; }
            set { billing_address = value; }
        }
        /*
        public Customer_Information() 
        { 
            //initial values
        }
        */
    }
}

/*
 [Customer_ID]
      ,[Customer_Name]
      ,[Billing_Address]
      ,[Billing_Address2]
      ,[Billing_City]
      ,[Billing_State]
      ,[Billing_Zip]
      ,[Billing_County]
      ,[Billing_Country]
      ,[Primary_Contact_Name]
      ,[Phone_Number]
      ,[Alternate_Phone_Number]
      ,[Fax_Number]
      ,[Email_Address]
      ,[Customer_Purchase_Behaviour]
      ,[Method_of_Payment]
      ,[Additional_Information]
      ,[PO_Required]
      ,[ShapePricingPerEach]
      ,[SendTo]
      ,[BuyFrom]
      ,[AccountType]
      ,[Unique_ID]
      ,[SendPriceIncreaseTo]
 */
