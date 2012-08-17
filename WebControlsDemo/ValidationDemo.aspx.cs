using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidationDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int i=0;
        foreach(ListItem item in CheckBoxList1.Items)
        {
            if(item.Selected)
             {
                i=1;
                break;
              }
        }
        if (i ==0)
        {
            args.IsValid = false;
           
        }
        else 
        {
            args.IsValid = true;
        }
    }

    
}