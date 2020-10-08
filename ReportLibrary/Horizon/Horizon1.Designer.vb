Partial Class Horizon1

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horizon1))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.SqlDataSourceHorizon1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox1})
        Me.detailSection1.Name = "detailSection1"
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox1.Value = "= Fields.input_name"
        '
        'SqlDataSourceHorizon1
        '
        Me.SqlDataSourceHorizon1.ConnectionString = "Data Source=tcp:mss-iotag.database.windows.net,1433;Initial Catalog=prod_iotag_ma" &
    "ster;Persist Security Info=True;User ID=iotag_usr;Password=""M@ng@n2020="""
        Me.SqlDataSourceHorizon1.Name = "SqlDataSourceHorizon1"
        Me.SqlDataSourceHorizon1.Parameters.Add(New Telerik.Reporting.SqlDataSourceParameter("@PLID", System.Data.DbType.[String], "= Parameters.protect_layer_hash.Value"))
        Me.SqlDataSourceHorizon1.SelectCommand = resources.GetString("SqlDataSourceHorizon1.SelectCommand")
        '
        'Horizon1
        '
        Me.DataSource = Me.SqlDataSourceHorizon1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detailSection1})
        Me.Name = "Horizon1"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "PLID"
        ReportParameter1.Value = ""
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(9.6R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSourceHorizon1 As Telerik.Reporting.SqlDataSource
End Class