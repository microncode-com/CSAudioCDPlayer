#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.Threading

Public Class frmAudioCDPlayer

    ''' <summary>
    ''' When done playing event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioCDPlayer1_PlayDone(sender As Object, e As EventArgs) Handles AudioCDPlayer1.PlayDone

        'Reset the form controls:
        lblMeterOut.Text = "0"
        trckPlayerPosition.Value = 0
        lblPositionCurrent.Text = "00:00:00"

        tmrPlayerPosition.Enabled = False
        Console.WriteLine("Done.")

    End Sub

    ''' <summary>
    ''' On error.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioCDPlayer1_PlayError(sender As Object, e As CSAudioCDPlayer.MessageArgs) Handles AudioCDPlayer1.PlayError

        'Get the error message and number:
        Console.WriteLine(e.Number & " (" & e.Number & ")")

    End Sub

    Private Sub AudioCDPlayer1_PlayPaused(sender As Object, e As EventArgs) Handles AudioCDPlayer1.PlayPaused

    End Sub

    Private Sub AudioCDPlayer1_PlayProgress(sender As Object, e As CSAudioCDPlayer.ProgressArgs) Handles AudioCDPlayer1.PlayProgress

    End Sub

    ''' <summary>
    ''' When start playing event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioCDPlayer1_PlayStart(sender As Object, e As EventArgs) Handles AudioCDPlayer1.PlayStart

        trckPlayerPosition.Minimum = 0
        trckPlayerPosition.Maximum = CInt(AudioCDPlayer1.Length.TotalSeconds)
        lblPositionTotal.Text = "audioPlayer1.Length"
        lblPositionTotal.Text = String.Format("{0:hh\:mm\:ss}", AudioCDPlayer1.Length)

        'Set the volume of the playing:
        AudioCDPlayer1.Volume = trckVolume.Value

        Console.WriteLine("Start.")

    End Sub

    ''' <summary>
    ''' Form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioCDPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioCDPlayer1.UserName = "Your email"
        AudioCDPlayer1.UserKey = "Your registration key"

        'Get the CD drives:
        cboDevice.DataSource = AudioCDPlayer1.GetDevices()
        If cboDevice.Items.Count > 0 Then cboDevice.SelectedIndex = 0

#Region "LoadAudioProperties"

        'Samplerate
        cboPlayerSamplerate.DataSource = AudioCDPlayer1.GetSamplerates()
        cboPlayerSamplerate.Text = "44100"

        'Bit depth
        cboPlayerBits.DataSource = AudioCDPlayer1.GetBits()
        cboPlayerBits.Text = "16"

        'Channels
        cboPlayerChannels.DataSource = AudioCDPlayer1.GetChannels()
        cboPlayerChannels.Text = "2"

        'Player mode
        cboPlayerMode.DataSource = AudioCDPlayer1.GetPlayerModes()
        cboPlayerMode.SelectedItem = AudioCDPlayer1.GetEnumValue(AudioCDPlayer1.Mode)

