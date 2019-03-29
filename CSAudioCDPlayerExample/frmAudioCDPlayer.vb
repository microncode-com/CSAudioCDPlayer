Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms

Namespace CSAudioCDPlayerExample
    Public Partial Class frmAudioCDPlayer
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub frmAudioCDPlayer_Load(ByVal sender As Object, ByVal e As EventArgs)
            audioCDPlayer1.UserName = "Your email"
            audioCDPlayer1.UserKey = "Your registration key"
            cboDevice.DataSource = audioCDPlayer1.GetDevices()
            If cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0
            cboPlayerSamplerate.DataSource = audioCDPlayer1.GetSamplerates()
            cboPlayerSamplerate.Text = "44100"
            cboPlayerBits.DataSource = audioCDPlayer1.GetBits()
            cboPlayerBits.Text = "16"
            cboPlayerChannels.DataSource = audioCDPlayer1.GetChannels()
            cboPlayerChannels.Text = "2"
            cboPlayerMode.DataSource = audioCDPlayer1.GetPlayerModes()
            cboPlayerMode.SelectedItem = audioCDPlayer1.GetEnumValue(audioCDPlayer1.Mode)
            LoadCDTracks()
        End Sub

        Private Sub cboPlayerMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim mode As CSAudioCDPlayer.Mode = CType([Enum].Parse(GetType(CSAudioCDPlayer.Mode), cboPlayerMode.Text), CSAudioCDPlayer.Mode)
            cboPlayerAudioDevice.DataSource = audioCDPlayer1.GetDevices(mode)
            Dim default_device_index As Integer = audioCDPlayer1.GetDeviceDefaultIndex(mode)

            If default_device_index <> -1 Then
                cboPlayerAudioDevice.SelectedIndex = default_device_index
            Else
                cboPlayerAudioDevice.SelectedIndex = 0
            End If
        End Sub

        Private Function LoadCDTracks() As Integer
            If audioCDPlayer1.CDIsReady(cboDevice.SelectedIndex) = False Then
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
                Return -1
            Else
                lstTracks.Items.Clear()
                Dim arr As String() = New String(4) {}
                Dim itm As ListViewItem

                For Each trck As CSAudioCDPlayer.AudioCDPlayer.TrackInfo In audioCDPlayer1.GetTracks(cboDevice.SelectedIndex)
                    arr(0) = trck.TrackNumber.ToString()
                    arr(1) = "Track" & trck.TrackNumber.ToString()
                    arr(2) = TimeSpan.FromMilliseconds(trck.TrackLength).ToString("hh\:mm\:ss\.ff")
                    arr(3) = trck.TrackType
                    itm = New ListViewItem(arr)
                    lstTracks.Items.Add(itm)
                Next

                If lstTracks.Items.Count > 0 Then
                    lstTracks.Items(0).Selected = True
                End If

                Return 0
            End If
        End Function

        Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDPlayer1.EjectCD(cboDevice.SelectedIndex)
        End Sub

        Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDPlayer1.CloseCD(cboDevice.SelectedIndex)
        End Sub

        Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadCDTracks()
        End Sub

        Private Sub cmdLoadFreeDB_Click(ByVal sender As Object, ByVal e As EventArgs)
            If freeDB1.CDIsReady(cboDevice.SelectedIndex) = False Then
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
                Return
            Else
                freeDB1.GetFreeDBInfo(cboDevice.SelectedIndex)
            End If
        End Sub

        Private Sub cmdLoadFreeDBAsync_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim cntr As Integer = 0

            For Each trckFreeDB As String In freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo
                lstTracks.Items(cntr).SubItems(1).Text = trckFreeDB.ToString()
                cntr = cntr + 1
            Next

            If cntr > 0 Then
                lblArtist.Text = "Artist: " & freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist
                lblAlbum.Text = "Album: " & freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName
            End If
        End Sub

        Private Sub freeDB1_FreeDBDone(ByVal sender As Object)
            toolStripStatusLabel1.Text = "Done."
        End Sub

        Private Sub freeDB1_FreeDBError(ByVal sender As Object, ByVal e As CSFreeDB.Core.MessageArgs)
            MessageBox.Show(e.String & "(" & e.Number & ")")
            toolStripStatusLabel1.Text = e.String & "(" & e.Number & ")"
        End Sub

        Private Sub freeDB1_FreeDBStatus(ByVal sender As Object, ByVal e As CSFreeDB.Core.MessageArgs)
            Console.WriteLine(e.String)
            toolStripStatusLabel1.Text = e.String
        End Sub

        Private Sub freeDB1_FreeDBAlbum(ByVal sender As Object, ByVal e As CSFreeDBLib.FreeDB.AlbumInfo)
            Console.WriteLine(e.AlbumName)
            lblArtist.Text = e.AlbumArtist
            lblAlbum.Text = e.AlbumName
        End Sub

        Private Sub freeDB1_FreeDBTracks(ByVal sender As Object, ByVal e As CSFreeDBLib.FreeDB.TrackInfo)
            Console.WriteLine(e.TrackName)
            lstTracks.Items(e.TrackNumber - 1).SubItems(1).Text = e.TrackName
        End Sub

        Private Sub cmdPlay_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped Then
                audioCDPlayer1.[Resume]()
                audioCDPlayer1.[Stop]()

                While audioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped
                    Thread.Sleep(100)
                End While
            End If

            audioVisualization1.BackColor = Color.Black
            audioVisualization1.pictureBoxGraph.BackgroundImage = Nothing
            audioCDPlayer1.AudioVisualization = audioVisualization1
            audioCDPlayer1.AudioMeter = audioMeter1
            audioCDPlayer1.Samplerate = CType([Enum].Parse(GetType(CSAudioCDPlayer.Samplerate), cboPlayerSamplerate.Text), CSAudioCDPlayer.Samplerate)
            audioCDPlayer1.Bits = CType([Enum].Parse(GetType(CSAudioCDPlayer.Bits), cboPlayerBits.Text), CSAudioCDPlayer.Bits)
            audioCDPlayer1.Channels = CType([Enum].Parse(GetType(CSAudioCDPlayer.Channels), cboPlayerChannels.Text), CSAudioCDPlayer.Channels)
            audioCDPlayer1.Mode = CType([Enum].Parse(GetType(CSAudioCDPlayer.Mode), cboPlayerMode.Text), CSAudioCDPlayer.Mode)
            audioCDPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex
            audioCDPlayer1.DriveIndex = cboDevice.SelectedIndex
            audioCDPlayer1.TrackIndex = lstTracks.Items.IndexOf(lstTracks.SelectedItems(0))
            audioCDPlayer1.Play()
            tmrMeterOut.Interval = 40
            tmrMeterOut.Enabled = True
            tmrPlayerPosition.Interval = 100
            tmrPlayerPosition.Enabled = True
        End Sub

        ''' <summary>
        ''' Display the position of the playing operation.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub tmrPlayerPosition_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Try
                trckPlayerPosition.Value = CInt(audioCDPlayer1.Position.TotalSeconds)
                lblPositionCurrent.Text = String.Format("{0:hh\:mm\:ss}", audioCDPlayer1.Position)
            Catch ex As Exception
            Finally
            End Try
        End Sub

        Private Sub tmrMeterOut_Tick(ByVal sender As Object, ByVal e As EventArgs)
            lblMeterOut.Text = audioMeter1.Meter.ToString("0.00")
        End Sub

        Private Sub cmdPause_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Playing Then audioCDPlayer1.Pause()
        End Sub

        Private Sub cmdResume_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Paused Then audioCDPlayer1.[Resume]()
        End Sub

        Private Sub cmdStop_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioCDPlayer1.[Stop]()
            audioCDPlayer1.Enabled = False
        End Sub

        Private Sub audioCDPlayer1_PlayStart(ByVal sender As Object, ByVal e As EventArgs)
            trckPlayerPosition.Minimum = 0
            trckPlayerPosition.Maximum = CInt(audioCDPlayer1.Length.TotalSeconds)
            lblPositionTotal.Text = "audioPlayer1.Length"
            lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", audioCDPlayer1.Length)
            audioCDPlayer1.Volume = trckVolume.Value
            Console.WriteLine("Start.")
        End Sub

        Private Sub audioCDPlayer1_PlayDone(ByVal sender As Object, ByVal e As EventArgs)
            lblMeterOut.Text = "0"
            trckPlayerPosition.Value = 0
            lblPositionCurrent.Text = "00:00:00"
            tmrPlayerPosition.Enabled = False
            Console.WriteLine("Done.")
        End Sub

        Private Sub audioCDPlayer1_PlayError(ByVal sender As Object, ByVal e As CSAudioCDPlayer.MessageArgs)
            Console.WriteLine(e.Number & " (" & e.Number & ")")
        End Sub

        Private Sub trckPlayerPosition_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            tmrPlayerPosition.Enabled = False
        End Sub

        Private Sub trckPlayerPosition_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If audioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Stopped Then Return

            Try
                audioCDPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value)
                tmrPlayerPosition.Enabled = True
            Catch ex As Exception
            Finally
            End Try
        End Sub

        Private Sub trckVolume_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            audioCDPlayer1.Volume = trckVolume.Value
            Console.WriteLine("audioCDPlayer1.Volume")
            Console.WriteLine(audioCDPlayer1.Volume)
            lblVolume.Text = trckVolume.Value.ToString()
        End Sub

        Private Sub frmAudioCDPlayer_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)

#Region "SafeExit"
            If audioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped Then
                audioCDPlayer1.[Resume]()
                audioCDPlayer1.[Stop]()

                While audioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped
                    Thread.Sleep(100)
                End While
            End If
#End Region

        End Sub

        Private Sub cmdCheckLicense_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioCDPlayer1.CheckLicense() Then MessageBox.Show("Registration is OK")
        End Sub
    End Class
End Namespace
