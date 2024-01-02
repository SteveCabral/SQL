<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReportFrontEnd.aspx.vb" Inherits="AxelburgFrontEnd.ReportFrontEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 24px">
    <form id="form1" runat="server">
    <div>
    
        <asp:label id="Label5" 
            style="Z-INDEX: 103; LEFT: 384px; POSITION: absolute; TOP: 72px" runat="server"
				Width="72px" Height="24px" Font-Bold="True">End Date</asp:label>
        <asp:label id="Label4" 
            style="Z-INDEX: 102; LEFT: 112px; POSITION: absolute; TOP: 72px" runat="server"
				Width="72px" Height="24px" Font-Bold="True">Start Date</asp:label>
    
    </div>
    <asp:Calendar ID="calEndDate" runat="server" SelectedDate="2015-12-31" 
        style="z-index: 1; left: 299px; top: 114px; position: absolute; height: 188px; width: 259px" 
        VisibleDate="2015-12-31"></asp:Calendar>
    <asp:Calendar ID="calStartDate" runat="server" SelectedDate="2015-11-01" 
        style="z-index: 1; left: 15px; top: 114px; position: absolute; height: 188px; width: 259px" 
        VisibleDate="2015-11-01"></asp:Calendar>
    <p>
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="616px" Height="48px" Font-Size="X-Large">Axelburg Invoice-Batch Number Report</asp:label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="cmdExecute" runat="server" 
            style="z-index: 1; left: 205px; top: 346px; position: absolute; height: 44px; width: 166px" 
            Text="Execute" />
    </p>
    </form>
</body>
</html>
