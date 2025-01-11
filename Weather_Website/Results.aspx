<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Weather_Website.Results" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weather Results</title>
    <link href="Styles.css" rel="stylesheet" />
        
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Weather Results</h1>
            <p><strong>City:</strong> <asp:Label ID="lblCity" runat="server"></asp:Label></p>
            <p><strong>State:</strong> <asp:Label ID="lblState" runat="server"></asp:Label></p>
            <p><strong>Weather Information:</strong></p>
            <asp:Label ID="lblWeatherInfo" runat="server"></asp:Label>
            <br />
            <a href="Index.aspx" class="back-button">Go Back</a>
        </div>
    </form>
</body>
</html>
