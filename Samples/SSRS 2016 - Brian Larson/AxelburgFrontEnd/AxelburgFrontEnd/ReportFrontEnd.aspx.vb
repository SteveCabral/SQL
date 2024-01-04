Public Class ReportFrontEnd
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click
        Dim report As Byte() = Nothing
        ' Create an instance of the Reporting Services
        ' Web Reference. 
        Dim rs As RptExecSvc.ReportExecutionService _
                             = New RptExecSvc.ReportExecutionService
        ' Create the credentials that will be used when accessing
        ' Reporting Services. This must be a Windows logon that has 
        ' rights to the Axelburg Invoice-Batch Number report. 
        ' *** Replace "LoginName", "Password", and "Domain" with
        '     the appropriate values. ***
        rs.Credentials = New _
           System.Net.NetworkCredential("Administrator",
           "Pass@word1", "win-b8iskf19lt4")
        rs.PreAuthenticate = True

        ' The Reporting Services virtual path to the report.
        Dim reportPath As String =
     "/Galactic Delivery Services/Axelburg/Invoice-Batch Number Report"

        ' The rendering format for the report. 
        Dim format As String = "HTML5"

        ' The devInfo string tells the report viewer
        ' how to display with the report. 
        Dim devInfo As String =
          "<DeviceInfo>" +
          "<Toolbar>False</Toolbar>" +
          "<Parameters>False</Parameters>" +
          "<DocMap>True</DocMap>" +
          "<Zoom>100</Zoom>" +
          "</DeviceInfo>"

        ' Create an array of the values for the report parameters
        Dim parameters(1) As RptExecSvc.ParameterValue
        Dim paramValue As RptExecSvc.ParameterValue _
                               = New RptExecSvc.ParameterValue
        paramValue.Name = "StartDate"
        paramValue.Value = calStartDate.SelectedDate
        parameters(0) = paramValue
        paramValue = New RptExecSvc.ParameterValue
        paramValue.Name = "EndDate"
        paramValue.Value = calEndDate.SelectedDate
        parameters(1) = paramValue

        ' Create variables for the remainder of the parameters
        Dim historyID As String = Nothing
        Dim credentials() As RptExecSvc.DataSourceCredentials = Nothing
        Dim showHideToggle As String = Nothing
        Dim mimeType As String
        Dim warnings() As RptExecSvc.Warning = Nothing
        Dim reportHistoryParameters() As _
                          RptExecSvc.ParameterValue = Nothing
        Dim streamIDs() As String = Nothing

        Dim execInfo As New RptExecSvc.ExecutionInfo
        Dim execHeader As New RptExecSvc.ExecutionHeader
        rs.ExecutionHeaderValue = execHeader
        execInfo = rs.LoadReport(reportPath, historyID)
        rs.SetExecutionParameters(parameters, "en-us")

        Try
            ' Execute the report. 
            report = rs.Render(format,
                     devInfo, "", mimeType, "", warnings, streamIDs)

            ' Flush any pending response. 
            Response.Clear()

            ' Set the HTTP headers for a PDF response. 
            HttpContext.Current.Response.ClearHeaders()
            HttpContext.Current.Response.ClearContent()
            HttpContext.Current.Response.ContentType = "text/html"
            ' filename is the default filename displayed
            ' if the user does a save as. 
            HttpContext.Current.Response.AppendHeader(
                  "Content-Disposition",
                  "filename=""Invoice-BatchNumber.HTM""")

            ' Send the byte array containing the report
            ' as a binary response. 
            HttpContext.Current.Response.BinaryWrite(report)
            HttpContext.Current.Response.End()
        Catch ex As Exception
            If ex.Message <> "Thread was being aborted." Then
                HttpContext.Current.Response.ClearHeaders()
                HttpContext.Current.Response.ClearContent()
                HttpContext.Current.Response.ContentType = "text/html"
                HttpContext.Current.Response.Write(
                               "<HTML><BODY><H1>Error</H1><br><br>" &
                               ex.Message & "</BODY></HTML>")
                HttpContext.Current.Response.End()
            End If
        End Try

    End Sub
End Class