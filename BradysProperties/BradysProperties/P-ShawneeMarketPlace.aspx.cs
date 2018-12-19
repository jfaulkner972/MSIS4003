using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.ShawneeProperties
{
    public partial class ShawneeMarketPlace : System.Web.UI.Page
    {
        public static string m2 = "~/img/shawnee/DSCN0833-1080x675.jpg";//ChangeMainPic
        public static string m3 = "I-40 and Kickapoo St.<br>";//changeLocation
        public static string a1 = "Shawnee Marketplace is a shopping center located on I-40 and North Kickapoo St. in Shawnee, OK. The shopping center is well lit, with plenty of retail shops and all different kinds of restaurants for your dining needs. The shops that are included in the shopping center are Aldi, Hobby Lobby, PetSmart, T.J. Maxx, and Ulta just to name a few.";//Property Description
        public static string a = "<b>General Info</b>";//General Info
        public static string b = "Access: Kickapoo St.<br>"
            + "County: Pottawatomie County<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Property Location: I-40 and Kickapoo St.";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "None at this time.";// information about available space goes here
        public static string k = "~/img/shawnee/DSCN0834-400x284.jpg";//carousel img 1
        public static string l = "~/img/shawnee/DSCN0835-400x284.jpg";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Shawnee Marketplace";
            Master.changeTitle("Shawnee Marketplace");
            Master.changeInfo(m2, m3, a1, a, b, c, d, e1, f, g, h, i, j, k, l, m);
            Master.updateCarousel();
            Master.updateFloorPlanPics();
            Master.updateGeneralInfo();
            Master.updateSpaceInfo();
            Master.updateDescription();
            Master.changeMainPic();
            Master.changeLocation();
        }
    }
}