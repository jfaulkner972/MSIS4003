using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class DowntownShoppingCenter : System.Web.UI.Page
    {
        public static string m2 = "~/img/downtown shopping/DownTown3-1.png";//ChangeMainPic
        public static string m3 = "555 West Main Norman, OK. 73069";//changeLocation
        public static string a1 = "Downtown Shopping Center is located within walking distance of Norman City Hall and all the necessities in the center of Norman. The center is less than a mile away from the University of Oklahoma and a couple of miles from I-35 on Main Street. Downtown Shopping Center has excellent visibility from Main Street. The shopping center is 50,000 sq. ft. with Sprouts Grocery Store as the anchor tenant occupying 30,000 sq. ft. of the center and Cellar Wine and Spirits occupying the rest.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Access: Main St.<br>"
            +"County: Cleveland<br>"
            +"Type: Shopping Center<br>"
            +"Building SF: 50,000<br>"
            +"Parking: ample";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "  There is no available space at this time.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$8.00 per sq ft plus Taxes, Insurance and CAM expenses";// information about available space goes here
        public static string k = "~/img/downtown shopping/DownTown1-1-400x284.png";//carousel img 1
        public static string l = "~/img/downtown shopping/DownTown2-1-400x284.png";//carousel img 2
        public static string m = "~/img/downtown shopping/DownTown5-1-400x284.png";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Downtown Shopping Center";
            Master.changeTitle("Downtown Shopping Center");
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