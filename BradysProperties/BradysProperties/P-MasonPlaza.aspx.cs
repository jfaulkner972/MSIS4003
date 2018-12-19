using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class MasonPlaza : System.Web.UI.Page
    {
        public static string m2 = "~/img/mason plaza/Mason-1.png";//ChangeMainPic
        public static string m3 = "751 Canadian Trails Dr, Norman, OK, 73072";//changeLocation
        public static string a1 = "The center is west of the intersection of Highway 9 and Chautauqua Avenue, right next to Rudy’s BBQ restaurant in Norman, OK. It is near the University of Oklahoma Campus and about a mile east of I-35 and River Wind Casino. Mason Plaza has 8,125 square feet and excellent visibility from Highway 9. The center is occupied by a liquor store and a chiropractor. The center is a great location for any business!";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Access: Chautauqua Road or S.Canadian Trails Dr.<br>"
            + "County: Cleveland<br>"
            + "Lease Information: $12.00 per sq.ft.plus Taxes, Insurance and CAM charges.<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Parking: ample";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "751 Canadian Trails Suite 120 -- 1560 sq. ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$12.00 per square foot plus Taxes, Insurance, and CAM Charges";// information about available space goes here
        public static string k = "~/img/mason plaza/Mason-1-400x284.png";//carousel img 1
        public static string l = "~/img/mason plaza/Mason-2-400x284.png";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Mason Plaza";
            Master.changeTitle("Mason Plaza");
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