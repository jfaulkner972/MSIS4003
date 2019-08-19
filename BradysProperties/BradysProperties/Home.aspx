<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BradysProperties.Home" %>

<%@ MasterType VirtualPath="~/Main.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="aboutUs" runat="server" Text="Label"></asp:Label>
        <div class="centerBox">
            <div class="col-12">
                <div id="regionalPropertyCarousel" class="carousel slide" data-ride="carousel" style="margin-top: 25px;">
                    <ol class="carousel-indicators">
                        <li data-target="regionalPropertyCarousel" data-slide-to="0" class="active"></li>
                        <li data-target="regionalPropertyCarousel" data-slide-to="1"></li>
                        <li data-target="regionalPropertyCarousel" data-slide-to="2"></li>
                        <li data-target="regionalPropertyCarousel" data-slide-to="3"></li>
                        <li data-target="regionalPropertyCarousel" data-slide-to="4"></li>
                    </ol>
                    <div class="carousel-inner col-12">
                        <div class=" carousel-item active">
                            <img src="img/PennCrossing.jpg" class="fullwidth" />
                            <div class="carousel-caption">
                                <asp:Label ID="img1" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/Stonebriar.jpg" class="fullwidth" />
                            <div class="carousel-caption">
                                <asp:Label ID="img2" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/GhaniabadiBusinessPark.jpeg" class="fullwidth" />
                            <div class="carousel-caption">
                                <asp:Label ID="img3" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/WestRenoIndustrialPark.jpeg" class="fullwidth" />
                            <div class="carousel-caption">
                                <asp:Label ID="img4" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/UniversityPlaza.jpg" class="fullwidth" />
                            <div class="carousel-caption">
                                <asp:Label ID="img5" runat="server" Text="Label"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#regionalPropertyCarousel" data-slide="prev" role="button">
                        <span class="carousel-control-prev-icon"></span>
                    </a>
                    <a class="carousel-control-next" href="#regionalPropertyCarousel" data-slide="next" role="button">
                        <span class="carousel-control-next-icon"></span>
                    </a>
                </div>
            </div>
        </div>
        <br />
        <br />
        <br />
        <section id="okc" class="location">
                        <asp:Label ID="location1" runat="server" Text="Oklahoma City Properties"></asp:Label>
            <div class="row title-space">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-BradyPlaza.aspx">
                            <img src="img/BradyPlaza.jpg" class="homeimages" alt="test" />
                        </a>
                    </figure>
                </div>
                <div class="col12 col-lg-4">
                    <figure>
                        <a href="P-CollonadeShoppingCenter.aspx">
                            <img src="img/CollonadeShoppingCenter.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-GhaniabadiBusinessPark.aspx">
                            <img src="img/GhaniabadiBusinessPark.jpeg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
            <div class="row">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-PennCrossing.aspx">
                            <img src="img/PennCrossing.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-SantaFePlaza.aspx">
                            <img src="img/SantaFePlaza.png" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-Stonebriar.aspx">
                            <img src="img/Stonebriar.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
            <div class="row">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-VirtualOfficesWestminster.aspx">
                            <img src="img/VirtualOfficesatWestminsterExecutiveSuites.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-WestRenoIndustrialPark.aspx">
                            <img src="img/WestRenoIndustrialPark.jpeg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-WestminsterEventCenter.aspx">
                            <img src="img/WestminsterEventCenter.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
            <div class="row">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-WestminsterVillage.aspx">
                            <img src="img/WestminsterVillage.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
        </section>
        <section id="norman" class="location">
            <asp:Label ID="location2" runat="server" Text="Norman Properties" CssClass="title-space"></asp:Label>
            <div class="row title-space">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-DowntownShoppingCenter.aspx">
                            <img src="img/DowntownShoppingCenter.png" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-MasonPlaza.aspx">
                            <img src="img/MasonPlaza.png" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-RobinsonCrossing.aspx">
                            <img src="img/RobinsonCrossing.jpeg" class="homeimages" />
                        </a>
                    </figure>
                </div>

            </div>
            <div class="row">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-RobinsonCrossingOfficeSuites.aspx">
                            <img src="img/RobinsonCrossingOfficeSuites.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
        </section>
        <section id="edmond" class="location">
            <asp:Label ID="location3" runat="server" Text="Edmond Properties" CssClass="title-space"></asp:Label>
            <div class="row title-space">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-EdmondCenter.aspx">
                            <img src="img/EdmondCenter.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-UniversityPlaza.aspx">
                            <img src="img/UniversityPlaza.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
        </section>
        <section id="mwc" class="location">
            <asp:Label ID="location4" runat="server" Text="Midwest City Properties"></asp:Label>
            <div class="row title-space">
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-DeckerCenter.aspx">
                            <img src="img/DeckerCenter.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
                <div class="col-12 col-lg-4">
                    <figure>
                        <a href="P-OrchardPlaza.aspx">
                            <img src="img/OrchardPlaza.jpg" class="homeimages" />
                        </a>
                    </figure>
                </div>
            </div>
        </section>
        <section id="shawnee" class="location">
            <asp:Label ID="location5" runat="server" Text="Shawnee Properties"></asp:Label>
            <div class="row title-space">
                <div class="col-12 col-lg-4">
                    <a href="P-ShawneeMarketPlace.aspx">
                        <img src="img/ShawneeMarketplace.jpg" class="homeimages" />
                    </a>
                </div>
            </div>
        </section>
    </div>
</asp:Content>
