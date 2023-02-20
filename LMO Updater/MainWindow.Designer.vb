<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarBackground = New System.Windows.Forms.Label()
        Me.PBStart = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PBEnd = New System.Windows.Forms.Label()
        Me.ProgBarStatus = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.4!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(460, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "0 MB / 0 MB"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(460, 34)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Lade die aktuellste Version von LMO herunter..."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 37)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Aktualisiere deine Welt!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(460, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Immer Up-to-date mit dem"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 41.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 78)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LMO Updater"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'ProgressBarBackground
        '
        Me.ProgressBarBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgressBarBackground.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.ProgressBarBackground.ForeColor = System.Drawing.Color.White
        Me.ProgressBarBackground.Location = New System.Drawing.Point(12, 563)
        Me.ProgressBarBackground.Name = "ProgressBarBackground"
        Me.ProgressBarBackground.Size = New System.Drawing.Size(460, 30)
        Me.ProgressBarBackground.TabIndex = 14
        Me.ProgressBarBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressBarBackground.Visible = False
        '
        'PBStart
        '
        Me.PBStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PBStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.PBStart.ForeColor = System.Drawing.Color.White
        Me.PBStart.Image = Global.LMO_Updater.My.Resources.Resources.Knof1
        Me.PBStart.Location = New System.Drawing.Point(12, 563)
        Me.PBStart.Name = "PBStart"
        Me.PBStart.Size = New System.Drawing.Size(11, 30)
        Me.PBStart.TabIndex = 15
        Me.PBStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PBStart.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.4!, System.Drawing.FontStyle.Bold)
        Me.Label4.Image = Global.LMO_Updater.My.Resources.Resources.Button
        Me.Label4.Location = New System.Drawing.Point(128, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 60)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Aktualisierung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Initialisieren"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBEnd
        '
        Me.PBEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PBEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.PBEnd.ForeColor = System.Drawing.Color.White
        Me.PBEnd.Image = Global.LMO_Updater.My.Resources.Resources.Knof2
        Me.PBEnd.Location = New System.Drawing.Point(461, 563)
        Me.PBEnd.Name = "PBEnd"
        Me.PBEnd.Size = New System.Drawing.Size(11, 30)
        Me.PBEnd.TabIndex = 16
        Me.PBEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PBEnd.Visible = False
        '
        'ProgBarStatus
        '
        Me.ProgBarStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgBarStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 14.4!, System.Drawing.FontStyle.Bold)
        Me.ProgBarStatus.ForeColor = System.Drawing.Color.White
        Me.ProgBarStatus.Location = New System.Drawing.Point(23, 563)
        Me.ProgBarStatus.Name = "ProgBarStatus"
        Me.ProgBarStatus.Size = New System.Drawing.Size(0, 30)
        Me.ProgBarStatus.TabIndex = 17
        Me.ProgBarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgBarStatus.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.4!, System.Drawing.FontStyle.Bold)
        Me.Label7.Image = Global.LMO_Updater.My.Resources.Resources.Button
        Me.Label7.Location = New System.Drawing.Point(128, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 60)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Spielen"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 611)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgBarStatus)
        Me.Controls.Add(Me.PBEnd)
        Me.Controls.Add(Me.PBStart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LMO Updater"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBarBackground As Label
    Friend WithEvents PBStart As Label
    Friend WithEvents PBEnd As Label
    Friend WithEvents ProgBarStatus As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label7 As Label
End Class
