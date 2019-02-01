using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class Collonade_Shopping_Center : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/collonade/Collonade3-1.jpg";//ChangeMainPic
        public static string location = "N May Ave and Britton Rd, Oklahoma City, OK 73120";//changeLocation
        public static string description = "Collonade Shopping Center, 9600 North May Ave (Just north of May and Britton) The Collonade Shopping Center features a strong mix of tenants in North Oklahoma City. The signalized intersection at N. May and Britton and the building’s “L-Shape” ensures high visibility and easy access to N. May. The Collonade is a 59,000 sq. ft. mixed use center with abundant parking and the center consists of a strong mix of retail stores, restaurants, and multi-tenant office suites on the second floor. Traffic light controlled entrance from May Avenue. Traffic count: 20,300 on N. May Avenue, 19,600 on Britton Road.";//Property Description
        public static string generalInfoHeader = "<b>General Info </b>";//General Info
        public static string buildingInformation = "Access: N. May Avenue or Britton Rd.<br>"
            + "County: Oklahoma<br>"
            + "Type: Shopping Center<br>"
            + "Building SF: 59,000<br>"
            + "Site SF: 84,300<br>"
            + "Property Location: N May Ave and Britton Rd, Oklahoma City, OK 73120";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne = "";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo = "";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree = "";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "9606 N. May – Retail               2,290 sq. ft.<br>"
            + "$12.00 per square foot plus Taxes, Insurance, CAM Charges<br>"
            + "9608 N.May – Retail               2,000 sq.ft.<br>"
            + "$12.00 per square foot plus Taxes, Insurance, CAM Charges<br>"
            + "9636 N.May Suite 200 – Office          5,972 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)<br>"
            + "9636 N.May Suite 212 – Office          1,595 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)<br>"
            + "9636 N.May Suite 270 – Office           1,030 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)<br>"
            + "9636 N.May Suite 272 – Office         1,351 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)<br>"
            + "9636 N.May Suite 276 – Office           1,320 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)<br>"
            + "9636 N.May Suite 279 – Office            1,800 sq.ft.<br>"
            + "$14.00 per square foot(Full Service)";// information about available space goes here
        public static string carouselImageOne = "~/img/collonade/Collonade2-1-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/collonade/attachment-3-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "~/img/collonade/20171215_084025-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Collonade Shopping Center";
            Master.changeTitle("Collonade Shopping Center");
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