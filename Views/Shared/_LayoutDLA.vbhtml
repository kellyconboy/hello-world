<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - DACS Landing Page</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Styles.Render("~/Content/datepicker")
    @Scripts.Render("~/bundles/datepicker")
    @Scripts.Render("~/bundles/JqueryContextMenu")
    <script src="https://cdn.ckeditor.com/4.4.3/standard/ckeditor.js" ></script>
    @*<link href="Https://www.private.dacs.dla.mil/shared/ClickJack.css" type="text/css" rel="stylesheet" id="antiClickjack">
    <script src="Https://www.private.dacs.dla.mil/shared/ClickJack.js"></script>*@

</head>
<body>

    <script>
        var x_iis_server = "";
        var x_tomcat_server = "";
    </script>

    <style type="text/css">
        .classBar {
            height: 25px;
            line-height: 25px;
            color: #FFF;
            font-size: 16px;
            background: #0A0;
            text-align: Center;
        }

        #classBarLeft {
            float: left;
        }

        #classBarCenter {
            display: inline-block;
            margin: 0 auto;
        }

        #classBarRight {
            float: right;
        }

        .greenBar {
            color: #FFF;
            background: #0A0;
        }
    </style>



    <div id="minMax">
        <div class="classBar" id="topBar">
            <div id="classBarLeft"><span id=webinfo></span></div>
            <div id="classBarCenter">This information system is approved for UNCLASSIFIED//<span id="topClass">FOUO</span> data</div>
            <div id="classBarRight">DACS Private MilCloud</div>
        </div>
        <div id="header">
            @*<script src="Https://www.private.dacs.dla.mil/shared/Classification.js"></script>*@
            <img src="@Url.Content("~/Content/Images/DLABanner.jpg")" alt="DLA Document Services Banner" border="0" usemap="#Map" class="Centered" />
            @*<map id="Map" name="DLABannerMap">
                    <area shape="rect" coords="42,4,146,116" href="http://www.dla.mil" target="_blank" alt="DLA" />
                </map>*@
        </div>

        <!-- end header -->
        <div id="topbar">

            <div id="outer11">
                <div class="content">
                    &nbsp;
                </div>
            </div>
            <div id="outer12">
                <div style="font-size: 15px;">
                    <!--Html.MvcSiteMap().Menu("BootStrapMenuHelperModel") -->
                </div>
                <div style="float: left; vertical-align: central;">
                </div>
                <div style="float: right; font-size: 15px; color: White; vertical-align: central;">

                </div>
            </div>
        </div>
        <br />
        <!-- Left Hand Side Bar -->

        <div id="wrapper">
            <div id="outer1">
                <div class="content">
                    <h1 class="NewsList">News & Updates</h1>
                    <a href="NewsItems/Index">Administration</a>
                       @* @Html.Action("~/NewsItems/", "News*@
                                             <br />
                         <br />
                         <h1 class="DACS">Supporting the Warfighter</h1>
                         <div style="text-align: center;">
                             <img src="@Url.Content("~/Content/Images/armyfinished.jpg")" alt="Department of Defense Department of the Army Seal" />
                             <img src="@Url.Content("~/Content/Images/navy.jpg")" alt="Department of defense department of the navy seal" />
                         </div> <div style="text-align: center;">
                             <img src="@Url.Content("~/Content/Images/dod.jpg")" alt="Department of Defense Seal" />
                         </div> <div style="text-align: center;">
                             <img src="@Url.Content("~/Content/Images/airforce.jpg")" alt="Department of Defense Department of the Air Force Seal" />
                             <img src="@Url.Content("~/Content/Images/marine.jpg")" alt="Department of Defense Marian Corps Seal" />
                         </div>
                    
                </div> <!-- end content -->
            </div> <!-- Right Hand Main Body --> <div id="outer2">
                <div class="content">
                    <br />
                    <br />
                    <div style=""></div>
                    @RenderBody()
                </div> <!-- end content -->
            </div> <!-- end outer2 -->
        </div> <!-- end #wrapper -->
        <!-- Begin footer -->
        <div id="footer">
            <div class="content">
                <div class="float" style="width: 13.125%;">
                    &nbsp;
                </div>
                <div class="float" style="width: 9.125%;">
                    <div class="hyperlink2" id="usagov">
                        <a href="http://www.usa.gov/" title="USA.GOV Web Site Link" target="_blank">USA.GOV</a>
                    </div>
                </div>
                <div class="float" style="width: 8.125%;">
                    <div class="hyperlink2" id="nofear">
                        <a href="https://www.dla.mil/EEO/Offers/NoFEAR.aspx" title="Equal Employment Opportunity Data Required to be Posted by the No FEAR Act" target="_self">No Fear</a>
                    </div>
                </div>
                <div class="float" style="width: 14.125%;">
                    <div class="hyperlink2" id="privacy">
                        <a href="http://www.defense.gov/Resources/Privacy" title="Privacy/Security" target="_self">Privacy/Security</a>
                    </div>
                </div>
                <div class="float" style="width: 18.125%;">
                    <div class="hyperlink2" id="compliance">
                        <a href="http://www.dla.mil/508.aspx" title="Accessibility/Section 508" target="_blank">Accessibility/Section 508</a>
                    </div>
                </div>
                <div class="float" style="width: 12.125%;">
                    <div class="hyperlink2" id="disclaimer">
                        <a href="http://www.defense.gov/Resources/External-Link-Disclaimer" title="Links Disclaimer" target="_self">Links Disclaimer</a>
                    </div>
                </div>
                </div>
                <div class="float" style="width: 15.125%">
                    &nbsp;
                </div>
            </div>
            <br />
        </div> <!-- end footer -->
    </div>



    @Scripts.Render("~/bundles/bootstrap")

    @RenderSection("scripts", required:=False)
</body>
</html>