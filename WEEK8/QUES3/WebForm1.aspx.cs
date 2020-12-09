using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace QUES3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Cars.xml");
            
            XDocument doc = new XDocument(
                new XElement("Cars", 
                 new XElement("Details",
                            new XElement("Name", "I20"), 
                            new XElement("Make", "Hyundai"), 
                            new XElement("Price", 700000)
                            ),
                 new XElement("Details", 
                            new XElement("Name", "City"), 
                            new XElement("Make", "Honda"), 
                            new XElement("Price", 900000)
                            )
                )
               );
            doc.Save(file);
            Label1.Text = doc.ToString();


        }
    }
}