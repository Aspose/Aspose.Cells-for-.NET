﻿<%@ Page Title="Get GridWeb Version - Aspose.Cells Grid Suite Examples" Language="C#" 
    MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GetGridWebVersion.aspx.cs" Inherits="Aspose.Cells.GridWeb.Examples.CSharp.GridWebBasics.GetGridWebVersion" %>

<%@ Register TagPrefix="acw" Namespace="Aspose.Cells.GridWeb" Assembly="Aspose.Cells.GridWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">   
    <script type="text/javascript">
        // ExStart:GetClientSideGridWebVersion
        function GetVersion()
        {
            alert(acw_version);
            console.log(acw_version);
            return false;
        }
        // ExEnd:GetClientSideGridWebVersion
    </script>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <table class="componentDescriptionTxt" border="0" cellpadding="0" cellspacing="0"
        style="text-align: center; width: 100%; font-family: Arial; font-size: small;">
        <tbody>
            <tr>
                <td style="width: 19; vertical-align: top;">
                    <img alt="" height="41" src="/Common/images/heading_lft.jpg" width="19" />
                </td>
                <td class="demos-heading-bg" style="width: 100%;">
                    <h2 class="demos-heading-bg">
                        Get GridWeb Version - Aspose.Cells Grid Suite Examples
                    </h2>
                </td>
                <td style="width: 19; vertical-align: top;">
                    <img alt="" height="41" src="/Common/images/heading_rt.jpg" width="19" />
                </td>
            </tr>
        </tbody>
    </table>
    <div style="text-align: left; font-family: Arial; font-size: small;" class="componentDescriptionTxt">
        <p>
            Click <b>Get GridWeb Version</b> to see GridWeb version or <br /> click <b>Get Client Side GridWeb Version</b> to see version for GridWeb's client side script.
                      
        </p>
        <br />
        <div>
            <table>
                <tr>
                    <td>
                       
                        <p>
                           <asp:Label ID="Label1" runat="server"></asp:Label>
                            <br />
                           <asp:Button ID="btnGetGridWebVersion" runat="server" Text="Get GridWeb Version" OnClick="btnGetGridWebVersion_Click" />
                            <asp:Button ID="btnGetClientSideVersion" runat="server" Text="Get Client Side GridWeb Version" OnClientClick="return GetVersion();" />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <acw:GridWeb ID="GridWeb1" runat="server"
                            OnSaveCommand="GridWeb1_SaveCommand" ShowLoading="false">
                        </acw:GridWeb>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </div>
</asp:Content>



