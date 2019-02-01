using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class WestminsterVillage : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/WestminsterVillage.jpg";//text for hyperlink3
        public static string location = "S. W. 104th and South Western Avenue";//text for hyperlink3
        public static string description = "Westminster Village is just south and west of the intersection at SW 104th and S."
                                    + "Western Avenue, in Oklahoma City. The center has a row of suites that face S. "
                                    + "Western with excellent visibility and access. The rest of the center extends to the "
                                    + "west. The parking lot is shared by Mazzio’s Pizza and a mini-strip center/gas "
                                    + "station that generate “through” traffic. It has a neighborhood and commercial "
                                    + "atmosphere – Could this be the place for you?";//Property Description
        public static string generalInfoHeader ="<b> General Info </b>";//General Info
        public static string buildingInformation ="Traffic count: 20,100 on S. Western, 15,500 on S.W. 104th Street.<br>"
                                    + "Lease Information:<br>"
                                    + "$10.00- $12.00 per sq. ft. plus Taxes, Insurance and CAM charges.<br>"
                                    + "Type:<br>"
                                    + "Shopping Center <br>"
                                    + "Parking:<br>"
                                    + "Ample";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "10605 S. Western – 3,325 sq. ft. – $12.00 per sq. ft.<br>"
                                + "928 SW 104th – 6,100 sq. ft. – $10.00 per sq. ft.<br>"
                                + "1004 SW 104th – 2,100 sq. ft. – $10.00 per sq. ft. ";// information about available space goes here
        public static string carouselImageOne = "";//carousel img 1
        public static string carouselImageTwo = "~/img/WestminsterVillageCarousel2.jpg";//carousel img 2
        public static string carouselImageThree = "~/img/WestminsterVillageCarousel1.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Westminster Village";
            Master.changeTitle("Westminster Village");
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