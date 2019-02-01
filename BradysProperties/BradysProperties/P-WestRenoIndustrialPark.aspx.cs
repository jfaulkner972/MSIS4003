using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class WestRenoIndustrialPark : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/WestRenoIndustrialPark.jpeg";//ChangeMainPic
        public static string location = "North Council Road and West Reno";//changeLocation
        public static string description ="West Reno Industrial Service Center is located at the Northwest corner of North Council"
                                    +" Road and West Reno in Oklahoma City by the Oklahoma City Outlet Mall. The complex is" 
                                    +" a combination of 2000 square feet spaces that have a single office and bathroom in the"
                                    +" front in half of the complex and an open space with a 14′ tall x 12′ wide garage door" 
                                    +" which is in front of the space, which are in the back half of the complex. The center"
                                    +" has very easy access to I-40 west, and has ample parking.";//Property Description
        public static string generalInfoHeader ="";//General Info
        public static string buildingInformation ="";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "5 S. Council Suite C -- 1500 sq. ft.<br>"
                                + "5 S.Council Suite D -- 1500 sq.ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$950.00/ per month <br>"
                                + "8017 W.Reno -- 2,000 sq.ft.<br>"
                                + "8035 W.Reno -- 2,000 sq.ft.<br>"
                                + "8037 W.Reno -- 2,000 sq.ft.<br>"
                                + "$950.00/per month";// information about available space goes here
        public static string carouselImageOne = "~/img/WestRenoIndustrialPark-Carousel1.jpeg";//carousel img 1
        public static string carouselImageTwo = "~/img/WestRenoIndustrialPark-Carousel2.jpeg";//carousel img 2
        public static string carouselImageThree = "~/img/WestRenoIndustrialPark-Carousel3.jpeg";//carousel img 3
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "West Reno Industrial Park";
            Master.changeTitle("West Reno Industrial Park");
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