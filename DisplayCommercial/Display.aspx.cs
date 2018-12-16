using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;

namespace DisplayCommercial
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Generate();

        }

        SqlConnection con = new SqlConnection();

      

        protected void Button1_Click(object sender, EventArgs e)
        {

            //string[> NameArray = new string[>
            //{
            //    "Tue",
            //    "Torban",
            //    "Ismail",
            //    "Mariana",
            //    "Chandra"
            //};
            List<string> NameArray = new List<string>(){
                "Tue",
                "Torban",
                "Ismail",
                "Mariana",
                "Chandra"
            };
            Random rand = new Random();

            //lblMessage.Text = NameArray[rand.Next(1, NameArray.Count)>;
            string showData = NameArray[rand.Next(1, NameArray.Count)];


            //void randoData()
            //{
            //    int i;
            //    for(i=0;i<NameArray.Length; i++)
            //    {

            //    }
            //}




            //string displayRandom = NameArray.OrderBy(n=>Guid.NewGuid()).ToArray();

            GridView1.DataSource = showData;
            GridView1.DataBind();

            //Generate();
            //setImgs();
            //SqlConnection con = UtilityClass.CreateConnection();

            //var rand = new Random();
            //var MovieName = DB.Movies.OrderBy(c => rand.Next()).Select(c => c.ContactName).Take(5);
            //foreach(string name in MovieName)
            //{
            //    Console.WriteLine(name);
            //}
        }

        //<script>
        ////setTimeout(function(){
        ////    notifyMe();

        ////} , 1000 )
        //</script>


        //public void Generate()
        //{
        //    List<string> Quotes = new List<string>();
        //    Random rand = new Random();
        //    StreamReader quoteReader = new StreamReader("Quotes.txt");
        //        String line = "";
        //    while (!quoteReader.EndOfStream)
        //    {
        //        line = quoteReader.ReadLine();
        //        Quotes.Add(line);
        //    }
        //    lblMessage.Text = Quotes[rand.Next(1, Quotes.Count)>;
        //}

        //    public void setImgs()
        //    {
        //        double imgWidth = 50;
        //        double imgHeight = 30;

        //        // Substract image dimensions so they don't be cut off by youre canvas 
        //        double horVal = myCanvas.Width - imgWidth;  //You can  also use myCanvas.ActualWidth
        //        double verVal = myCanvas.Height - imgHeight; //You can  also use myCanvas.ActualHeight 
        //        for (int i = 0; i < 20; i++)
        //        {
        //            Random myRandom1 = new Random(i);// i = seed   
        //            Rectangle rect = new Rectangle();
        //            rect.Width = imgWidth;
        //            rect.Height = imgHeight;
        //            rect.Fill = Brushes.DarkGray;
        //            myCanvas.Children.Add(rect);

        //            // Multiply the available space by a random value between 0 and 1
        //            Canvas.SetLeft(rect, horVal * myRandom1.NextDouble());
        //            Canvas.SetTop(rect, verVal * myRandom1.NextDouble());
        //        }
        //    }
    }
}