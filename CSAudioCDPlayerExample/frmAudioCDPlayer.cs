#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CSAudioCDPlayerExample
{
    public partial class frmAudioCDPlayer : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioCDPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioCDPlayer_Load(object sender, EventArgs e)
        {
            audioCDPlayer1.UserName = "Your email";
            audioCDPlayer1.UserKey = "Your registration key";

            //Get the CD drives:
            cboDevice.DataSource = audioCDPlayer1.GetDevices();
            if (cboDevice.Items.Count > 0) cboDevice.SelectedIndex = 0;

            #region LoadAudioProperties

            //Samplerate
            cboPlayerSamplerate.DataSource = audioCDPlayer1.GetSamplerates();
            cboPlayerSamplerate.Text = "44100";

            //Bit depth
            cboPlayerBits.DataSource = audioCDPlayer1.GetBits();
            cboPlayerBits.Text = "16";

            //Channels
            cboPlayerChannels.DataSource = audioCDPlayer1.GetChannels();
            cboPlayerChannels.Text = "2";

            //Player mode
            cboPlayerMode.DataSource = audioCDPlayer1.GetPlayerModes();
            cboPlayerMode.SelectedItem = audioCDPlayer1.GetEnumValue(audioCDPlayer1.Mode);

            #endregion

            //Load the CD tracks:
            LoadCDTracks();

        }
        
        private void cboPlayerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected capture mode:
            CSAudioCDPlayer.Mode mode = (CSAudioCDPlayer.Mode)Enum.Parse(typeof(CSAudioCDPlayer.Mode), cboPlayerMode.Text);

            //Get the audio devices:
            cboPlayerAudioDevice.DataSource = audioCDPlayer1.GetDevices(mode);

            //Try to set the default device:
            int default_device_index = audioCDPlayer1.GetDeviceDefaultIndex(mode);

            if (default_device_index != -1)
                //Set the default device index:
                cboPlayerAudioDevice.SelectedIndex = default_device_index;
            else
                //LineIn will always return -1:
                cboPlayerAudioDevice.SelectedIndex = 0;
        }

        /// <summary>
        /// Load the CD tracks to the list view.
        /// </summary>
        /// <returns></returns>
        int LoadCDTracks()
        {

            if (audioCDPlayer1.CDIsReady(cboDevice.SelectedIndex) == false)
            {
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.");
                return -1;
            }
            else
            {

                lstTracks.Items.Clear();

                string[] arr = new string[5];
                ListViewItem itm;

                foreach (CSAudioCDPlayer.AudioCDPlayer.TrackInfo trck in audioCDPlayer1.GetTracks(cboDevice.SelectedIndex))
                {
                    arr[0] = trck.TrackNumber.ToString();
                    arr[1] = "Track" + trck.TrackNumber.ToString();
                    arr[2] = TimeSpan.FromMilliseconds(trck.TrackLength).ToString("hh\\:mm\\:ss\\.ff");
                    arr[3] = trck.TrackType;

                    itm = new ListViewItem(arr);

                    lstTracks.Items.Add(itm);
                }

                if (lstTracks.Items.Count > 0)
                {
                    lstTracks.Items[0].Selected = true;

                }

                return 0;
            }
        }

        /// <summary>
        /// Open the CD door.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            audioCDPlayer1.EjectCD(cboDevice.SelectedIndex);
        }

        /// <summary>
        /// Close the CD door.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            audioCDPlayer1.CloseCD(cboDevice.SelectedIndex);
        }

        /// <summary>
        /// Refresh the CD tracks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCDTracks();
        }

        /// <summary>
        /// Load the FreeDB using the events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadFreeDB_Click(object sender, EventArgs e)
        {
            if (freeDB1.CDIsReady(cboDevice.SelectedIndex) == false)
            {
                MessageBox.Show("The CD is not ready. Please insert an audio cd to the drive.");
                return;
            }
            else
            {
                //Call the FreeDB and receive the data in the events:
                freeDB1.GetFreeDBInfo(cboDevice.SelectedIndex);

            }
        }

        /// <summary>
        /// Load the FreeDB using Async.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadFreeDBAsync_Click(object sender, EventArgs e)
        {
            int cntr = 0;

            // Tracks names:
            foreach (string trckFreeDB in freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).FreeDBTracksInfo)
            {
                lstTracks.Items[cntr].SubItems[1].Text = trckFreeDB.ToString();
                cntr = cntr + 1;
            }


            //Album / Artist name:
            if (cntr > 0)
            {
                lblArtist.Text = "Artist: " + freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).Artist;
                lblAlbum.Text = "Album: " + freeDB1.GetFreeDBInfoAsync(cboDevice.SelectedIndex).AlbumName;
            }
        }

        private void freeDB1_FreeDBDone(object sender)
        {
            toolStripStatusLabel1.Text = "Done.";
        }

        private void freeDB1_FreeDBError(object sender, CSFreeDB.Core.MessageArgs e)
        {
            MessageBox.Show(e.String + "(" + e.Number + ")");

            toolStripStatusLabel1.Text = e.String + "(" + e.Number + ")";
        }

        private void freeDB1_FreeDBStatus(object sender, CSFreeDB.Core.MessageArgs e)
        {
            Console.WriteLine(e.String);
            toolStripStatusLabel1.Text = e.String;
        }

        private void freeDB1_FreeDBAlbum(object sender, CSFreeDBLib.FreeDB.AlbumInfo e)
        {
            Console.WriteLine(e.AlbumName);
            lblArtist.Text = e.AlbumArtist;
            lblAlbum.Text = e.AlbumName;
        }

        private void freeDB1_FreeDBTracks(object sender, CSFreeDBLib.FreeDB.TrackInfo e)
        {
            Console.WriteLine(e.TrackName);

            lstTracks.Items[e.TrackNumber - 1].SubItems[1].Text = e.TrackName;
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {

            //If the control is already playing, stop before replay:
            if (audioCDPlayer1.PlayingState != CSAudioCDPlayer.PlayingState.Stopped)
            {
                //If paused
                audioCDPlayer1.Resume();

                //Stop
                audioCDPlayer1.Stop();

                //Wait for the Stopped state
                while (audioCDPlayer1.PlayingState != CSAudioCDPlayer.PlayingState.Stopped)
                    Thread.Sleep(100);
            }
            
            //There is no id3 image tag, just display a black background
            audioVisualization1.BackColor = Color.Black;
            audioVisualization1.pictureBoxGraph.BackgroundImage = null;

            //Set the visualization of the player control:
            audioCDPlayer1.AudioVisualization = audioVisualization1;

            //Set the meter of the control:
            audioCDPlayer1.AudioMeter = audioMeter1;

            //Set the sample rate to play (from 8000 to 48000):
            audioCDPlayer1.Samplerate = (CSAudioCDPlayer.Samplerate)Enum.Parse(typeof(CSAudioCDPlayer.Samplerate), cboPlayerSamplerate.Text);

            //Set the bit-depth to play (8, 16, 24, 32):
            audioCDPlayer1.Bits = (CSAudioCDPlayer.Bits)Enum.Parse(typeof(CSAudioCDPlayer.Bits), cboPlayerBits.Text);

            //Set the number of the channels to play (1 or 2):
            audioCDPlayer1.Channels = (CSAudioCDPlayer.Channels)Enum.Parse(typeof(CSAudioCDPlayer.Channels), cboPlayerChannels.Text);

            //Set the mode of the player (WASAPI or LineOut):
            audioCDPlayer1.Mode = (CSAudioCDPlayer.Mode)Enum.Parse(typeof(CSAudioCDPlayer.Mode), cboPlayerMode.Text);

            //Set the audio device index to play to:
            audioCDPlayer1.AudioDevice = cboPlayerAudioDevice.SelectedIndex;

            //Set the device index and the track index to play:
            audioCDPlayer1.DriveIndex = cboDevice.SelectedIndex;
            audioCDPlayer1.TrackIndex = lstTracks.Items.IndexOf(lstTracks.SelectedItems[0]);

            //Or by a file name:
            //audioCDPlayer1.FileName = "F:\\Track02.cda";

            //Start playing:
            audioCDPlayer1.Play();

            //Start the meter timer:
            tmrMeterOut.Interval = 40;
            tmrMeterOut.Enabled = true;

            //Start the position timer:
            tmrPlayerPosition.Interval = 100;
            tmrPlayerPosition.Enabled = true;
        }


        /// <summary>
        /// Display the position of the playing operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrPlayerPosition_Tick(object sender, EventArgs e)
        {
            try
            {
                trckPlayerPosition.Value = (int)audioCDPlayer1.Position.TotalSeconds;

                lblPositionCurrent.Text = string.Format(@"{0:hh\:mm\:ss}", audioCDPlayer1.Position);

            }
            catch (Exception ex)
            {
                //RaiseError(ex);
            }
            finally
            {

            }
        }

        private void tmrMeterOut_Tick(object sender, EventArgs e)
        {
            lblMeterOut.Text = audioMeter1.Meter.ToString("0.00");
        }

        /// <summary>
        /// Pause play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPause_Click(object sender, EventArgs e)
        {
            if (audioCDPlayer1.PlayingState == CSAudioCDPlayer.PlayingState.Playing)
                audioCDPlayer1.Pause();
        }

        /// <summary>
        /// Resume play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdResume_Click(object sender, EventArgs e)
        {
            if (audioCDPlayer1.PlayingState == CSAudioCDPlayer.PlayingState.Paused)
                audioCDPlayer1.Resume();
        }

        /// <summary>
        /// Stop to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStop_Click(object sender, EventArgs e)
        {
            //Stop to play.
            audioCDPlayer1.Stop();

            //Disable the timer of the meter:
            audioCDPlayer1.Enabled = false;
        }

        /// <summary>
        /// When start playing event.
        /// </summary>
        private void audioCDPlayer1_PlayStart(object sender, EventArgs e)
        {
            trckPlayerPosition.Minimum = 0;
            trckPlayerPosition.Maximum = (int)audioCDPlayer1.Length.TotalSeconds;

            lblPositionTotal.Text = "audioPlayer1.Length";
            lblPositionTotal.Text = string.Format(@"{0:hh\:mm\:ss}", audioCDPlayer1.Length);

            //Set the volume of the playing:
            audioCDPlayer1.Volume = trckVolume.Value;
            
            Console.WriteLine("Start.");

        }

        /// <summary>
        /// When done playing event.
        /// </summary>
        private void audioCDPlayer1_PlayDone(object sender, EventArgs e)
        {
            //Reset the form controls:
            lblMeterOut.Text = "0";
            trckPlayerPosition.Value = 0;
            lblPositionCurrent.Text = "00:00:00";
            tmrPlayerPosition.Enabled = false;

            Console.WriteLine("Done.");
        }

        /// <summary>
        /// On error.
        /// </summary>
        private void audioCDPlayer1_PlayError(object sender, CSAudioCDPlayer.MessageArgs e)
        {
            //Get the error message and number:
            Console.WriteLine(e.Number + " (" + e.Number + ")");
            
        }

        /// <summary>
        /// Disable the tmrPlayerPosition on mouse down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckPlayerPosition_MouseDown(object sender, MouseEventArgs e)
        {
            tmrPlayerPosition.Enabled = false;
        }

        /// <summary>
        /// Seek the play to the slider position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckPlayerPosition_MouseUp(object sender, MouseEventArgs e)
        {
            if (audioCDPlayer1.PlayingState == CSAudioCDPlayer.PlayingState.Stopped) return;

            try
            {
                audioCDPlayer1.Position = TimeSpan.FromSeconds(trckPlayerPosition.Value);
                tmrPlayerPosition.Enabled = true;

            }
            catch (Exception ex)
            {
                //RaiseError(ex);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Set the volume of the player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trckVolume_ValueChanged(object sender, EventArgs e)
        {
            audioCDPlayer1.Volume = trckVolume.Value;

            Console.WriteLine("audioCDPlayer1.Volume");
            Console.WriteLine(audioCDPlayer1.Volume);

            lblVolume.Text = trckVolume.Value.ToString();
        }

        /// <summary>
        /// Safe exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioCDPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit

            //If the control is already playing, stop before replay:
            if (audioCDPlayer1.PlayingState != CSAudioCDPlayer.PlayingState.Stopped)
            {
                //If paused
                audioCDPlayer1.Resume();

                //Stop
                audioCDPlayer1.Stop();

                //Wait for the Stopped state
                while (audioCDPlayer1.PlayingState != CSAudioCDPlayer.PlayingState.Stopped)
                    Thread.Sleep(100);
            }

            #endregion
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioCDPlayer1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }

    }

}
