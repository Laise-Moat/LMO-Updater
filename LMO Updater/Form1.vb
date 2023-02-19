Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.IO.Compression
Imports System.Net

Public Class Form1

	' Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
	'	If bool = False Then Label4.BackColor = Color.FromArgb(16, 163, 93)
	' End Sub


	Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
		Label4.BackColor = Color.FromArgb(102, 102, 102)
	End Sub
	Private Sub Label4_MouseUp(sender As Object, e As EventArgs) Handles Label4.MouseUp
		Label4.BackColor = Color.FromArgb(102, 102, 102)
		Label4.Visible = True
		Label6.Visible = True
		Label5.Visible = True
		ProgressBar1.Visible = True

		If My.Computer.FileSystem.FileExists("latestD.zip") Then
			My.Computer.FileSystem.DeleteFile("latestD.zip")
		End If

		Dim wc As New WebClient
		AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
		AddHandler wc.DownloadFileCompleted, AddressOf ProgDone
		wc.DownloadFileAsync(New Uri("https://ssl.cdn.toaaa.de/lmo/download/latest.zip"), "latestD.zip")
	End Sub

	Private Sub ProgDone(sender As Object, e As AsyncCompletedEventArgs)
		ProgressBar1.Value = 100
		Label5.Text = "Extrahiere das komprimierte Archiv..."
		Label6.Text = ""

		ZipFile.ExtractToDirectory("latestD.zip", Application.StartupPath())

		Timer1.Enabled = True
	End Sub

	Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
		ProgressBar1.Value = e.ProgressPercentage
		Label6.Text = String.Format("{0:N0} MB / {1:N0} MB", (e.BytesReceived / 1024D / 1024D), (e.TotalBytesToReceive / 1024D / 1024D))
	End Sub

	Private Sub Label4_MouseDown(sender As Object, e As EventArgs) Handles Label4.MouseDown
		Label4.BackColor = Color.FromArgb(13, 171, 118)
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		If My.Computer.FileSystem.FileExists("Laise Moat Online.exe") Then

			Label5.Text = "Aktualisierung erfolgreich vollendet!"
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

	Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
	End Sub

	Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
	End Sub

	Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
	End Sub

	Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
	End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
	End Sub

	Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
	End Sub

	Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
	End Sub
End Class

