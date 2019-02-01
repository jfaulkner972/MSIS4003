using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.EdmondProperties
{
    public partial class UniversityPlaza : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/university plaza/20160801_101911-1024x768-1024x675.jpg";//ChangeMainPic
        public static string location = "1142 East 2nd Street, Edmond, OK";//changeLocation
        public static string description = "University Plaza is near the intersection of 2nd street and Bryant. In front of the Super Target. Lowes, Wal-mart neighborhood grocery store and the Edmond medical center are located at this intersection.";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Access: 2nd St. and Bryant in Edmond<br>"
                                + "County: Oklahoma<br>"
                                + "Type: Neighborhood Shopping Center";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "1110 E. 2nd St. -- 4700 sq. ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$14.00 per square foot plus Taxes, Insurance and CAM Charges";// information about available space goes here
        public static string carouselImageOne = "~/img/university plaza/20160801_101839-1024x768-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/university plaza/20160801_102012-1024x768-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "~/img/university plaza/UniversityPlaza2.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "University Plaza";
            Master.changeTitle("University Plaza");
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