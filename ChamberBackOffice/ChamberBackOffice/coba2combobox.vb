'Imports System
'Imports System.Windows.Forms
'Imports DevExpress.DataAccess.ConnectionParameters
'Imports DevExpress.DataAccess.sql
'Imports DevExpress.XtraReports.UI

'Namespace XtraReport_RuntimeDataBinding

'    Public Class coba2combobox

'        Inherits Form

'        Public Sub New()
'            InitializeComponent()
'        End Sub

'        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'            ' Create an empty report.
'            Dim report As New XtraReport()

'            ' Create a data source.
'            Dim connectionParameters As New Access97ConnectionParameters("../../nwind.mdb", "", "")
'            Dim ds As New SqlDataSource(connectionParameters)

'            ' Create an SQL query to access the Products table.
'            Dim query As New CustomSqlQuery()
'            query.Name = "customQuery1"
'            query.Sql = "SELECT * FROM Products"

'            ds.Queries.Add(query)
'            ds.RebuildResultSchema()

'            ' Assign the data source to the report.
'            report.DataSource = ds
'            report.DataMember = "customQuery1"

'            ' Add a detail band to the report.
'            Dim detailBand As New DetailBand()
'            detailBand.Height = 50
'            report.Bands.Add(detailBand)

'            ' Add a label to the detail band.
'            Dim label As New XRLabel()
'            label.DataBindings.Add("Text", Nothing, "customQuery1.ProductName")
'            detailBand.Controls.Add(label)

'            ' Show the report's print preview.
'            report.ShowPreview()
'        End Sub
'    End Class

'End Namespace
