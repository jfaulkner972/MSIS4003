using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties.PropertyListings.OKCProperties
{
    public partial class WestminsterEventCenter : System.Web.UI.Page
    {
        public static string m2 = "~/img/westminster event/Westminster-Event-Center-2-1080x675 - Copy.jpg";//ChangeMainPic
        public static string m3 = "10601 S Western Ave, Oklahoma City, OK 73170";//changeLocation
        public static string a1 = "The Westminster Event Center is the perfect location for any event from a formal wedding and reception, special events, banquettes, quinceaneras, bar mitzvahs, as well as a company conference. You and your guest can enjoy an evening or afternoon in a center that is close to hotels and is an easy commute to the Oklahoma City downtown area, without the parking problems of being in the center of downtown Oklahoma City.<Br>"
                                    + "We offer a preferred caterer’s list, any additional outside catering must be licensed and meet the guidelines of the Westminster Events Center. All beverage services will be arranged through the Westminster Event Center. We have several amenities that are available for your convenience including tables and chairs as well as a stage with all the lighting and cable lines for a sound system."
                                    + "Amenities included with the rental <br>"
                                    + "Audio Visual equipment: 4 large projection screens with 4 projectors<br>"
                                    + "We offer a stage that can be put in place for presentations or ceremonies.<br>" 
                                    + "- A fully equipped kitchen with walk in cooler,  warming cabinets, ice machine,  prep tables, and ice machine.<br>"
                                    + "- A fully equipped kitchen with walk in cooler,  warming cabinets,  ice machine,  prep tables,  and ice machine.<br>"
                                    + "- A furnished Bride’s room with makeup and hair station, cable TV, drink cooler that can be stocked (price depends on requested beverages), space to hang the dress, private access to the restroom and seating area.<br>"
                                    + "- 60- 60” round tables, 6 buffet tables and Mahogany Chiavari chairs with ivory cushions.<br>"
                                    + "- Two portable bars for beverage service.<br>"
                                    + "- A wood dance floor with the size dependent on your own personal layout.<br>"
                                    + "- Open floor plan so that you can customize the layout for your event to you specific needs and desires, simply give us the floor plans and we will have stage and / or tables set to make your event unique to you.<br>"
                                    + "- Access to the outside patio area with seating and tables.<br>"
                                    + "<br>"
                                    + "<b>Additional Venue:</b><br>"
                                    + "Westminster Event Center also has a Smaller Venue that can be combined with the Larger Venue. Amenities Included with the Rental:<br>"
                                    + "-Audio visual equipment, 2 Large Projection screens with 2 Projectors.<br>"
                                    + "-Stage that can be put in place for presentations or ceremonies.<br>"
                                    + "-Accent Wall Lighting<br>"
                                    + "– 6 feet Round Tables with Chiavari Chairs<br>"
                                    + "– Portable Bars for Beverage Services<br>"
                                    + "– Open Floor Plans so that you can customize the layout for your event to your specific needs and desires<br>"
                                    + "- Kitchen, Bride’s Room and Groom’s Room would also be available<br>"
                                    + "This room can be used for Wedding ceremony and parties. <br>"
                                    + "<br>"
                                    + "<b>More Information:</b><br>"
                                    + "There is a $350.00 to $500.00 Clean Up and Set Up fee on all events.<br>"
                                    + "There is an extra charge for any event that falls on a holiday.<br>"
                                    + "No smoking is allowed in any part of the facility, however smoking is allowed in the patio area. <br>"
                                    + "All clients are responsible for complying with the Oklahoma State liquor laws.<br>"
                                    + "Activities will be confined to the event center.  Food and drinks are restricted to the event center. <br>"
                                    + "Westminster Events Center is not liable or responsible for any items lost or damaged during the event.<br>"
                                    + "<br>"
                                    + "<b>Payment Information:</b><br>"
                                    + "A deposit of one third (1/3) of the rental fee as well as the $500.00 refundable security deposit and a signed contract are required to reserve your date, 30 days prior to your event another payment of one third (1/3) is required with the balance due 14 days prior to your event. <br>"
                                    + "Checks for the facility are to made payable to Westminster Events Center.<br>"
                                    + "Westminster Events Center is not liable or responsible for any items lost or damaged during the event.";//Property Description
        public static string a = "<b>General Info: </b><br>";//General Info
        public static string b = "Westminster Event Center <br>"
                                + "10601 South Western Ave, Oklahoma City, OK 73170 <br>"
                                + "Phone: 405-703-4400 if no answer 405-732-8899 <br>"
                                + "Fax: 405-703-4499 <br>"
                                + "E-Mail: ali@bradysproperties.com or infobradysproperties@gmail.com <br>"
                                + "  Please feel free to check us out on facebook.com or at www.westminstereventscenter.com <br>";//Buidling stuff square ft location building type etc
        public static string c = "";//Redirect Path to Floor Plan 1
        public static string d = "";// Text of Hyperlink ex Floor Plan 1
        public static string e1 = "";// redirect for hyperlink 2
        public static string f = "";// text of hyperlink 2
        public static string g = "";//redirect for hyperlink3
        public static string h = "";//text for hyperlink3
        public static string i = "<b> Pricing Information </b>";//Spacing information Title
        public static string j = "Prices for parties up to 349 people:<br>"
                                + "Sunday through Thursday:........$2000.00 <br>"
                                + "Friday:.........................$2500.00 <br>"
                                + "Saturday:.......................$3300.00 <br>"
                                + "For parties of 350 to 500 people:<br>"
                                + "Sunday through Thursday:........$2500.00<br>"
                                + "Friday:.........................$3000.00 <br>"
                                + "Saturday:  .....................$3800.00<br>"
                                + "<b>Pricing for Both Venues:</b><br>"
                                + "Sunday – Thursday:..............$3,000.00<br>"
                                + "Friday:.........................$3,500.00<br>"
                                + "Saturday:.......................$4,500.00<br>"
                                + "<br>"
            ;// information about available space goes here
        public static string k = "~/img/westminster event/WestminsterEventCenter2-150x150.jpeg";//carousel img 1
        public static string l = "~/img/westminster event/WestminsterEventCenter3-400x284.jpg";//carousel img 2
        public static string m = "~/img/westminster event/Westminster-Event-Center-1-150x150.jpeg";//carousel img 3


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Westminster Event Center";
            Master.changeTitle("Westminster Event Center");
            Master.changeInfo(m2, m3, a1, a, b, c, d, e1, f, g, h, i, j, k, l, m);
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