using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.MidwestCityProperties
{
    public partial class DeckerCenter : System.Web.UI.Page
    {
        public static string m2 = "~/img/decker/DeckerCenter1.jpg";//ChangeMainPic
        public static string m3 = "1200 S. Air Depot, Midwest City, OK 73110 <br>";//changeLocation
        public static string a1 = "Decker Center is a 33,500 sq. ft. shopping center located at 1200 South Air Depot in Midwest City. This center is very visible to traffic on Air Depot. The center has a strong mix of retail and service tenants. The tenants are well-known among the community.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Access: S.Air Depot"
            + "County: Oklahoma<br>"
            + "Type: Shopping Center<br>"
            + "Building SF: 33,500<br>"
            + "Parking: Ample";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "Suite J -- 1300 sq. ft.<br>"
                                + "Suite T -- 1100 sq.ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "Lease Rate: $6.00 to $12.00 per square foot plus Taxes, Insurances and CAM charges";// information about available space goes here
        public static string k = "~/img/decker/DeckerCenter3-400x284.jpg";//carousel img 1
        public static string l = "~/img/decker/DeckerCenterdrawing-400x284.jpg";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Decker Center";
            Master.changeTitle("Decker Center");
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