#End Region

        LoadCDTracks()

    End Sub

    Private Sub cboPlayerMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPlayerMode.SelectedIndexChanged

        'Get the selected capture mode:
        Dim mode As CSAudioCDPlayer.Mode = CType([Enum].Parse(GetType(CSAudioCDPlayer.Mode), cboPlayerMode.Text), CSAudioCDPlayer.Mode)

        'Get the audio devices:
        cboPlayerAudioDevice.DataSource = AudioCDPlayer1.GetDevices(mode)

        'Try to set the default device:
        Dim default_device_index As Integer = AudioCDPlayer1.GetDeviceDefaultIndex(mode)

        If default_device_index <> -1 Then
            'Set the default device index:
            cboPlayerAudioDevice.SelectedIndex = default_device_index
        Else
            'LineIn will always return -1:
            cboPlayerAudioDevice.SelectedIndex = 0
        End If

    End Sub

    ''' <summary>
    ''' Load the CD tracks to the list view.
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadCDTracks() As Integer
        If AudioCDPlayer1.CDIsReady(cboDevice.SelectedIndex) = False Then
            MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
            Return -1
        Else
            lstTracks.Items.Clear()
            Dim arr As String() = New String(4) {}
            Dim itm As ListViewItem

            For Each trck As CSAudioCDPlayer.AudioCDPlayer.TrackInfo In AudioCDPlayer1.GetTracks(cboDevice.SelectedIndex)
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

    ''' <summary>
    ''' Open the CD door.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        AudioCDPlayer1.EjectCD(cboDevice.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Close the CD door.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        AudioCDPlayer1.CloseCD(cboDevice.SelectedIndex)

    End Sub

    ''' <summary>
    ''' Refresh the CD tracks.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadCDTracks()

    End Sub

    ''' <summary>
    ''' Load the FreeDB using the events.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdLoadFreeDB_Click(sender As Object, e As EventArgs) Handles cmdLoadFreeDB.Click

        If FreeDB1.CDIsReady(cboDevice.SelectedIndex) = False Then
            MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.")
            Return
        Else
            FreeDB1.GetFreeDBInfo(cboDevice.SelectedIndex)
        End If

    End Sub

    Private Sub FreeDB1_FreeDBAlbum(sender As Object, e As CSFreeDBLib.FreeDB.AlbumInfo) Handles FreeDB1.FreeDBAlbum

        Console.WriteLine(e.AlbumName)
        lblArtist.Text = e.AlbumArtist
        lblAlbum.Text = e.AlbumName

    End Sub

    Private Sub FreeDB1_FreeDBDone(sender As Object) Handles FreeDB1.FreeDBDone

        toolStripStatusLabel1.Text = "Done."

    End Sub

    Private Sub FreeDB1_FreeDBError(sender As Object, e As CSFreeDB.Core.MessageArgs) Handles FreeDB1.FreeDBError

        MessageBox.Show(e.String + "(" + e.Number + ")")
        toolStripStatusLabel1.Text = e.String + "(" + e.Number + ")"

    End Sub

    Private Sub FreeDB1_FreeDBStatus(sender As Object, e As CSFreeDB.Core.MessageArgs) Handles FreeDB1.FreeDBStatus

        Console.WriteLine(e.String)
        toolStripStatusLabel1.Text = e.String

    End Sub

    Private Sub FreeDB1_FreeDBTracks(sender As Object, e As CSFreeDBLib.FreeDB.TrackInfo) Handles FreeDB1.FreeDBTracks

        Console.WriteLine(e.TrackName)
        lstTracks.Items(e.TrackNumber - 1).SubItems(1).Text = e.TrackName

    End Sub

    ''' <summary>
    ''' Load the FreeDB using Async.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdLoadFreeDBAsync_Click(sender As Object, e As EventArgs) Handles cmdLoadFreeDBAsync.Click

        Dim cntr As Integer = 0

        For Each trckFreeDB As String In FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo
            lstTracks.Items(cntr).SubItems(1).Text = trckFreeDB.ToString()
            cntr = cntr + 1
        Next

        If cntr > 0 Then
            lblArtist.Text = "Artist: " & FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist
            lblAlbum.Text = "Album: " & FreeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName
        End If

    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click

        'If the control is already playing, stop before replay:
        If AudioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped Then

            'If paused
            AudioCDPlayer1.[Resume]()

            'Stop
            AudioCDPlayer1.[Stop]()

            While AudioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped
                Thread.Sleep(100)
            End While

        End If

        'There is no id3 image tag, just display a black background
        AudioVisualization1.BackColor = Color.Black
        AudioVisualization1.pictureBoxGraph.BackgroundImage = Nothing

        'Set the visualization of the player control:
        AudioCDPlayer1.AudioVisualization = AudioVisualization1

        'Set the meter of the control:
        AudioCDPlayer1.AudioMeter = AudioMeter1

        'Set the sample rate to play (from 8000 to 48000):
        AudioCDPlayer1.Samplerate = CType([Enum].Parse(GetType(CSAudioCDPlayer.Samplerate), cboPlayerSamplerate.Text), CSAudioCDPlayer.Samplerate)

        'Set the bit-depth to play (8, 16, 24, 32):
        AudioCDPlayer1.Bits = CType([Enum].Parse(GetType(CSAudioCDPlayer.Bits), cboPlayerBits.Text), CSAudioCDPlayer.Bits)

        'Set the number of the channels to play (1 or 2):
        AudioCDPlayer1.Channels = CType([Enum].Parse(GetType(CSAudioCDPlayer.Channels), cboPlayerChannels.Text), CSAudioCDPlayer.Channels)

        'Set the mode of the player (WASAPI or LineOut):
        AudioCDPlayer1.Mode = CType([Enum].Parse(GetType(CSAudioCDPlayer.Mode), cboPlayerMode.Text), CSAudioCDPlayer.Mode)

        'Set the audio device index to play to:
        AudioCDPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex

        'Set the device index and the track index to play:
        AudioCDPlayer1.DriveIndex = cboDevice.SelectedIndex
        AudioCDPlayer1.TrackIndex = lstTracks.Items.IndexOf(lstTracks.SelectedItems(0))

        'Or by a file name
        'AudioCDPlayer1.FileName = "F:\\Track02.cda"

        'Start playing:
        AudioCDPlayer1.Play()

        'Start the meter timer:
        tmrMeterOut.Interval = 40
        tmrMeterOut.Enabled = True

        'Start the position timer:
        tmrPlayerPosition.Interval = 100
        tmrPlayerPosition.Enabled = True

    End Sub

    ''' <summary>
    ''' Display the position of the playing operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tmrPlayerPosition_Tick(sender As Object, e As EventArgs) Handles tmrPlayerPosition.Tick
        Try
            trckPlayerPosition.Value = CInt(AudioCDPlayer1.Position.TotalSeconds)
            lblPositionCurrent.Text = String.Format("{0:hh\:mm\:ss}", AudioCDPlayer1.Position)
        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub tmrMeterOut_Tick(sender As Object, e As EventArgs) Handles tmrMeterOut.Tick
        lblMeterOut.Text = AudioMeter1.Meter.ToString("0.00")
    End Sub

    ''' <summary>
    ''' Pause play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click

        If AudioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Playing Then AudioCDPlayer1.Pause()

    End Sub

    ''' <summary>
    ''' Resume play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click

        If AudioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Paused Then AudioCDPlayer1.[Resume]()

    End Sub

    ''' <summary>
    ''' Stop to play.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click

        'Stop to play.
        AudioCDPlayer1.Stop()

        'Disable the timer of the meter
        AudioCDPlayer1.Enabled = False

    End Sub

    ''' <summary>
    ''' Disable the tmrPlayerPosition on mouse down.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckPlayerPosition_MouseDown(sender As Object, e As MouseEventArgs) Handles trckPlayerPosition.MouseDown

        tmrPlayerPosition.Enabled = False

    End Sub

    ''' <summary>
    ''' Seek the play to the slider position.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckPlayerPosition_MouseUp(sender As Object, e As MouseEventArgs) Handles trckPlayerPosition.MouseUp

        If AudioCDPlayer1.PlayingState = CSAudioCDPlayer.PlayingState.Stopped Then Return

        Try
            AudioCDPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value)
            tmrPlayerPosition.Enabled = True
        Catch ex As Exception
        Finally
        End Try

    End Sub

    ''' <summary>
    ''' Set the volume of the player.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trckVolume_ValueChanged(sender As Object, e As EventArgs) Handles trckVolume.ValueChanged
        AudioCDPlayer1.Volume = trckVolume.Value
        Console.WriteLine("audioCDPlayer1.Volume")
        Console.WriteLine(AudioCDPlayer1.Volume)
        lblVolume.Text = trckVolume.Value.ToString()
    End Sub

    ''' <summary>
    ''' Safe exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioCDPlayer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If AudioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped Then
            AudioCDPlayer1.[Resume]()
            AudioCDPlayer1.[Stop]()

            While AudioCDPlayer1.PlayingState <> CSAudioCDPlayer.PlayingState.Stopped
                Thread.Sleep(100)
            End While
        End If

    End Sub

    ''' <summary>
    ''' Check the license.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click

        If AudioCDPlayer1.CheckLicense() Then MessageBox.Show("Registration is OK")

    End Sub
End Class
