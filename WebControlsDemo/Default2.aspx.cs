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
        if (!IsPostBack)
        {
            ddlCountry.Items.Add("China");
            ddlCountry.Items.Add("Japan");
        }
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        lblSelCountry.Text = "You have selected = " + ddlCountry.Text;
    }
    protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblSelCountry.Text = "You have selected = " + ddlCountry.Text;
    }
}