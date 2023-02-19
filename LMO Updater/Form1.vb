Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Net

Public Class Form1

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.BackColor = Color.FromArgb(16, 163, 93)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.FromArgb(19, 154, 67)
    End Sub
    Private Sub Label4_MouseUp(sender As Object, e As EventArgs) Handles Label4.MouseUp
        Label4.BackColor = Color.FromArgb(16, 163, 93)
        Label4.Visible = False
        Label6.Visible = True
        Label5.Visible = True
        ProgressBar1.Visible = True

        If My.Computer.FileSystem.FileExists("latestD.zip") Then
            My.Computer.FileSystem.DeleteFile("latestD.zip")
        End If

        Dim wc As New WebClient
        AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
        AddHandler wc.DownloadFileCompleted, AddressOf ProgDone
        wc.DownloadFileAsync(New Uri("http://www.cartaux.net/LMO/latest.zip"), "latestD.zip")
        'It is used to download a file from the specified URl to the destination
    End Sub

    Private Sub ProgDone(sender As Object, e As AsyncCompletedEventArgs)
        ProgressBar1.Value = 100
        Label5.Text = "Extrahiere komprimierte Bytes aus dem Archiv..."
        Label6.Text = ""

        ZipFile.ExtractToDirectory("latestD.zip", Application.StartupPath())

        Timer1.Enabled = True
    End Sub

    Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = e.ProgressPercentage
        Label6.Text = String.Format("{0} MB / {1} MB", (e.BytesReceived / 1024D / 1024D.ToString()), (e.TotalBytesToReceive / 1024D / 1024D.ToString()))
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As EventArgs) Handles Label4.MouseDown
        Label4.BackColor = Color.FromArgb(13, 171, 118)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.FileSystem.FileExists("Laise Moat Online.exe") Then

            Label5.Text = "Aktualisierung erfolgreich vereinsamt ausgeführt!"
            Label5.ForeColor = Color.FromArgb(19, 154, 67)
            ProgressBar1.Visible = False
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        My.Computer.FileSystem.DeleteFile("latestD.zip")
        End
    End Sub
End Class
