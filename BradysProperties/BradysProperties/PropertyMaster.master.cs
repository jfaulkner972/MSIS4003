using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class PropertyMaster : System.Web.UI.MasterPage
    {
        //initalize class level variables
        public static string mainPicture, location, description, generalInformation, generalInformationText, floorPlanOne, 
            floorPlanOneText, floorPlanTwo, floorPlanTwoText, floorPlanThree, floorPlanThreeText, spaceInfoHeader, spaceInfomation, 
            carouselImageOne, carouselImageTwo, carouselImageThree = "";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //update the Title of the page
        public void changeTitle(string pageName)
        {
            Master.changeTitle(pageName);
        }

        //update the description label
        public void updateDescription()
        {
            descriptionID.Text = description;
        }

        public void changeInfo(string cc,
            string bb,
            string aa,
            string z,
            string y,
            string x,
            string w,
            string v,
            string u,
            string t,
            string s,
            string r,
            string q,
            string p,
            string o,
            string n
            )
        {
            //Set entered values into class level variables
            int counter = 0;
            mainPicture = cc;//Main Pic
            location = bb;//Location
            description = aa;//description
            generalInformation = z;// geninfo
            generalInformationText = y;// geninfoText
            floorPlanOne = x;// floorOne
            floorPlanOneText = w;// floorOneText
            floorPlanTwo = v;// floorTwo
            floorPlanTwoText = u;// floorTwoText
            floorPlanThree = t;// floorThree
            floorPlanThreeText = s;//floorThreeText
            spaceInfoHeader = r;// spaceInfo
            spaceInfomation = q;// spaceInfoText
            carouselImageOne = p;// Carousel Pic1
            carouselImageTwo = o;// Carousel Pic2
            carouselImageThree = n;// Carousel Pic3

            //create arrays for the controls, all variables, general variables, space information variables
            Control[] labels = new Control[] { propertyMainPic, propertyLocation, descriptionID, genInfo, genInfoText, floorOne, floorTwo, floorThree, spaceInfo, spaceInfoText };
            string[] allVaris = new string[] { mainPicture, location, description, generalInformation, generalInformationText, floorPlanOne,
                floorPlanTwo, floorPlanThree, spaceInfoHeader, spaceInfomation };
            string[] genVaris = new string[] { generalInformation, generalInformationText, floorPlanOne, floorPlanTwo, floorPlanThree };
            string[] spaceVaris = new string[] { spaceInfoHeader, spaceInfomation };

            //Set all labels that do not have text to invisble
            for (int ii = 0; ii < allVaris.Length; ii++)
            {
                if (allVaris[ii] == "")
                {
                    labels[ii].Visible = false;
                }
            }

            //count the number of invisble fields for general information 
            for (int kk = 3; kk < 8; kk++)
            {
                if (labels[kk].Visible == false)
                {
                    counter++;
                }
            }

            //if all fields for general are null hide the box
            if (counter == 5)
            {
                gen.Attributes["class"] = "hide";
                space.Attributes["class"] = "centerBox border";
                build.Attributes["class"] = "";
            }

            //reset counter variable
            counter = 0;

            //count the number of null fields for space information
            for (int kk = 8; kk < 10; kk++)
            {
                if (labels[kk].Visible == false)
                {
                    counter++;
                }
            }

            //If all space fields are empty, hide the box
            if (counter == 5)
            {
                gen.Attributes["class"] = "centerBox border";
                space.Attributes["class"] = "hide";
                build.Attributes["class"] = "";
            }
        }
        //enter name of property, then info
        public void updateGeneralInfo()
        {
            genInfo.Text = generalInformation;
            genInfoText.Text = generalInformationText;
        }

        //update floor plan navigation paths and text
        public void updateFloorPlanPics()
        {
            floorOne.NavigateUrl = floorPlanOne;
            floorOne.Text = floorPlanOneText;
            floorTwo.NavigateUrl = floorPlanTwo;
            floorTwo.Text = floorPlanTwoText;
            floorThree.NavigateUrl = floorPlanThree;
            floorThree.Text = floorPlanThreeText;
        }

        //update building space information
        public void updateSpaceInfo()
        {
            spaceInfo.Text = spaceInfoHeader;
            spaceInfoText.Text = spaceInfomation;
        }

        //update Carousel images
        public void updateCarousel()
        {
            cpic1.ImageUrl = carouselImageOne;
            cpic2.ImageUrl = carouselImageTwo;
            cpic3.ImageUrl = carouselImageThree;
        }

        //Change the main picture for the property page
        public void changeMainPic()
        {
            propertyMainPic.ImageUrl = mainPicture;
        }

        //Change the location label
        public void changeLocation()
        {
            propertyLocation.Text = location;
        }
    }
}