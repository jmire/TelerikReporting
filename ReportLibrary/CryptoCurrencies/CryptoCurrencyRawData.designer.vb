Partial Class CryptoCurrencyRawData

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim SortingAction1 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction2 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction3 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim SortingAction4 As Telerik.Reporting.SortingAction = New Telerik.Reporting.SortingAction()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.CurrenciesList = New Telerik.Reporting.ObjectDataSource()
        Me.details = New Telerik.Reporting.ObjectDataSource()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.table1 = New Telerik.Reporting.Table()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.htmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'CurrenciesList
        '
        '
        'details
        '
        Me.details.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("MarketCapInThous", GetType(UInteger), "= Fields.MarketCap/1000")})
        Me.details.DataMember = "GetDetails"
        Me.details.DataSource = GetType(CryptoDataResolver)
        Me.details.Name = "details"
        Me.details.Parameters.AddRange(New Telerik.Reporting.ObjectDataSourceParameter() {New Telerik.Reporting.ObjectDataSourceParameter("currencyCode", GetType(String), "= Parameters.currencyCode.Value")})
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40003934502601624R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox9})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'textBox9
        '
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.8000006675720215R), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448R))
        Me.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.textBox9.Value = "= ""Raw Data for "" + ToUpper(Parameters.currencyCode.Value)"
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.table1, Me.htmlTextBox1})
        Me.detailSection1.Name = "detailSection1"
        Me.detailSection1.Style.Font.Name = "Segoe UI"
        '
        'table1
        '
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R)))
        Me.table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.9045617580413818R)))
        Me.table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651R)))
        Me.table1.Body.SetCellContent(0, 0, Me.textBox5)
        Me.table1.Body.SetCellContent(0, 1, Me.textBox6)
        Me.table1.Body.SetCellContent(0, 2, Me.textBox7)
        Me.table1.Body.SetCellContent(0, 3, Me.textBox8)
        TableGroup1.Name = "date"
        TableGroup1.ReportItem = Me.textBox1
        TableGroup2.Name = "price"
        TableGroup2.ReportItem = Me.textBox2
        TableGroup3.Name = "coins"
        TableGroup3.ReportItem = Me.textBox3
        TableGroup4.Name = "marketCap"
        TableGroup4.ReportItem = Me.textBox4
        Me.table1.ColumnGroups.Add(TableGroup1)
        Me.table1.ColumnGroups.Add(TableGroup2)
        Me.table1.ColumnGroups.Add(TableGroup3)
        Me.table1.ColumnGroups.Add(TableGroup4)
        Me.table1.DataSource = Me.details
        Me.table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox5, Me.textBox6, Me.textBox7, Me.textBox8, Me.textBox1, Me.textBox2, Me.textBox3, Me.textBox4})
        Me.table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.table1.Name = "table1"
        TableGroup5.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup5.Name = "detail"
        Me.table1.RowGroups.Add(TableGroup5)
        Me.table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.7999997138977051R), Telerik.Reporting.Drawing.Unit.Inch(0.593710720539093R))
        Me.table1.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.table1.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.table1.Style.BorderColor.Right = System.Drawing.Color.Black
        Me.table1.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.table1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.table1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.table1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid
        Me.table1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.table1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.table1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.table1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.table1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.table1.StyleName = "Apex.TableNormal"
        '
        'textBox5
        '
        Me.textBox5.Format = "{0:d}"
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651R))
        Me.textBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.textBox5.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox5.StyleName = "Apex.TableBody"
        Me.textBox5.Value = "= Fields.Date"
        '
        'textBox6
        '
        Me.textBox6.Format = "{0:C2}"
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651R))
        Me.textBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.textBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox6.StyleName = "Apex.TableBody"
        Me.textBox6.Value = "= Fields.Price"
        '
        'textBox7
        '
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651R))
        Me.textBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.textBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox7.StyleName = "Apex.TableBody"
        Me.textBox7.Value = "= Fields.Coins"
        '
        'textBox8
        '
        Me.textBox8.Format = "{0:C0}"
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9045618772506714R), Telerik.Reporting.Drawing.Unit.Inch(0.31248036026954651R))
        Me.textBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        Me.textBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox8.StyleName = "Apex.TableBody"
        Me.textBox8.Value = "= Fields.MarketCap"
        '
        'textBox1
        '
        SortingAction1.SortingExpression = "= Fields.Date"
        SortingAction1.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox1.Action = SortingAction1
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651R))
        Me.textBox1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textBox1.Style.Color = System.Drawing.Color.White
        Me.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox1.StyleName = "Apex.TableHeader"
        Me.textBox1.Value = "Date"
        '
        'textBox2
        '
        SortingAction2.SortingExpression = "= Fields.Price"
        SortingAction2.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox2.Action = SortingAction2
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651R))
        Me.textBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textBox2.Style.Color = System.Drawing.Color.White
        Me.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox2.StyleName = "Apex.TableHeader"
        Me.textBox2.Value = "Price"
        '
        'textBox3
        '
        SortingAction3.SortingExpression = "= Fields.Coins"
        SortingAction3.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox3.Action = SortingAction3
        Me.textBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.298479437828064R), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651R))
        Me.textBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textBox3.Style.Color = System.Drawing.Color.White
        Me.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox3.StyleName = "Apex.TableHeader"
        Me.textBox3.Value = "Coins"
        '
        'textBox4
        '
        SortingAction4.SortingExpression = "= Fields.MarketCap"
        SortingAction4.Targets.AddRange(New Telerik.Reporting.IActionTarget() {Me.table1})
        Me.textBox4.Action = SortingAction4
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9045617580413818R), Telerik.Reporting.Drawing.Unit.Inch(0.28123036026954651R))
        Me.textBox4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textBox4.Style.Color = System.Drawing.Color.White
        Me.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.textBox4.StyleName = "Apex.TableHeader"
        Me.textBox4.Value = "Market Cap"
        '
        'htmlTextBox1
        '
        Me.htmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.79996079206466675R))
        Me.htmlTextBox1.Name = "htmlTextBox1"
        Me.htmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4999606609344482R), Telerik.Reporting.Drawing.Unit.Inch(0.40000009536743164R))
        Me.htmlTextBox1.Value = "Reference:<br /><a href=""https://coinmetrics.io/data-downloads/"">https://coinmetr" &
    "ics.io/data-downloads/</a>"
        Me.CurrenciesList.DataMember = "GetData"
        Me.CurrenciesList.DataSource = GetType(CryptoDataResolver)
        Me.CurrenciesList.Name = "CurrenciesList"
        Me.CurrenciesList.Parameters.AddRange(New Telerik.Reporting.ObjectDataSourceParameter() {New Telerik.Reporting.ObjectDataSourceParameter("forDate", GetType(Date), "= Today()")})
        '
        'CryptocurrencyRaw
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detailSection1})
        Me.Name = "CryptoCurrenciesRawData"
        Me.PageSettings.ColumnCount = 1
        Me.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0R)
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.AutoRefresh = True
        ReportParameter1.AvailableValues.DataSource = Me.CurrenciesList
        ReportParameter1.AvailableValues.DisplayMember = "= Fields.Name"
        ReportParameter1.AvailableValues.ValueMember = "= Fields.Code"
        ReportParameter1.Name = "currencyCode"
        ReportParameter1.Text = "Cryptocurrency"
        ReportParameter1.Value = "btc"
        ReportParameter1.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.Font.Name = "Segoe UI"
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(6.5R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents CurrenciesList As Telerik.Reporting.ObjectDataSource
    Friend WithEvents details As Telerik.Reporting.ObjectDataSource
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents textBox9 As Telerik.Reporting.TextBox
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents table1 As Telerik.Reporting.Table
    Friend WithEvents textBox5 As Telerik.Reporting.TextBox
    Friend WithEvents textBox6 As Telerik.Reporting.TextBox
    Friend WithEvents textBox7 As Telerik.Reporting.TextBox
    Friend WithEvents textBox8 As Telerik.Reporting.TextBox
    Friend WithEvents textBox1 As Telerik.Reporting.TextBox
    Friend WithEvents textBox2 As Telerik.Reporting.TextBox
    Friend WithEvents textBox3 As Telerik.Reporting.TextBox
    Friend WithEvents textBox4 As Telerik.Reporting.TextBox
    Friend WithEvents htmlTextBox1 As Telerik.Reporting.HtmlTextBox
End Class