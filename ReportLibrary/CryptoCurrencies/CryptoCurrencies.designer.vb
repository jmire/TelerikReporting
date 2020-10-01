Partial Class CryptoCurrencies

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim NavigateToReportAction1 As Telerik.Reporting.NavigateToReportAction = New Telerik.Reporting.NavigateToReportAction()
        Dim TypeReportSource1 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim SortingAction1 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction2 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction3 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction4 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction5 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction6 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim GraphGroup1 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphTitle1 As Telerik.Reporting.GraphTitle = New Telerik.Reporting.GraphTitle()
        Dim NumericalScale1 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim NumericalScale2 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim ColorPalette1 As Telerik.Reporting.Drawing.ColorPalette = New Telerik.Reporting.Drawing.ColorPalette()
        Dim GraphGroup2 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim ColorPalette2 As Telerik.Reporting.Drawing.ColorPalette = New Telerik.Reporting.Drawing.ColorPalette()
        Dim GraphGroup3 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim NavigateToReportAction2 As Telerik.Reporting.NavigateToReportAction = New Telerik.Reporting.NavigateToReportAction()
        Dim TypeReportSource2 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.table1 = New Telerik.Reporting.Table()
        Me.textBox13 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox14 = New Telerik.Reporting.TextBox()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox15 = New Telerik.Reporting.TextBox()
        Me.textBox12 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.textBox22 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.textBox16 = New Telerik.Reporting.TextBox()
        Me.CurrenciesData = New Telerik.Reporting.ObjectDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.graph1 = New Telerik.Reporting.Graph()
        Me.polarCoordinateSystem1 = New Telerik.Reporting.PolarCoordinateSystem()
        Me.angularAxis = New Telerik.Reporting.GraphAxis()
        Me.radialAxis1 = New Telerik.Reporting.GraphAxis()
        Me.algorithmSeries = New Telerik.Reporting.BarSeries()
        Me.codeSeries = New Telerik.Reporting.BarSeries()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.reportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.htmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'table1
        '
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.681R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.968R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.028R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.682R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.967R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.186R)))
        Me.table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.252R)))
        Me.table1.Body.SetCellContent(0, 0, Me.textBox13)
        Me.table1.Body.SetCellContent(0, 1, Me.textBox9)
        Me.table1.Body.SetCellContent(0, 3, Me.textBox14)
        Me.table1.Body.SetCellContent(0, 4, Me.textBox5)
        Me.table1.Body.SetCellContent(0, 5, Me.textBox15)
        Me.table1.Body.SetCellContent(0, 2, Me.textBox12)
        TableGroup2.Name = "group4"
        TableGroup2.ReportItem = Me.textBox8
        TableGroup3.Name = "group5"
        TableGroup3.ReportItem = Me.textBox1
        TableGroup4.Name = "group7"
        TableGroup4.ReportItem = Me.textBox11
        TableGroup5.Name = "group8"
        TableGroup5.ReportItem = Me.textBox2
        TableGroup6.Name = "group9"
        TableGroup6.ReportItem = Me.textBox22
        TableGroup7.Name = "group10"
        TableGroup7.ReportItem = Me.textBox3
        TableGroup1.ChildGroups.Add(TableGroup2)
        TableGroup1.ChildGroups.Add(TableGroup3)
        TableGroup1.ChildGroups.Add(TableGroup4)
        TableGroup1.ChildGroups.Add(TableGroup5)
        TableGroup1.ChildGroups.Add(TableGroup6)
        TableGroup1.ChildGroups.Add(TableGroup7)
        TableGroup1.Name = "group"
        TableGroup1.ReportItem = Me.textBox16
        Me.table1.ColumnGroups.Add(TableGroup1)
        Me.table1.DataSource = Me.CurrenciesData
        Me.table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox13, Me.textBox9, Me.textBox12, Me.textBox14, Me.textBox5, Me.textBox15, Me.textBox16, Me.textBox8, Me.textBox1, Me.textBox11, Me.textBox2, Me.textBox22, Me.textBox3})
        Me.table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.7R))
        Me.table1.Name = "table1"
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup8.Name = "detail"
        Me.table1.RowGroups.Add(TableGroup8)
        Me.table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.512R), Telerik.Reporting.Drawing.Unit.Inch(0.746R))
        Me.table1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.MarketCap", Telerik.Reporting.SortDirection.Desc))
        Me.table1.StyleName = "Apex.TableNormal"
        '
        'textBox13
        '
        TypeReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("currencyCode", "= Fields.Code"))
        TypeReportSource1.TypeName = "CryptoCurrencyInfo, VB.ReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKey" &
    "Token=null"
        NavigateToReportAction1.ReportSource = TypeReportSource1
        Me.textBox13.Action = NavigateToReportAction1
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.681R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox13.StyleName = "Apex.TableBody"
        Me.textBox13.Value = "= ToUpper(Fields.Code)"
        '
        'textBox9
        '
        Me.textBox9.Action = NavigateToReportAction1
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.968R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox9.StyleName = "Apex.TableBody"
        Me.textBox9.Value = "= Fields.Name"
        '
        'textBox14
        '
        Me.textBox14.Action = NavigateToReportAction1
        Me.textBox14.Format = "{0:# ##0k}"
        Me.textBox14.Name = "textBox14"
        Me.textBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.682R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox14.StyleName = "Apex.TableBody"
        Me.textBox14.Value = "= Fields.Coins/1000"
        '
        'textBox5
        '
        Me.textBox5.Action = NavigateToReportAction1
        Me.textBox5.Format = "{0:$#,##.00}"
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.967R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox5.StyleName = "Apex.TableBody"
        Me.textBox5.Value = "= Fields.Price"
        '
        'textBox15
        '
        Me.textBox15.Action = NavigateToReportAction1
        Me.textBox15.Format = "{0:$#,##0M,,}"
        Me.textBox15.Name = "textBox15"
        Me.textBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.186R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox15.StyleName = "Apex.TableBody"
        Me.textBox15.Value = "= Fields.MarketCap"
        '
        'textBox12
        '
        Me.textBox12.Action = NavigateToReportAction1
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.028R), Telerik.Reporting.Drawing.Unit.Inch(0.252R))
        Me.textBox12.StyleName = "Apex.TableBody"
        Me.textBox12.Value = "= Fields.Algorithm"
        '
        'textBox8
        '
        SortingAction1.SortingExpression = "= Fields.Code"
        SortingAction1.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox8.Action = SortingAction1
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.681R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox8.StyleName = "Apex.TableHeader"
        Me.textBox8.Value = "Code"
        '
        'textBox1
        '
        SortingAction2.SortingExpression = "= Fields.Name"
        SortingAction2.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox1.Action = SortingAction2
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.968R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox1.StyleName = "Apex.TableHeader"
        Me.textBox1.Value = "Currency"
        '
        'textBox11
        '
        SortingAction3.SortingExpression = "= Fields.Algorithm"
        SortingAction3.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox11.Action = SortingAction3
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.028R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox11.StyleName = "Apex.TableHeader"
        Me.textBox11.Value = "Algorithm"
        '
        'textBox2
        '
        SortingAction4.SortingExpression = "= Fields.Coins"
        SortingAction4.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox2.Action = SortingAction4
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.682R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox2.StyleName = "Apex.TableHeader"
        Me.textBox2.Value = "Coins"
        '
        'textBox22
        '
        SortingAction5.SortingExpression = "= Fields.Price"
        SortingAction5.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox22.Action = SortingAction5
        Me.textBox22.Name = "textBox22"
        Me.textBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.967R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox22.StyleName = "Apex.TableHeader"
        Me.textBox22.Value = "Price"
        '
        'textBox3
        '
        SortingAction6.SortingExpression = "= Fields.MarketCap"
        SortingAction6.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox3.Action = SortingAction6
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.186R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox3.StyleName = "Apex.TableHeader"
        Me.textBox3.Value = "Market Cap"
        '
        'textBox16
        '
        Me.textBox16.Format = "{0:dd.MMM.yy}"
        Me.textBox16.Name = "textBox16"
        Me.textBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.512R), Telerik.Reporting.Drawing.Unit.Inch(0.294R))
        Me.textBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.textBox16.StyleName = "Apex.TableHeader"
        Me.textBox16.Value = "=Fields.Date"
        '
        'CurrenciesData
        '
        Me.CurrenciesData.DataMember = "GetData"
        Me.CurrenciesData.DataSource = GetType(CryptoDataResolver)
        Me.CurrenciesData.Name = "CurrenciesData"
        Me.CurrenciesData.Parameters.AddRange(New Telerik.Reporting.ObjectDataSourceParameter() {New Telerik.Reporting.ObjectDataSourceParameter("forDate", GetType(Date), "= Parameters.date.Value")})
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox7})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'textBox7
        '
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.4R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(24.0R)
        Me.textBox7.Value = "Crypto Currencies"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(6.5R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox6, Me.graph1, Me.table1, Me.textBox10})
        Me.detailSection1.Name = "detailSection1"
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.95R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.textBox6.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.textBox6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.textBox6.Style.Font.Bold = True
        Me.textBox6.TextWrap = False
        Me.textBox6.Value = "Click on a currency for more details."
        '
        'graph1
        '
        GraphGroup1.Name = "categoryGroup"
        Me.graph1.CategoryGroups.Add(GraphGroup1)
        Me.graph1.CoordinateSystems.Add(Me.polarCoordinateSystem1)
        Me.graph1.DataSource = Me.CurrenciesData
        Me.graph1.Legend.IsInsidePlotArea = True
        Me.graph1.Legend.Position = Telerik.Reporting.GraphItemPosition.BottomLeft
        Me.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.graph1.Legend.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(0R)
        Me.graph1.Legend.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Legend.Title = "Algorithm"
        Me.graph1.Legend.TitleStyle.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.graph1.Legend.TitleStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(20.0R)
        Me.graph1.Legend.TitleStyle.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(20.0R)
        Me.graph1.Legend.TitleStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(-10.0R)
        Me.graph1.Legend.TitleStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.graph1.Legend.TitleStyle.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.graph1.Legend.TitleStyle.Visible = True
        Me.graph1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.89R), Telerik.Reporting.Drawing.Unit.Cm(0.508R))
        Me.graph1.Name = "graph1"
        Me.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.graph1.Series.Add(Me.algorithmSeries)
        Me.graph1.Series.Add(Me.codeSeries)
        Me.graph1.SeriesGroups.Add(GraphGroup2)
        Me.graph1.SeriesGroups.Add(GraphGroup3)
        Me.graph1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.066R), Telerik.Reporting.Drawing.Unit.Cm(16.002R))
        Me.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        GraphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        GraphTitle1.Style.LineColor = System.Drawing.Color.LightGray
        GraphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        GraphTitle1.Style.Visible = False
        GraphTitle1.Text = "graph1"
        Me.graph1.Titles.Add(GraphTitle1)
        '
        'polarCoordinateSystem1
        '
        Me.polarCoordinateSystem1.AngularAxis = Me.angularAxis
        Me.polarCoordinateSystem1.Name = "polarCoordinateSystem1"
        Me.polarCoordinateSystem1.RadialAxis = Me.radialAxis1
        '
        'angularAxis
        '
        Me.angularAxis.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.angularAxis.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.angularAxis.MajorGridLineStyle.Visible = False
        Me.angularAxis.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.angularAxis.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.angularAxis.MinorGridLineStyle.Visible = False
        Me.angularAxis.Name = "angularAxis"
        Me.angularAxis.Scale = NumericalScale1
        Me.angularAxis.Style.Visible = False
        '
        'radialAxis1
        '
        Me.radialAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.radialAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.radialAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.radialAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.radialAxis1.MinorGridLineStyle.Visible = False
        Me.radialAxis1.Name = "radialAxis1"
        NumericalScale2.Minimum = 0R
        Me.radialAxis1.Scale = NumericalScale2
        Me.radialAxis1.Style.Visible = False
        '
        'algorithmSeries
        '
        Me.algorithmSeries.ArrangeByAxis = Me.radialAxis1
        Me.algorithmSeries.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100
        Me.algorithmSeries.CategoryGroup = GraphGroup1
        ColorPalette1.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer)))
        ColorPalette1.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(79, Byte), Integer)))
        ColorPalette1.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(79, Byte), Integer)))
        ColorPalette1.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(132, Byte), Integer)))
        ColorPalette1.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(219, Byte), Integer)))
        Me.algorithmSeries.ColorPalette = ColorPalette1
        Me.algorithmSeries.CoordinateSystem = Me.polarCoordinateSystem1
        Me.algorithmSeries.DataPointLabel = "= Fields.Algorithm"
        Me.algorithmSeries.DataPointLabelAlignment = Telerik.Reporting.BarDataPointLabelAlignment.Center
        Me.algorithmSeries.DataPointLabelConnectorStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.algorithmSeries.DataPointLabelConnectorStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.algorithmSeries.DataPointLabelConnectorStyle.Visible = False
        Me.algorithmSeries.DataPointLabelOffset = Telerik.Reporting.Drawing.Unit.Mm(5.0R)
        Me.algorithmSeries.DataPointLabelStyle.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.algorithmSeries.DataPointLabelStyle.Visible = True
        Me.algorithmSeries.DataPointStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.algorithmSeries.DataPointStyle.Visible = True
        Me.algorithmSeries.LegendItem.Value = "= Fields.Algorithm"
        Me.algorithmSeries.Name = "algorithmSeries"
        GraphGroup2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Algorithm"))
        GraphGroup2.Name = "algorithmGroup"
        GraphGroup2.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Algorithm", Telerik.Reporting.SortDirection.Asc))
        Me.algorithmSeries.SeriesGroup = GraphGroup2
        Me.algorithmSeries.ToolTip.Text = "= Format('{0:P}', Sum(Fields.MarketCap) / CDbl(Exec('graph1', Sum(Fields.MarketCa" &
    "p))))"
        Me.algorithmSeries.ToolTip.Title = "= Fields.Algorithm"
        Me.algorithmSeries.X = "= Sum(Fields.MarketCap)"
        Me.algorithmSeries.Y = "=0.8"
        Me.algorithmSeries.Y0 = "=0"
        '
        'codeSeries
        '
        Me.codeSeries.ArrangeByAxis = Me.radialAxis1
        Me.codeSeries.ArrangeMode = Telerik.Reporting.GraphSeriesArrangeMode.Stacked100
        Me.codeSeries.CategoryGroup = GraphGroup1
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(151, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(86, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(0, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(73, Byte), Integer)))
        ColorPalette2.Colors.Add(System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(132, Byte), Integer)))
        Me.codeSeries.ColorPalette = ColorPalette2
        Me.codeSeries.CoordinateSystem = Me.polarCoordinateSystem1
        Me.codeSeries.DataPointLabel = "= Format(""{0} {1:P2}"", ToUpper(Fields.Code), Sum(Fields.MarketCap) / CDbl(Exec('g" &
    "raph1', Sum(Fields.MarketCap))))"
        Me.codeSeries.DataPointLabelConnectorStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.codeSeries.DataPointLabelConnectorStyle.Padding.Top = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.codeSeries.DataPointLabelConnectorStyle.Visible = False
        Me.codeSeries.DataPointLabelOffset = Telerik.Reporting.Drawing.Unit.Mm(2.0R)
        Me.codeSeries.LegendItem.Style.Visible = False
        Me.codeSeries.LegendItem.Value = "= Fields.Code"
        Me.codeSeries.Name = "codeSeries"
        TypeReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("currencyCode", "= Fields.Code"))
        TypeReportSource2.TypeName = "CryptoCurrencyInfo, VB.ReportLibrary, Version=1.0.0.0, Culture=neutral, PublicKey" &
    "Token=null"
        NavigateToReportAction2.ReportSource = TypeReportSource2
        GraphGroup3.Action = NavigateToReportAction2
        GraphGroup3.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Code"))
        GraphGroup3.Name = "codeGroup"
        GraphGroup3.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Algorithm", Telerik.Reporting.SortDirection.Asc))
        Me.codeSeries.SeriesGroup = GraphGroup3
        Me.codeSeries.ToolTip.Text = "= Format('{0:P}', Sum(Fields.MarketCap) / CDbl(Exec('graph1', Sum(Fields.MarketCa" &
    "p))))"
        Me.codeSeries.ToolTip.Title = "= Fields.Name"
        Me.codeSeries.X = "=Sum( Fields.MarketCap)"
        Me.codeSeries.Y = "=1"
        Me.codeSeries.Y0 = "=0.8"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.2R), Telerik.Reporting.Drawing.Unit.Inch(0.3R))
        Me.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.textBox10.Value = "Compare crypto currencies based on market cap."
        '
        'reportFooterSection1
        '
        Me.reportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.reportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.htmlTextBox1})
        Me.reportFooterSection1.Name = "reportFooterSection1"
        '
        'htmlTextBox1
        '
        Me.htmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.htmlTextBox1.Name = "htmlTextBox1"
        Me.htmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.762R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.htmlTextBox1.Value = "Reference:<br /><a href=""https://coinmetrics.io/data-downloads/"">https://coinmetr" &
    "ics.io/data-downloads/</a>"
        '
        'CryptoCurrencies
        '
        Me.DocumentName = "Crypto Currencies"
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1, Me.reportFooterSection1})
        Me.Name = "CryptoCurrencies"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.AutoRefresh = True
        ReportParameter1.Name = "date"
        ReportParameter1.Text = "For Date:"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter1.Value = "= today()"
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.Font.Name = "Segoe UI"
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Apex.TableNormal")})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Segoe UI"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableBody")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.Black
        StyleRule4.Style.Font.Name = "Segoe UI"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableHeader")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(88, Byte), Integer))
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Color = System.Drawing.Color.White
        StyleRule5.Style.Font.Name = "Segoe UI"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(11.4R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents CurrenciesData As Telerik.Reporting.ObjectDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents graph1 As Telerik.Reporting.Graph
    Friend WithEvents polarCoordinateSystem1 As Telerik.Reporting.PolarCoordinateSystem
    Friend WithEvents angularAxis As Telerik.Reporting.GraphAxis
    Friend WithEvents radialAxis1 As Telerik.Reporting.GraphAxis
    Friend WithEvents algorithmSeries As Telerik.Reporting.BarSeries
    Friend WithEvents codeSeries As Telerik.Reporting.BarSeries
    Friend WithEvents table1 As Telerik.Reporting.Table
    Friend WithEvents textBox13 As Telerik.Reporting.TextBox
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents textBox14 As Telerik.Reporting.TextBox
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox15 As Telerik.Reporting.TextBox
    Friend WithEvents textBox12 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox11 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents textBox22 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox16 As Telerik.Reporting.TextBox
    Friend WithEvents textBox10 As Telerik.Reporting.TextBox
    Friend WithEvents reportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents htmlTextBox1 As Telerik.Reporting.HtmlTextBox
End Class