using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.ShawneeProperties
{
    public partial class ShawneeMarketPlace : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/shawnee/DSCN0833-1080x675.jpg";//ChangeMainPic
        public static string location = "I-40 and Kickapoo St.<br>";//changeLocation
        public static string description = "Shawnee Marketplace is a shopping center located on I-40 and North Kickapoo St. in Shawnee, OK. The shopping center is well lit, with plenty of retail shops and all different kinds of restaurants for your dining needs. The shops that are included in the shopping center are Aldi, Hobby Lobby, PetSmart, T.J. Maxx, and Ulta just to name a few.";//Property Description
        public static string generalInfoHeader ="<b>General Info</b>";//General Info
        public static string buildingInformation ="Access: Kickapoo St.<br>"
            + "County: Pottawatomie County<br>"
            + "Type: Neighborhood Shopping Center<br>"
            + "Property Location: I-40 and Kickapoo St.";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "None at this time.";// information about available space goes here
        public static string carouselImageOne = "~/img/shawnee/DSCN0834-400x284.jpg";//carousel img 1
        public static string carouselImageTwo = "~/img/shawnee/DSCN0835-400x284.jpg";//carousel img 2
        public static string carouselImageThree = "";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Shawnee Marketplace";
            Master.changeTitle("Shawnee Marketplace");
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