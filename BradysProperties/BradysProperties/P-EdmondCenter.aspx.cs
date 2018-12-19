using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.EdmondProperties
{
    public partial class EdmondCenter : System.Web.UI.Page
    {
        public static string m2 = "~/img/edmond cneter/20160801_101255-1024x768-1-400x284.jpg";//ChangeMainPic
        public static string m3 = "112 E 21st St, Edmond, OK 73013<br>";//changeLocation
        public static string a1 = "This center is located in downtown Edmond, directly in front of Edmond City Hall on the corner of 2nd Street and Litler. The center has great visibility from 2nd street and the traffic going to and from the University of Central Oklahoma which is located just down 2nd street from the center. The center contains 12,000 sq ft and is occupied by three tenants- Market Beverage Company, Subway and K&K Nail Salon. There is plenty of parking available for shoppers of this center.";//Property Description
        public static string a = "<b>General Info</b>";//General Info
        public static string b = "Access: 2nd street<br>"
            + "County: Oklahoma<br>"
            +"Type: Neighborhood Shopping Center<br>"
            + "Building SF: 12,000"
            + "Parking: ample";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Available Space </b>";//Spacing information Title
        public static string j = "  There is no available space at this time";// information about available space goes here
        public static string k = "~/img/edmond cneter/20160801_100817-e1473174856332-1-1080x675.jpg";//carousel img 1
        public static string l = "~/img/edmond cneter/20160801_100939-e1473175066627-1-400x284.jpg";//carousel img 2
        public static string m = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Edmond Center";
            Master.changeTitle("Edmond Center");
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