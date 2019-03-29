<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioCDPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioCDPlayer))
        Dim MessageArgs1 As CSAudioCDPlayer.MessageArgs = New CSAudioCDPlayer.MessageArgs()
        Dim ProgressArgs1 As CSAudioCDPlayer.ProgressArgs = New CSAudioCDPlayer.ProgressArgs()
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.trckVolume = New System.Windows.Forms.TrackBar()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.lblPositionTotal = New System.Windows.Forms.Label()
        Me.lblPositionCurrent = New System.Windows.Forms.Label()
        Me.cboPlayerAudioDevice = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.cmdLoadFreeDB = New System.Windows.Forms.Button()
        Me.cmdLoadFreeDBAsync = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblPlayerMode = New System.Windows.Forms.Label()
        Me.cboPlayerMode = New System.Windows.Forms.ComboBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cTrackTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboDevice = New System.Windows.Forms.ComboBox()
        Me.lblDevice = New System.Windows.Forms.Label()
        Me.cboPlayerBits = New System.Windows.Forms.ComboBox()
        Me.lblSamplerate = New System.Windows.Forms.Label()
        Me.lblAudioDevice = New System.Windows.Forms.Label()
        Me.cboPlayerChannels = New System.Windows.Forms.ComboBox()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.cboPlayerSamplerate = New System.Windows.Forms.ComboBox()
        Me.lblMeterOut = New System.Windows.Forms.Label()
        Me.lblMediaFile = New System.Windows.Forms.Label()
        Me.trckPlayerPosition = New System.Windows.Forms.TrackBar()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.tmrPlayerPosition = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMeterOut = New System.Windows.Forms.Timer(Me.components)
        Me.cTrackType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.grpSource = New System.Windows.Forms.GroupBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.lstTracks = New System.Windows.Forms.ListView()
        Me.cTrackNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cTrackName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AudioCDPlayer1 = New CSAudioCDPlayer.AudioCDPlayer()
        Me.FreeDB1 = New CSAudioCDPlayer.FreeDB()
        Me.AudioVisualization1 = New CSAudioCDPlayer.AudioVisualization()
        Me.AudioMeter1 = New CSAudioCDPlayer.AudioMeter()
        CType(Me.trckVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trckPlayerPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSource.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(459, 851)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(168, 23)
        Me.cmdCheckLicense.TabIndex = 312
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(219, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(246, 16)
        Me.label3.TabIndex = 287
        Me.label3.Text = ".NET component to play audio CD."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(8, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(215, 25)
        Me.label2.TabIndex = 286
        Me.label2.Text = "CSAudioCDPlayer |"
        '
        'trckVolume
        '
        Me.trckVolume.Location = New System.Drawing.Point(619, 124)
        Me.trckVolume.Maximum = 100
        Me.trckVolume.Name = "trckVolume"
        Me.trckVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trckVolume.Size = New System.Drawing.Size(45, 292)
        Me.trckVolume.TabIndex = 308
        Me.trckVolume.Value = 50
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(94, 851)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 306
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'lblPositionTotal
        '
        Me.lblPositionTotal.AutoSize = True
        Me.lblPositionTotal.Location = New System.Drawing.Point(558, 771)
        Me.lblPositionTotal.Name = "lblPositionTotal"
        Me.lblPositionTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblPositionTotal.TabIndex = 305
        Me.lblPositionTotal.Text = "00:00:00"
        '
        'lblPositionCurrent
        '
        Me.lblPositionCurrent.AutoSize = True
        Me.lblPositionCurrent.Location = New System.Drawing.Point(16, 771)
        Me.lblPositionCurrent.Name = "lblPositionCurrent"
        Me.lblPositionCurrent.Size = New System.Drawing.Size(49, 13)
        Me.lblPositionCurrent.TabIndex = 304
        Me.lblPositionCurrent.Text = "00:00:00"
        '
        'cboPlayerAudioDevice
        '
        Me.cboPlayerAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerAudioDevice.FormattingEnabled = True
        Me.cboPlayerAudioDevice.Location = New System.Drawing.Point(31, 706)
        Me.cboPlayerAudioDevice.Name = "cboPlayerAudioDevice"
        Me.cboPlayerAudioDevice.Size = New System.Drawing.Size(244, 21)
        Me.cboPlayerAudioDevice.TabIndex = 302
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(484, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 199
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnClose.Location = New System.Drawing.Point(375, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 23)
        Me.btnClose.TabIndex = 198
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(266, 19)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(103, 23)
        Me.btnOpen.TabIndex = 197
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'cmdLoadFreeDB
        '
        Me.cmdLoadFreeDB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdLoadFreeDB.Location = New System.Drawing.Point(20, 329)
        Me.cmdLoadFreeDB.Name = "cmdLoadFreeDB"
        Me.cmdLoadFreeDB.Size = New System.Drawing.Size(132, 27)
        Me.cmdLoadFreeDB.TabIndex = 196
        Me.cmdLoadFreeDB.Text = "Load FreeDB"
        Me.cmdLoadFreeDB.UseVisualStyleBackColor = True
        '
        'cmdLoadFreeDBAsync
        '
        Me.cmdLoadFreeDBAsync.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdLoadFreeDBAsync.Location = New System.Drawing.Point(158, 329)
        Me.cmdLoadFreeDBAsync.Name = "cmdLoadFreeDBAsync"
        Me.cmdLoadFreeDBAsync.Size = New System.Drawing.Size(132, 27)
        Me.cmdLoadFreeDBAsync.TabIndex = 195
        Me.cmdLoadFreeDBAsync.Text = "Load FreeDB Async"
        Me.cmdLoadFreeDBAsync.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Location = New System.Drawing.Point(-30, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox1.TabIndex = 310
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pictureBox2.Location = New System.Drawing.Point(-20, 7)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox2.TabIndex = 311
        Me.pictureBox2.TabStop = False
        '
        'lblPlayerMode
        '
        Me.lblPlayerMode.AutoSize = True
        Me.lblPlayerMode.Location = New System.Drawing.Point(28, 628)
        Me.lblPlayerMode.Name = "lblPlayerMode"
        Me.lblPlayerMode.Size = New System.Drawing.Size(66, 13)
        Me.lblPlayerMode.TabIndex = 301
        Me.lblPlayerMode.Text = "Player Mode"
        '
        'cboPlayerMode
        '
        Me.cboPlayerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerMode.FormattingEnabled = True
        Me.cboPlayerMode.Location = New System.Drawing.Point(31, 644)
        Me.cboPlayerMode.Name = "cboPlayerMode"
        Me.cboPlayerMode.Size = New System.Drawing.Size(244, 21)
        Me.cboPlayerMode.TabIndex = 300
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(645, 263)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(19, 13)
        Me.lblVolume.TabIndex = 309
        Me.lblVolume.Text = "50"
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(175, 851)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 307
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(499, 690)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 298
        Me.label1.Text = "Channels"
        '
        'cTrackTime
        '
        Me.cTrackTime.Text = "Track Time"
        Me.cTrackTime.Width = 120
        '
        'cboDevice
        '
        Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cboDevice.FormattingEnabled = True
        Me.cboDevice.Location = New System.Drawing.Point(22, 46)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.Size = New System.Drawing.Size(562, 21)
        Me.cboDevice.TabIndex = 175
        '
        'lblDevice
        '
        Me.lblDevice.AutoSize = True
        Me.lblDevice.Location = New System.Drawing.Point(22, 27)
        Me.lblDevice.Name = "lblDevice"
        Me.lblDevice.Size = New System.Drawing.Size(44, 13)
        Me.lblDevice.TabIndex = 174
        Me.lblDevice.Text = "Device:"
        '
        'cboPlayerBits
        '
        Me.cboPlayerBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerBits.FormattingEnabled = True
        Me.cboPlayerBits.Location = New System.Drawing.Point(405, 706)
        Me.cboPlayerBits.Name = "cboPlayerBits"
        Me.cboPlayerBits.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerBits.TabIndex = 296
        '
        'lblSamplerate
        '
        Me.lblSamplerate.AutoSize = True
        Me.lblSamplerate.Location = New System.Drawing.Point(305, 690)
        Me.lblSamplerate.Name = "lblSamplerate"
        Me.lblSamplerate.Size = New System.Drawing.Size(60, 13)
        Me.lblSamplerate.TabIndex = 295
        Me.lblSamplerate.Text = "Samplerate"
        '
        'lblAudioDevice
        '
        Me.lblAudioDevice.AutoSize = True
        Me.lblAudioDevice.Location = New System.Drawing.Point(28, 690)
        Me.lblAudioDevice.Name = "lblAudioDevice"
        Me.lblAudioDevice.Size = New System.Drawing.Size(71, 13)
        Me.lblAudioDevice.TabIndex = 303
        Me.lblAudioDevice.Text = "Audio Device"
        '
        'cboPlayerChannels
        '
        Me.cboPlayerChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerChannels.FormattingEnabled = True
        Me.cboPlayerChannels.Location = New System.Drawing.Point(502, 706)
        Me.cboPlayerChannels.Name = "cboPlayerChannels"
        Me.cboPlayerChannels.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerChannels.TabIndex = 299
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(402, 690)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(49, 13)
        Me.lblBits.TabIndex = 297
        Me.lblBits.Text = "Bit depth"
        '
        'cboPlayerSamplerate
        '
        Me.cboPlayerSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayerSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlayerSamplerate.FormattingEnabled = True
        Me.cboPlayerSamplerate.Location = New System.Drawing.Point(308, 706)
        Me.cboPlayerSamplerate.Name = "cboPlayerSamplerate"
        Me.cboPlayerSamplerate.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayerSamplerate.TabIndex = 294
        '
        'lblMeterOut
        '
        Me.lblMeterOut.AutoSize = True
        Me.lblMeterOut.Location = New System.Drawing.Point(599, 452)
        Me.lblMeterOut.Name = "lblMeterOut"
        Me.lblMeterOut.Size = New System.Drawing.Size(28, 13)
        Me.lblMeterOut.TabIndex = 293
        Me.lblMeterOut.Text = "0.00"
        '
        'lblMediaFile
        '
        Me.lblMediaFile.Location = New System.Drawing.Point(10, 767)
        Me.lblMediaFile.Name = "lblMediaFile"
        Me.lblMediaFile.Size = New System.Drawing.Size(602, 36)
        Me.lblMediaFile.TabIndex = 292
        '
        'trckPlayerPosition
        '
        Me.trckPlayerPosition.Location = New System.Drawing.Point(9, 800)
        Me.trckPlayerPosition.Name = "trckPlayerPosition"
        Me.trckPlayerPosition.Size = New System.Drawing.Size(609, 45)
        Me.trckPlayerPosition.TabIndex = 291
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(256, 851)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 290
        Me.cmdStop.Text = "Stop"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'tmrPlayerPosition
        '
        '
        'tmrMeterOut
        '
        '
        'cTrackType
        '
        Me.cTrackType.Text = "Track Type"
        Me.cTrackType.Width = 100
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(13, 851)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlay.TabIndex = 289
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'grpSource
        '
        Me.grpSource.BackColor = System.Drawing.SystemColors.Control
        Me.grpSource.Controls.Add(Me.lblArtist)
        Me.grpSource.Controls.Add(Me.lblAlbum)
        Me.grpSource.Controls.Add(Me.btnRefresh)
        Me.grpSource.Controls.Add(Me.btnClose)
        Me.grpSource.Controls.Add(Me.btnOpen)
        Me.grpSource.Controls.Add(Me.cmdLoadFreeDB)
        Me.grpSource.Controls.Add(Me.cmdLoadFreeDBAsync)
        Me.grpSource.Controls.Add(Me.lstTracks)
        Me.grpSource.Controls.Add(Me.cboDevice)
        Me.grpSource.Controls.Add(Me.lblDevice)
        Me.grpSource.Location = New System.Drawing.Point(9, 67)
        Me.grpSource.Name = "grpSource"
        Me.grpSource.Size = New System.Drawing.Size(604, 374)
        Me.grpSource.TabIndex = 285
        Me.grpSource.TabStop = False
        Me.grpSource.Text = "Source"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.Location = New System.Drawing.Point(372, 336)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(30, 13)
        Me.lblArtist.TabIndex = 201
        Me.lblArtist.Text = "Artist"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlbum.Location = New System.Drawing.Point(519, 336)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblAlbum.TabIndex = 200
        Me.lblAlbum.Text = "Album"
        '
        'lstTracks
        '
        Me.lstTracks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cTrackNum, Me.cTrackName, Me.cTrackTime, Me.cTrackType})
        Me.lstTracks.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTracks.FullRowSelect = True
        Me.lstTracks.GridLines = True
        Me.lstTracks.HideSelection = False
        Me.lstTracks.Location = New System.Drawing.Point(22, 82)
        Me.lstTracks.MultiSelect = False
        Me.lstTracks.Name = "lstTracks"
        Me.lstTracks.Size = New System.Drawing.Size(562, 232)
        Me.lstTracks.TabIndex = 176
        Me.lstTracks.UseCompatibleStateImageBehavior = False
        Me.lstTracks.View = System.Windows.Forms.View.Details
        '
        'cTrackNum
        '
        Me.cTrackNum.Text = "Track Num"
        Me.cTrackNum.Width = 80
        '
        'cTrackName
        '
        Me.cTrackName.Text = "Track Name"
        Me.cTrackName.Width = 220
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(118, 17)
        Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 895)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(674, 22)
        Me.statusStrip1.TabIndex = 288
        Me.statusStrip1.Text = "statusStrip1"
        '
        'AudioCDPlayer1
        '
        Me.AudioCDPlayer1.AudioDevice = 0
        Me.AudioCDPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioCDPlayer1.FileName = ""
        Me.AudioCDPlayer1.Location = New System.Drawing.Point(612, 28)
        MessageArgs1.Number = 0
        MessageArgs1.String = Nothing
        Me.AudioCDPlayer1.MessageArgs = MessageArgs1
        Me.AudioCDPlayer1.Name = "AudioCDPlayer1"
        Me.AudioCDPlayer1.Position = System.TimeSpan.Parse("00:00:00")
        ProgressArgs1.Position = System.TimeSpan.Parse("00:00:00")
        Me.AudioCDPlayer1.ProgressArgs = ProgressArgs1
        Me.AudioCDPlayer1.SamplerateVal = 0
        Me.AudioCDPlayer1.Size = New System.Drawing.Size(52, 52)
        Me.AudioCDPlayer1.TabIndex = 313
        Me.AudioCDPlayer1.UserKey = "Your registration key"
        Me.AudioCDPlayer1.UserName = "Your email"
        Me.AudioCDPlayer1.Volume = 100
        '
        'FreeDB1
        '
        Me.FreeDB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FreeDB1.FreeDBClientName = "FreedbDemo"
        Me.FreeDB1.FreeDBHostname = "abc.company"
        Me.FreeDB1.FreeDBSiteAddress = "us.freedb.org"
        Me.FreeDB1.FreeDBUserName = "test"
        Me.FreeDB1.FreeDBVersion = "1.0"
        Me.FreeDB1.Location = New System.Drawing.Point(555, 28)
        Me.FreeDB1.Name = "FreeDB1"
        Me.FreeDB1.Size = New System.Drawing.Size(52, 52)
        Me.FreeDB1.TabIndex = 314
        '
        'AudioVisualization1
        '
        Me.AudioVisualization1.BarCount = 50
        Me.AudioVisualization1.BarSpacing = 2
        Me.AudioVisualization1.ColorBase = System.Drawing.Color.DarkRed
        Me.AudioVisualization1.ColorMax = System.Drawing.Color.Snow
        Me.AudioVisualization1.HighQuality = True
        Me.AudioVisualization1.Interval = 40
        Me.AudioVisualization1.IsXLogScale = True
        Me.AudioVisualization1.Location = New System.Drawing.Point(31, 478)
        Me.AudioVisualization1.MaximumFrequency = 10000
        Me.AudioVisualization1.Name = "AudioVisualization1"
        Me.AudioVisualization1.Size = New System.Drawing.Size(562, 135)
        Me.AudioVisualization1.TabIndex = 315
        Me.AudioVisualization1.UseAverage = True
        '
        'AudioMeter1
        '
        Me.AudioMeter1.Location = New System.Drawing.Point(31, 450)
        Me.AudioMeter1.Name = "AudioMeter1"
        Me.AudioMeter1.Size = New System.Drawing.Size(562, 23)
        Me.AudioMeter1.TabIndex = 316
        '
        'frmAudioCDPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 917)
        Me.Controls.Add(Me.AudioMeter1)
        Me.Controls.Add(Me.AudioVisualization1)
        Me.Controls.Add(Me.FreeDB1)
        Me.Controls.Add(Me.AudioCDPlayer1)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.trckVolume)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.lblPositionTotal)
        Me.Controls.Add(Me.lblPositionCurrent)
        Me.Controls.Add(Me.cboPlayerAudioDevice)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lblPlayerMode)
        Me.Controls.Add(Me.cboPlayerMode)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboPlayerBits)
        Me.Controls.Add(Me.lblSamplerate)
        Me.Controls.Add(Me.lblAudioDevice)
        Me.Controls.Add(Me.cboPlayerChannels)
        Me.Controls.Add(Me.lblBits)
        Me.Controls.Add(Me.cboPlayerSamplerate)
        Me.Controls.Add(Me.lblMeterOut)
        Me.Controls.Add(Me.lblMediaFile)
        Me.Controls.Add(Me.trckPlayerPosition)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.grpSource)
        Me.Controls.Add(Me.statusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioCDPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioCDPlayer - VB Full Example"
        CType(Me.trckVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trckPlayerPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSource.ResumeLayout(False)
        Me.grpSource.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cmdCheckLicense As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents trckVolume As TrackBar
    Private WithEvents cmdPause As Button
    Private WithEvents lblPositionTotal As Label
    Private WithEvents lblPositionCurrent As Label
    Private WithEvents cboPlayerAudioDevice As ComboBox
    Private WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOpen As Button
    Private WithEvents cmdLoadFreeDB As Button
    Private WithEvents cmdLoadFreeDBAsync As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents lblPlayerMode As Label
    Private WithEvents cboPlayerMode As ComboBox
    Private WithEvents lblVolume As Label
    Private WithEvents cmdResume As Button
    Private WithEvents label1 As Label
    Private WithEvents cTrackTime As ColumnHeader
    Friend WithEvents cboDevice As ComboBox
    Friend WithEvents lblDevice As Label
    Private WithEvents cboPlayerBits As ComboBox
    Private WithEvents lblSamplerate As Label
    Private WithEvents lblAudioDevice As Label
    Private WithEvents cboPlayerChannels As ComboBox
    Private WithEvents lblBits As Label
    Private WithEvents cboPlayerSamplerate As ComboBox
    Private WithEvents lblMeterOut As Label
    Private WithEvents lblMediaFile As Label
    Private WithEvents trckPlayerPosition As TrackBar
    Private WithEvents cmdStop As Button
    Private WithEvents tmrPlayerPosition As Timer
    Private WithEvents tmrMeterOut As Timer
    Private WithEvents cTrackType As ColumnHeader
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents cmdPlay As Button
    Private WithEvents grpSource As GroupBox
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblAlbum As Label
    Private WithEvents lstTracks As ListView
    Private WithEvents cTrackNum As ColumnHeader
    Private WithEvents cTrackName As ColumnHeader
    Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents toolTip1 As ToolTip
    Friend WithEvents AudioCDPlayer1 As CSAudioCDPlayer.AudioCDPlayer
    Friend WithEvents FreeDB1 As CSAudioCDPlayer.FreeDB
    Friend WithEvents AudioVisualization1 As CSAudioCDPlayer.AudioVisualization
    Friend WithEvents AudioMeter1 As CSAudioCDPlayer.AudioMeter
End Class
