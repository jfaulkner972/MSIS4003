using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class VirtualOfficesWestminster : System.Web.UI.Page
    {
        public static string m2 = "~/img/VirtualOfficesatWestminsterExecutiveSuites.jpg";//ChangeMainPic
        public static string m3 = "10601 S Western Ave, Oklahoma City, OK 73170";//changeLocation
        public static string a1 = "Sign up for a Virtual Office at Westminster Executive Suites to project the best possible impression to your clients. We offer a great professional image at a fraction of the cost of running your own office. We are located within a few minutes of three major highways, I-240, I-35, and I-44. This is an efficient alternative to having a full-time office, and can be easily set up within 48 hours. Our Virtual offices are perfect for start-up, small, out of town and home-based businesses or for those looking to expand their markets, risk-free!<br>"
                                   + " Do you own a small business, but do not need a full-time office?<br>"
                                   + " Do you need a place to meet clients in the Oklahoma City Area, but live elsewhere?<br>"
                                   + "Is your business headquarters out-of-state, but you occasionally conduct business in Oklahoma?<br>"
                                   + "Do you need a local Oklahoma phone number and/or address for your clients?<br>"
                                   + "We would be delighted to welcome you as a new member of our Virtual Office team at the Westminster Executive Suites!";//Property Description
        public static string a = "<b>General Info </b>";//General Info
        public static string b = "Included with your low monthly rent, you have access to:</b><br>"
                                   + "-Personalized telephone line<br>"
                                   + "-Voice Mail<br>"
                                   + "-Incoming package and mail receipt<br>"
                                   + "-24-Hour access to mail and packages<br>"
                                   + "-Receptionist to greet your guests<br>"
                                   + "-Comfortable waiting area<br>"
                                   + "-8 hours per month for the use of two conference rooms<br>"
                                   + "-Kitchen with refrigerator, microwave, and vending machine<br>"
                                   + "-Free coffee for you and your guests<br>"
                                    
            ;//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Leasing Information: </b>";//Spacing information Title
        public static string j = "12-Month Agreement..............$195.00 per month<br>"
                                + "6-Month Agreement..............$225.00 per month<br>"
                                + "Month-to-Month Agreement.......$245.00 per month<br>"
                                + "<b>Available for Additional Fees:</b><br>"
                                + "Fax/Copy machine<br>"
                                + "Document and parcel delivery<br>"
                                + "Postage metering<br>";// information about available space goes here
        public static string k = "~/img/virtual westminster exec/WestminsterExecutiveSuites11-1.jpg";//carousel img 1
        public static string l = "~/img/virtual westminster exec/WestminsterExecutiveSuites41-150x150.jpeg";//carousel img 2
        public static string m = "~/img/virtual westminster exec/WestminsterExecutiveSuites31-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Virtual Offices at Westminster Executive Suites";
            Master.changeTitle("Virtual Offices at Westminster Executive Suites");
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