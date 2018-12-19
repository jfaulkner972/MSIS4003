using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class WestRenoIndustrialPark : System.Web.UI.Page
    {
        public static string m2 = "~/img/WestRenoIndustrialPark.jpeg";//ChangeMainPic
        public static string m3 = "North Council Road and West Reno";//changeLocation
        public static string a1 ="West Reno Industrial Service Center is located at the Northwest corner of North Council"
                                    +" Road and West Reno in Oklahoma City by the Oklahoma City Outlet Mall. The complex is" 
                                    +" a combination of 2000 square feet spaces that have a single office and bathroom in the"
                                    +" front in half of the complex and an open space with a 14′ tall x 12′ wide garage door" 
                                    +" which is in front of the space, which are in the back half of the complex. The center"
                                    +" has very easy access to I-40 west, and has ample parking.";//Property Description
        public static string a = "";//General Info
        public static string b = "";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "5 S. Council Suite C -- 1500 sq. ft.<br>"
                                + "5 S.Council Suite D -- 1500 sq.ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$950.00/ per month <br>"
                                + "8017 W.Reno -- 2,000 sq.ft.<br>"
                                + "8035 W.Reno -- 2,000 sq.ft.<br>"
                                + "8037 W.Reno -- 2,000 sq.ft.<br>"
                                + "$950.00/per month";// information about available space goes here
        public static string k = "~/img/WestRenoIndustrialPark-Carousel1.jpeg";//carousel img 1
        public static string l = "~/img/WestRenoIndustrialPark-Carousel2.jpeg";//carousel img 2
        public static string m = "~/img/WestRenoIndustrialPark-Carousel3.jpeg";//carousel img 3
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "West Reno Industrial Park";
            Master.changeTitle("West Reno Industrial Park");
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