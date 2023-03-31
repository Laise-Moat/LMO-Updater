Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.IO.Compression
Imports System.Net

Public Class MainWindow

	' Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
	'	If bool = False Then Label4.BackColor = Color.FromArgb(16, 163, 93)
	' End Sub
	Dim hasPressed As Boolean = False
	Dim isAtEnd As Boolean = False


	Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
		If hasPressed = False And isAtEnd = False Then
			Label4.BackColor = Color.FromArgb(19, 184, 67)
		ElseIf Label4.Text = "Beenden" Then
			Label4.BackColor = Color.FromArgb(230, 74, 49)
		End If


	End Sub

	Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
		If hasPressed = False And isAtEnd = False Then
			Label4.BackColor = Color.FromArgb(19, 154, 67)
		ElseIf Label4.Text = "Beenden" Then
			Label4.BackColor = Color.FromArgb(220, 64, 39)
		End If
	End Sub
	Private Sub Label4_MouseUp(sender As Object, e As EventArgs) Handles Label4.MouseUp
		Try

			If hasPressed = False And isAtEnd = False Then
				hasPressed = True
				Label4.BackColor = Color.FromArgb(102, 102, 102)
				Label4.Visible = True
				Label6.Visible = True
				Label5.Visible = True

				ProgressBarBackground.Visible = True
				PBStart.Visible = True
				PBEnd.Visible = True
				ProgBarStatus.Visible = True
				ProgBarStatus.BackColor = Color.FromArgb(19, 154, 67)



				If My.Computer.FileSystem.FileExists("latestD.zip") Then
					My.Computer.FileSystem.DeleteFile("latestD.zip")
				End If

				Dim wc As New WebClient
				AddHandler wc.DownloadProgressChanged, AddressOf ProgChanged
				AddHandler wc.DownloadFileCompleted, AddressOf ProgDone
				wc.DownloadFileAsync(New Uri("https://cdn.laise-moat.com/lmo/latest.zip"), "latestD.zip")
			ElseIf Label4.Text = "Beenden" Then
				End
			End If

		Catch ex As Exception
			MsgBox("Ein Fehler ist der Erscheinung ergangen: " + ex.ToString(), MsgBoxStyle.Critical)
			End
		End Try
	End Sub

	Private Sub ProgDone(sender As Object, e As AsyncCompletedEventArgs)

		ProgBarStatus.Size = New Size(438, 30)
		PBEnd.BackColor = Color.FromArgb(19, 154, 67)

		Label5.Text = "Extrahiere das komprimierte Archiv..."
		Label6.Text = ""

		Timer3.Enabled = True
	End Sub

	Private Sub ProgChanged(sender As Object, e As DownloadProgressChangedEventArgs)
		Try
			If e.ProgressPercentage >= 2 Then
				PBStart.BackColor = Color.FromArgb(19, 154, 67)
				Dim progres As Integer = e.ProgressPercentage
				ProgBarStatus.Size = New Size(progres * 4.38, 30)
			End If

			'If e.ProgressPercentage  Then
			'PBEnd.BackColor = Color.FromArgb(19, 154, 67)
			'End If

			Label6.Text = String.Format("{0:N0} MB / {1:N0} MB", (e.BytesReceived / 1024D / 1024D), (e.TotalBytesToReceive / 1024D / 1024D))
		Catch ex As Exception
			MsgBox("Ein Fehler ist der Erscheinung ergangen: " + ex.ToString(), MsgBoxStyle.Critical)
			End
		End Try
	End Sub

	Private Sub Label4_MouseDown(sender As Object, e As EventArgs) Handles Label4.MouseDown
		If hasPressed = False And isAtEnd = False Then
			Label4.BackColor = Color.FromArgb(13, 171, 118)
		ElseIf Label4.Text = "Beenden" Then
			Label4.BackColor = Color.FromArgb(250, 94, 69)
		End If
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Try
			If My.Computer.FileSystem.FileExists("Laise Moat Online.exe") Then

				Label5.Text = "Aktualisierung erfolgreich vollendet!"
				Label5.ForeColor = Color.FromArgb(19, 154, 67)


				ProgressBarBackground.Visible = False
				PBStart.Visible = False
				PBEnd.Visible = False
				ProgBarStatus.Visible = False

				Label7.Visible = True
				Label4.Text = "Beenden"
				Label4.BackColor = Color.FromArgb(220, 64, 39)
				isAtEnd = True

				Timer1.Enabled = False
			End If
		Catch ex As Exception
			MsgBox("Ein Fehler ist der Erscheinung ergangen: " + ex.ToString(), MsgBoxStyle.Critical)
			End
		End Try
	End Sub



	Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
		Try
			If My.Computer.FileSystem.DirectoryExists("Laise Moat Online_Data") Then My.Computer.FileSystem.DeleteDirectory("Laise Moat Online_Data", FileIO.DeleteDirectoryOption.DeleteAllContents)
			If My.Computer.FileSystem.DirectoryExists("MonoBleedingEdge") Then My.Computer.FileSystem.DeleteDirectory("MonoBleedingEdge", FileIO.DeleteDirectoryOption.DeleteAllContents)
			If My.Computer.FileSystem.FileExists("Laise Moat Online.exe") Then My.Computer.FileSystem.DeleteFile("Laise Moat Online.exe")
			If My.Computer.FileSystem.FileExists("UnityCrashHandler64.exe") Then My.Computer.FileSystem.DeleteFile("UnityCrashHandler64.exe")
			If My.Computer.FileSystem.FileExists("UnityPlayer.dll") Then My.Computer.FileSystem.DeleteFile("UnityPlayer.dll")

			ZipFile.ExtractToDirectory("latestD.zip", Application.StartupPath())

			Timer1.Enabled = True
			Timer3.Enabled = False
		Catch ex As Exception
			MsgBox("Ein Fehler ist der Erscheinung ergangen: " + ex.ToString())
			End
		End Try
	End Sub


	Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
		Label7.BackColor = Color.FromArgb(19, 184, 67)
	End Sub

	Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
		Label7.BackColor = Color.FromArgb(19, 154, 67)
	End Sub

	Private Sub Label7_MouseDown(sender As Object, e As EventArgs) Handles Label7.MouseDown
		Label7.BackColor = Color.FromArgb(13, 171, 118)
	End Sub

	Private Sub Label7_MouseUp(sender As Object, e As EventArgs) Handles Label7.MouseUp
		Try
			Dim p As New ProcessStartInfo
			p.FileName = "Laise Moat Online.exe"
			Dim pro As Process = Process.Start(p)

			Label7.BackColor = Color.FromArgb(19, 184, 67)
		Catch ex As Exception
			MsgBox("Ein Fehler ist der Erscheinung ergangen: " + ex.ToString())
			End
		End Try
		End
	End Sub

	Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

	End Sub

	Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class

