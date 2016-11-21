﻿<%@ Page Title="Read Cell Values on Client Side - Aspose.Cells Grid Suite Examples" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" 
    CodeBehind="ReadCellsClientSide.aspx.vb" Inherits="Aspose.Cells.GridWeb.Examples.VisualBasic.Articles.ReadCellsClientSide" %>

<%@ Register TagPrefix="acw" Namespace="Aspose.Cells.GridWeb" Assembly="Aspose.Cells.GridWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <!-- ExStart:ReadGridWebCellsClientSide -->
    <script type="text/javascript">
        function ReadGridWebCells() {
            // Access GridWeb instance and cells array
            var gridwebins = gridwebinstance.get("<%=GridWeb1.ClientID%>");
            var cells = gridwebins.getCellsArray();

            // Log cell name, values, row & column indexes in console
            for (var j = 0; j < cells.length; j++) {
                var cellInfo = j + ":" + gridwebins.getCellName(cells[j]) + ",";
                cellInfo += "value is:" + gridwebins.getCellValueByCell(cells[j]) + " ,";
                cellInfo += "row:" + gridwebins.getCellRow(cells[j]) + ",";
                cellInfo += "col:" + gridwebins.getCellColumn(cells[j]);
                console.log(cellInfo);
            }
        }
    </script>
    <!-- ExEnd:ReadGridWebCellsClientSide -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <table class="componentDescriptionTxt" border="0" cellpadding="0" cellspacing="0"
        style="text-align: center; width: 100%; font-family: Arial; font-size: small;">
        <tbody>
            <tr>
                <td class="demos-heading-bg" style="width: 100%;">
                    <h2 class="demos-heading-bg">
                       Read Cell Values on Client Side - Aspose.Cells Grid Suite Examples
                    </h2>
                </td>
            </tr>
        </tbody>
    </table>
    <div style="text-align: left; font-family: Arial; font-size: small;" class="componentDescriptionTxt">
        <p>
            Click <b>Click me</b> to access cell values on client side. Verify the values from browser console.
        </p>
        <br />
        <div>
            <table>
                <tr>
                    <td>
                        <!-- ExStart:ReadGridWebCells -->
                        <button type="button" onclick="ReadGridWebCells()">Click me</button>
                        <!-- ExEnd:ReadGridWebCells -->
                    </td>
                </tr>
                <tr>
                    <td>
                        <acw:GridWeb ID="GridWeb1" runat="server">
                        </acw:GridWeb>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
