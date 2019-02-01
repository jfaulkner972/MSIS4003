using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class I_240Center : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/i-240/240-1-979x675.png";//ChangeMainPic
        public static string location = "7800 and Western";//changeLocation
        public static string description ="I-240 Plaza is conveniently located just south of the intersection of Interstate 240 and S. Western. The shopping center is on the east side of S. Western. The proximity to the interstate generates high traffic counts for the center. Also, this location allows you and your customers to easily access the shopping center and I-240. Call today for leasing options. Traffic count: 24,917 on S. Western";//Property Description
        public static string generalInfoHeader ="<b>General Info </b>";//General Info
        public static string buildingInformation ="Access: South Western Avenue<br>"
            +"County: Oklahoma<br>"
            + "Lease InformationLease Rate: $10.00 per sq.ft.plus Taxes, Insurance, and CAM charges.<br>"
            +"Type: Shopping Center<br>"
            +"Parking: ample<br>"
            +"Property Location: Just south of I 240 on S Western Ave in Oklahoma City, 73139";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "No space available at this time.";// information about available space goes here
        public static string carouselImageOne = "~/img/i-240/240-5-400x284.png";//carousel img 1
        public static string carouselImageTwo = "~/img/i-240/240-2-400x284.png";//carousel img 2
        public static string carouselImageThree = "~/img/i-240/240-4-400x284.png";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "I-240 Plaza";
            Master.changeTitle("I-240 Plaza");
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