using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class PennCrossing : System.Web.UI.Page
    {
        public static string m2 = "~/img/penn crossing/penncrossing4.jpg";//ChangeMainPic
        public static string m3 = "NW 23rd and North Pennsylvania";//changeLocation
        public static string a1 = "Penn Crossing Shopping Center is 100,000 square feet shopping center located in the heart of Oklahoma City at the intersection of NW 23rd and north Pennsylvania anchored by Wal- Mart Neighborhood grocery store on one side and 100,000 square feet Buy for Less grocery store on the other, Shephard Mall is next door to this center which is home to over 100 of State of Oklahoma agency’s with 1000 of employee who shop at Penn Crossing from food to everyday needs. Oklahoma City University is also within walking distance of this center.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Zoning:<br>"
                                + "Commercial Shopping Center<br>"
                                + "Access:<br>"
                                + "Intersection of NW 23rd and north Pennsylvania<br>"
                                + "County: Oklahoma<br>"
                                + "Lease Information Lease Rate: $8.00 per sq. ft. plus Taxes, Insurances and CAM charges.<br>";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "No Available Space at this time";// information about available space goes here
        public static string k = "~/img/penn crossing/penncrossing4-150x150.jpeg";//carousel img 1
        public static string l = "~/img/penn crossing/penncrossing6-150x150.jpeg";//carousel img 2
        public static string m = "~/img/penn crossing/penncrossing5-150x150.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Penn Crossing ";
            Master.changeTitle("Penn Crossing");
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