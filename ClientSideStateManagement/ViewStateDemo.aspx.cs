using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewStateDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ViewState["language"] != null)
        {
            string language = ViewState["language"].ToString();
            Label2.Text = "Last selected Language was :" + language;

        }
        else
        {
            Label2.Text = "Last selected Language was None"; 
        }
        
        ViewState["language"] = DropDownList1.Text;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Current selected Language = " + DropDownList1.Text;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    }
