#pragma checksum "C:\Users\danmo\source\repos\FNCORCL2\Views\Forms\NonOpito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fe145717cf41037aa43eac393788e2686b0bd30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_NonOpito), @"mvc.1.0.view", @"/Views/Forms/NonOpito.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forms/NonOpito.cshtml", typeof(AspNetCore.Views_Forms_NonOpito))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fe145717cf41037aa43eac393788e2686b0bd30", @"/Views/Forms/NonOpito.cshtml")]
    public class Views_Forms_NonOpito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\danmo\source\repos\FNCORCL2\Views\Forms\NonOpito.cshtml"
  
    ViewData["Title"] = "NonOpito";

#line default
#line hidden
            BeginContext(46, 2970, true);
            WriteLiteral(@"<div class=""container-fluid"">
    <h2>Non-Opito</h2>
    <table id=""NonOpito"" class=""table table-striped table-bordered dt-responsive nowrap"" width=100% cellspacing=""0"">
        <thead>
            <tr>
                <th>Person Code</th>
                <th>First Name</th>
                <th>Surname</th>
                <th>UI Code</th>
                <th>Calocc Code</th>
                <th>Cert 1</th>
                <th>Cert 2</th>
                <th>Cert 3</th>
                <th>Certificate Expiry Date</th>
                <th>New Cert Start Date</th>
                <th>Refresh Cert End Date</th>
            </tr>
        </thead>

    </table>
</div>
<script>
        $(document).ready(function ()
        {
            $(""#NonOpito"").DataTable({
                ""processing"": true, // for show progress bar
                ""serverSide"": true, // for process server side
                ""filter"": true, // this is for disable filter (search box)
                ""orderMulti"":");
            WriteLiteral(@" false, // for disable multiple column at once
                ""ajax"": {
                    ""url"": ""/Forms/NonOpito"",
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""columnDefs"":
                [{
                    ""targets"": [0],
                    ""visible"": false,
                    ""searchable"": false
                }],
                ""columns"": [
                    { ""data"": ""person_code"", ""name"": ""person_code"", ""autoWidth"": true },
                    { ""data"": ""forename"", ""name"": ""forename"", ""autoWidth"": true },
                    { ""data"": ""surname"", ""name"": ""surname"", ""autoWidth"": true },
                    { ""data"": ""ui_code"", ""name"": ""ui_code"", ""autoWidth"": true },
                    { ""data"": ""cert_1"", ""name"": ""cert_1"", ""autoWidth"": true },
                    { ""data"": ""cert_2"", ""name"": ""cert_2"", ""autoWidth"": true },
                    { ""data"": ""cert_3"", ""name"": ""cert_3"", ""autoWidth"": true },
        ");
            WriteLiteral(@"            { ""data"": ""certificate_expiry_date"", ""name"": ""certificate_expiry_date"", ""autoWidth"": true },
                    { ""data"": ""new_cert_start_date"", ""name"": ""new_cert_start_date"", ""autoWidth"": true },
                    { ""data"": ""refresh_cert_end_date"", ""name"": ""refresh_cert_end_date"", ""autoWidth"": true },
                    {
                        ""render"": function (data, type, full, meta)
                        { return '<a class=""btn btn-info"" href=""/DemoGrid/Edit/' + full.CustomerID + '"">Edit</a>'; }
                    },
                    {
                        data: null, render: function (data, type, row)
                        {
                            return ""<a href='#' class='btn btn-danger' onclick=DeleteData('"" + row.CustomerID + ""'); >Delete</a>"" ;
                        }
                    },
                ]
            });
        });

</script>");
            EndContext();
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
