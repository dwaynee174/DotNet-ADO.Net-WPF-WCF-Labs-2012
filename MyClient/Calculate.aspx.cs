using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class Calculate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        Service1Client sc = new Service1Client();
        int a=Convert.ToInt32(txtnum1.Text);
        int b = Convert.ToInt32(txtnum2.Text);
        int c= sc.add(a,b);
        lblMessage.Text ="Addition is : " +c.ToString();
    }
    protected void btnSubtract_Click(object sender, EventArgs e)
    {
        Service1Client sc = new Service1Client();
        int a = Convert.ToInt32(txtnum1.Text);
        int b = Convert.ToInt32(txtnum2.Text);
        int c = sc.subtract(a,b);
        lblMessage.Text = "Difference is : " + c.ToString();

    }
}