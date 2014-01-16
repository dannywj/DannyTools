<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CodeBuilder.aspx.cs" Inherits="DannyTools._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>批量代码生成器</title>
</head>
<body>
    <form runat="server">
        <div style="margin-left: 50px; border: solid 1px #0094ff; padding: 20px; width: 900px;">
            <h1 style="font-size: 14px;">参数配置</h1>
            Code:<br />
            <textarea runat="server" id="txtCode" style="width: 800px; height: 200px;"></textarea>
            <br />
            <br />
            Template: Replace with {*}<br />
            <textarea runat="server" id="txtTemplate" style="width: 800px; height: 200px;"></textarea>

            <br />

            <asp:Button ID="btnProcess" runat="server" Text="Process" OnClick="btnProcess_Click" />

        </div>

        <div style="margin-left: 50px; margin-top: 20px; border: solid 1px #0094ff; padding: 20px; width: 900px;">
            <h1 style="font-size: 14px;">Result:</h1>
            <div id="txtResultDiv">

                <asp:Label ID="txtResult" runat="server" Text=""></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
