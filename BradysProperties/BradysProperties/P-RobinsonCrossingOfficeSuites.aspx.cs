using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class RobinsonCrossingOfficeSuites : System.Web.UI.Page
    {
        public static string m2 = "~/img/robinson office/RobinsonCrossingOfficeSuites1-1-1080x675.jpg";//ChangeMainPic
        public static string m3 = "1370 North Interstate Drive Norman, OK";//changeLocation
        public static string a1 = "The Robinson Crossing Office Suites are located at 1370 North Interstate Drive, in the Robinson Crossing Shopping Center.  The office suites are clearly visible from I-35. The office sizes range from 218 square feet to 940 square feet, including a 10% common area factor.The larger suites have the ability to have two or three offices and a receptionist area built in the suites depending on the tenants need.Some suite’s have a door leading to the outside, as well as access to the inside common area.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Pricing: $14.00 per sq.ft. (FULL SERVICE)";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "Suite 152 – 816 sq. ft.  at $14.00 full service<br>"
                                + "Suite 153 – 654 sq. ft. at $14.00 full service<br>";// information about available space goes here
        public static string k = "~/img/robinson office/RobinsonCrossingOfficeSuites2-1-400x284.jpg";//carousel img 1
        public static string l = "~/img/robinson office/RobinsonCrossingOfficeSuites6-1-400x284.jpg";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Robinson Crossing Office Suites";
            Master.changeTitle("Robinson Crossing Office Suites");
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