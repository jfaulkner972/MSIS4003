using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.EdmondProperties
{
    public partial class UniversityPlaza : System.Web.UI.Page
    {
        public static string m2 = "~/img/university plaza/20160801_101911-1024x768-1024x675.jpg";//ChangeMainPic
        public static string m3 = "1142 East 2nd Street, Edmond, OK";//changeLocation
        public static string a1 = "University Plaza is near the intersection of 2nd street and Bryant. In front of the Super Target. Lowes, Wal-mart neighborhood grocery store and the Edmond medical center are located at this intersection.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Access: 2nd St. and Bryant in Edmond<br>"
                                + "County: Oklahoma<br>"
                                + "Type: Neighborhood Shopping Center";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "1110 E. 2nd St. -- 4700 sq. ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$14.00 per square foot plus Taxes, Insurance and CAM Charges";// information about available space goes here
        public static string k = "~/img/university plaza/20160801_101839-1024x768-400x284.jpg";//carousel img 1
        public static string l = "~/img/university plaza/20160801_102012-1024x768-400x284.jpg";//carousel img 2
        public static string m = "~/img/university plaza/UniversityPlaza2.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "University Plaza";
            Master.changeTitle("University Plaza");
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