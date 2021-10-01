<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateFile.aspx.cs" Inherits="Proj.UpdateFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Patient File</h1>
        </div>
        <table class="auto-style1">
            <tr>
                <td>Patient:</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Enter patient ID:&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit Patient ID" OnClick="btnSubmit_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOutput" runat="server" Text="[Output]"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Panel ID="Panel1" runat="server" Height="183px" Visible="False">
                        <br />
                        Update record:&nbsp;&nbsp;
                        <asp:TextBox ID="txtRecord" runat="server" Height="88px" TextMode="MultiLine"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Record" />
                    </asp:Panel>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnExit" runat="server" Text="Exit" Width="109px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
