using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.NormanProperties
{
    public partial class MasonPlaza : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/mason plaza/Mason-1.png";//ChangeMainPic
        public static string location = "751 Canadian Trails Dr, Norman, OK, 73072";//changeLocation
        public static string description ="The center is west of the intersection of Highway 9 and Chautauqua Avenue, right next to Rudy’s BBQ restaurant in Norman, OK. It is near the University of Oklahoma Campus and about a mile east of I-35 and River Wind Casino. Mason Plaza has 8,125 square feet and excellent visibility from Highway 9. The center is occupied by a liquor store and a chiropractor. The center is a great location for any business!";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Access: Chautauqua Road or S.Canadian Trails Dr.<br>"
            + "County: Cleveland<br>"
            + "Lease Information: $12.00 per sq.ft.plus Taxes, Insurance and CAM charges.<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Parking: ample";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "751 Canadian Trails Suite 120 -- 1560 sq. ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "$12.00 per square foot plus Taxes, Insurance, and CAM Charges";// information about available space goes here
        public static string carouselImageOne = "~/img/mason plaza/Mason-1-400x284.png";//carousel img 1
        public static string carouselImageTwo = "~/img/mason plaza/Mason-2-400x284.png";//carousel img 2
        public static string carouselImageThree = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Mason Plaza";
            Master.changeTitle("Mason Plaza");
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