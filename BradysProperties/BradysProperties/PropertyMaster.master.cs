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
        public static string a, b, c, d, e, f, g, h, i, j, k, l, m, ac, at, ay = "";


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void changeTitle(string pageName)
        {
            Master.changeTitle(pageName);
        }

        public void updateDescription()
        {
            descriptionID.Text = ac;
        }
        public void changeInfo(string tw,
            string gf,
            string ca,
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
            at = tw;//Main Pic
            ay = gf;//Location
            ac = ca;//description
            a = z;// geninfo
            b = y;// geninfoText
            c = x;// genNav1
            d = w;// genNavText
            e = v;// genNav2
            f = u;// Nav2Text
            g = t;// genNav3
            h = s;// nav3Text
            i = r;// spaceInfo
            j = q;// spaceInfoText
            k = p;// Carasel Pic1
            l = o;// Carasel Pic2
            m = n;// Carasel Pic3
            Control[] labels = new Control[] { propertyMainPic, propertyLocation, descriptionID, genInfo, genInfoText, genNav1, genNav2, genNav3, spaceInfo, spaceInfoText };
            string[] allVaris = new string[] { at, ay, ac, a, b, c, e, g, i, j };
            string[] genVaris = new string[] { a, b, c, e, g };
            string[] spaceVaris = new string[] { i, j };
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
            genInfo.Text = a;
            genInfoText.Text = b;
        }

        public void updateFloorPlanPics()
        {
            genNav1.NavigateUrl = c;
            genNav1.Text = d;
            genNav2.NavigateUrl = e;
            genNav2.Text = f;
            genNav3.NavigateUrl = g;
            genNav3.Text = h;
        }

        public void updateSpaceInfo()
        {
            spaceInfo.Text = i;
            spaceInfoText.Text = j;
        }

        public void updateCarousel()
        {
            cpic1.ImageUrl = k;
            cpic2.ImageUrl = l;
            cpic3.ImageUrl = m;
        }

        public void changeMainPic()
        {
            propertyMainPic.ImageUrl = at;
        }

        public void changeLocation()
        {
            propertyLocation.Text = ay;
        }
    }
}