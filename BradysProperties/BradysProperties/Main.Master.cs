using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BradysProperties
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Listings_SelectedIndexChanged(object sender, EventArgs e);
        ////{
        //    if (OKCListings.SelectedIndex == 1)
        //    {
        //        Response.Redirect("~/OKCProperties.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 2)
        //    {
        //        Response.Redirect("~/P-BradyPlaza.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 3)
        //    {
        //        Response.Redirect("~/P-CollonadeShoppingCenter.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 4)
        //    {
        //        Response.Redirect("~/P-GhaniabadiBusinessPark.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 5)
        //    {
        //        Response.Redirect("~/P-I-240Center.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 6)
        //    {
        //        Response.Redirect("~/P-PennCrosssing.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 7)
        //    {
        //        Response.Redirect("~/P-SantaFePlaza.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 8)
        //    {
        //        Response.Redirect("~/P-Stonebriar.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 9)
        //    {
        //        Response.Redirect("~/P-TownAndCountry.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 10)
        //    {
        //        Response.Redirect("~/P-VirtualOfficesWestminster.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 11)
        //    {
        //        Response.Redirect("~/P-WestRenoIndustrialPark.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 12)
        //    {
        //        Response.Redirect("~/P-WestminsterEventCenter.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 13)
        //    {
        //        Response.Redirect("~/P-WestminsterExecutiveSuites.aspx");
        //    }
        //    else if (OKCListings.SelectedIndex == 14)
        //    {
        //        Response.Redirect("~/P-WestminsterVillage.aspx");
        //    }

        //}

        public void changeTitle(string pageName)
        {
            pageHeader.Text = pageName;
        }

        //protected void NormanListings_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (NormanListings.SelectedIndex == 1)
        //    {
        //        Response.Redirect("~/NormanProperties.aspx");
        //    }
        //    else if (NormanListings.SelectedIndex == 2)
        //    {
        //        Response.Redirect("~/P-DowntownShoppingCenter.aspx");
        //    }
        //    else if (NormanListings.SelectedIndex == 3)
        //    {
        //        Response.Redirect("~/P-MasonPlaza.aspx");
        //    }
        //    else if (NormanListings.SelectedIndex == 4)
        //    {
        //        Response.Redirect("~/P-RobinsonCrossing.aspx");
        //    }
        //    else if (NormanListings.SelectedIndex == 5)
        //    {
        //        Response.Redirect("~/P-RobinsonCrossingOfficeSuites.aspx");
        //    }
        //}

        //protected void EdmondListings_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (EdmondListings.SelectedIndex == 1)
        //    {
        //        Response.Redirect("~/EdmondProperties.aspx");
        //    }
        //    else if (EdmondListings.SelectedIndex == 2)
        //    {
        //        Response.Redirect("~/P-EdmondCenter.aspx");
        //    }
        //    else if (EdmondListings.SelectedIndex == 3)
        //    {
        //        Response.Redirect("~/P-UniversityPlaza.aspx");
        //    }
        //}

        //protected void MidwestCityListings_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (MidwestCityListings.SelectedIndex == 1)
        //    {
        //        Response.Redirect("~/MidwestCityProperties.aspx");
        //    }
        //    else if (MidwestCityListings.SelectedIndex == 2)
        //    {
        //        Response.Redirect("~/P-DeckerCenter.aspx");
        //    }
        //    else if (MidwestCityListings.SelectedIndex == 3)
        //    {
        //        Response.Redirect("~/P-OrchardPlaza.aspx");
        //    }
        //}
    }
}