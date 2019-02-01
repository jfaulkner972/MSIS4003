using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.MidwestCityProperties
{
    public partial class DeckerCenter : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/decker/DeckerCenter1.jpg";//ChangeMainPic
        public static string location = "1200 S. Air Depot, Midwest City, OK 73110 <br>";//changeLocation
        public static string description = "Decker Center is a 33,500 sq. ft. shopping center located at 1200 South Air Depot in Midwest City. This center is very visible to traffic on Air Depot. The center has a strong mix of retail and service tenants. The tenants are well-known among the community.";//Property Description
        public static string generalInfoHeader = "<b>General Info </b>";//General Info
        public static string buildingInformation = "Access: S.Air Depot"
            + "County: Oklahoma<br>"
            + "Type: Shopping Center<br>"
            + "Building SF: 33,500<br>"
            + "Parking: Ample";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne = "";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo = "";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree = "";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "Suite J -- 1300 sq. ft.<br>"
                                + "Suite T -- 1100 sq.ft.<br>"
                                + "<b>Leasing Information:</b><br>"
                                + "Lease Rate: $6.00 to $12.00 per square foot plus Taxes, Insurances and CAM charges";// information about available space goes here
        public static string carouselImageOne = "~/img/decker/DeckerCenter3-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/decker/DeckerCenterdrawing-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Decker Center";
            Master.changeTitle("Decker Center");
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