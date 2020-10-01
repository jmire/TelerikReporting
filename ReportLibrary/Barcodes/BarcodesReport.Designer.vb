
Imports Telerik.Reporting
Imports Telerik.Reporting.Barcodes

Partial Class BarcodesReport
#Region "Component Designer generated code"
    ''' <summary>
    ''' Required method for Telerik Reporting designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup10 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup11 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup12 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup13 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup14 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup15 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup16 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup17 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup18 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup19 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup20 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup21 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup22 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup23 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup24 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim PostnetEncoder1 As Telerik.Reporting.Barcodes.PostnetEncoder = New Telerik.Reporting.Barcodes.PostnetEncoder()
        Dim UpceEncoder1 As Telerik.Reporting.Barcodes.UPCEEncoder = New Telerik.Reporting.Barcodes.UPCEEncoder()
        Dim UpcSupplement2Encoder1 As Telerik.Reporting.Barcodes.UPCSupplement2Encoder = New Telerik.Reporting.Barcodes.UPCSupplement2Encoder()
        Dim UpcSupplement5Encoder1 As Telerik.Reporting.Barcodes.UPCSupplement5Encoder = New Telerik.Reporting.Barcodes.UPCSupplement5Encoder()
        Dim UpcaEncoder1 As Telerik.Reporting.Barcodes.UPCAEncoder = New Telerik.Reporting.Barcodes.UPCAEncoder()
        Dim DataMatrixEncoder1 As Telerik.Reporting.Barcodes.DataMatrixEncoder = New Telerik.Reporting.Barcodes.DataMatrixEncoder()
        Dim PdF417Encoder1 As Telerik.Reporting.Barcodes.PDF417Encoder = New Telerik.Reporting.Barcodes.PDF417Encoder()
        Dim QrCodeEncoder1 As Telerik.Reporting.Barcodes.QRCodeEncoder = New Telerik.Reporting.Barcodes.QRCodeEncoder()
        Dim DataMatrixEncoder2 As Telerik.Reporting.Barcodes.DataMatrixEncoder = New Telerik.Reporting.Barcodes.DataMatrixEncoder()
        Dim CodabarEncoder1 As Telerik.Reporting.Barcodes.CodabarEncoder = New Telerik.Reporting.Barcodes.CodabarEncoder()
        Dim Code11Encoder1 As Telerik.Reporting.Barcodes.Code11Encoder = New Telerik.Reporting.Barcodes.Code11Encoder()
        Dim Code25StandardEncoder1 As Telerik.Reporting.Barcodes.Code25StandardEncoder = New Telerik.Reporting.Barcodes.Code25StandardEncoder()
        Dim Code25InterleavedEncoder1 As Telerik.Reporting.Barcodes.Code25InterleavedEncoder = New Telerik.Reporting.Barcodes.Code25InterleavedEncoder()
        Dim Code39Encoder1 As Telerik.Reporting.Barcodes.Code39Encoder = New Telerik.Reporting.Barcodes.Code39Encoder()
        Dim Code39ExtendedEncoder1 As Telerik.Reporting.Barcodes.Code39ExtendedEncoder = New Telerik.Reporting.Barcodes.Code39ExtendedEncoder()
        Dim Code93Encoder1 As Telerik.Reporting.Barcodes.Code93Encoder = New Telerik.Reporting.Barcodes.Code93Encoder()
        Dim Code93ExtendedEncoder1 As Telerik.Reporting.Barcodes.Code93ExtendedEncoder = New Telerik.Reporting.Barcodes.Code93ExtendedEncoder()
        Dim Code128Encoder1 As Telerik.Reporting.Barcodes.Code128Encoder = New Telerik.Reporting.Barcodes.Code128Encoder()
        Dim Code128AEncoder1 As Telerik.Reporting.Barcodes.Code128AEncoder = New Telerik.Reporting.Barcodes.Code128AEncoder()
        Dim Code128BEncoder1 As Telerik.Reporting.Barcodes.Code128BEncoder = New Telerik.Reporting.Barcodes.Code128BEncoder()
        Dim Code128CEncoder1 As Telerik.Reporting.Barcodes.Code128CEncoder = New Telerik.Reporting.Barcodes.Code128CEncoder()
        Dim CodeMSIEncoder1 As Telerik.Reporting.Barcodes.CodeMSIEncoder = New Telerik.Reporting.Barcodes.CodeMSIEncoder()
        Dim EaN8Encoder1 As Telerik.Reporting.Barcodes.EAN8Encoder = New Telerik.Reporting.Barcodes.EAN8Encoder()
        Dim EaN13Encoder1 As Telerik.Reporting.Barcodes.EAN13Encoder = New Telerik.Reporting.Barcodes.EAN13Encoder()
        Dim EaN128Encoder1 As Telerik.Reporting.Barcodes.EAN128Encoder = New Telerik.Reporting.Barcodes.EAN128Encoder()
        Dim IntelligentMailEncoder1 As Telerik.Reporting.Barcodes.IntelligentMailEncoder = New Telerik.Reporting.Barcodes.IntelligentMailEncoder()
        Dim PlanetEncoder1 As Telerik.Reporting.Barcodes.PlanetEncoder = New Telerik.Reporting.Barcodes.PlanetEncoder()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.table2 = New Telerik.Reporting.Table()
        Me.textBox69 = New Telerik.Reporting.TextBox()
        Me.textBox71 = New Telerik.Reporting.TextBox()
        Me.textBox74 = New Telerik.Reporting.TextBox()
        Me.textBox76 = New Telerik.Reporting.TextBox()
        Me.textBox79 = New Telerik.Reporting.TextBox()
        Me.textBox81 = New Telerik.Reporting.TextBox()
        Me.textBox84 = New Telerik.Reporting.TextBox()
        Me.textBox86 = New Telerik.Reporting.TextBox()
        Me.textBox89 = New Telerik.Reporting.TextBox()
        Me.textBox91 = New Telerik.Reporting.TextBox()
        Me.textBox94 = New Telerik.Reporting.TextBox()
        Me.textBox96 = New Telerik.Reporting.TextBox()
        Me.textBox99 = New Telerik.Reporting.TextBox()
        Me.textBox101 = New Telerik.Reporting.TextBox()
        Me.textBox104 = New Telerik.Reporting.TextBox()
        Me.textBox106 = New Telerik.Reporting.TextBox()
        Me.textBox109 = New Telerik.Reporting.TextBox()
        Me.textBox111 = New Telerik.Reporting.TextBox()
        Me.textBox114 = New Telerik.Reporting.TextBox()
        Me.textBox116 = New Telerik.Reporting.TextBox()
        Me.textBox119 = New Telerik.Reporting.TextBox()
        Me.textBox121 = New Telerik.Reporting.TextBox()
        Me.textBox124 = New Telerik.Reporting.TextBox()
        Me.textBox126 = New Telerik.Reporting.TextBox()
        Me.textBox129 = New Telerik.Reporting.TextBox()
        Me.textBox131 = New Telerik.Reporting.TextBox()
        Me.textBox134 = New Telerik.Reporting.TextBox()
        Me.textBox136 = New Telerik.Reporting.TextBox()
        Me.barcode41 = New Telerik.Reporting.Barcode()
        Me.barcode43 = New Telerik.Reporting.Barcode()
        Me.barcode45 = New Telerik.Reporting.Barcode()
        Me.barcode44 = New Telerik.Reporting.Barcode()
        Me.barcode46 = New Telerik.Reporting.Barcode()
        Me.textBox95 = New Telerik.Reporting.TextBox()
        Me.textBox98 = New Telerik.Reporting.TextBox()
        Me.textBox97 = New Telerik.Reporting.TextBox()
        Me.textBox102 = New Telerik.Reporting.TextBox()
        Me.textBox100 = New Telerik.Reporting.TextBox()
        Me.textBox7 = New Telerik.Reporting.TextBox()
        Me.textBox9 = New Telerik.Reporting.TextBox()
        Me.textBox12 = New Telerik.Reporting.TextBox()
        Me.textBox14 = New Telerik.Reporting.TextBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.barcode25 = New Telerik.Reporting.Barcode()
        Me.barcode28 = New Telerik.Reporting.Barcode()
        Me.textBox4 = New Telerik.Reporting.TextBox()
        Me.textBox10 = New Telerik.Reporting.TextBox()
        Me.barcode26 = New Telerik.Reporting.Barcode()
        Me.textBox8 = New Telerik.Reporting.TextBox()
        Me.barcode1 = New Telerik.Reporting.Barcode()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox11 = New Telerik.Reporting.TextBox()
        Me.textBox15 = New Telerik.Reporting.TextBox()
        Me.barcode29 = New Telerik.Reporting.Barcode()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.barcode27 = New Telerik.Reporting.Barcode()
        Me.textBox13 = New Telerik.Reporting.TextBox()
        Me.barcode3 = New Telerik.Reporting.Barcode()
        Me.textBox2 = New Telerik.Reporting.TextBox()
        Me.barcode30 = New Telerik.Reporting.Barcode()
        Me.textBox3 = New Telerik.Reporting.TextBox()
        Me.barcode2 = New Telerik.Reporting.Barcode()
        Me.textBox16 = New Telerik.Reporting.TextBox()
        Me.barcode4 = New Telerik.Reporting.Barcode()
        Me.textBox17 = New Telerik.Reporting.TextBox()
        Me.barcode31 = New Telerik.Reporting.Barcode()
        Me.textBox18 = New Telerik.Reporting.TextBox()
        Me.barcode32 = New Telerik.Reporting.Barcode()
        Me.textBox19 = New Telerik.Reporting.TextBox()
        Me.barcode33 = New Telerik.Reporting.Barcode()
        Me.textBox20 = New Telerik.Reporting.TextBox()
        Me.barcode34 = New Telerik.Reporting.Barcode()
        Me.textBox21 = New Telerik.Reporting.TextBox()
        Me.barcode36 = New Telerik.Reporting.Barcode()
        Me.textBox22 = New Telerik.Reporting.TextBox()
        Me.barcode35 = New Telerik.Reporting.Barcode()
        Me.textBox23 = New Telerik.Reporting.TextBox()
        Me.barcode38 = New Telerik.Reporting.Barcode()
        Me.textBox24 = New Telerik.Reporting.TextBox()
        Me.barcode37 = New Telerik.Reporting.Barcode()
        Me.textBox25 = New Telerik.Reporting.TextBox()
        Me.barcode39 = New Telerik.Reporting.Barcode()
        Me.textBox26 = New Telerik.Reporting.TextBox()
        Me.barcode40 = New Telerik.Reporting.Barcode()
        Me.textBox27 = New Telerik.Reporting.TextBox()
        Me.textBox30 = New Telerik.Reporting.TextBox()
        Me.barcode6 = New Telerik.Reporting.Barcode()
        Me.textBox28 = New Telerik.Reporting.TextBox()
        Me.textBox31 = New Telerik.Reporting.TextBox()
        Me.barcode5 = New Telerik.Reporting.Barcode()
        Me.textBox66 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Mm(285.0R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.table2})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        '
        'table2
        '
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.8R)))
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.0R)))
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.8R)))
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.0R)))
        Me.table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.8R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(7.29R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.36R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.36R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.36R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.729R)))
        Me.table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Mm(22.85R)))
        Me.table2.Body.SetCellContent(4, 1, Me.textBox69)
        Me.table2.Body.SetCellContent(4, 3, Me.textBox71)
        Me.table2.Body.SetCellContent(5, 1, Me.textBox74)
        Me.table2.Body.SetCellContent(5, 3, Me.textBox76)
        Me.table2.Body.SetCellContent(6, 1, Me.textBox79)
        Me.table2.Body.SetCellContent(6, 3, Me.textBox81)
        Me.table2.Body.SetCellContent(7, 1, Me.textBox84)
        Me.table2.Body.SetCellContent(7, 3, Me.textBox86)
        Me.table2.Body.SetCellContent(8, 1, Me.textBox89)
        Me.table2.Body.SetCellContent(8, 3, Me.textBox91)
        Me.table2.Body.SetCellContent(9, 1, Me.textBox94)
        Me.table2.Body.SetCellContent(9, 3, Me.textBox96)
        Me.table2.Body.SetCellContent(10, 1, Me.textBox99)
        Me.table2.Body.SetCellContent(10, 3, Me.textBox101)
        Me.table2.Body.SetCellContent(11, 1, Me.textBox104)
        Me.table2.Body.SetCellContent(11, 3, Me.textBox106)
        Me.table2.Body.SetCellContent(12, 1, Me.textBox109)
        Me.table2.Body.SetCellContent(12, 3, Me.textBox111)
        Me.table2.Body.SetCellContent(13, 1, Me.textBox114)
        Me.table2.Body.SetCellContent(13, 3, Me.textBox116)
        Me.table2.Body.SetCellContent(14, 1, Me.textBox119)
        Me.table2.Body.SetCellContent(14, 3, Me.textBox121)
        Me.table2.Body.SetCellContent(15, 1, Me.textBox124)
        Me.table2.Body.SetCellContent(15, 3, Me.textBox126)
        Me.table2.Body.SetCellContent(16, 1, Me.textBox129)
        Me.table2.Body.SetCellContent(16, 3, Me.textBox131)
        Me.table2.Body.SetCellContent(17, 1, Me.textBox134)
        Me.table2.Body.SetCellContent(17, 3, Me.textBox136)
        Me.table2.Body.SetCellContent(15, 2, Me.barcode41)
        Me.table2.Body.SetCellContent(17, 0, Me.barcode43)
        Me.table2.Body.SetCellContent(17, 2, Me.barcode45)
        Me.table2.Body.SetCellContent(17, 4, Me.barcode44)
        Me.table2.Body.SetCellContent(15, 4, Me.barcode46)
        Me.table2.Body.SetCellContent(14, 2, Me.textBox95)
        Me.table2.Body.SetCellContent(14, 4, Me.textBox98)
        Me.table2.Body.SetCellContent(16, 0, Me.textBox97)
        Me.table2.Body.SetCellContent(16, 2, Me.textBox102)
        Me.table2.Body.SetCellContent(16, 4, Me.textBox100)
        Me.table2.Body.SetCellContent(1, 1, Me.textBox7)
        Me.table2.Body.SetCellContent(1, 3, Me.textBox9)
        Me.table2.Body.SetCellContent(0, 1, Me.textBox12)
        Me.table2.Body.SetCellContent(0, 3, Me.textBox14)
        Me.table2.Body.SetCellContent(0, 0, Me.textBox1)
        Me.table2.Body.SetCellContent(1, 0, Me.barcode25)
        Me.table2.Body.SetCellContent(3, 0, Me.barcode28)
        Me.table2.Body.SetCellContent(2, 0, Me.textBox4)
        Me.table2.Body.SetCellContent(0, 4, Me.textBox10)
        Me.table2.Body.SetCellContent(1, 4, Me.barcode26)
        Me.table2.Body.SetCellContent(0, 2, Me.textBox8)
        Me.table2.Body.SetCellContent(1, 2, Me.barcode1)
        Me.table2.Body.SetCellContent(2, 1, Me.textBox5)
        Me.table2.Body.SetCellContent(2, 3, Me.textBox11)
        Me.table2.Body.SetCellContent(2, 2, Me.textBox15)
        Me.table2.Body.SetCellContent(3, 2, Me.barcode29)
        Me.table2.Body.SetCellContent(2, 4, Me.textBox6)
        Me.table2.Body.SetCellContent(3, 4, Me.barcode27)
        Me.table2.Body.SetCellContent(4, 0, Me.textBox13)
        Me.table2.Body.SetCellContent(5, 0, Me.barcode3)
        Me.table2.Body.SetCellContent(4, 2, Me.textBox2)
        Me.table2.Body.SetCellContent(5, 2, Me.barcode30)
        Me.table2.Body.SetCellContent(4, 4, Me.textBox3)
        Me.table2.Body.SetCellContent(5, 4, Me.barcode2)
        Me.table2.Body.SetCellContent(6, 0, Me.textBox16)
        Me.table2.Body.SetCellContent(7, 0, Me.barcode4)
        Me.table2.Body.SetCellContent(6, 2, Me.textBox17)
        Me.table2.Body.SetCellContent(7, 2, Me.barcode31)
        Me.table2.Body.SetCellContent(6, 4, Me.textBox18)
        Me.table2.Body.SetCellContent(7, 4, Me.barcode32)
        Me.table2.Body.SetCellContent(8, 0, Me.textBox19)
        Me.table2.Body.SetCellContent(9, 0, Me.barcode33)
        Me.table2.Body.SetCellContent(8, 2, Me.textBox20)
        Me.table2.Body.SetCellContent(9, 2, Me.barcode34)
        Me.table2.Body.SetCellContent(8, 4, Me.textBox21)
        Me.table2.Body.SetCellContent(9, 4, Me.barcode36)
        Me.table2.Body.SetCellContent(10, 0, Me.textBox22)
        Me.table2.Body.SetCellContent(11, 0, Me.barcode35)
        Me.table2.Body.SetCellContent(10, 2, Me.textBox23)
        Me.table2.Body.SetCellContent(11, 2, Me.barcode38)
        Me.table2.Body.SetCellContent(10, 4, Me.textBox24)
        Me.table2.Body.SetCellContent(11, 4, Me.barcode37)
        Me.table2.Body.SetCellContent(12, 0, Me.textBox25)
        Me.table2.Body.SetCellContent(13, 0, Me.barcode39)
        Me.table2.Body.SetCellContent(12, 2, Me.textBox26)
        Me.table2.Body.SetCellContent(13, 2, Me.barcode40)
        Me.table2.Body.SetCellContent(12, 4, Me.textBox27)
        Me.table2.Body.SetCellContent(3, 3, Me.textBox30)
        Me.table2.Body.SetCellContent(13, 4, Me.barcode6)
        Me.table2.Body.SetCellContent(14, 0, Me.textBox28)
        Me.table2.Body.SetCellContent(3, 1, Me.textBox31)
        Me.table2.Body.SetCellContent(15, 0, Me.barcode5)
        TableGroup2.Name = "group3"
        TableGroup3.Name = "tableGroup1"
        TableGroup4.Name = "group2"
        TableGroup5.Name = "group4"
        TableGroup6.Name = "tableGroup2"
        TableGroup1.ChildGroups.Add(TableGroup2)
        TableGroup1.ChildGroups.Add(TableGroup3)
        TableGroup1.ChildGroups.Add(TableGroup4)
        TableGroup1.ChildGroups.Add(TableGroup5)
        TableGroup1.ChildGroups.Add(TableGroup6)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.textBox66
        Me.table2.ColumnGroups.Add(TableGroup1)
        Me.table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox1, Me.textBox12, Me.textBox8, Me.textBox14, Me.textBox10, Me.barcode25, Me.textBox7, Me.barcode1, Me.textBox9, Me.barcode26, Me.textBox4, Me.textBox5, Me.textBox15, Me.textBox11, Me.textBox6, Me.barcode28, Me.textBox31, Me.barcode29, Me.textBox30, Me.barcode27, Me.textBox13, Me.textBox69, Me.textBox2, Me.textBox71, Me.textBox3, Me.barcode3, Me.textBox74, Me.barcode30, Me.textBox76, Me.barcode2, Me.textBox16, Me.textBox79, Me.textBox17, Me.textBox81, Me.textBox18, Me.barcode4, Me.textBox84, Me.barcode31, Me.textBox86, Me.barcode32, Me.textBox19, Me.textBox89, Me.textBox20, Me.textBox91, Me.textBox21, Me.barcode33, Me.textBox94, Me.barcode34, Me.textBox96, Me.barcode36, Me.textBox22, Me.textBox99, Me.textBox23, Me.textBox101, Me.textBox24, Me.barcode35, Me.textBox104, Me.barcode38, Me.textBox106, Me.barcode37, Me.textBox25, Me.textBox109, Me.textBox26, Me.textBox111, Me.textBox27, Me.barcode39, Me.textBox114, Me.barcode40, Me.textBox116, Me.barcode6, Me.textBox28, Me.textBox119, Me.textBox95, Me.textBox121, Me.textBox98, Me.barcode5, Me.textBox124, Me.barcode41, Me.textBox126, Me.barcode46, Me.textBox97, Me.textBox129, Me.textBox102, Me.textBox131, Me.textBox100, Me.barcode43, Me.textBox134, Me.barcode45, Me.textBox136, Me.barcode44, Me.textBox66})
        Me.table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.table2.Name = "table2"
        TableGroup7.Name = "group21"
        TableGroup8.Name = "group20"
        TableGroup9.Name = "group"
        TableGroup10.Name = "group1"
        TableGroup11.Name = "group5"
        TableGroup12.Name = "group6"
        TableGroup13.Name = "group7"
        TableGroup14.Name = "group8"
        TableGroup15.Name = "group9"
        TableGroup16.Name = "group10"
        TableGroup17.Name = "group11"
        TableGroup18.Name = "group12"
        TableGroup19.Name = "group13"
        TableGroup20.Name = "group14"
        TableGroup21.Name = "group15"
        TableGroup22.Name = "group16"
        TableGroup23.Name = "group17"
        TableGroup24.Name = "group18"
        Me.table2.RowGroups.Add(TableGroup7)
        Me.table2.RowGroups.Add(TableGroup8)
        Me.table2.RowGroups.Add(TableGroup9)
        Me.table2.RowGroups.Add(TableGroup10)
        Me.table2.RowGroups.Add(TableGroup11)
        Me.table2.RowGroups.Add(TableGroup12)
        Me.table2.RowGroups.Add(TableGroup13)
        Me.table2.RowGroups.Add(TableGroup14)
        Me.table2.RowGroups.Add(TableGroup15)
        Me.table2.RowGroups.Add(TableGroup16)
        Me.table2.RowGroups.Add(TableGroup17)
        Me.table2.RowGroups.Add(TableGroup18)
        Me.table2.RowGroups.Add(TableGroup19)
        Me.table2.RowGroups.Add(TableGroup20)
        Me.table2.RowGroups.Add(TableGroup21)
        Me.table2.RowGroups.Add(TableGroup22)
        Me.table2.RowGroups.Add(TableGroup23)
        Me.table2.RowGroups.Add(TableGroup24)
        Me.table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.638R), Telerik.Reporting.Drawing.Unit.Cm(28.498R))
        '
        'textBox69
        '
        Me.textBox69.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox69.Name = "textBox69"
        Me.textBox69.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox69.StyleName = ""
        '
        'textBox71
        '
        Me.textBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox71.Name = "textBox71"
        Me.textBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox71.StyleName = ""
        '
        'textBox74
        '
        Me.textBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox74.Name = "textBox74"
        Me.textBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox74.StyleName = ""
        '
        'textBox76
        '
        Me.textBox76.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox76.Name = "textBox76"
        Me.textBox76.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox76.StyleName = ""
        '
        'textBox79
        '
        Me.textBox79.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox79.Name = "textBox79"
        Me.textBox79.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox79.StyleName = ""
        '
        'textBox81
        '
        Me.textBox81.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox81.Name = "textBox81"
        Me.textBox81.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox81.StyleName = ""
        '
        'textBox84
        '
        Me.textBox84.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox84.Name = "textBox84"
        Me.textBox84.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox84.StyleName = ""
        '
        'textBox86
        '
        Me.textBox86.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox86.Name = "textBox86"
        Me.textBox86.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox86.StyleName = ""
        '
        'textBox89
        '
        Me.textBox89.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox89.Name = "textBox89"
        Me.textBox89.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox89.StyleName = ""
        '
        'textBox91
        '
        Me.textBox91.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox91.Name = "textBox91"
        Me.textBox91.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox91.StyleName = ""
        '
        'textBox94
        '
        Me.textBox94.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox94.Name = "textBox94"
        Me.textBox94.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox94.StyleName = ""
        '
        'textBox96
        '
        Me.textBox96.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox96.Name = "textBox96"
        Me.textBox96.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox96.StyleName = ""
        '
        'textBox99
        '
        Me.textBox99.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox99.Name = "textBox99"
        Me.textBox99.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox99.StyleName = ""
        '
        'textBox101
        '
        Me.textBox101.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox101.Name = "textBox101"
        Me.textBox101.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox101.StyleName = ""
        '
        'textBox104
        '
        Me.textBox104.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox104.Name = "textBox104"
        Me.textBox104.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox104.StyleName = ""
        '
        'textBox106
        '
        Me.textBox106.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox106.Name = "textBox106"
        Me.textBox106.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox106.StyleName = ""
        '
        'textBox109
        '
        Me.textBox109.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox109.Name = "textBox109"
        Me.textBox109.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox109.StyleName = ""
        '
        'textBox111
        '
        Me.textBox111.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox111.Name = "textBox111"
        Me.textBox111.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox111.StyleName = ""
        '
        'textBox114
        '
        Me.textBox114.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox114.Name = "textBox114"
        Me.textBox114.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox114.StyleName = ""
        '
        'textBox116
        '
        Me.textBox116.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox116.Name = "textBox116"
        Me.textBox116.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox116.StyleName = ""
        '
        'textBox119
        '
        Me.textBox119.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox119.Name = "textBox119"
        Me.textBox119.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox119.StyleName = ""
        '
        'textBox121
        '
        Me.textBox121.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox121.Name = "textBox121"
        Me.textBox121.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox121.StyleName = ""
        '
        'textBox124
        '
        Me.textBox124.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox124.Name = "textBox124"
        Me.textBox124.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox124.StyleName = ""
        '
        'textBox126
        '
        Me.textBox126.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox126.Name = "textBox126"
        Me.textBox126.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox126.StyleName = ""
        '
        'textBox129
        '
        Me.textBox129.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox129.Name = "textBox129"
        Me.textBox129.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox129.StyleName = ""
        '
        'textBox131
        '
        Me.textBox131.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox131.Name = "textBox131"
        Me.textBox131.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox131.StyleName = ""
        '
        'textBox134
        '
        Me.textBox134.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox134.Name = "textBox134"
        Me.textBox134.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox134.StyleName = ""
        '
        'textBox136
        '
        Me.textBox136.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox136.Name = "textBox136"
        Me.textBox136.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox136.StyleName = ""
        '
        'barcode41
        '
        Me.barcode41.Encoder = PostnetEncoder1
        Me.barcode41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode41.Name = "barcode41"
        Me.barcode41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode41.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode41.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode41.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode41.Value = "0123456789"
        '
        'barcode43
        '
        Me.barcode43.Encoder = UpceEncoder1
        Me.barcode43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode43.Name = "barcode43"
        Me.barcode43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode43.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode43.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode43.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode43.Value = "1200000789"
        '
        'barcode45
        '
        Me.barcode45.Encoder = UpcSupplement2Encoder1
        Me.barcode45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode45.Name = "barcode45"
        Me.barcode45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode45.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode45.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode45.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode45.Value = "12"
        '
        'barcode44
        '
        Me.barcode44.Encoder = UpcSupplement5Encoder1
        Me.barcode44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode44.Name = "barcode44"
        Me.barcode44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode44.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode44.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode44.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode44.Value = "01234"
        '
        'barcode46
        '
        Me.barcode46.Encoder = UpcaEncoder1
        Me.barcode46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode46.Name = "barcode46"
        Me.barcode46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode46.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode46.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode46.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode46.Value = "0123456789"
        '
        'textBox95
        '
        Me.textBox95.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox95.Name = "textBox95"
        Me.textBox95.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox95.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox95.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox95.Value = "Postnet"
        '
        'textBox98
        '
        Me.textBox98.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox98.Name = "textBox98"
        Me.textBox98.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox98.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox98.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox98.Value = "UPCA"
        '
        'textBox97
        '
        Me.textBox97.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox97.Name = "textBox97"
        Me.textBox97.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox97.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox97.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox97.Value = "UPCE"
        '
        'textBox102
        '
        Me.textBox102.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox102.Name = "textBox102"
        Me.textBox102.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox102.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox102.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox102.Value = "UPCSupplement2"
        '
        'textBox100
        '
        Me.textBox100.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox100.Name = "textBox100"
        Me.textBox100.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox100.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox100.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox100.Value = "UPCSupplement5"
        '
        'textBox7
        '
        Me.textBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox7.StyleName = ""
        '
        'textBox9
        '
        Me.textBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox9.Name = "textBox9"
        Me.textBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.textBox9.StyleName = ""
        '
        'textBox12
        '
        Me.textBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox12.Name = "textBox12"
        Me.textBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(7.29R))
        Me.textBox12.StyleName = ""
        '
        'textBox14
        '
        Me.textBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox14.Name = "textBox14"
        Me.textBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(7.29R))
        Me.textBox14.StyleName = ""
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(7.29R))
        Me.textBox1.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox1.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox1.Value = "DataMatrix"
        '
        'barcode25
        '
        Me.barcode25.Encoder = DataMatrixEncoder1
        Me.barcode25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode25.Name = "barcode25"
        Me.barcode25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode25.Stretch = True
        Me.barcode25.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.barcode25.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.barcode25.Style.BorderColor.Right = System.Drawing.Color.Black
        Me.barcode25.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.barcode25.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode25.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode25.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode25.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode25.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode25.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode25.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode25.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode25.Value = "http://demos.telerik.com/reporting"
        '
        'barcode28
        '
        Me.barcode28.Encoder = PdF417Encoder1
        Me.barcode28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode28.Name = "barcode28"
        Me.barcode28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode28.Stretch = True
        Me.barcode28.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.barcode28.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.barcode28.Style.BorderColor.Right = System.Drawing.Color.Black
        Me.barcode28.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.barcode28.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode28.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode28.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode28.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode28.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode28.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode28.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.25R)
        Me.barcode28.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.25R)
        Me.barcode28.Value = "01234567890"
        '
        'textBox4
        '
        Me.textBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox4.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox4.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox4.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox4.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox4.Value = "PDF417"
        '
        'textBox10
        '
        Me.textBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox10.Name = "textBox10"
        Me.textBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(7.29R))
        Me.textBox10.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox10.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox10.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox10.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox10.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox10.Value = "QR Code"
        '
        'barcode26
        '
        QrCodeEncoder1.Version = 3
        Me.barcode26.Encoder = QrCodeEncoder1
        Me.barcode26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode26.Name = "barcode26"
        Me.barcode26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode26.Stretch = True
        Me.barcode26.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.barcode26.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.barcode26.Style.BorderColor.Right = System.Drawing.Color.Black
        Me.barcode26.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.barcode26.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode26.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode26.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode26.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode26.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode26.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode26.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.barcode26.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0R)
        Me.barcode26.Value = "http://www.telerik.com"
        '
        'textBox8
        '
        Me.textBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(7.29R))
        Me.textBox8.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox8.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.textBox8.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox8.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox8.Value = "DataMatrix"
        '
        'barcode1
        '
        DataMatrixEncoder2.SymbolSize = Telerik.Reporting.Barcodes.DataMatrix.SymbolSize.RectangleAuto
        Me.barcode1.Encoder = DataMatrixEncoder2
        Me.barcode1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode1.Name = "barcode1"
        Me.barcode1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode1.Stretch = True
        Me.barcode1.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.barcode1.Style.BorderColor.Left = System.Drawing.Color.Black
        Me.barcode1.Style.BorderColor.Right = System.Drawing.Color.Black
        Me.barcode1.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.barcode1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode1.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode1.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode1.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode1.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.barcode1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode1.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Mm(2.5R)
        Me.barcode1.Value = "http://demos.telerik.com/reporting"
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox5.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox5.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox5.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        '
        'textBox11
        '
        Me.textBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox11.Name = "textBox11"
        Me.textBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox11.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox11.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox11.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox11.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        '
        'textBox15
        '
        Me.textBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox15.Name = "textBox15"
        Me.textBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox15.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox15.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox15.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox15.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox15.Value = "Codabar"
        '
        'barcode29
        '
        Me.barcode29.Encoder = CodabarEncoder1
        Me.barcode29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode29.Name = "barcode29"
        Me.barcode29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode29.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode29.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode29.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode29.Value = "0123456789"
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox6.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox6.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox6.Value = "Code11"
        '
        'barcode27
        '
        Me.barcode27.Encoder = Code11Encoder1
        Me.barcode27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode27.Name = "barcode27"
        Me.barcode27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode27.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode27.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode27.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode27.Value = "0123456789"
        '
        'textBox13
        '
        Me.textBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox13.Name = "textBox13"
        Me.textBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox13.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox13.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox13.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox13.Value = "Code25Standard"
        '
        'barcode3
        '
        Me.barcode3.Encoder = Code25StandardEncoder1
        Me.barcode3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode3.Name = "barcode3"
        Me.barcode3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode3.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode3.Value = "01234567"
        '
        'textBox2
        '
        Me.textBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox2.Value = "Code25Interleaved"
        '
        'barcode30
        '
        Me.barcode30.Encoder = Code25InterleavedEncoder1
        Me.barcode30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode30.Name = "barcode30"
        Me.barcode30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode30.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode30.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode30.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode30.Value = "0123456789"
        '
        'textBox3
        '
        Me.textBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox3.Value = "Code39"
        '
        'barcode2
        '
        Me.barcode2.Encoder = Code39Encoder1
        Me.barcode2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode2.Name = "barcode2"
        Me.barcode2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode2.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode2.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode2.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode2.Value = "0123456"
        '
        'textBox16
        '
        Me.textBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox16.Name = "textBox16"
        Me.textBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox16.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox16.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox16.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox16.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox16.Value = "Code39Extended"
        '
        'barcode4
        '
        Me.barcode4.Encoder = Code39ExtendedEncoder1
        Me.barcode4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode4.Name = "barcode4"
        Me.barcode4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode4.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode4.Value = "0123456"
        '
        'textBox17
        '
        Me.textBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox17.Name = "textBox17"
        Me.textBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox17.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox17.Value = "Code93"
        '
        'barcode31
        '
        Me.barcode31.Encoder = Code93Encoder1
        Me.barcode31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode31.Name = "barcode31"
        Me.barcode31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode31.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode31.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode31.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode31.Value = "0123456789"
        '
        'textBox18
        '
        Me.textBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox18.Name = "textBox18"
        Me.textBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox18.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox18.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox18.Value = "Code93Extended"
        '
        'barcode32
        '
        Me.barcode32.Encoder = Code93ExtendedEncoder1
        Me.barcode32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode32.Name = "barcode32"
        Me.barcode32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode32.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode32.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode32.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode32.Value = "0123456789"
        '
        'textBox19
        '
        Me.textBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox19.Name = "textBox19"
        Me.textBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox19.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox19.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox19.Value = "Code128"
        '
        'barcode33
        '
        Me.barcode33.Encoder = Code128Encoder1
        Me.barcode33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode33.Name = "barcode33"
        Me.barcode33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode33.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode33.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode33.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode33.Value = "0123456789"
        '
        'textBox20
        '
        Me.textBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox20.Name = "textBox20"
        Me.textBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox20.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox20.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox20.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox20.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox20.Value = "Code128A"
        '
        'barcode34
        '
        Me.barcode34.Encoder = Code128AEncoder1
        Me.barcode34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode34.Name = "barcode34"
        Me.barcode34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode34.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode34.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode34.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode34.Value = "01234567"
        '
        'textBox21
        '
        Me.textBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox21.Name = "textBox21"
        Me.textBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox21.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox21.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox21.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox21.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox21.Value = "Code128B"
        '
        'barcode36
        '
        Me.barcode36.Encoder = Code128BEncoder1
        Me.barcode36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode36.Name = "barcode36"
        Me.barcode36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode36.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode36.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode36.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode36.Value = "01234567"
        '
        'textBox22
        '
        Me.textBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox22.Name = "textBox22"
        Me.textBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox22.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox22.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox22.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox22.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox22.Value = "Code128C"
        '
        'barcode35
        '
        Me.barcode35.Encoder = Code128CEncoder1
        Me.barcode35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode35.Name = "barcode35"
        Me.barcode35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode35.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode35.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode35.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode35.Value = "0123456789"
        '
        'textBox23
        '
        Me.textBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox23.Name = "textBox23"
        Me.textBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox23.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox23.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox23.Value = "CodeMSI"
        '
        'barcode38
        '
        Me.barcode38.Encoder = CodeMSIEncoder1
        Me.barcode38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode38.Name = "barcode38"
        Me.barcode38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode38.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode38.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode38.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode38.Value = "012345678"
        '
        'textBox24
        '
        Me.textBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox24.Name = "textBox24"
        Me.textBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox24.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox24.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox24.Value = "EAN8"
        '
        'barcode37
        '
        Me.barcode37.Encoder = EaN8Encoder1
        Me.barcode37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode37.Name = "barcode37"
        Me.barcode37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.barcode37.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode37.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode37.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode37.Value = "0123456"
        '
        'textBox25
        '
        Me.textBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox25.Name = "textBox25"
        Me.textBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox25.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox25.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox25.Value = "EAN13"
        '
        'barcode39
        '
        Me.barcode39.Encoder = EaN13Encoder1
        Me.barcode39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode39.Name = "barcode39"
        Me.barcode39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode39.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode39.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode39.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode39.Value = "012345678912"
        '
        'textBox26
        '
        Me.textBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox26.Name = "textBox26"
        Me.textBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox26.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox26.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox26.Value = "EAN128"
        '
        'barcode40
        '
        Me.barcode40.Encoder = EaN128Encoder1
        Me.barcode40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.barcode40.Name = "barcode40"
        Me.barcode40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode40.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode40.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode40.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode40.Value = "0123456789"
        '
        'textBox27
        '
        Me.textBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox27.Name = "textBox27"
        Me.textBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox27.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox27.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox27.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox27.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox27.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox27.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox27.Value = "IntelligentMail"
        '
        'textBox30
        '
        Me.textBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(-15.0R), Telerik.Reporting.Drawing.Unit.Mm(-15.0R))
        Me.textBox30.Name = "textBox30"
        Me.textBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox30.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.textBox30.StyleName = ""
        '
        'barcode6
        '
        Me.barcode6.Encoder = IntelligentMailEncoder1
        Me.barcode6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode6.Name = "barcode6"
        Me.barcode6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode6.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode6.Value = "01234567890123456789"
        '
        'textBox28
        '
        Me.textBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.textBox28.Name = "textBox28"
        Me.textBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Cm(0.729R))
        Me.textBox28.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.textBox28.Style.BorderColor.Top = System.Drawing.Color.Black
        Me.textBox28.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox28.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox28.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox28.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.textBox28.Value = "Planet"
        '
        'textBox31
        '
        Me.textBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(-15.0R), Telerik.Reporting.Drawing.Unit.Mm(-15.0R))
        Me.textBox31.Name = "textBox31"
        Me.textBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Mm(22.36R))
        Me.textBox31.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.textBox31.StyleName = ""
        '
        'barcode5
        '
        Me.barcode5.Encoder = PlanetEncoder1
        Me.barcode5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.barcode5.Name = "barcode5"
        Me.barcode5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8R), Telerik.Reporting.Drawing.Unit.Mm(22.85R))
        Me.barcode5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.barcode5.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        Me.barcode5.Value = "01234567890"
        '
        'textBox66
        '
        Me.textBox66.Name = "textBox66"
        Me.textBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.401R), Telerik.Reporting.Drawing.Unit.Inch(0.598R))
        Me.textBox66.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Ridge
        Me.textBox66.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.textBox66.StyleName = "Header"
        Me.textBox66.Value = "Barcode Types"
        '
        'BarcodesReport
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "BarcodesReport"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R), Telerik.Reporting.Drawing.Unit.Inch(0.1R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Header")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Bold = True
        StyleRule2.Style.Font.Name = "Segoe UI Light"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25.0R)
        StyleRule2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextBox))})
        StyleRule3.Style.BackgroundColor = System.Drawing.Color.Transparent
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        StyleRule3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(82, Byte), Integer))
        StyleRule3.Style.Font.Bold = True
        StyleRule3.Style.Font.Name = "Segoe UI Light"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        StyleRule3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Barcode))})
        StyleRule4.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        StyleRule4.Style.Font.Bold = True
        StyleRule4.Style.Font.Name = "Segoe UI"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule4.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        StyleRule4.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.3R)
        StyleRule4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm
        Me.Width = Telerik.Reporting.Drawing.Unit.Mm(194.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region
    Private detail As DetailSection
    Friend WithEvents table2 As Table
    Friend WithEvents textBox69 As TextBox
    Friend WithEvents textBox71 As TextBox
    Friend WithEvents textBox74 As TextBox
    Friend WithEvents textBox76 As TextBox
    Friend WithEvents textBox79 As TextBox
    Friend WithEvents textBox81 As TextBox
    Friend WithEvents textBox84 As TextBox
    Friend WithEvents textBox86 As TextBox
    Friend WithEvents textBox89 As TextBox
    Friend WithEvents textBox91 As TextBox
    Friend WithEvents textBox94 As TextBox
    Friend WithEvents textBox96 As TextBox
    Friend WithEvents textBox99 As TextBox
    Friend WithEvents textBox101 As TextBox
    Friend WithEvents textBox104 As TextBox
    Friend WithEvents textBox106 As TextBox
    Friend WithEvents textBox109 As TextBox
    Friend WithEvents textBox111 As TextBox
    Friend WithEvents textBox114 As TextBox
    Friend WithEvents textBox116 As TextBox
    Friend WithEvents textBox119 As TextBox
    Friend WithEvents textBox121 As TextBox
    Friend WithEvents textBox124 As TextBox
    Friend WithEvents textBox126 As TextBox
    Friend WithEvents textBox129 As TextBox
    Friend WithEvents textBox131 As TextBox
    Friend WithEvents textBox134 As TextBox
    Friend WithEvents textBox136 As TextBox
    Friend WithEvents barcode41 As Barcode
    Friend WithEvents barcode43 As Barcode
    Friend WithEvents barcode45 As Barcode
    Friend WithEvents barcode44 As Barcode
    Friend WithEvents barcode46 As Barcode
    Friend WithEvents textBox95 As TextBox
    Friend WithEvents textBox98 As TextBox
    Friend WithEvents textBox97 As TextBox
    Friend WithEvents textBox102 As TextBox
    Friend WithEvents textBox100 As TextBox
    Friend WithEvents textBox7 As TextBox
    Friend WithEvents textBox9 As TextBox
    Friend WithEvents textBox12 As TextBox
    Friend WithEvents textBox14 As TextBox
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents barcode25 As Barcode
    Friend WithEvents barcode28 As Barcode
    Friend WithEvents textBox4 As TextBox
    Friend WithEvents textBox10 As TextBox
    Friend WithEvents barcode26 As Barcode
    Friend WithEvents textBox8 As TextBox
    Friend WithEvents barcode1 As Barcode
    Friend WithEvents textBox5 As TextBox
    Friend WithEvents textBox11 As TextBox
    Friend WithEvents textBox15 As TextBox
    Friend WithEvents barcode29 As Barcode
    Friend WithEvents textBox6 As TextBox
    Friend WithEvents barcode27 As Barcode
    Friend WithEvents textBox13 As TextBox
    Friend WithEvents barcode3 As Barcode
    Friend WithEvents textBox2 As TextBox
    Friend WithEvents barcode30 As Barcode
    Friend WithEvents textBox3 As TextBox
    Friend WithEvents barcode2 As Barcode
    Friend WithEvents textBox16 As TextBox
    Friend WithEvents barcode4 As Barcode
    Friend WithEvents textBox17 As TextBox
    Friend WithEvents barcode31 As Barcode
    Friend WithEvents textBox18 As TextBox
    Friend WithEvents barcode32 As Barcode
    Friend WithEvents textBox19 As TextBox
    Friend WithEvents barcode33 As Barcode
    Friend WithEvents textBox20 As TextBox
    Friend WithEvents barcode34 As Barcode
    Friend WithEvents textBox21 As TextBox
    Friend WithEvents barcode36 As Barcode
    Friend WithEvents textBox22 As TextBox
    Friend WithEvents barcode35 As Barcode
    Friend WithEvents textBox23 As TextBox
    Friend WithEvents barcode38 As Barcode
    Friend WithEvents textBox24 As TextBox
    Friend WithEvents barcode37 As Barcode
    Friend WithEvents textBox25 As TextBox
    Friend WithEvents barcode39 As Barcode
    Friend WithEvents textBox26 As TextBox
    Friend WithEvents barcode40 As Barcode
    Friend WithEvents textBox27 As TextBox
    Friend WithEvents textBox30 As TextBox
    Friend WithEvents barcode6 As Barcode
    Friend WithEvents textBox28 As TextBox
    Friend WithEvents textBox31 As TextBox
    Friend WithEvents barcode5 As Barcode
    Friend WithEvents textBox66 As TextBox
End Class
