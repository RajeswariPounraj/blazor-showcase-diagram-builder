// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DiagramBuilder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using DiagramBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\fork\DB-Source-Fork\Server-side\_Imports.razor"
using DiagramBuilder.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\fork\DB-Source-Fork\Server-side\Pages\DiagramMoreShapes.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fork\DB-Source-Fork\Server-side\Pages\DiagramMoreShapes.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
    public partial class DiagramMoreShapes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\fork\DB-Source-Fork\Server-side\Pages\DiagramMoreShapes.razor"
       
    public DiagramLeftSideBar Parent;
    SfDialog MoreShapesPalette;
    SfListView<ListViewDataFields> MoreShapesList;
    List<ListViewDataFields> SelectedItems = new List<ListViewDataFields>();
    bool MoreShapesVisible = false;
    string ShapeImageLoaction = "./assets/dbstyle/shapes_images/flow.png";
    string BackgroundImage = "background-image: url(./assets/dbstyle/shapes_images/flow.png);";
    public string OverviewSpanClassName = "db-overview";
    string alternateText = "flowshapes";

    public class ListViewDataFields
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public bool Checked { get; set; }
    }
    public List<ListViewDataFields> ListViewData = new List<ListViewDataFields>()
    {
        new ListViewDataFields(){ Text= "Flow", Id="flowShapes", Checked= true },
        new ListViewDataFields(){ Text= "Basic", Id="basicShapes", Checked= true },
        new ListViewDataFields(){ Text= "Connectors", Id="connectorsShapes", Checked= true },
    };

    private void MoreShapesClick()
    {
        MoreShapesVisible = true;
    }
    private void ListViewSelectionChange(Syncfusion.Blazor.Lists.ClickEventArgs<ListViewDataFields> args)
    {
        ShapeImageLoaction = "./assets/dbstyle/shapes_images/" + args.Text.ToLower() + ".png";
        BackgroundImage = "background-image: url(./assets/dbstyle/shapes_images/" + args.Text.ToLower() + ".png" +");";
        alternateText = args.Text.ToLower() + "shapes";

        foreach (ListViewDataFields data in SelectedItems)
        {
            if (data.Text == args.Text)
            {
                SelectedItems.Remove(data);
                break;
            }
        }
        (args.ItemData as ListViewDataFields).Checked = args.IsChecked;
        SelectedItems.Add(args.ItemData as ListViewDataFields);
    }

    private async Task BtnSave()
    {
        Parent.Parent.Parent.SpinnerObj.Show();
        await Parent.DiagramSymbolpalette.UpdatePalettes(SelectedItems);
        Parent.Parent.Parent.SpinnerObj.Hide();
        await MoreShapesPalette.Hide();
    }


    private async Task btnCancelClick()
    {
        await MoreShapesPalette.Hide();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
