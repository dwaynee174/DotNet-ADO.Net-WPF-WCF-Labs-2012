using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SerializationDemo
{
    [XmlRoot(ElementName="LoginInfo")]
    public class User
    {

        string username;
        string password;
        [XmlElement(ElementName="LoginName")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [XmlIgnore]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
