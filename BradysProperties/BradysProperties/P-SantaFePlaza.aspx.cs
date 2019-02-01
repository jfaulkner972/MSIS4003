using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class SantaFePlaza : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/santa fe/SantaFe1-400x284.png";//ChangeMainPic
        public static string location = "SW 89 and South Santa Fe, OKC";//changeLocation
        public static string description = "Santa Fe Plaza is a 20,500 square foot shopping center located at the intersection of SW 89th Street and Santa Fe Avenue in OKC. The center is about a mile south of I-240 and 2 miles west of I-35. The center benefits from high traffic traveling between the city of Moore and I-240. The center is very visible from and has very good access to both 89th street and Santa Fe Avenue. The center is a neighborhood center with strong long-time tenants.";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Zoning:<br>"
                                 + "Access: <br>"
                                 + "SW 89 & S. Santa Fe <br>"
                                 + "County: Oklahoma<br>"
                                 + "<b>Lease Information:</b><br>" 
                                 +"Lease Rate: $7.00 per sq. ft. plus Taxes, Insurances and CAM charges.<br>"
                                 + "Improvements:<br>"
                                 + "Type: Shopping center<br>"
                                 + "Building SF: 20,500<br>"
                                 + "Site SF<br>"
                                 + "Parking: Ample <br>";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="img/santa fe/Stonebriar-Site-Plan-7-9-2014 (2).pdf~";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "Site Plan";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "Size SF Unit Comment<br>"
                                + "8901 S. Santa Fe Suite B – 1,500 sq. ft. <br>"
                                + "$7.00 per sq. ft. plus Taxes, Insurance, CAM Charges<br>"
                                + "8901 S. Santa Fe Suite E – 1,450 sq. ft. <br>"
                                + "$7.00 per sq. ft. plus Taxes, Insurance, CAM Charges<br>"
                                + "8901 S. Santa Fe Suite G & H – 2,950 sq. ft.<br>"
                                + "$7.00 per sq. ft. plus Taxes, Insurance, CAM Charges<br>"
                                + "8901 S. Santa Fe Suite J -1,500 sq. ft."
                                + "$7.00 per sq. ft. plus Taxes, Insurance, CAM Charges";// information about available space goes here
        public static string carouselImageOne = "~/img/santa fe/SantaFe4-400x284.png";//carousel img 1
        public static string carouselImageTwo = "~/img/santa fe/SantaFe1-400x284.png";//carousel img 2
        public static string carouselImageThree = "~/img/santa fe/SantaFe3-400x284.png";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Santa Fe Plaza";
            Master.changeTitle("Santa Fe Plaza");
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