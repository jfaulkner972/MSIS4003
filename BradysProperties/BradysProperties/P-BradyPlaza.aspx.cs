using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class BradyPlaza : System.Web.UI.Page
    {
        public static string m2 = "~/img/brady plaza/bradyplaza11-1.jpg";//ChangeMainPic
        public static string m3 = "88th and S Santa Fe Oklahoma City, 73139";//changeLocation
        public static string a1 = "Brady Plaza Shopping Center is located just north of the intersection of SW 89th and S. Santa Fe, about a mile south of I-240 and 2 miles west of I-35 on southwest 89th. The center has good visibility, easy access to S. Santa Fe and abundant parking with a good mix of strong local tenants. Wal-Mart Super Center and Lowe’s are within a mile of the center on S. Santa Fe. and Home Depot is nearby on S. Shields Ave.";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = " Type: Neighborhood Shopping Center<br>"
            +"Building SF: 17,500<br>"
            +"Property Location: 88th and S Santa Fe Oklahoma City, 73139<br>";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "8803 – 1,000 sq.ft.<br>"
            +"$8.00 per sq.ft.plus Taxes, Insurance, and CAM Charges<br>"
            +"8823 – 1,000 sq.ft.<br>"
            +"$8.00 per sq. ft.plus Taxes, Insurance, and CAM Charges<br>"
            +"8825 – 1, 000 sq.ft.<br>"
            +"$8.00 per sq. ft.plus Taxes, Insurance, and CAM Charges";// information about available space goes here
        public static string k = "~/img/brady plaza/bradyplaza11-1-400x284.jpg";//carousel img 1
        public static string l = "~/img/brady plaza/bradyplaza31-1-400x284.jpg";//carousel img 2
        public static string m = "~/img/brady plaza/bradyplazadrawing1-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Brady Plaza";
            Master.changeTitle("Brady Plaza");
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