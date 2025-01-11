<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Weather_Website.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weather Finder</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
  
        <div class="container">
            <h1>Weather Finder</h1>
            <div class="form-group">
                <label for="txtCity">City:</label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="input-box"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtState">State:</label>
                <asp:TextBox ID="txtState" runat="server" CssClass="input-box"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Get Weather" CssClass="submit-button" OnClick="BtnSubmit_Click" />
            </div>

        </div>
    </form>
</body>
</html>
