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
            TransformXml();

        }
        public void TransformXml()
        {

            string sourcefile = Server.MapPath("Commercial.xml");
            string xsltfile = Server.MapPath("Commercial.xslt");
            string destinationfile = Server.MapPath("CommercialTransformed.xml");
            string xslthtmlfile = Server.MapPath("CommercialToHTML.xslt");
            string destinationhtmlfile = Server.MapPath("CommercialTransformed.html");

            XMLCommercialClass xmlfile1 = new XMLCommercialClass(sourcefile, xsltfile, destinationfile);
            xmlfile1.CreateToTransformXml();

            HtmlCommercialClass htmlfile1 = new HtmlCommercialClass(sourcefile, xslthtmlfile, destinationhtmlfile);
            htmlfile1.CreateToTransformHtml();

        }

    }
}