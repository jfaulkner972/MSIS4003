using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class TownAndCountry : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/town and country/TownCountry1.jpg";//ChangeMainPic
        public static string location = "North May Ave. and NW 122nd, OKC";//changeLocation
        public static string description = "Town & Country Shopping Center is located just north of the NW corner of May Avenue and NW 122nd street in OKC. The center is on the west side of N. May Avenue. The center has very good visibility and very good access from N. May Avenue, with about 250 parking spaces. This center is located in a heavily developed area with high traffic count, making it a great retail center.";//General Info

        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Zoning:<br>"
                                 + "Access: 122nd St. and N. May. <br>"
                                 + "County: Oklahoma <br>"
                                 + "Lease Information: Suite 113 3,262 sq. ft.<br>"
                                 + "$8.00 per square foot plus taxes, insurance and CAM Charges<br>"
                                 + "Improvements:<br>"
                                 + "Type: Neighborhood Shopping Center<br>";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "Suite 113 –  3,262  sq.ft.<br>"
                                 + "$7.00 per square foot plus Taxes, Insurance, and CAM Charges.<br>";// information about available space goes here
        public static string carouselImageOne = "~/img/town and country/TownCountry1.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/town and country/TownCountry2-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Town and Country";
            Master.changeTitle("Town and Country");
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