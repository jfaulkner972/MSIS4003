using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class TownAndCountry : System.Web.UI.Page
    {
        public static string m2 = "~/img/town and country/TownCountry1.jpg";//ChangeMainPic
        public static string m3 = "North May Ave. and NW 122nd, OKC";//changeLocation
        public static string a1 = "Town & Country Shopping Center is located just north of the NW corner of May Avenue and NW 122nd street in OKC. The center is on the west side of N. May Avenue. The center has very good visibility and very good access from N. May Avenue, with about 250 parking spaces. This center is located in a heavily developed area with high traffic count, making it a great retail center.";//General Info

        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Zoning:<br>"
                                 + "Access: 122nd St. and N. May. <br>"
                                 + "County: Oklahoma <br>"
                                 + "Lease Information: Suite 113 3,262 sq. ft.<br>"
                                 + "$8.00 per square foot plus taxes, insurance and CAM Charges<br>"
                                 + "Improvements:<br>"
                                 + "Type: Neighborhood Shopping Center<br>";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "Suite 113 –  3,262  sq.ft.<br>"
                                 + "$7.00 per square foot plus Taxes, Insurance, and CAM Charges.<br>";// information about available space goes here
        public static string k = "~/img/town and country/TownCountry1.jpg";//carousel img 1
        public static string l = "~/img/town and country/TownCountry2-400x284.jpg";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Town and Country";
            Master.changeTitle("Town and Country");
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