using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DcsTest2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            webTestService.TestService testService = new webTestService.TestService();
            string usernamePass = testService.GetUsernameAndPassword();
            Label1.Text = "" + usernamePass + ""; 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            webTestService.TestService testService = new webTestService.TestService();
            string usernamePass = testService.GetUsernameAndPassword();
            string username = null;
            string password = null;

            string[] multiArray = usernamePass.Split(new[] { "username: ", "password: ", "," }, StringSplitOptions.None);
            foreach (string str in multiArray)
            {
                if (str.Trim() != "")
                {
                    if (username != null)
                        password = str;
                    else username = str;
                }           
                    
       
            }

            webTestService.Supplier[] suppliers = new webTestService.Supplier[3];
            suppliers[0] = new webTestService.Supplier();
            suppliers[1] = new webTestService.Supplier();
            suppliers[2] = new webTestService.Supplier();

            suppliers[0].Id = Text1.Value;
            suppliers[0].Name = Text2.Value;
            suppliers[0].Brutto = decimal.Parse(Text3.Value);
            suppliers[0].Netto = decimal.Parse(Text4.Value);
            
            suppliers[1].Id = Text5.Value;
            suppliers[1].Name = Text6.Value;
            suppliers[1].Brutto = decimal.Parse(Text7.Value);
            suppliers[1].Netto = decimal.Parse(Text8.Value);

           
            suppliers[2].Id = Text9.Value;
            suppliers[2].Name = Text10.Value;
            suppliers[2].Brutto = decimal.Parse(Text11.Value);
            suppliers[2].Netto = decimal.Parse(Text12.Value);

            System.Diagnostics.Debug.WriteLine("shiran: "+suppliers[0]);


            webTestService.SupplierGain[] supplierGain = new webTestService.SupplierGain[3];
            supplierGain[0] = new webTestService.SupplierGain();
            supplierGain[1] = new webTestService.SupplierGain();
            supplierGain[2] = new webTestService.SupplierGain();

            supplierGain = testService.SuppliersGain(username, password, suppliers);

            Label2.Text = "Supplier 1 - Name:" + supplierGain[0].Name + " " + "Total gain:" + supplierGain[0].TotalGain ;
            Label3.Text = "Supplier 2 - Name:" + supplierGain[1].Name + " " + "Total gain:" + supplierGain[1].TotalGain;
            Label4.Text = "Supplier 3 - Name:" + supplierGain[2].Name + " " + "Total gain:" + supplierGain[2].TotalGain;



        }

    }
}