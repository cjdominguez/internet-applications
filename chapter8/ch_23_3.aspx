
<%@ Page Language="C#" AutoEventWireup="true"

                           CodeBehind="WebTimeShow.aspx.cs" Inherits="_10201_19_3E.WebTimeShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Display Current Time</title>

    <style type="text/css">

        <%--Style for the label--%>

        .webtimeStyle

        {

            font-size: xx-large;

            background-color: #008000;

            border: medium ridge #008000;

            color: #FFFFFF;

        }

        <%--Style for the table--%>

        .tabStyle

        {

            background-color: #CCFFCC;

        }

    </style>

</head>

    <!—To change the text color -->

    <tr>

    <td>Set the Text Color</td>

    <td>

    <!--Control to change the text color-->

    <asp:DropDownList ID="TextColor" runat="server"

        AutoPostBack="true"

            onselectedindexchanged=

                   "TextColor_SelectedIndexChanged">

        <asp:ListItem Text="White"/>

        <asp:ListItem Text="Green"/>

        <asp:ListItem Text="Blue" />

        <asp:ListItem Text="Red"/>

    </asp:DropDownList>

    </td>

    </tr>

<!—To set the font size— >

    <tr>

    <td>

    Set the Font Size

    </td>

    <td>

    <!--To change the font size-->

    <asp:DropDownList ID="ddlFont" runat="server"

    AutoPostBack="true"

            onselectedindexchanged=

                   "DropDownList1_SelectedIndexChanged">

        <asp:ListItem Text="xx-large" />

        <asp:ListItem Text="x-large"/>

        <asp:ListItem Text="xx-small"/>

        <asp:ListItem Text="x-small"/>

        </asp:DropDownList>

    </td>

    </tr>

    <!--row to show the time-->

    <tr>

    <td><h2>

            Set the Current time:</h2></td>

    <td>

    <!--Control to show the time-->

    <asp:Label ID="lblWebTime" runat="server" Text="Time"

       CssClass="webtimeStyle"/>

    </td>

    </tr>

    </table>

    </form>

</body>

</html>
