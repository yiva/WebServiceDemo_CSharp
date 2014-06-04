using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.CalService;
namespace WebClient
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TestService ts = new TestService();
            int n = Select1.SelectedIndex;
            if (Num1.Text != "" && Num2.Text != "") {
                switch (n) { 
                    case 0:
                        Result.Text = ts.add(Double.Parse(Num1.Text), Double.Parse(Num2.Text)).ToString();
                        break;
                    case 1:
                        Result.Text = ts.sub(Double.Parse(Num1.Text), Double.Parse(Num2.Text)).ToString();
                        break;
                    case 2:
                        Result.Text = ts.multi(Double.Parse(Num1.Text), Double.Parse(Num2.Text)).ToString();
                        break;
                    case 3:
                        Result.Text = ts.div(Double.Parse(Num1.Text), Double.Parse(Num2.Text)).ToString();
                        break;
                }
            }
        }
    }
}