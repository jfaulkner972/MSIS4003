using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class RobinsonCrossing : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/robinson/New-Robinson-2-1-1080x675.jpeg";//ChangeMainPic
        public static string location = "1300 N. Interstate Drive";//changeLocation
        public static string description = "Robinson Crossing benefits from the variety of people who travel on I-35 to go to OKC or to come to Norman to watch the University of Oklahoma play sports. It is highly visible from the Interstate and very easy to get to from the Robinson Street exit on I-35. The center is anchored by a 6-screen movie theater. The good mix of service, retail and restaurant tenants makes Robinson Crossing an ideal spot for business that are looking for a space on the west side of Norman.";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Access: Robinson Street Exit from I-35 in Norman.I-35 service Road.<br>"
            + "County: Cleveland<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Building SF: 110,000<br>"
            + "Parking: ample";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "#8 –  1,170 sq. ft. – $10.00 per sq. ft.<br>"
            + "#20- 1,260 sq. ft. – $10.00 per sq. ft.<br>"
            + "#21- 2,417 sq. ft.- $10.00 per sq. ft.<br>"
            + "#35- 1,500 sq. ft. – $10.00 per sq. ft.<br>"
            + "#39- 4,016 sq. ft. – $10.00 per sq. ft.<br>"
            + "<b>Leasing Information:</b><br>"
            + "$14.00 per sq. ft., all bills paid";// information about available space goes here
        public static string carouselImageOne = "~/img/robinson/New-Robinson-1-400x284.jpeg";//carousel img 1
        public static string carouselImageTwo = "~/img/robinson/New-Robinson-4-1-400x284.jpeg";//carousel img 2
        public static string carouselImageThree = "~/img/robinson/20150331_110940-1024x576-1-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Robinson Crossing";
            Master.changeTitle("Robinson Crossing");
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