Partial Class Horizon

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TypeReportSource2 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horizon))
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.subReport1 = New Telerik.Reporting.SubReport()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.SqlDataSourceHorizon = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.subReport1, Me.textBox1, Me.textBox2})
        Me.detailSection1.Name = "detailSection1"
        '
        'subReport1
        '
        Me.subReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.subReport1.Name = "subReport1"
        TypeReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("PLID", "= Fields.protect_layer_hash"))
        TypeReportSource2.TypeName = "Horizon1, VB.ReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" &
    ""
        Me.subReport1.ReportSource = TypeReportSource2
        Me.subReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox1.Value = "= Fields.protect_layer_hash"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox2.Value = "= Fields.protect_layer_description"
        '
        'SqlDataSourceHorizon
        '
        Me.SqlDataSourceHorizon.ConnectionString = "Data Source=tcp:mss-iotag.database.windows.net,1433;Initial Catalog=prod_iotag_ma" &
    "ster;Persist Security Info=True;User ID=iotag_usr;Password=""M@ng@n2020="""
        Me.SqlDataSourceHorizon.Name = "SqlDataSourceHorizon"
        Me.SqlDataSourceHorizon.ProviderName = "System.Data.SqlClient"
        Me.SqlDataSourceHorizon.SelectCommand = resources.GetString("SqlDataSourceHorizon.SelectCommand")
        '
        'Horizon
        '
        Me.DataSource = Me.SqlDataSourceHorizon
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detailSection1})
        Me.Name = "Horizon"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.4R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents subReport1 As Telerik.Reporting.SubReport
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSourceHorizon As Telerik.Reporting.SqlDataSource
End Class