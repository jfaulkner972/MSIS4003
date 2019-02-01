using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class RobinsonCrossingOfficeSuites : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/robinson office/RobinsonCrossingOfficeSuites1-1-1080x675.jpg";//ChangeMainPic
        public static string location = "1370 North Interstate Drive Norman, OK";//changeLocation
        public static string description = "The Robinson Crossing Office Suites are located at 1370 North Interstate Drive, in the Robinson Crossing Shopping Center.  The office suites are clearly visible from I-35. The office sizes range from 218 square feet to 940 square feet, including a 10% common area factor.The larger suites have the ability to have two or three offices and a receptionist area built in the suites depending on the tenants need.Some suite’s have a door leading to the outside, as well as access to the inside common area.";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Pricing: $14.00 per sq.ft. (FULL SERVICE)";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "Suite 152 – 816 sq. ft.  at $14.00 full service<br>"
                                + "Suite 153 – 654 sq. ft. at $14.00 full service<br>";// information about available space goes here
        public static string carouselImageOne = "~/img/robinson office/RobinsonCrossingOfficeSuites2-1-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/robinson office/RobinsonCrossingOfficeSuites6-1-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Robinson Crossing Office Suites";
            Master.changeTitle("Robinson Crossing Office Suites");
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