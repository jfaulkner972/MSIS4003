using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class PennCrossing : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/penn crossing/penncrossing4.jpg";//ChangeMainPic
        public static string location = "NW 23rd and North Pennsylvania";//changeLocation
        public static string description = "Penn Crossing Shopping Center is 100,000 square feet shopping center located in the heart of Oklahoma City at the intersection of NW 23rd and north Pennsylvania anchored by Wal- Mart Neighborhood grocery store on one side and 100,000 square feet Buy for Less grocery store on the other, Shephard Mall is next door to this center which is home to over 100 of State of Oklahoma agency’s with 1000 of employee who shop at Penn Crossing from food to everyday needs. Oklahoma City University is also within walking distance of this center.";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Zoning:<br>"
                                + "Commercial Shopping Center<br>"
                                + "Access:<br>"
                                + "Intersection of NW 23rd and north Pennsylvania<br>"
                                + "County: Oklahoma<br>"
                                + "Lease Information Lease Rate: $8.00 per sq. ft. plus Taxes, Insurances and CAM charges.<br>";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "No Available Space at this time";// information about available space goes here
        public static string carouselImageOne = "~/img/penn crossing/penncrossing4-150x150.jpeg";//carousel img 1
        public static string carouselImageTwo = "~/img/penn crossing/penncrossing6-150x150.jpeg";//carousel img 2
        public static string carouselImageThree = "~/img/penn crossing/penncrossing5-150x150.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Penn Crossing ";
            Master.changeTitle("Penn Crossing");
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