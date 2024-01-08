Imports System.Net
Imports AxelburgRVFrontEnd
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeList.stp_EmployeeList' table. You can move, or remove it, as needed.
        Me.stp_EmployeeListTableAdapter.Fill(Me.EmployeeList.stp_EmployeeList)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class


