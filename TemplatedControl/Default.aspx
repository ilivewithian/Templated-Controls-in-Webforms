<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TemplatedControl.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register TagPrefix="OSF" Namespace="TemplatedControl.CustomControls" Assembly="TemplatedControl" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <OSF:TemplatedControl ID="TemplatedControl1" runat="server">
        <MyTemplate>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList runat="server" ID="SampleDropDown" AutoPostBack="true" OnSelectedIndexChanged="SampleDropDown_SelectedIndexChanged">
                        <asp:ListItem Text="text1" />
                        <asp:ListItem Text="text2" />
                    </asp:DropDownList>
                    <asp:Button Text="Hidden Button" runat="server" ID="HiddenButton" Visible="false" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </MyTemplate>
    </OSF:TemplatedControl>
    </form>
</body>
</html>
