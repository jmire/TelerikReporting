Partial Class CryptoCurrencyInfo

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim DataColumn1 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn2 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn3 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn4 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn5 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim NavigateToReportAction1 As Telerik.Reporting.NavigateToReportAction = New Telerik.Reporting.NavigateToReportAction()
        Dim TypeReportSource1 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim GraphGroup1 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup2 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim ColorPalette1 As Telerik.Reporting.Drawing.ColorPalette = New Telerik.Reporting.Drawing.ColorPalette()
        Dim GraphTitle1 As Telerik.Reporting.GraphTitle = New Telerik.Reporting.GraphTitle()
        Dim DateTimeScale1 As Telerik.Reporting.DateTimeScale = New Telerik.Reporting.DateTimeScale()
        Dim DateTimeScaleCrossAxisPosition1 As Telerik.Reporting.DateTimeScaleCrossAxisPosition = New Telerik.Reporting.DateTimeScaleCrossAxisPosition()
        Dim DateTimeScaleCrossAxisPosition2 As Telerik.Reporting.DateTimeScaleCrossAxisPosition = New Telerik.Reporting.DateTimeScaleCrossAxisPosition()
        Dim NumericalScale1 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim NumericalScale2 As Telerik.Reporting.NumericalScale = New Telerik.Reporting.NumericalScale()
        Dim GraphGroup3 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim GraphGroup4 As Telerik.Reporting.GraphGroup = New Telerik.Reporting.GraphGroup()
        Dim ShapeMapGroup1 As Telerik.Reporting.ShapeMapGroup = New Telerik.Reporting.ShapeMapGroup()
        Dim GeoLocationMapGroup1 As Telerik.Reporting.GeoLocationMapGroup = New Telerik.Reporting.GeoLocationMapGroup()
        Dim MapLegend1 As Telerik.Reporting.MapLegend = New Telerik.Reporting.MapLegend()
        Dim MercatorProjection1 As Telerik.Reporting.MercatorProjection = New Telerik.Reporting.MercatorProjection()
        Dim MapTitle1 As Telerik.Reporting.MapTitle = New Telerik.Reporting.MapTitle()
        Dim GradientPalette1 As Telerik.Reporting.Drawing.GradientPalette = New Telerik.Reporting.Drawing.GradientPalette()
        Dim MapGroup1 As Telerik.Reporting.MapGroup = New Telerik.Reporting.MapGroup()
        Dim EsriShapeFileSourceType1 As Telerik.Reporting.EsriShapeFileSourceType = New Telerik.Reporting.EsriShapeFileSourceType()
        Dim MapRelationPair1 As Telerik.Reporting.MapRelationPair = New Telerik.Reporting.MapRelationPair()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim NavigateToReportAction2 As Telerik.Reporting.NavigateToReportAction = New Telerik.Reporting.NavigateToReportAction()
        Dim TypeReportSource2 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CryptoCurrencyInfo))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.dsData = New Telerik.Reporting.CsvDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.graph1 = New Telerik.Reporting.Graph()
        Me.cartesianCoordinateSystem1 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.graphAxis2 = New Telerik.Reporting.GraphAxis()
        Me.graphAxis1 = New Telerik.Reporting.GraphAxis()
        Me.cartesianCoordinateSystem3 = New Telerik.Reporting.CartesianCoordinateSystem()
        Me.GraphAxis3 = New Telerik.Reporting.GraphAxis()
        Me.lineSeriesPrice = New Telerik.Reporting.LineSeries()
        Me.lineSeriesCoins = New Telerik.Reporting.LineSeries()
        Me.map2 = New Telerik.Reporting.Map()
        Me.shapeMapSeries1 = New Telerik.Reporting.ShapeMapSeries()
        Me.PointMapSeries1 = New Telerik.Reporting.PointMapSeries()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.htmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.details = New Telerik.Reporting.ObjectDataSource()
        Me.CurrenciesList = New Telerik.Reporting.ObjectDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'dsData
        '
        Me.dsData.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("RiskPercent", GetType(Integer), "= Fields.RiskIndex/5*100")})
        DataColumn1.Name = "Country"
        DataColumn2.Name = "RiskIndex"
        DataColumn2.Type = Telerik.Reporting.SimpleType.Float
        DataColumn3.Name = "TSI"
        DataColumn3.Type = Telerik.Reporting.SimpleType.[Integer]
        DataColumn4.Name = "Lat"
        DataColumn4.Type = Telerik.Reporting.SimpleType.Float
        DataColumn5.Name = "Long"
        DataColumn5.Type = Telerik.Reporting.SimpleType.Float
        Me.dsData.Columns.Add(DataColumn1)
        Me.dsData.Columns.Add(DataColumn2)
        Me.dsData.Columns.Add(DataColumn3)
        Me.dsData.Columns.Add(DataColumn4)
        Me.dsData.Columns.Add(DataColumn5)
        Me.dsData.FieldSeparators = New Char() {Global.Microsoft.VisualBasic.ChrW(44)}
        Me.dsData.HasHeaders = True
        Me.dsData.Name = "dsData"
        Me.dsData.RecordSeparators = New Char() {Global.Microsoft.VisualBasic.ChrW(13), Global.Microsoft.VisualBasic.ChrW(10)}
        Me.dsData.Source = "Country,RiskIndex,TSI,Lat,Long" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "China,81,0,40.0, 105.737707" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iceland,5,0,64.8, -1" &
    "8.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Japan,3,0,35.435666, 148.737707" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Czech Republic,3,0,53.0,19.467" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Georgia,2." &
    "4,0,38.7,47.8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "India,2,0,19,78"
        Me.dsData.ThousandSeparator = ""
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.500039279460907R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox9})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'textBox9
        '
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.5999608039855957R), Telerik.Reporting.Drawing.Unit.Inch(0.49999991059303284R))
        Me.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.textBox9.Value = "=""Details for "" + ToUpper(Parameters.currencyCode.Value)"
        '
        'detailSection1
        '
        Me.detailSection1.CanShrink = True
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(10.500000953674316R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.graph1, Me.map2, Me.textBox2, Me.htmlTextBox1})
        Me.detailSection1.Name = "detailSection1"
        '
        'graph1
        '
        TypeReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("currencyCode", "= Parameters.currencyCode.Value"))
        TypeReportSource1.TypeName = "CryptoCurrencyRawData, VB.ReportLibrary, Version=1.0.0.0, Culture=neutral, Public" &
    "KeyToken=null"
        NavigateToReportAction1.ReportSource = TypeReportSource1
        Me.graph1.Action = NavigateToReportAction1
        GraphGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Date"))
        GraphGroup1.Name = "dateGroup"
        GraphGroup1.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Date", Telerik.Reporting.SortDirection.Asc))
        GraphGroup2.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Date"))
        GraphGroup2.Name = "dateGroup1"
        GraphGroup2.Sortings.Add(New Telerik.Reporting.Sorting("= Fields.Date", Telerik.Reporting.SortDirection.Asc))
        Me.graph1.CategoryGroups.Add(GraphGroup1)
        Me.graph1.CategoryGroups.Add(GraphGroup2)
        ColorPalette1.Colors.Add(System.Drawing.Color.DodgerBlue)
        ColorPalette1.Colors.Add(System.Drawing.Color.MediumVioletRed)
        Me.graph1.ColorPalette = ColorPalette1
        Me.graph1.CoordinateSystems.Add(Me.cartesianCoordinateSystem1)
        Me.graph1.CoordinateSystems.Add(Me.cartesianCoordinateSystem3)
        Me.graph1.DataSource = Me.details
        Me.graph1.Filters.Add(New Telerik.Reporting.Filter("= Fields.Date", Telerik.Reporting.FilterOperator.GreaterThan, "= Parameters.fromDate.Value"))
        Me.graph1.Filters.Add(New Telerik.Reporting.Filter("= Fields.Date", Telerik.Reporting.FilterOperator.LessOrEqual, "= Parameters.toDate.Value"))
        Me.graph1.Legend.IsInsidePlotArea = True
        Me.graph1.Legend.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        Me.graph1.Legend.Style.LineColor = System.Drawing.Color.LightGray
        Me.graph1.Legend.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.graph1.Name = "graph1"
        Me.graph1.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.graph1.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.graph1.Series.Add(Me.lineSeriesPrice)
        Me.graph1.Series.Add(Me.lineSeriesCoins)
        Me.graph1.SeriesGroups.Add(GraphGroup3)
        Me.graph1.SeriesGroups.Add(GraphGroup4)
        Me.graph1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.799961090087891R), Telerik.Reporting.Drawing.Unit.Inch(2.5R))
        Me.graph1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.graph1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        GraphTitle1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        GraphTitle1.Style.LineColor = System.Drawing.Color.LightGray
        GraphTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0R)
        GraphTitle1.Style.Visible = False
        GraphTitle1.Text = "graph1"
        Me.graph1.Titles.Add(GraphTitle1)
        '
        'cartesianCoordinateSystem1
        '
        Me.cartesianCoordinateSystem1.Name = "cartesianCoordinateSystem1"
        Me.cartesianCoordinateSystem1.XAxis = Me.graphAxis2
        Me.cartesianCoordinateSystem1.YAxis = Me.graphAxis1
        '
        'graphAxis2
        '
        Me.graphAxis2.LabelFormat = "{0:MMM.yy}"
        Me.graphAxis2.MajorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis2.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis2.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis2.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis2.MinorGridLineStyle.Visible = False
        Me.graphAxis2.Name = "graphAxis2"
        DateTimeScaleCrossAxisPosition1.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMaximum
        DateTimeScaleCrossAxisPosition1.Value = New Date(CType(0, Long))
        DateTimeScaleCrossAxisPosition2.Position = Telerik.Reporting.GraphScaleCrossAxisPosition.AtMinimum
        DateTimeScaleCrossAxisPosition2.Value = New Date(CType(0, Long))
        DateTimeScale1.CrossAxisPositions.Add(DateTimeScaleCrossAxisPosition1)
        DateTimeScale1.CrossAxisPositions.Add(DateTimeScaleCrossAxisPosition2)
        DateTimeScale1.LabelStep = 4
        DateTimeScale1.LabelUnit = Telerik.Reporting.DateTimeScaleUnits.Months
        DateTimeScale1.MajorStep = 4
        DateTimeScale1.MajorUnit = Telerik.Reporting.DateTimeScaleUnits.Months
        DateTimeScale1.MinorUnit = Telerik.Reporting.DateTimeScaleUnits.Years
        Me.graphAxis2.Scale = DateTimeScale1
        '
        'graphAxis1
        '
        Me.graphAxis1.LabelFormat = "{0:$0}"
        Me.graphAxis1.MajorGridLineStyle.LineColor = System.Drawing.Color.LightSteelBlue
        Me.graphAxis1.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis1.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.graphAxis1.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.graphAxis1.MinorGridLineStyle.Visible = False
        Me.graphAxis1.Name = "graphAxis1"
        Me.graphAxis1.Scale = NumericalScale1
        Me.graphAxis1.Style.Color = System.Drawing.Color.DodgerBlue
        Me.graphAxis1.Style.LineColor = System.Drawing.Color.DodgerBlue
        '
        'cartesianCoordinateSystem3
        '
        Me.cartesianCoordinateSystem3.Name = "cartesianCoordinateSystem3"
        Me.cartesianCoordinateSystem3.XAxis = Me.graphAxis2
        Me.cartesianCoordinateSystem3.YAxis = Me.GraphAxis3
        '
        'GraphAxis3
        '
        Me.GraphAxis3.LabelFormat = "{0:#,##0M,,}"
        Me.GraphAxis3.MajorGridLineStyle.LineColor = System.Drawing.Color.MistyRose
        Me.GraphAxis3.MajorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.LineColor = System.Drawing.Color.LightGray
        Me.GraphAxis3.MinorGridLineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.GraphAxis3.MinorGridLineStyle.Visible = False
        Me.GraphAxis3.Name = "GraphAxis1"
        Me.GraphAxis3.Scale = NumericalScale2
        Me.GraphAxis3.Style.Color = System.Drawing.Color.MediumVioletRed
        Me.GraphAxis3.Style.LineColor = System.Drawing.Color.MediumVioletRed
        '
        'lineSeriesPrice
        '
        Me.lineSeriesPrice.CategoryGroup = GraphGroup1
        Me.lineSeriesPrice.CoordinateSystem = Me.cartesianCoordinateSystem1
        Me.lineSeriesPrice.DataPointLabel = "= Sum(Fields.Price)"
        Me.lineSeriesPrice.DataPointLabelStyle.Visible = False
        Me.lineSeriesPrice.DataPointStyle.Visible = False
        Me.lineSeriesPrice.LegendItem.Value = "Price"
        Me.lineSeriesPrice.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.lineSeriesPrice.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50.0R)
        Me.lineSeriesPrice.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.lineSeriesPrice.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.lineSeriesPrice.Name = "lineSeriesPrice"
        GraphGroup3.Name = "seriesGroup"
        Me.lineSeriesPrice.SeriesGroup = GraphGroup3
        Me.lineSeriesPrice.Size = Nothing
        Me.lineSeriesPrice.ToolTip.Text = "= Sum(Fields.Price)"
        Me.lineSeriesPrice.ToolTip.Title = "Price"
        Me.lineSeriesPrice.X = "= Fields.Date"
        Me.lineSeriesPrice.Y = "= Sum(Fields.Price)"
        '
        'lineSeriesCoins
        '
        Me.lineSeriesCoins.CategoryGroup = GraphGroup2
        Me.lineSeriesCoins.CoordinateSystem = Me.cartesianCoordinateSystem3
        Me.lineSeriesCoins.DataPointLabel = "= Fields.MarketCap"
        Me.lineSeriesCoins.DataPointLabelStyle.Visible = False
        Me.lineSeriesCoins.DataPointStyle.Visible = False
        Me.lineSeriesCoins.LegendItem.Value = "Market cap"
        Me.lineSeriesCoins.LineStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.lineSeriesCoins.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Pixel(50.0R)
        Me.lineSeriesCoins.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.lineSeriesCoins.MarkerSize = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.lineSeriesCoins.Name = "lineSeriesCoins"
        GraphGroup4.Name = "seriesGroup1"
        Me.lineSeriesCoins.SeriesGroup = GraphGroup4
        Me.lineSeriesCoins.Size = Nothing
        Me.lineSeriesCoins.ToolTip.Text = "= Fields.MarketCap"
        Me.lineSeriesCoins.ToolTip.Title = "Coins"
        Me.lineSeriesCoins.X = "= Fields.Date"
        Me.lineSeriesCoins.Y = "= Fields.MarketCap"
        '
        'map2
        '
        Me.map2.Bindings.Add(New Telerik.Reporting.Binding("Visible", "= Parameters.currencyCode.Value = ""btc"""))
        Me.map2.ColorPalette = Nothing
        Me.map2.DataSource = Me.dsData
        Me.map2.Extent.LatitudeMax = 74.393967649013874R
        Me.map2.Extent.LatitudeMin = -20.886359822167741R
        Me.map2.Extent.LongitudeMax = 169.84247446060181R
        Me.map2.Extent.LongitudeMin = -40.861018896102905R
        ShapeMapGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.CNTRY_NAME"))
        ShapeMapGroup1.Name = "categoryGroup1"
        GeoLocationMapGroup1.Filters.Add(New Telerik.Reporting.Filter("= Fields.Country is Null", Telerik.Reporting.FilterOperator.Equal, "=False"))
        GeoLocationMapGroup1.Groupings.Add(New Telerik.Reporting.Grouping("= Fields.Country"))
        GeoLocationMapGroup1.Name = "geoLocationMapGroup"
        Me.map2.GeoLocationGroups.Add(ShapeMapGroup1)
        Me.map2.GeoLocationGroups.Add(GeoLocationMapGroup1)
        MapLegend1.IsInsidePlotArea = True
        MapLegend1.Position = Telerik.Reporting.GraphItemPosition.TopCenter
        MapLegend1.Style.LineColor = System.Drawing.Color.LightGray
        MapLegend1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        MapLegend1.Title = "Mining Pools %"
        MapLegend1.TitleStyle.Font.Bold = True
        MapLegend1.TitleStyle.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(6.0R)
        MapLegend1.TitleStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.map2.Legends.Add(MapLegend1)
        Me.map2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R))
        Me.map2.Meridians.Style.LineColor = System.Drawing.Color.LightGray
        Me.map2.Name = "map2"
        Me.map2.Parallels.Style.LineColor = System.Drawing.Color.LightGray
        Me.map2.PlotAreaStyle.LineColor = System.Drawing.Color.LightGray
        Me.map2.PlotAreaStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.map2.Projection = MercatorProjection1
        Me.map2.ScaleLegend.ItemStyle.BorderColor.Default = System.Drawing.Color.White
        Me.map2.ScaleLegend.ItemStyle.LineColor = System.Drawing.Color.DodgerBlue
        Me.map2.ScaleLegend.ItemStyle.LineWidth = Telerik.Reporting.Drawing.Unit.Pixel(2.0R)
        Me.map2.ScaleLegend.ItemStyle.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.map2.ScaleLegend.ItemStyle.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(5.0R)
        Me.map2.ScaleLegend.ItemStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.map2.ScaleLegend.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.map2.Series.Add(Me.shapeMapSeries1)
        Me.map2.Series.Add(Me.PointMapSeries1)
        Me.map2.SeriesGroups.Add(MapGroup1)
        Me.map2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(10.236221313476563R), Telerik.Reporting.Drawing.Unit.Cm(18.034002304077148R))
        Me.map2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.map2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.map2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        Me.map2.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(10.0R)
        MapTitle1.Style.LineColor = System.Drawing.Color.LightGray
        MapTitle1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Cm(0R)
        MapTitle1.Text = ""
        Me.map2.Titles.Add(MapTitle1)
        '
        'shapeMapSeries1
        '
        Me.shapeMapSeries1.ColorData = "= Fields.RiskIndex"
        GradientPalette1.BeginColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(168, Byte), Integer))
        GradientPalette1.EndColor = System.Drawing.Color.Maroon
        Me.shapeMapSeries1.ColorPalette = GradientPalette1
        Me.shapeMapSeries1.ColorsCount = 4
        Me.shapeMapSeries1.DataPointLabel = "{Fields.CNTRY_NAME}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "({Sum(Fields.[RiskIndex])})"
        Me.shapeMapSeries1.DataPointLabelStyle.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.shapeMapSeries1.DataPointLabelStyle.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.shapeMapSeries1.DataPointLabelStyle.Visible = False
        Me.shapeMapSeries1.DataPointStyle.LineColor = System.Drawing.Color.Gray
        Me.shapeMapSeries1.DataPointStyle.Visible = True
        Me.shapeMapSeries1.LegendItem.Value = "= RangeMax"
        Me.shapeMapSeries1.Name = "shapeMapSeries1"
        Me.shapeMapSeries1.RangeGrouping = Telerik.Reporting.ShapeMapSeries.RangeGroupings.EqualDistribution
        MapGroup1.Name = "seriesGroup1"
        Me.shapeMapSeries1.SeriesGroup = MapGroup1
        Me.shapeMapSeries1.ShapeMapGroup = ShapeMapGroup1
        EsriShapeFileSourceType1.FileName = "./Resources/world.shp"
        MapRelationPair1.AnalyticalField = "= Fields.Country"
        MapRelationPair1.ShapeFileField = "= Fields.CNTRY_NAME"
        EsriShapeFileSourceType1.RelationPairs.Add(MapRelationPair1)
        Me.shapeMapSeries1.SourceType = EsriShapeFileSourceType1
        '
        'PointMapSeries1
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.LessThan, "=2.4"))
        FormattingRule1.Style.LineColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(145, Byte), Integer))
        FormattingRule1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=2.4"))
        FormattingRule2.Style.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(79, Byte), Integer))
        FormattingRule2.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=3.5"))
        FormattingRule3.Style.LineColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(79, Byte), Integer))
        FormattingRule3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("= Fields.RiskIndex", Telerik.Reporting.FilterOperator.GreaterOrEqual, "=4"))
        FormattingRule4.Style.LineColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(132, Byte), Integer))
        FormattingRule4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.PointMapSeries1.DataPointConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1, FormattingRule2, FormattingRule3, FormattingRule4})
        Me.PointMapSeries1.DataPointLabel = "=Format('" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Region: {0}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pools: {1}%, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PH/s: {2}', " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fields.Country, Fields.RiskI" &
    "ndex, 12000*Fields.RiskIndex/100)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.PointMapSeries1.DataPointLabelAlignment = Telerik.Reporting.LineDataPointLabelAlignment.Center
        Me.PointMapSeries1.DataPointLabelStyle.Color = System.Drawing.Color.White
        Me.PointMapSeries1.DataPointLabelStyle.Font.Bold = False
        Me.PointMapSeries1.DataPointStyle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PointMapSeries1.GeoLocationGroup = GeoLocationMapGroup1
        Me.PointMapSeries1.Latitude = "= Fields.Lat"
        Me.PointMapSeries1.LegendItem.Style.Visible = False
        Me.PointMapSeries1.Longitude = "= Fields.Long"
        Me.PointMapSeries1.MarkerMaxSize = Telerik.Reporting.Drawing.Unit.Cm(4.0R)
        Me.PointMapSeries1.MarkerMinSize = Telerik.Reporting.Drawing.Unit.Cm(4.0R)
        Me.PointMapSeries1.MarkerType = Telerik.Reporting.DataPointMarkerType.Circle
        Me.PointMapSeries1.SeriesGroup = MapGroup1
        Me.PointMapSeries1.Size = "= Fields.TSI"
        '
        'textBox2
        '
        TypeReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("currencyCode", "= Parameters.currencyCode.Value"))
        TypeReportSource2.TypeName = "CryptoCurrencyRawData, VB.ReportLibrary, Version=1.0.0.0, Culture=neutral, Public" &
    "KeyToken=null"
        NavigateToReportAction2.ReportSource = TypeReportSource2
        Me.textBox2.Action = NavigateToReportAction2
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.5000789165496826R), Telerik.Reporting.Drawing.Unit.Inch(9.90000057220459R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394R), Telerik.Reporting.Drawing.Unit.Inch(0.19995880126953125R))
        Me.textBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.textBox2.Style.Font.Underline = True
        Me.textBox2.Value = "Raw data."
        '
        'htmlTextBox1
        '
        Me.htmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(9.7000818252563477R))
        Me.htmlTextBox1.Name = "htmlTextBox1"
        Me.htmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.4999606609344482R), Telerik.Reporting.Drawing.Unit.Inch(0.79987972974777222R))
        Me.htmlTextBox1.Value = resources.GetString("htmlTextBox1.Value")
        '
        'details
        '
        Me.details.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("MarketCapInThous", GetType(UInteger), "= Fields.MarketCap/1000")})
        Me.details.DataMember = "GetDetails"
        Me.details.DataSource = GetType(CryptoDataResolver)
        Me.details.Name = "details"
        Me.details.Parameters.AddRange(New Telerik.Reporting.ObjectDataSourceParameter() {New Telerik.Reporting.ObjectDataSourceParameter("currencyCode", GetType(String), "= Parameters.currencyCode.Value")})
        '
        'CurrenciesList
        '
        Me.CurrenciesList.DataMember = "GetData"
        Me.CurrenciesList.DataSource = GetType(CryptoDataResolver)
        Me.CurrenciesList.Name = "CurrenciesList"
        Me.CurrenciesList.Parameters.AddRange(New Telerik.Reporting.ObjectDataSourceParameter() {New Telerik.Reporting.ObjectDataSourceParameter("forDate", GetType(Date), "= Parameters.toDate.Value")})
        '
        'CryptocurrencyInfo
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1})
        Me.Name = "CryptoCurrencyInfo"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.AutoRefresh = True
        ReportParameter1.AvailableValues.DataSource = Me.CurrenciesList
        ReportParameter1.AvailableValues.DisplayMember = "= Fields.Name"
        ReportParameter1.AvailableValues.ValueMember = "= Fields.Code"
        ReportParameter1.Name = "currencyCode"
        ReportParameter1.Text = "Crypto Currency"
        ReportParameter1.Value = "btc"
        ReportParameter1.Visible = True
        ReportParameter2.AutoRefresh = True
        ReportParameter2.Name = "fromDate"
        ReportParameter2.Text = "From Date"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter2.Value = "= AddYears(today(), - 1)"
        ReportParameter2.Visible = True
        ReportParameter3.AutoRefresh = True
        ReportParameter3.Name = "toDate"
        ReportParameter3.Text = "To Date"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.DateTime
        ReportParameter3.Value = "=today()"
        ReportParameter3.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
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
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableBody")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Font.Name = "Segoe UI"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableHeader")})
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule5.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(109, Byte), Integer))
        StyleRule5.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(102, Byte), Integer))
        StyleRule5.Style.Font.Name = "Segoe UI"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(10.800000190734863R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents details As Telerik.Reporting.ObjectDataSource
    Friend WithEvents dsData As Telerik.Reporting.CsvDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents graph1 As Telerik.Reporting.Graph
    Friend WithEvents cartesianCoordinateSystem1 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents graphAxis2 As Telerik.Reporting.GraphAxis
    Friend WithEvents graphAxis1 As Telerik.Reporting.GraphAxis
    Friend WithEvents cartesianCoordinateSystem3 As Telerik.Reporting.CartesianCoordinateSystem
    Friend WithEvents GraphAxis3 As Telerik.Reporting.GraphAxis
    Friend WithEvents lineSeriesPrice As Telerik.Reporting.LineSeries
    Friend WithEvents lineSeriesCoins As Telerik.Reporting.LineSeries
    Friend WithEvents map2 As Telerik.Reporting.Map
    Friend WithEvents shapeMapSeries1 As Telerik.Reporting.ShapeMapSeries
    Friend WithEvents PointMapSeries1 As Telerik.Reporting.PointMapSeries
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents htmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Private components As ComponentModel.IContainer
    Private WithEvents CurrenciesList As Telerik.Reporting.ObjectDataSource
End Class