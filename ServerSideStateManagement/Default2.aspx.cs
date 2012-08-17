using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> selectedSkills =(List<string>)Session["skills"];
        foreach (string s in selectedSkills)
        {
            ListBox1.Items.Add(s);
        }
    }
}