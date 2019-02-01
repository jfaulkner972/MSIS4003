using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class WestminsterExecutiveSuites : System.Web.UI.Page
    {
        public static string mainPicture = "~/img/westminster exec/WestminsterExecutiveSuites11.jpg";//ChangeMainPic
        public static string location = "10601 S Western Ave, Oklahoma City, OK 73170";//changeLocation
        public static string description = "Westminster Executive Suites are located at the SW corner of S. W. 104th and South"
                                    + " Western Avenue, within a few minutes of three major highways, I-240, I-35, and I-44. The "
                                    + "Executive Suites are located within the Westminster Shopping Center with a large stone "
                                    + "archway over the entrance.";//Property Description
        public static string generalInfoHeader ="<b>General Info</b>";//General Info
        public static string buildingInformation ="The executive suites provide a successful and affordable environment for your small "
                                    + "business or independent firm. The following is included with your monthly rent: "
                                    + "your office, your phone and internet access, conference room availability,"
                                    + " kitchen break area, and all your utilities are paid."
                                    + " "
                                    + "Other services available for an additional fee are: postage, copies, fax service or virtual office space."
                                    + "If you are familiar with Oklahoma City, our offices are located in the former Bowling Green. "
                                    + "You must see these newly renovated offices to believe the change! Stop by anytime between, "
                                    + "Monday – Friday, 8 a.m.-5 p.m.";//Buidling stuff square ft location building type etc
        public static string pathToFloorPlanOne ="";//Redirect Path to Floor Plan 1
        public static string floorPlanOneText = "";// Text of Hyperlink ex Floor Plan 1
        public static string pathToFloorPlanTwo ="";// redirect for hyperlink 2
        public static string floorPlanTwoText = "";// text of hyperlink 2
        public static string pathToFloorPlanThree ="";//redirect for hyperlink3
        public static string floorPlanThreeText = "";//text for hyperlink3
        public static string spacingInformationHeader = "<b> Available Space </b>";//Spacing information Title
        public static string spacingInformation = "100, 105, 114, 116, 117, 119, 120<br>"
                                + "100 – 285 sq. ft. at $650.00 per/month<br>"
                                + "105 – 345 sq. ft. at $750.00 per/month<br>"
                                + "114 – 345 sq. ft. at $750.00 per/month <br>"
                                + "116 – 300 sq. ft. at $675.00 per/month<br>"
                                + "117 – 285 sq. ft. at $650.00 per/month<br>"
                                + "119 – 285 sq. ft. at $650.00 per.month<br>"
                                + "120 – 285 sq. ft. at $650.00 per/month<br>"
                                + "We also have Virtual Office Services available at this address.<br> "
                                + "Please visit our Virtual Office page for more information.<br>"
                                + "Westminster Executive Suites<br>"
                                + "10601 South Western Oklahoma City, OK 73170";// information about available space goes here
        public static string carouselImageOne = "~/img/westminster exec/WestminsterExecutiveSuites4-150x150.jpeg";//carousel img 1
        public static string carouselImageTwo = "~/img/westminster exec/WestminsterExecutiveSuites6-150x150.jpegWestRenoIndustrialPark-Carousel2.jpeg";//carousel img 2
        public static string carouselImageThree = "~/img/westminster exec/WestminsterExecutiveSuites31-1-400x284.jpg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Westminster Executive Suites";
            Master.changeTitle("Westminster Executive Suites");
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