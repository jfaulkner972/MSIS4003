using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Property";
            Master.changeTitle("Welcome to Properties");
            AboutUs();
            imgCaptions();
        }

        private void AboutUs()
        {
            aboutUs.Text = "At Properties, we know that your time is valuable. That is why we dedicate ourselves to handling all aspects of your commercial real estate leasing needs. We want to be sure that you have time for the other things in your life. To find out what we can do for you, please contact us right away!";
        }

        private void imgCaptions()
        {
            img1.Text = "";
            img2.Text = "";
            img3.Text = "";
            img4.Text = "";
            img5.Text = "";
        }
    }
}