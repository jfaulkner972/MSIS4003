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
        public static string mainPicture, location, description, generalInformation, generalInformationText, floorPlanOne, 
            floorPlanOneText, floorPlanTwo, floorPlanTwoText, floorPlanThree, floorPlanThreeText, spaceInfoHeader, spaceInfomation, 
            carouselImageOne, carouselImageTwo, carouselImageThree = "";


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void changeTitle(string pageName)
        {
            Master.changeTitle(pageName);
        }

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
            int counter = 0;
            mainPicture = cc;//Main Pic
            location = bb;//Location
            description = aa;//description
            generalInformation = z;// geninfo
            generalInformationText = y;// geninfoText
            floorPlanOne = x;// genNav1
            floorPlanOneText = w;// genNavText
            floorPlanTwo = v;// genNav2
            floorPlanTwoText = u;// Nav2Text
            floorPlanThree = t;// genNav3
            floorPlanThreeText = s;// nav3Text
            spaceInfoHeader = r;// spaceInfo
            spaceInfomation = q;// spaceInfoText
            carouselImageOne = p;// Carasel Pic1
            carouselImageTwo = o;// Carasel Pic2
            carouselImageThree = n;// Carasel Pic3
            Control[] labels = new Control[] { propertyMainPic, propertyLocation, descriptionID, genInfo, genInfoText, floorOne, floorTwo, floorThree, spaceInfo, spaceInfoText };
            string[] allVaris = new string[] { mainPicture, location, description, generalInformation, generalInformationText, floorPlanOne,
                floorPlanTwo, floorPlanThree, spaceInfoHeader, spaceInfomation };
            string[] genVaris = new string[] { generalInformation, generalInformationText, floorPlanOne, floorPlanTwo, floorPlanThree };
            string[] spaceVaris = new string[] { spaceInfoHeader, spaceInfomation };
            for (int ii = 0; ii < allVaris.Length; ii++)
            {
                if (allVaris[ii] == "")
                {
                    labels[ii].Visible = false;
                }
            }
            for (int kk = 3; kk < 8; kk++)
            {
                if (labels[kk].Visible == false)
                {
                    counter++;
                }
            }
            if (counter == 5)
            {
                gen.Attributes["class"] = "hide";
                space.Attributes["class"] = "centerBox border";
                build.Attributes["class"] = "";
            }
            counter = 0;
            for (int kk = 8; kk < 10; kk++)
            {
                if (labels[kk].Visible == false)
                {
                    counter++;
                }
            }
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

        public void updateFloorPlanPics()
        {
            floorOne.NavigateUrl = floorPlanOne;
            floorOne.Text = floorPlanOneText;
            floorTwo.NavigateUrl = floorPlanTwo;
            floorTwo.Text = floorPlanTwoText;
            floorThree.NavigateUrl = floorPlanThree;
            floorThree.Text = floorPlanThreeText;
        }

        public void updateSpaceInfo()
        {
            spaceInfo.Text = spaceInfoHeader;
            spaceInfoText.Text = spaceInfomation;
        }

        public void updateCarousel()
        {
            cpic1.ImageUrl = carouselImageOne;
            cpic2.ImageUrl = carouselImageTwo;
            cpic3.ImageUrl = carouselImageThree;
        }

        public void changeMainPic()
        {
            propertyMainPic.ImageUrl = mainPicture;
        }

        public void changeLocation()
        {
            propertyLocation.Text = location;
        }
    }
}