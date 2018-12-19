using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.MidwestCityProperties
{
    public partial class OrchardPlaza : System.Web.UI.Page
    {
        public static string m2 = "~/img/orchard/OrchardPlaza1-1080x675.jpg";//ChangeMainPic
        public static string m3 = "2150 S. Douglas Blvd. MWC, 73130<br>";//changeLocation
        public static string a1 = "Orchard Plaza is a 12,000 sq. ft. shopping center on approximately 2 acres of land on the east side of Douglas Boulevard, between SE 29th and SE 15th in Midwest City. Approximately 80 parking spaces are available. High traffic counts on Douglas and high visibility and easy access from Douglas make Orchard Plaza an ideal retail center. A list of current tenants is attached.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Access: Douglas Blvd<br>"
            + "County: Oklahoma<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Building SF: 12,000<br>"
            + "Parking: ample";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "There is no space available at this time";// information about available space goes here
        public static string k = "~/img/orchard/orchardplazadrawing-400x284.jpg";//carousel img 1
        public static string l = "";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Orchard Plaza";
            Master.changeTitle("Orchard Plaza");
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