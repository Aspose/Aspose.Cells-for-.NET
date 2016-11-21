<%@ Page Language="C#" AutoEventWireup="true" Inherits="Aspose.Cells.GridWeb.Examples.CSharp.Miscellaneous.PivotTable.CreatePivotTableFromWorksheet"
    MasterPageFile="~/Site.Master" Title="Create Pivot Table from Worksheet - Aspose.Cells Grid Suite Examples"
    CodeBehind="CreatePivotTableFromWorksheet.aspx.cs" %>

<%@ Register TagPrefix="acw" Namespace="Aspose.Cells.GridWeb" Assembly="Aspose.Cells.GridWeb" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <table class="componentDescriptionTxt" border="0" cellpadding="0" cellspacing="0"
        style="text-align: center; width: 100%; font-family: Arial; font-size: small;">
        <tbody>
            <tr>
                <td class="demos-heading-bg" style="width: 100%;">
                    <h2 class="demos-heading-bg">
                        Create Pivot Table from Worksheet - Aspose.Cells Grid Suite Examples
                    </h2>
                </td>             
            </tr>
        </tbody>
    </table>
    <div style="text-align: left; font-family: Arial; font-size: small;" class="componentDescriptionTxt">
        <p>
            In this example, an existing worksheet is read into WebWorksheet using <b>ImportExcelFile</b>
            method of GridWeb. A <b>Pivot Table</b> is created on imported data.
            You can also Save/Open the output in <b>XLS</b> Format by clicking the Save Button
            on GridWeb Control Bar.
        </p>
        <p>
            Click <b>From Worksheet</b> to see how PivotTable is generated from a worksheet.<br />
            
        </p>
        <p>
            Please download the
            <asp:LinkButton ID="lnkFile" runat="server" Text="PivotTable.xls" OnClick="lnkFile_Click"></asp:LinkButton>
            used in this example.</p>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnReload" runat="server" Text="Reload Source Data" Width="130px"
                        OnClick="btnReload_Click"></asp:Button>
                    <asp:Button ID="btnWorksheet" runat="server" Text="From WorkSheet" Width="130px"
                        OnClick="btnWorksheet_Click"></asp:Button>
                      
                </td>
            </tr>
            <tr>
                <td>
                    <acw:GridWeb ID="GridWeb1" runat="server" Width="700px" PresetStyle="Traditional1"
                        ShowLoading="false" OnSaveCommand="GridWeb1_SaveCommand">
                    </acw:GridWeb>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
