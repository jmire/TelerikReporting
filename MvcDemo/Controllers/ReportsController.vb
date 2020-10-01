Imports Telerik.Reporting.Services
Imports Telerik.Reporting.Services.WebApi
Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class ReportsController
    Inherits ReportsControllerBase

    Shared configurationInstance As ReportServiceConfiguration

    Shared Sub New()
        Dim appPath = HttpContext.Current.Server.MapPath("~/")
        Dim reportsPath = Path.Combine(appPath, "..\..\..\Report Designer\Examples")

        Dim resolver = New UriReportSourceResolver(reportsPath) _
                       .AddFallbackResolver(New TypeReportSourceResolver())

        Dim reportServiceConfiguration As New ReportServiceConfiguration()
        reportServiceConfiguration.HostAppId = "MvcDemoApp"
        reportServiceConfiguration.ReportSourceResolver = resolver
        reportServiceConfiguration.Storage = New Telerik.Reporting.Cache.File.FileStorage()
        ' reportServiceConfiguration.ReportSharingTimeout = 0
        ' reportServiceConfiguration.ClientSessionTimeout = 15
        configurationInstance = reportServiceConfiguration
    End Sub

    Public Sub New()
        Me.ReportServiceConfiguration = configurationInstance
    End Sub

    Protected Overrides Function SendMailMessage(ByVal mailMessage As MailMessage) As HttpStatusCode
        Throw New NotImplementedException("This method should be implemented in order to send mail messages.")

        'Using smtpClient = New SmtpClient("smtp01.companyname.com", 25)
        '    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network
        '    smtpClient.EnableSsl = True
        '    smtpClient.Send(mailMessage)
        'End Using

        'Return HttpStatusCode.OK
    End Function
End Class
