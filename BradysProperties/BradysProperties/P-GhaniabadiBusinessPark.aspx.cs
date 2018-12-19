using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class GhaniabadiBusinessPark : System.Web.UI.Page
    {
        public static string m2 = "~/img/ghaniabadi/20170403_155312-e1492185780860-1080x675.jpeg";//ChangeMainPic
        public static string m3 = "SW 119th St & S Western Ave, Oklahoma City, OK 73170";//changeLocation
        public static string a1 = "Building A & B<br>"
            + "The property is 30,000 square feet which consist of 15, 2000 sq.ft space each suite has one 10′ x 12′ office and ADA bathroom, the rest of the suite is built out open with a 12′ x 14′ over head back door.The suites has glass front door and window.There is plenty of parking in front of each space and in the back. The properties have Western Avenue signage.<br>"
            + "South west corner of South 119th and South Western Avenue in OKC.Behind O’Reily’s Auto Parts.<br>"
            + "Building C<br>"
            + "The property consist of 8000 sq.ft.of retail space facing South Western Ave.close to Westmoore High School with two ADA bathrooms in 2,000 sq.ft.suite.The suite are delivered in a white box condition, ready for occupancy, with plenty of lighted parking.The property has street signage available.";//Property Description
        public static string a = "";//General Info
        public static string b = "";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "Building A & B Office/ Warehouse: 2,000 sq. ft.<br>"
            +"-4 spaces available – $1,250.00 per month<br>"
            +"Building C Retail: 2,000 sq.ft.<br>"
            +"no space available for building C.";// information about available space goes here
        public static string k = "~/img/ghaniabadi/20170403_155341-e1492185373237-400x284.jpg";//carousel img 1
        public static string l = "~/img/ghaniabadi/20161024_152718-e1485892009309-400x284.jpeg";//carousel img 2
        public static string m = "~/img/ghaniabadi/20161024_152514-e1485892126542-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Ghaniabadi Business Park";
            Master.changeTitle("Ghaniabadi Business Park");
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