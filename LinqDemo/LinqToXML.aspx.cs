using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq; 

public partial class LinqToXML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        XDocument contactsDoc= new XDocument (new XElement("Contacts",
            new XElement("Contact",
                new XAttribute("ContactNo", "9845563363"),
                new XElement("Name","Kiran Patange"),
                new XElement("Address",
                    new XElement("City","Pune"),
                    new XElement("State","Maharashtra")))));

        XElement e1=new XElement("Contact",
                new XAttribute("ContactNo", "989542303"),
                new XElement("Name","Amarjeet Singh"),
                new XElement("Address",
                    new XElement("City","Bangalore"),
                    new XElement("State","Karnataka")));

        XElement e2 = new XElement("Contact",
             new XAttribute("ContactNo", "782554662"),
             new XElement("Name", "Shafique Shaikh"),
             new XElement("Address",
                 new XElement("City", "Mumbai"),
                 new XElement("State", "Maharashtra")));

        XElement e3 = new XElement("Contact",
            new XAttribute("ContactNo", "97732324123"),
            new XElement("Name", "Dhwani Patel"),
            new XElement("Address",
                new XElement("City", "Mumbai"),
                new XElement("State", "Maharashtra")));

        XElement root = contactsDoc.Root;
        root.Add(e1);
        root.Add(e2);
        root.Add(e3);

        contactsDoc.Save(Server.MapPath(@"Contacts.xml")); //the file is created on the solution explorer
        //i.e the server itself,since we dont have a physical drive for asp.net since it works with the browser & server 

        lblmessage.Text = "XML file created...";

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        XElement docElement = XElement.Load(Server.MapPath(@"Contacts.xml"));

        var contactsQuery = from c in docElement.Elements("Contact")
                            where (string)c.Element("Address").Element("State")=="Maharashtra"
                            select new {   //anonymous type
                            ContactName=(string)c.Element("Name"),
                            City=(string)c.Element("Address").Element("City"),
                            ContactNo =(double)c.Attribute("ContactNo")
                            };

        //or create a class called Contact with properties ContactName,City & ContactNo
        //select new Contact {  // return type is Contact here

                            //ContactName=(string)c.Element("Name"),
                            //City=(string)c.Element("Address").Element("City"),
                            //ContactNo =(double)c.Attribute("ContactNo")
        GridView1.DataSource = contactsQuery;
        GridView1.DataBind();
    }
}