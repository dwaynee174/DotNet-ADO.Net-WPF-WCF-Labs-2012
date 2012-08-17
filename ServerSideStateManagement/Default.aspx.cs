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
        Label1.Text = Application["count"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        List<string> skillList = new List<string>();
        foreach (ListItem item in CheckBoxList1.Items)
        {
            if (item.Selected)
            {
                skillList.Add(item.Value);
            }
        }


        Session["skills"] = skillList;
        Response.Redirect("Default2.aspx");
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
