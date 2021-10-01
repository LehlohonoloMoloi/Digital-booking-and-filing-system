<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletePatient.aspx.cs" Inherits="Proj.DeletePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
        <div>
            <h1>Delete Patient </h1>
        </div>
    <form id="form1" runat="server">
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
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="52px" Visible="False">
                        <asp:Button ID="btnUpdate" runat="server" Text="Delete Patient" />
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
                    <asp:Button ID="btnExit" runat="server" Text="Exit" Width="109px" />
        </div>
    </form>
</body>
</html>
