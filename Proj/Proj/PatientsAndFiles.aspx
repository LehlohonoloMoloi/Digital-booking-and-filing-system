<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientsAndFiles.aspx.cs" Inherits="Proj.PatientsAndFiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 469px;
        }
        .auto-style3 {
            width: 469px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Patients and Files</h1>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <h3>Patients:</h3>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">List of patients</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="gvPatients" runat="server">
                    </asp:GridView>
                </td>
                <td><strong>Order table<br />
                    </strong>Sort by Patient_ID:<br />
                    <asp:RadioButtonList ID="rbPatients" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbPatients_SelectedIndexChanged">
                        <asp:ListItem>Ascending</asp:ListItem>
                        <asp:ListItem>Descending</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <h3>Files:</h3>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">List of files</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblOutputFiles" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="gvFiles" runat="server">
                    </asp:GridView>
                </td>
                <td><strong>Order table<br />
                    </strong>Sort by Patient_ID:<br />
                    <asp:RadioButtonList ID="rbFiles" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbFiles_SelectedIndexChanged">
                        <asp:ListItem>Ascending</asp:ListItem>
                        <asp:ListItem>Descending</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnExit" runat="server" Text="Exit" Width="86px" />
                </td>
                <td>
                    <asp:Label ID="lblTimeStamp" runat="server" Text="[Date and Time stamp]"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
