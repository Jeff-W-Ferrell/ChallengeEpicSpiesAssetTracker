<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpyAssetTracker.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.SpyAssetTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 119px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif">
    
        <img alt="Epic Spies Logo" class="auto-style1" src="epic-spies-logo.jpg" /><h3>Asset Performance Tracker</h3>
    
    </div>
        <p>
            Asset Name:
            <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:
            <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsOfSubterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="performanceLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
