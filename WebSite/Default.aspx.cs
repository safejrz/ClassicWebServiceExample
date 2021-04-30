using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // This click event in the client will instantiate a new WebServiceClient and call the Multiplication web method inside it.
        var mys = new ServiceReference.ServiceSoapClient();
        int a = Convert.ToInt32(TextBox1.Text);
        int b = Convert.ToInt32(TextBox2.Text);
        int c = mys.Multiplication(a, b);

        //The result from the webservice is saved into the c variable and sets the text value of the result textbox here:
        TextBox3.Text = c.ToString();
    }
}