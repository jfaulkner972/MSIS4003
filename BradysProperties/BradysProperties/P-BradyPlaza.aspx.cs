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
        public static string mainPicture = "~/img/brady plaza/bradyplaza11-1.jpg";//ChangeMainPic
        public static string location = "88th and S Santa Fe Oklahoma City, 73139";//changeLocation
        public static string description = "Brady Plaza Shopping Center is located just north of the intersection of SW 89th and S. Santa Fe, about a mile south of I-240 and 2 miles west of I-35 on southwest 89th. The center has good visibility, easy access to S. Santa Fe and abundant parking with a good mix of strong local tenants. Wal-Mart Super Center and Lowe’s are within a mile of the center on S. Santa Fe. and Home Depot is nearby on S. Shields Ave.";//Property Description
        public static string generalInfoHeader = "<b>General Info </b>";//General Info
        public static string buildingInformation = " Type: Neighborhood Shopping Center<br>"
            +"Building SF: 17,500<br>"
            +"Property Location: 88th and S Santa Fe Oklahoma City, 73139<br>";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne = "";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo = "";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree = "";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "8803 – 1,000 sq.ft.<br>"
            +"$8.00 per sq.ft.plus Taxes, Insurance, and CAM Charges<br>"
            +"8823 – 1,000 sq.ft.<br>"
            +"$8.00 per sq. ft.plus Taxes, Insurance, and CAM Charges<br>"
            +"8825 – 1, 000 sq.ft.<br>"
            +"$8.00 per sq. ft.plus Taxes, Insurance, and CAM Charges";// information about available space goes here
        public static string carouselImageOne = "~/img/brady plaza/bradyplaza11-1-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/brady plaza/bradyplaza31-1-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "~/img/brady plaza/bradyplazadrawing1-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Brady Plaza";
            Master.changeTitle("Brady Plaza");
            Master.changeInfo(mainPicture, location, description, generalInfoHeader, buildingInformation, pathToFloorPlanOne, floorPlanOneText, pathToFloorPlanTwo, 
                floorPlanTwoText, pathToFloorPlanThree, floorPlanThreeText, spacingInformationHeader, spacingInformation, carouselImageOne, carouselImageTwo, carouselImageThree);
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