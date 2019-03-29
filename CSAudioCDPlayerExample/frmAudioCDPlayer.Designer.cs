namespace CSAudioCDPlayerExample
{
    partial class frmAudioCDPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioCDPlayer));
            CSAudioCDPlayer.MessageArgs messageArgs1 = new CSAudioCDPlayer.MessageArgs();
            CSAudioCDPlayer.ProgressArgs progressArgs1 = new CSAudioCDPlayer.ProgressArgs();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrMeterOut = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerPosition = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerMode = new System.Windows.Forms.Label();
            this.cboPlayerMode = new System.Windows.Forms.ComboBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cTrackType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lstTracks = new System.Windows.Forms.ListView();
            this.trckVolume = new System.Windows.Forms.TrackBar();
            this.cmdResume = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.lblPositionTotal = new System.Windows.Forms.Label();
            this.lblPositionCurrent = new System.Windows.Forms.Label();
            this.cboPlayerAudioDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPlayerBits = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.lblAudioDevice = new System.Windows.Forms.Label();
            this.cboPlayerChannels = new System.Windows.Forms.ComboBox();
            this.lblBits = new System.Windows.Forms.Label();
            this.cboPlayerSamplerate = new System.Windows.Forms.ComboBox();
            this.lblMeterOut = new System.Windows.Forms.Label();
            this.lblMediaFile = new System.Windows.Forms.Label();
            this.trckPlayerPosition = new System.Windows.Forms.TrackBar();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmdLoadFreeDB = new System.Windows.Forms.Button();
            this.cmdLoadFreeDBAsync = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            this.audioCDPlayer1 = new CSAudioCDPlayer.AudioCDPlayer();
            this.freeDB1 = new CSAudioCDPlayer.FreeDB();
            this.audioMeter1 = new CSAudioCDPlayer.AudioMeter();
            this.audioVisualization1 = new CSAudioCDPlayer.AudioVisualization();
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckPlayerPosition)).BeginInit();
            this.grpSource.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrMeterOut
            // 
            this.tmrMeterOut.Tick += new System.EventHandler(this.tmrMeterOut_Tick);
            // 
            // tmrPlayerPosition
            // 
            this.tmrPlayerPosition.Tick += new System.EventHandler(this.tmrPlayerPosition_Tick);
            // 
            // lblPlayerMode
            // 
            this.lblPlayerMode.AutoSize = true;
            this.lblPlayerMode.Location = new System.Drawing.Point(27, 628);
            this.lblPlayerMode.Name = "lblPlayerMode";
            this.lblPlayerMode.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerMode.TabIndex = 264;
            this.lblPlayerMode.Text = "Player Mode";
            // 
            // cboPlayerMode
            // 
            this.cboPlayerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerMode.FormattingEnabled = true;
            this.cboPlayerMode.Location = new System.Drawing.Point(30, 644);
            this.cboPlayerMode.Name = "cboPlayerMode";
            this.cboPlayerMode.Size = new System.Drawing.Size(244, 21);
            this.cboPlayerMode.TabIndex = 263;
            this.cboPlayerMode.SelectedIndexChanged += new System.EventHandler(this.cboPlayerMode_SelectedIndexChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(644, 263);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(19, 13);
            this.lblVolume.TabIndex = 274;
            this.lblVolume.Text = "50";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(22, 46);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(562, 21);
            this.cboDevice.TabIndex = 175;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(22, 27);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(44, 13);
            this.lblDevice.TabIndex = 174;
            this.lblDevice.Text = "Device:";
            // 
            // cTrackType
            // 
            this.cTrackType.Text = "Track Type";
            this.cTrackType.Width = 100;
            // 
            // cTrackTime
            // 
            this.cTrackTime.Text = "Track Time";
            this.cTrackTime.Width = 120;
            // 
            // cTrackName
            // 
            this.cTrackName.Text = "Track Name";
            this.cTrackName.Width = 220;
            // 
            // cTrackNum
            // 
            this.cTrackNum.Text = "Track Num";
            this.cTrackNum.Width = 80;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(372, 336);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 201;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(519, 336);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblAlbum.TabIndex = 200;
            this.lblAlbum.Text = "Album";
            // 
            // lstTracks
            // 
            this.lstTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTrackNum,
            this.cTrackName,
            this.cTrackTime,
            this.cTrackType});
            this.lstTracks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTracks.FullRowSelect = true;
            this.lstTracks.GridLines = true;
            this.lstTracks.HideSelection = false;
            this.lstTracks.Location = new System.Drawing.Point(22, 82);
            this.lstTracks.MultiSelect = false;
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(562, 232);
            this.lstTracks.TabIndex = 176;
            this.lstTracks.UseCompatibleStateImageBehavior = false;
            this.lstTracks.View = System.Windows.Forms.View.Details;
            // 
            // trckVolume
            // 
            this.trckVolume.Location = new System.Drawing.Point(618, 124);
            this.trckVolume.Maximum = 100;
            this.trckVolume.Name = "trckVolume";
            this.trckVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckVolume.Size = new System.Drawing.Size(45, 292);
            this.trckVolume.TabIndex = 271;
            this.trckVolume.Value = 50;
            this.trckVolume.ValueChanged += new System.EventHandler(this.trckVolume_ValueChanged);
            // 
            // cmdResume
            // 
            this.cmdResume.Location = new System.Drawing.Point(174, 851);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(75, 23);
            this.cmdResume.TabIndex = 270;
            this.cmdResume.Text = "Resume";
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(93, 851);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 269;
            this.cmdPause.Text = "Pause";
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // lblPositionTotal
            // 
            this.lblPositionTotal.AutoSize = true;
            this.lblPositionTotal.Location = new System.Drawing.Point(557, 771);
            this.lblPositionTotal.Name = "lblPositionTotal";
            this.lblPositionTotal.Size = new System.Drawing.Size(49, 13);
            this.lblPositionTotal.TabIndex = 268;
            this.lblPositionTotal.Text = "00:00:00";
            // 
            // lblPositionCurrent
            // 
            this.lblPositionCurrent.AutoSize = true;
            this.lblPositionCurrent.Location = new System.Drawing.Point(15, 771);
            this.lblPositionCurrent.Name = "lblPositionCurrent";
            this.lblPositionCurrent.Size = new System.Drawing.Size(49, 13);
            this.lblPositionCurrent.TabIndex = 267;
            this.lblPositionCurrent.Text = "00:00:00";
            // 
            // cboPlayerAudioDevice
            // 
            this.cboPlayerAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerAudioDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerAudioDevice.FormattingEnabled = true;
            this.cboPlayerAudioDevice.Location = new System.Drawing.Point(30, 706);
            this.cboPlayerAudioDevice.Name = "cboPlayerAudioDevice";
            this.cboPlayerAudioDevice.Size = new System.Drawing.Size(244, 21);
            this.cboPlayerAudioDevice.TabIndex = 265;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 261;
            this.label1.Text = "Channels";
            // 
            // cboPlayerBits
            // 
            this.cboPlayerBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerBits.FormattingEnabled = true;
            this.cboPlayerBits.Location = new System.Drawing.Point(404, 706);
            this.cboPlayerBits.Name = "cboPlayerBits";
            this.cboPlayerBits.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerBits.TabIndex = 259;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(304, 690);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 258;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // lblAudioDevice
            // 
            this.lblAudioDevice.AutoSize = true;
            this.lblAudioDevice.Location = new System.Drawing.Point(27, 690);
            this.lblAudioDevice.Name = "lblAudioDevice";
            this.lblAudioDevice.Size = new System.Drawing.Size(71, 13);
            this.lblAudioDevice.TabIndex = 266;
            this.lblAudioDevice.Text = "Audio Device";
            // 
            // cboPlayerChannels
            // 
            this.cboPlayerChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerChannels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerChannels.FormattingEnabled = true;
            this.cboPlayerChannels.Location = new System.Drawing.Point(501, 706);
            this.cboPlayerChannels.Name = "cboPlayerChannels";
            this.cboPlayerChannels.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerChannels.TabIndex = 262;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(401, 690);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 260;
            this.lblBits.Text = "Bit depth";
            // 
            // cboPlayerSamplerate
            // 
            this.cboPlayerSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayerSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlayerSamplerate.FormattingEnabled = true;
            this.cboPlayerSamplerate.Location = new System.Drawing.Point(307, 706);
            this.cboPlayerSamplerate.Name = "cboPlayerSamplerate";
            this.cboPlayerSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboPlayerSamplerate.TabIndex = 257;
            // 
            // lblMeterOut
            // 
            this.lblMeterOut.AutoSize = true;
            this.lblMeterOut.Location = new System.Drawing.Point(598, 452);
            this.lblMeterOut.Name = "lblMeterOut";
            this.lblMeterOut.Size = new System.Drawing.Size(28, 13);
            this.lblMeterOut.TabIndex = 256;
            this.lblMeterOut.Text = "0.00";
            // 
            // lblMediaFile
            // 
            this.lblMediaFile.Location = new System.Drawing.Point(9, 767);
            this.lblMediaFile.Name = "lblMediaFile";
            this.lblMediaFile.Size = new System.Drawing.Size(602, 36);
            this.lblMediaFile.TabIndex = 255;
            // 
            // trckPlayerPosition
            // 
            this.trckPlayerPosition.Location = new System.Drawing.Point(8, 800);
            this.trckPlayerPosition.Name = "trckPlayerPosition";
            this.trckPlayerPosition.Size = new System.Drawing.Size(609, 45);
            this.trckPlayerPosition.TabIndex = 253;
            this.trckPlayerPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trckPlayerPosition_MouseDown);
            this.trckPlayerPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckPlayerPosition_MouseUp);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(255, 851);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 252;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(12, 851);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(75, 23);
            this.cmdPlay.TabIndex = 251;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 16);
            this.label3.TabIndex = 249;
            this.label3.Text = ".NET component to play audio CD.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 248;
            this.label2.Text = "CSAudioCDPlayer |";
            // 
            // grpSource
            // 
            this.grpSource.BackColor = System.Drawing.SystemColors.Control;
            this.grpSource.Controls.Add(this.lblArtist);
            this.grpSource.Controls.Add(this.lblAlbum);
            this.grpSource.Controls.Add(this.btnRefresh);
            this.grpSource.Controls.Add(this.btnClose);
            this.grpSource.Controls.Add(this.btnOpen);
            this.grpSource.Controls.Add(this.cmdLoadFreeDB);
            this.grpSource.Controls.Add(this.cmdLoadFreeDBAsync);
            this.grpSource.Controls.Add(this.lstTracks);
            this.grpSource.Controls.Add(this.cboDevice);
            this.grpSource.Controls.Add(this.lblDevice);
            this.grpSource.Location = new System.Drawing.Point(8, 67);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(604, 374);
            this.grpSource.TabIndex = 246;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRefresh.Location = new System.Drawing.Point(484, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 199;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(375, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 23);
            this.btnClose.TabIndex = 198;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOpen.Location = new System.Drawing.Point(266, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(103, 23);
            this.btnOpen.TabIndex = 197;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmdLoadFreeDB
            // 
            this.cmdLoadFreeDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdLoadFreeDB.Location = new System.Drawing.Point(20, 329);
            this.cmdLoadFreeDB.Name = "cmdLoadFreeDB";
            this.cmdLoadFreeDB.Size = new System.Drawing.Size(132, 27);
            this.cmdLoadFreeDB.TabIndex = 196;
            this.cmdLoadFreeDB.Text = "Load FreeDB";
            this.cmdLoadFreeDB.UseVisualStyleBackColor = true;
            this.cmdLoadFreeDB.Click += new System.EventHandler(this.cmdLoadFreeDB_Click);
            // 
            // cmdLoadFreeDBAsync
            // 
            this.cmdLoadFreeDBAsync.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdLoadFreeDBAsync.Location = new System.Drawing.Point(158, 329);
            this.cmdLoadFreeDBAsync.Name = "cmdLoadFreeDBAsync";
            this.cmdLoadFreeDBAsync.Size = new System.Drawing.Size(132, 27);
            this.cmdLoadFreeDBAsync.TabIndex = 195;
            this.cmdLoadFreeDBAsync.Text = "Load FreeDB Async";
            this.cmdLoadFreeDBAsync.UseVisualStyleBackColor = true;
            this.cmdLoadFreeDBAsync.Click += new System.EventHandler(this.cmdLoadFreeDBAsync_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 889);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 250;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 45);
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-21, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 45);
            this.pictureBox2.TabIndex = 282;
            this.pictureBox2.TabStop = false;
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(458, 851);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(168, 23);
            this.cmdCheckLicense.TabIndex = 284;
            this.cmdCheckLicense.Text = "Order a license online";
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // audioCDPlayer1
            // 
            this.audioCDPlayer1.AudioDevice = 0;
            this.audioCDPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioCDPlayer1.FileName = "";
            this.audioCDPlayer1.Location = new System.Drawing.Point(610, 567);
            messageArgs1.Number = 0;
            messageArgs1.String = null;
            this.audioCDPlayer1.MessageArgs = messageArgs1;
            this.audioCDPlayer1.Name = "audioCDPlayer1";
            this.audioCDPlayer1.Position = System.TimeSpan.Parse("00:00:00");
            progressArgs1.Position = System.TimeSpan.Parse("00:00:00");
            this.audioCDPlayer1.ProgressArgs = progressArgs1;
            this.audioCDPlayer1.SamplerateVal = 0;
            this.audioCDPlayer1.Size = new System.Drawing.Size(52, 52);
            this.audioCDPlayer1.TabIndex = 283;
            this.audioCDPlayer1.UserKey = "Your registration key";
            this.audioCDPlayer1.UserName = "Your email";
            this.audioCDPlayer1.Volume = 100;
            this.audioCDPlayer1.PlayError += new CSAudioCDPlayer.OnPlayErrorEventHandler(this.audioCDPlayer1_PlayError);
            this.audioCDPlayer1.PlayDone += new System.EventHandler(this.audioCDPlayer1_PlayDone);
            this.audioCDPlayer1.PlayStart += new System.EventHandler(this.audioCDPlayer1_PlayStart);
            // 
            // freeDB1
            // 
            this.freeDB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.freeDB1.FreeDBClientName = "FreedbDemo";
            this.freeDB1.FreeDBHostname = "abc.company";
            this.freeDB1.FreeDBSiteAddress = "us.freedb.org";
            this.freeDB1.FreeDBUserName = "test";
            this.freeDB1.FreeDBVersion = "1.0";
            this.freeDB1.Location = new System.Drawing.Point(610, 625);
            this.freeDB1.Name = "freeDB1";
            this.freeDB1.Size = new System.Drawing.Size(52, 52);
            this.freeDB1.TabIndex = 278;
            this.freeDB1.FreeDBStatus += new CSFreeDBLib.FreeDB.FreeDBStatusEventHandler(this.freeDB1_FreeDBStatus);
            this.freeDB1.FreeDBError += new CSFreeDBLib.FreeDB.FreeDBErrorEventHandler(this.freeDB1_FreeDBError);
            this.freeDB1.FreeDBTracks += new CSFreeDBLib.FreeDB.FreeDBTracksEventHandler(this.freeDB1_FreeDBTracks);
            this.freeDB1.FreeDBAlbum += new CSFreeDBLib.FreeDB.FreeDBAlbumEventHandler(this.freeDB1_FreeDBAlbum);
            this.freeDB1.FreeDBDone += new CSFreeDBLib.FreeDB.FreeDBDoneEventHandler(this.freeDB1_FreeDBDone);
            // 
            // audioMeter1
            // 
            this.audioMeter1.Location = new System.Drawing.Point(28, 447);
            this.audioMeter1.Name = "audioMeter1";
            this.audioMeter1.Size = new System.Drawing.Size(564, 23);
            this.audioMeter1.TabIndex = 277;
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.BackColor = System.Drawing.Color.Black;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.ColorBase = System.Drawing.Color.DarkRed;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Snow;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(28, 476);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.Size = new System.Drawing.Size(564, 127);
            this.audioVisualization1.TabIndex = 275;
            this.audioVisualization1.UseAverage = true;
            // 
            // frmAudioCDPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 911);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.audioCDPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.freeDB1);
            this.Controls.Add(this.audioMeter1);
            this.Controls.Add(this.audioVisualization1);
            this.Controls.Add(this.lblPlayerMode);
            this.Controls.Add(this.cboPlayerMode);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trckVolume);
            this.Controls.Add(this.cmdResume);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.lblPositionTotal);
            this.Controls.Add(this.lblPositionCurrent);
            this.Controls.Add(this.cboPlayerAudioDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPlayerBits);
            this.Controls.Add(this.lblSamplerate);
            this.Controls.Add(this.lblAudioDevice);
            this.Controls.Add(this.cboPlayerChannels);
            this.Controls.Add(this.lblBits);
            this.Controls.Add(this.cboPlayerSamplerate);
            this.Controls.Add(this.lblMeterOut);
            this.Controls.Add(this.lblMediaFile);
            this.Controls.Add(this.trckPlayerPosition);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioCDPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioCDPlayer - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioCDPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioCDPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckPlayerPosition)).EndInit();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSAudioCDPlayer.AudioVisualization audioVisualization1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer tmrMeterOut;
        private System.Windows.Forms.Timer tmrPlayerPosition;
        private System.Windows.Forms.Label lblPlayerMode;
        private System.Windows.Forms.ComboBox cboPlayerMode;
        private System.Windows.Forms.Label lblVolume;
        internal System.Windows.Forms.ComboBox cboDevice;
        internal System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ColumnHeader cTrackType;
        private System.Windows.Forms.ColumnHeader cTrackTime;
        private System.Windows.Forms.ColumnHeader cTrackName;
        private System.Windows.Forms.ColumnHeader cTrackNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label lblArtist;
        internal System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.ListView lstTracks;
        private System.Windows.Forms.TrackBar trckVolume;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Label lblPositionTotal;
        private System.Windows.Forms.Label lblPositionCurrent;
        private System.Windows.Forms.ComboBox cboPlayerAudioDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPlayerBits;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.Label lblAudioDevice;
        private System.Windows.Forms.ComboBox cboPlayerChannels;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cboPlayerSamplerate;
        private System.Windows.Forms.Label lblMeterOut;
        private System.Windows.Forms.Label lblMediaFile;
        private System.Windows.Forms.TrackBar trckPlayerPosition;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button cmdLoadFreeDB;
        private System.Windows.Forms.Button cmdLoadFreeDBAsync;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private CSAudioCDPlayer.AudioMeter audioMeter1;
        private CSAudioCDPlayer.FreeDB freeDB1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CSAudioCDPlayer.AudioCDPlayer audioCDPlayer1;
        private System.Windows.Forms.Button cmdCheckLicense;
    }
}