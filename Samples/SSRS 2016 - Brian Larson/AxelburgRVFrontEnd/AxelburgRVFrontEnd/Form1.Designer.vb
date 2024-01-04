<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EmployeeList = New AxelburgRVFrontEnd.EmployeeList()
        Me.stp_EmployeeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stp_EmployeeListTableAdapter = New AxelburgRVFrontEnd.EmployeeListTableAdapters.stp_EmployeeListTableAdapter()
        CType(Me.EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stp_EmployeeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "EmployeeList"
        ReportDataSource1.Value = Me.stp_EmployeeListBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AxelburgRVFrontEnd.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.ReportPath = "/Galactic Delivery Services/Axelburg/Invoice-Batch Number Report"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://win-b8iskf19lt4/reportserver", System.UriKind.Absolute)
        Me.ReportViewer1.Size = New System.Drawing.Size(675, 448)
        Me.ReportViewer1.TabIndex = 0
        '
        'EmployeeList
        '
        Me.EmployeeList.DataSetName = "EmployeeList"
        Me.EmployeeList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'stp_EmployeeListBindingSource
        '
        Me.stp_EmployeeListBindingSource.DataMember = "stp_EmployeeList"
        Me.stp_EmployeeListBindingSource.DataSource = Me.EmployeeList
        '
        'stp_EmployeeListTableAdapter
        '
        Me.stp_EmployeeListTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 448)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stp_EmployeeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents stp_EmployeeListBindingSource As BindingSource
    Friend WithEvents EmployeeList As EmployeeList
    Friend WithEvents stp_EmployeeListTableAdapter As EmployeeListTableAdapters.stp_EmployeeListTableAdapter
End Class
