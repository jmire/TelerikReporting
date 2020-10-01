Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices

Public Class CryptoDataResolver
    Const tempDataDirKey As String = "CryptoDataTempDir"
    Shared ReadOnly defaultTemptDir As String
    Shared ReadOnly tempDir As String
    Shared ReadOnly currencyCodes As Dictionary(Of String, CurrencyModel) = New Dictionary(Of String, CurrencyModel) From {
        {"btc", New CurrencyModel With {
            .Name = "Bitcoin",
            .Algorithm = "PoW"
        }},
        {"bch", New CurrencyModel With {
            .Name = "Bitcoin Cash",
            .Algorithm = "PoW"
        }},
        {"bnb", New CurrencyModel With {
            .Name = "Binance Coin",
            .Algorithm = "PoS"
        }},
        {"ltc", New CurrencyModel With {
            .Name = "Litecoin",
            .Algorithm = "PoW"
        }},
        {"bsv", New CurrencyModel With {
            .Name = "Bitcoin SV",
            .Algorithm = "PoW"
        }},
        {"eth", New CurrencyModel With {
            .Name = "Ethereum",
            .Algorithm = "PoS"
        }},
        {"xrp", New CurrencyModel With {
            .Name = "Ripple",
            .Algorithm = "PoC"
        }}
    }

    Shared Sub New()
        defaultTemptDir = Path.Combine(Path.GetTempPath(), "CryptoCurrenciesData")
        tempDir = If(ConfigurationManager.AppSettings(tempDataDirKey), defaultTemptDir)
    End Sub

    Shared ReadOnly LockObject As Object = New Object()

    Public Iterator Function GetDetails(ByVal currencyCode As String) As IEnumerable(Of CurrencyDetails)
        If currencyCode Is Nothing OrElse Not currencyCodes.ContainsKey(currencyCode) Then
            Return
        End If

        SyncLock LockObject

            Using f = File.OpenText(Path.Combine(tempDir, currencyCode & ".csv"))
                Dim headerLine = f.ReadLine()
                Dim indexes = FillModelIndexer(headerLine)

                If indexes IsNot Nothing Then

                    While Not f.EndOfStream
                        Dim line = f.ReadLine()

                        If Not String.IsNullOrWhiteSpace(line) Then
                            Dim currentValues = line.Split(","c)

                            If currentValues.Length > indexes.Ceiling Then
                                Dim model = New CurrencyDetails()
                                FillModel(currentValues, model, indexes, currencyCode)
                                Yield model
                            Else
                                Debug.Assert(True)
                            End If
                        End If
                    End While
                Else
                    Debug.Assert(True)
                End If
            End Using
        End SyncLock
    End Function

    Public Function GetData(ByVal forDate As DateTime) As IEnumerable(Of CurrencyModel)
        Dim configs = Path.Combine(tempDir, "configs")

        SyncLock LockObject

            If File.Exists(configs) Then
                Dim lastDateTimeCheck = File.ReadAllText(configs)
                Dim dateLastDownload As DateTime

                If DateTime.TryParse(lastDateTimeCheck, dateLastDownload) Then

                    If (DateTime.Now - dateLastDownload).TotalHours > 1 Then
                        Me.UpdateDate(configs)
                    End If
                Else
                    Me.UpdateDate(configs)
                End If
            Else
                Me.UpdateDate(configs)
            End If

            Dim result = New List(Of CurrencyModel)()

            If Not ExtractData(forDate, result) Then

                If Me.RevertData() Then
                    ExtractData(forDate, result)
                End If
            End If

            Return result
        End SyncLock
    End Function

    Private Shared Function ExtractData(ByVal forDate As DateTime, ByRef result As IList(Of CurrencyModel)) As Boolean

        For Each currencyCode As KeyValuePair(Of String, CurrencyModel) In currencyCodes
            Dim model = currencyCode.Value
            model.Code = currencyCode.Key

            Using f = File.OpenText(Path.Combine(tempDir, currencyCode.Key & ".csv"))
                Dim lastLine = String.Empty
                Dim currentValues = New String(-1) {}
                Dim previousValues = New String(-1) {}
                Dim headerLine = f.ReadLine()
                Dim indexes = FillModelIndexer(headerLine)

                If indexes Is Nothing Then
                    Return False
                End If

                While Not f.EndOfStream
                    previousValues = CType(currentValues.Clone(), String())
                    Dim rowDate As DateTime
                    lastLine = f.ReadLine()

                    If String.IsNullOrWhiteSpace(lastLine) Then
                        currentValues = previousValues
                    End If

                    currentValues = lastLine.Split(","c)

                    If currentValues.Length < indexes.Ceiling Then
                        currentValues = previousValues
                    End If

                    If DateTime.TryParse(currentValues(indexes.ForDate), rowDate) AndAlso forDate.Date = rowDate Then
                        Exit While
                    End If
                End While

                If currentValues.Length > 6 Then
                    FillModel(currentValues, model, indexes, model.Code)
                    result.Add(model)
                End If
            End Using
        Next

        Return True
    End Function

    Private Shared Function FillModelIndexer(ByVal headerLine As String) As ModelIndexes
        If headerLine Is Nothing Then
            Return Nothing
        End If

        Dim model = New ModelIndexes()
        Dim columns = headerLine.Split(","c)
        Const dateH As String = "date"
        Const priceH As String = "PriceUSD"
        Const marketH As String = "CapMrktCurUSD"
        Const coinsH As String = "SplyCur"

        For i As Integer = 0 To columns.Length - 1

            Select Case columns(i)
                Case priceH
                    model.Price = i
                    model.Ceiling = Math.Max(model.Ceiling, i)
                Case marketH
                    model.MarketCap = i
                    model.Ceiling = Math.Max(model.Ceiling, i)
                Case coinsH
                    model.Coins = i
                    model.Ceiling = Math.Max(model.Ceiling, i)
                Case dateH
                    model.ForDate = i
                    model.Ceiling = Math.Max(model.Ceiling, i)
            End Select
        Next

        If model.ForDate <> -1 AndAlso model.MarketCap <> -1 AndAlso model.Price <> -1 Then
            Return model
        Else
            Return Nothing
        End If
    End Function

    Private Shared Sub FillModel(ByVal values As IList(Of String), ByVal model As CurrencyDetails, ByVal indexes As ModelIndexes, ByVal code As String)
        Dim forDate As DateTime
        DateTime.TryParse(values(indexes.ForDate), forDate)
        model.Date = forDate
        Dim coins As UInteger

        If indexes.Coins <> -1 Then
            UInteger.TryParse(values(indexes.Coins).Split("."c)(0), coins)
            model.Coins = coins
        End If

        Dim marketCap As Decimal
        Decimal.TryParse(values(indexes.MarketCap), NumberStyles.Any, CultureInfo.InvariantCulture, marketCap)
        model.MarketCap = marketCap
        Dim price As Decimal
        Decimal.TryParse(values(indexes.Price), NumberStyles.Any, CultureInfo.InvariantCulture, price)
        model.Price = price
    End Sub

    Private Sub UpdateDate(ByVal configs As String)
        Try

            If Not Directory.Exists(tempDir) Then
                Directory.CreateDirectory(tempDir)
            End If

            Me.DownloadData()

            If File.Exists(configs) Then
                File.Delete(configs)
            End If

            Using f = File.CreateText(configs)
                f.WriteLine(DateTime.Now.ToString())
            End Using

        Catch e As Exception
            Trace.WriteLine(e)
        End Try
    End Sub

    Private Sub DownloadData()
        Const dataLocation As String = "https://coinmetrics.io/newdata/{0}.csv"

        SyncLock LockObject

            Using client = New WebClient()

                For Each code As String In currencyCodes.Keys
                    Dim source = String.Format(dataLocation, code)
                    Dim destination = Path.Combine(tempDir, code & ".csv")
                    Dim backup = destination & ".backup"

                    If File.Exists(backup) Then
                        File.Delete(backup)
                    End If

                    If File.Exists(destination) Then
                        File.Move(destination, backup)
                    End If

                    client.DownloadFile(source, destination)
                Next
            End Using
        End SyncLock
    End Sub

    Private Function RevertData() As Boolean
        For Each code As KeyValuePair(Of String, CurrencyModel) In currencyCodes
            Dim destination = Path.Combine(tempDir, code.Key & ".csv")
            Dim source = destination & ".backup"

            If Not File.Exists(source) Then
                Return False
            End If

            If File.Exists(destination) Then
                File.Delete(destination)
            End If

            File.Move(source, destination)
        Next

        Return True
    End Function

    Class ModelIndexes
        Public Property ForDate As Integer
        Public Property Coins As Integer
        Public Property Price As Integer
        Public Property MarketCap As Integer
        Public Property Ceiling As Integer

        Public Sub New()
            Me.ForDate = -1
            Me.Coins = -1
            Me.Price = -1
            Me.MarketCap = -1
        End Sub
    End Class
End Class
