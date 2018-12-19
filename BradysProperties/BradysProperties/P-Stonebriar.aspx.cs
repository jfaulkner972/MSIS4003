using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class Stonebriar : System.Web.UI.Page
    {
        public static string m2 = "~/img/stonebriar/Stonebriar2-400x284.jpg";//ChangeMainPic
        public static string m3 = "SW 134th St. and Western Avenue";//changeLocation
        public static string a1 = "Stonebriar Shopping Center is 30,000 sq. ft. neighborhood retail center. The center is located north of the intersection of SW 134th St. and Western Avenue on the east side of South Western Avenue. The center has a strong mix of service and retail tenants. The center is located in a well populated and growing area which makes this ideal location for your business.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = " $10.00 to $12.00 per square foot plus taxes, insurance, and CAM Charges."
                                + "Zoning:<br>"
                                + "Access: S. Western<br>"
                                + "County: Cleveland<br>"
                                + "Improvements<br>"
                                + "Type:<br>"
                                + "Shopping Center<br>"
                                + "Building SF: 30,000<br>"
                                + "Site SF:<br>"
                                + "Parking: ample<br>";//Building stuff square ft location building type etc
        public static string c = "/img/stonebriar/Stonebriar-Site-Plan-7-9-2014 (2).pdf";//Redirect Path to Floor Plan 1
        public static string d = "Floor Plan";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "Suite M – 1,300 sq. ft. – $12.00 plus Taxes, Insurance, and CAM Charges<br>"
                                + "Suite N – 1,300 sq. ft. – $12.00 plus Taxes, Insurance, and CAM Charges<br>";// information about available space goes here
        public static string k = "~/img/WestRenoIndustrialPark-Carousel1.jpeg";//carousel img 1
        public static string l = "~/img/WestRenoIndustrialPark-Carousel2.jpeg";//carousel img 2
        public static string m = "~/img/WestRenoIndustrialPark-Carousel3.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Stonebriar";
            Master.changeTitle("Stonebriar");
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