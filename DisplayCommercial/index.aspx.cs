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
using System.Data.SqlClient;
using System.Configuration;


namespace DisplayCommercial
{
    public partial class index : System.Web.UI.Page
    {
        public static SqlConnection CreateConnection()
        {
            //SqlConnection conn = new SqlConnection(@"data source = LAPTOP-9C071575; integrated security = true; database = MovieDB");
            SqlConnection conn = new SqlConnection(@"data source = DESKTOP-F8MV33J\SQLEXPRESS; integrated security = true; database = MovieDB");
            return conn;
        }

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

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/CommercialTransformed.xml"));

                DataTable dtCommercial = ds.Tables["commercial"];
                conn.Open();
                using (SqlBulkCopy bc = new SqlBulkCopy(conn))
                {
                    bc.DestinationTableName = "Commercial";
                    bc.ColumnMappings.Add("ID", "ID");
                    bc.ColumnMappings.Add("CompanyName", "CompanyName");
                    bc.ColumnMappings.Add("Website", "Website");
                    bc.ColumnMappings.Add("Address", "Address");
                    bc.ColumnMappings.Add("Telephone", "Telephone");
                    bc.ColumnMappings.Add("CompanyLogo", "CompanyLogo");
                    bc.WriteToServer(dtCommercial);
                }
                
            }





        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();

                ds.ReadXml(Server.MapPath("~/Data.xml"));

                DataTable dtDept = ds.Tables["Department"];
                DataTable dtEmp = ds.Tables["Employee"];

                con.Open();

                using (SqlBulkCopy sb = new SqlBulkCopy(con))
                {
                    sb.DestinationTableName = "Departments";
                    sb.ColumnMappings.Add("ID", "ID");
                    sb.ColumnMappings.Add("Name", "Name");
                    sb.ColumnMappings.Add("Location", "Location");
                    sb.WriteToServer(dtDept);
                }

                using (SqlBulkCopy sb = new SqlBulkCopy(con))
                {
                    sb.DestinationTableName = "Employees";
                    sb.ColumnMappings.Add("ID", "ID");
                    sb.ColumnMappings.Add("Name", "Name");
                    sb.ColumnMappings.Add("Gender", "Gender");
                    sb.ColumnMappings.Add("DepartmentId", "DepartmentId");
                    sb.WriteToServer(dtEmp);
                }
            }

        }

    }
}