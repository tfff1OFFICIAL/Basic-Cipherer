Imports System.Net
Imports System.IO
Public Class Form1
    Private WithEvents _commandExecutor As New CommandExecutor()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If generate.Checked = True Then
            _commandExecutor.Execute("C:\Tfff1\Cipher\Generator.py", "")
        End If
    End Sub

    Private Sub _commandExecutor_OutputRead(ByVal output As String) Handles _commandExecutor.OutputRead
        Me.Invoke(New processCommandOutputDelegate(AddressOf processCommandOutput), output)
    End Sub

    Private Delegate Sub processCommandOutputDelegate(ByVal output As String)
    Private Sub processCommandOutput(ByVal output As String)
        outputText.Text = outputText.Text + "\n" + output
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _commandExecutor.Dispose()
    End Sub

    'Download Python Executables:
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists("C:\Tfff1") Then
            My.Computer.FileSystem.CreateDirectory("C:\Tfff1")
        End If

        If Not My.Computer.FileSystem.DirectoryExists("C:\Tfff1\Cipher") Then
            My.Computer.FileSystem.CreateDirectory("C:\Tfff1\Cipher")
        End If

        If Not My.Computer.FileSystem.FileExists("C:\Tfff1\Cipher\Generator.py") Then
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/tfff1OFFICIAL/tfff1OFFICIAL.github.io/master/resources/Downloads/Generator.py"), "C:\Tfff1\Cipher\Generator.py")
        End If

        If Not My.Computer.FileSystem.FileExists("C:\Tfff1\Cipher\Reader.py") Then
            Dim client As WebClient = New WebClient
            AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
            client.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/tfff1OFFICIAL/tfff1OFFICIAL.github.io/master/resources/Downloads/Reader.py"), "C:\Tfff1\Cipher\Reader.py")
        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBar1.Visible = True
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ProgressBar1.Visible = False
    End Sub
End Class