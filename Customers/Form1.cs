using System.Drawing.Text;

namespace Customers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Load_Button_Click(object sender, EventArgs e)
        {
            //create different buttons for different queries

            string customer = customer_textbox.Text;
            string query = $"SELECT TOP 500 * from Customer_Information WHERE Customer_Name = '{customer}';";
            Pass_Query(query);
        }
        /*
        private void Build_Query()
        {

        }
        */
        private void Pass_Query(string query_str)
        {
            Customer_Controller customer_Controller = new Customer_Controller();

            customer_grid_view.DataSource = customer_Controller.GetData(query_str);
        }
    }
}

/*
 * [Customer_ID]
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