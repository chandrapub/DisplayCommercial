using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml;
using System.Xml.Xsl;
using System.IO;
using System.Data;
using System.Net;

namespace DisplayCommercial
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the XML uses a namespace, the XSLT must refer to this namespace
            string sourcefile = Server.MapPath("Commercial.xml");
            string xsltfile = Server.MapPath("Commercial.xslt");
            string destinationfile = Server.MapPath("CommercialTransformed.xml");

            FileStream fs = new FileStream(destinationfile, FileMode.Create);
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(xsltfile);
            xct.Transform(sourcefile, null, fs);
            fs.Close();


        }
    }
}