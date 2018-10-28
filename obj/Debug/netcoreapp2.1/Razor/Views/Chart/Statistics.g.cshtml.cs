#pragma checksum "D:\Downloads\WebstoreZip\webStore2-master\Views\Chart\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ceec843e9ae537c5bdb6886360cd6baa1f8069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_Statistics), @"mvc.1.0.view", @"/Views/Chart/Statistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chart/Statistics.cshtml", typeof(AspNetCore.Views_Chart_Statistics))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Downloads\WebstoreZip\webStore2-master\Views\_ViewImports.cshtml"
using klaas;

#line default
#line hidden
#line 2 "D:\Downloads\WebstoreZip\webStore2-master\Views\_ViewImports.cshtml"
using klaas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ceec843e9ae537c5bdb6886360cd6baa1f8069", @"/Views/Chart/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352b5a98eed0cfcd5effdcb73eae774d1cd82482", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Downloads\WebstoreZip\webStore2-master\Views\Chart\Statistics.cshtml"
  
    ViewData["Title"] = "Statistics";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 738, true);
            WriteLiteral(@"<h2>Overview</h2>
On this page, you can find statistics related to the webshop. <br />The current page is WIP and some data here may be for testing purposes only!.<br />

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h4 style=""margin-left:200px""></h4>
            <div id=""chart1""></div>
            <h4 style=""margin-left:200px""></h4>
            <div id=""chart2""></div>
        </div>
    </div>
    <style>
        div.col-md-6 {
            width: 100%;
        }

        #chart1 {
            float: left;
            display: inline-block;
        }

        #chart2 {
            float: left;
            display: inline-block;
        }
    </style>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(850, 2134, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            $.get('GetCategorySold', function (jsonData) {
                var json = jsonData;
                var data = new google.visualization.DataTable(json);

                var option = {
                    title: 'Percentage sales of each category',
                    width: 500,
                    height: 400
                };


                //3D Pie Chart:
                option.is3D = true;
                chart = new google.visualization.PieChart(document.getElementById('chart1'));
                chart.draw(data, option);

            })
            $.get('GetTotalSoldData', function (jsonData) {
                data = google.visualization.arrayToDataTable(jsonData, false);
                var option = {
 ");
                WriteLiteral(@"                   title: ""Total products sold since last week"",
                    width: 600,
                    height: 400,
                    hAxis: {
                        title: 'Aantal dagen geleden'
                    },
                    vAxis: {
                        title: 'Aantal verkochtte producten'
                    },
                };
                chart = new google.visualization.LineChart(document.getElementById('chart2'));
                chart.draw(data, option);
            }) 
            /*
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Tax Type');
            data.addColumn('number', 'Tax Percentage');
            data.addRows([
                ['Roerboot', { v: 30, f: '30%' }],
                ['Speedboten', { v: 35, f: '35%' }],
                ['Zeilboten', { v: 15, f: '15%' }],
                ['Jachtboten', { v: 12, f: '12%' }],
                ['Boot Onderdelen', { v: 8, f: '8%' }]
       ");
                WriteLiteral("     ]);\r\n            */\r\n            // Simple Pie Chart:\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
