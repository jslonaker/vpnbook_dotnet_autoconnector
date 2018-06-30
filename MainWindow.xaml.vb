Imports wslib
Imports System.Threading
Class MainWindow
    Dim wso As WebScrapeData = New wslib.WebScrapeData()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub
    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs)


    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        wso.genCredentialFile()
        wso.DownloadOVPNFile()
        Dim proc As New System.Diagnostics.Process()
        Dim p = Process.GetProcessesByName("openvpn")

        If (p.Count = 0) Then
            proc = Process.Start(".\openvpn\openvpn.exe", "--config .\vpnbook-euro1-udp53.ovpn --auth-user-pass .\auth.txt")
        Else
            MessageBox.Show("Plese close the console window and try again.", "Open VPN Is already running!")

        End If
    End Sub
End Class
