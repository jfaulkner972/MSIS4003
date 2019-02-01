using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class GhaniabadiBusinessPark : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/ghaniabadi/20170403_155312-e1492185780860-1080x675.jpeg";//ChangeMainPic
        public static string location = "SW 119th St & S Western Ave, Oklahoma City, OK 73170";//changeLocation
        public static string description ="Building A & B<br>"
            + "The property is 30,000 square feet which consist of 15, 2000 sq.ft space each suite has one 10′ x 12′ office and ADA bathroom, the rest of the suite is built out open with a 12′ x 14′ over head back door.The suites has glass front door and window.There is plenty of parking in front of each space and in the back. The properties have Western Avenue signage.<br>"
            + "South west corner of South 119th and South Western Avenue in OKC.Behind O’Reily’s Auto Parts.<br>"
            + "Building C<br>"
            + "The property consist of 8000 sq.ft.of retail space facing South Western Ave.close to Westmoore High School with two ADA bathrooms in 2,000 sq.ft.suite.The suite are delivered in a white box condition, ready for occupancy, with plenty of lighted parking.The property has street signage available.";//Property Description
        public static string generalInfoHeader ="";//General Info
        public static string buildingInformation ="";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "Building A & B Office/ Warehouse: 2,000 sq. ft.<br>"
            +"-4 spaces available – $1,250.00 per month<br>"
            +"Building C Retail: 2,000 sq.ft.<br>"
            +"no space available for building C.";// information about available space goes here
        public static string carouselImageOne = "~/img/ghaniabadi/20170403_155341-e1492185373237-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/ghaniabadi/20161024_152718-e1485892009309-400x284.jpeg";//carousel img 2
        public static string carouselImageThree = "~/img/ghaniabadi/20161024_152514-e1485892126542-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Ghaniabadi Business Park";
            Master.changeTitle("Ghaniabadi Business Park");
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