namespace HotelGame
{
    partial class frmMain
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
            this.tbxInfo = new System.Windows.Forms.RichTextBox();
            this.tbcHotel = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.gbxAction = new System.Windows.Forms.GroupBox();
            this.pgbClean = new System.Windows.Forms.ProgressBar();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.btnCleanRoom = new System.Windows.Forms.Button();
            this.pbrWait = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnWait = new System.Windows.Forms.Button();
            this.gbxRooms = new System.Windows.Forms.GroupBox();
            this.pgbRoom = new System.Windows.Forms.ProgressBar();
            this.btnExpand = new System.Windows.Forms.Button();
            this.pbrRooms = new System.Windows.Forms.ProgressBar();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabResturant = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.tmrRoomBuild = new System.Windows.Forms.Timer(this.components);
            this.tbxHotelInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tmrClean = new System.Windows.Forms.Timer(this.components);
            this.tmrMisc = new System.Windows.Forms.Timer(this.components);
            this.btnGuestList = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlDialogBox = new System.Windows.Forms.Panel();
            this.lblDialogInfo = new System.Windows.Forms.Label();
            this.lblDialogText = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbcHotel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.gbxAction.SuspendLayout();
            this.gbxRooms.SuspendLayout();
            this.tabWork.SuspendLayout();
            this.tabResturant.SuspendLayout();
            this.pnlDialogBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInfo
            // 
            this.tbxInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxInfo.ForeColor = System.Drawing.Color.Black;
            this.tbxInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxInfo.Location = new System.Drawing.Point(13, 217);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ReadOnly = true;
            this.tbxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbxInfo.Size = new System.Drawing.Size(292, 233);
            this.tbxInfo.TabIndex = 0;
            this.tbxInfo.Text = "";
            // 
            // tbcHotel
            // 
            this.tbcHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcHotel.Controls.Add(this.tabMain);
            this.tbcHotel.Controls.Add(this.tabWork);
            this.tbcHotel.Controls.Add(this.tabResturant);
            this.tbcHotel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbcHotel.Location = new System.Drawing.Point(318, 12);
            this.tbcHotel.Name = "tbcHotel";
            this.tbcHotel.SelectedIndex = 0;
            this.tbcHotel.Size = new System.Drawing.Size(292, 438);
            this.tbcHotel.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.Window;
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.progressBar5);
            this.tabMain.Controls.Add(this.gbxAction);
            this.tabMain.Controls.Add(this.gbxRooms);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(284, 412);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "A worn down Hotel";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "A pretty worn down building you acquired very cheep from a suspicious salesman. I" +
    "t would not surprise you if the building is in a worse state than it seems.  \r\n";
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar5.Location = new System.Drawing.Point(6, 495);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(271, 10);
            this.progressBar5.TabIndex = 3;
            this.progressBar5.Visible = false;
            // 
            // gbxAction
            // 
            this.gbxAction.Controls.Add(this.pgbClean);
            this.gbxAction.Controls.Add(this.progressBar9);
            this.gbxAction.Controls.Add(this.progressBar7);
            this.gbxAction.Controls.Add(this.progressBar8);
            this.gbxAction.Controls.Add(this.progressBar6);
            this.gbxAction.Controls.Add(this.btnCleanRoom);
            this.gbxAction.Controls.Add(this.pbrWait);
            this.gbxAction.Controls.Add(this.button1);
            this.gbxAction.Controls.Add(this.button6);
            this.gbxAction.Controls.Add(this.button4);
            this.gbxAction.Controls.Add(this.btnWait);
            this.gbxAction.Location = new System.Drawing.Point(6, 195);
            this.gbxAction.Name = "gbxAction";
            this.gbxAction.Size = new System.Drawing.Size(271, 211);
            this.gbxAction.TabIndex = 0;
            this.gbxAction.TabStop = false;
            this.gbxAction.Text = "Actions";
            this.gbxAction.Visible = false;
            // 
            // pgbClean
            // 
            this.pgbClean.BackColor = System.Drawing.Color.DarkRed;
            this.pgbClean.Location = new System.Drawing.Point(7, 94);
            this.pgbClean.Name = "pgbClean";
            this.pgbClean.Size = new System.Drawing.Size(258, 10);
            this.pgbClean.TabIndex = 3;
            this.pgbClean.Visible = false;
            // 
            // progressBar9
            // 
            this.progressBar9.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar9.Location = new System.Drawing.Point(8, 276);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(258, 10);
            this.progressBar9.TabIndex = 3;
            this.progressBar9.Visible = false;
            // 
            // progressBar7
            // 
            this.progressBar7.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar7.Location = new System.Drawing.Point(8, 184);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(258, 10);
            this.progressBar7.TabIndex = 3;
            this.progressBar7.Visible = false;
            // 
            // progressBar8
            // 
            this.progressBar8.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar8.Location = new System.Drawing.Point(8, 231);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(258, 10);
            this.progressBar8.TabIndex = 3;
            this.progressBar8.Visible = false;
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar6.Location = new System.Drawing.Point(8, 139);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(258, 10);
            this.progressBar6.TabIndex = 3;
            this.progressBar6.Visible = false;
            // 
            // btnCleanRoom
            // 
            this.btnCleanRoom.Location = new System.Drawing.Point(7, 65);
            this.btnCleanRoom.Name = "btnCleanRoom";
            this.btnCleanRoom.Size = new System.Drawing.Size(258, 23);
            this.btnCleanRoom.TabIndex = 1;
            this.btnCleanRoom.Text = "Clean a room:  10$";
            this.tooltip.SetToolTip(this.btnCleanRoom, "Clean a room");
            this.btnCleanRoom.UseVisualStyleBackColor = true;
            this.btnCleanRoom.Visible = false;
            this.btnCleanRoom.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // pbrWait
            // 
            this.pbrWait.BackColor = System.Drawing.Color.DarkRed;
            this.pbrWait.Location = new System.Drawing.Point(7, 49);
            this.pbrWait.Name = "pbrWait";
            this.pbrWait.Size = new System.Drawing.Size(258, 10);
            this.pbrWait.TabIndex = 3;
            this.pbrWait.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Expand Room capacity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Clean a room  -  10 $";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Clean a room  -  10 $";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(7, 20);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(258, 23);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "Do absolutely nothing";
            this.tooltip.SetToolTip(this.btnWait, "Because doing nothing is an option.");
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Visible = false;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // gbxRooms
            // 
            this.gbxRooms.Controls.Add(this.pgbRoom);
            this.gbxRooms.Controls.Add(this.btnExpand);
            this.gbxRooms.Controls.Add(this.pbrRooms);
            this.gbxRooms.Controls.Add(this.btnNewRoom);
            this.gbxRooms.Location = new System.Drawing.Point(7, 48);
            this.gbxRooms.Name = "gbxRooms";
            this.gbxRooms.Size = new System.Drawing.Size(271, 141);
            this.gbxRooms.TabIndex = 0;
            this.gbxRooms.TabStop = false;
            this.gbxRooms.Text = "Construct Rooms (0/5 Blocks)";
            // 
            // pgbRoom
            // 
            this.pgbRoom.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pgbRoom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pgbRoom.Location = new System.Drawing.Point(7, 49);
            this.pgbRoom.Name = "pgbRoom";
            this.pgbRoom.Size = new System.Drawing.Size(258, 10);
            this.pgbRoom.TabIndex = 3;
            this.pgbRoom.Visible = false;
            // 
            // btnExpand
            // 
            this.btnExpand.Enabled = false;
            this.btnExpand.Location = new System.Drawing.Point(7, 65);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(258, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand Room capacity";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Visible = false;
            // 
            // pbrRooms
            // 
            this.pbrRooms.BackColor = System.Drawing.Color.DarkRed;
            this.pbrRooms.Location = new System.Drawing.Point(7, 94);
            this.pbrRooms.Name = "pbrRooms";
            this.pbrRooms.Size = new System.Drawing.Size(257, 10);
            this.pbrRooms.TabIndex = 3;
            this.pbrRooms.Visible = false;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(7, 20);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(257, 23);
            this.btnNewRoom.TabIndex = 0;
            this.btnNewRoom.Text = "Build new Room";
            this.tooltip.SetToolTip(this.btnNewRoom, "Make room for more guests");
            this.btnNewRoom.UseVisualStyleBackColor = true;
            this.btnNewRoom.Visible = false;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // tabWork
            // 
            this.tabWork.BackColor = System.Drawing.Color.LightYellow;
            this.tabWork.Controls.Add(this.label1);
            this.tabWork.Location = new System.Drawing.Point(4, 22);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabWork.Size = new System.Drawing.Size(284, 412);
            this.tabWork.TabIndex = 1;
            this.tabWork.Text = "Your messy desk";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your desk is literally just some upside down chairs with a bunch of important pap" +
    "ers on them. It seriously needs an upgrade. ";
            // 
            // tabResturant
            // 
            this.tabResturant.BackColor = System.Drawing.Color.Black;
            this.tabResturant.Controls.Add(this.label2);
            this.tabResturant.Location = new System.Drawing.Point(4, 22);
            this.tabResturant.Name = "tabResturant";
            this.tabResturant.Padding = new System.Windows.Forms.Padding(3);
            this.tabResturant.Size = new System.Drawing.Size(284, 412);
            this.tabResturant.TabIndex = 2;
            this.tabResturant.Text = "An old coffe mug";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "In the corner of you office there\'s an old coffe mug on the floor. What a nice gi" +
    "ft from the previous owner! You should get rid of it before the mold spreads.";
            // 
            // tmrGameUpdate
            // 
            this.tmrGameUpdate.Enabled = true;
            this.tmrGameUpdate.Interval = 50;
            this.tmrGameUpdate.Tick += new System.EventHandler(this.onEveryIngameMin);
            // 
            // tmrRoomBuild
            // 
            this.tmrRoomBuild.Interval = 50;
            this.tmrRoomBuild.Tick += new System.EventHandler(this.tmrBuild_Tick);
            // 
            // tbxHotelInfo
            // 
            this.tbxHotelInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.tbxHotelInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxHotelInfo.DetectUrls = false;
            this.tbxHotelInfo.ForeColor = System.Drawing.Color.Black;
            this.tbxHotelInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxHotelInfo.Location = new System.Drawing.Point(12, 34);
            this.tbxHotelInfo.Name = "tbxHotelInfo";
            this.tbxHotelInfo.ReadOnly = true;
            this.tbxHotelInfo.Size = new System.Drawing.Size(292, 115);
            this.tbxHotelInfo.TabIndex = 4;
            this.tbxHotelInfo.Text = "Hotel Name: \n\nMoney: \nGuests: \nIncome: \nRooms:\nDrty. Rooms: \nAvbl. Rooms: ";
            this.tbxHotelInfo.TextChanged += new System.EventHandler(this.tbxHotelInfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Event Log:";
            // 
            // tmrClean
            // 
            this.tmrClean.Interval = 10;
            this.tmrClean.Tick += new System.EventHandler(this.tmrClean_Tick);
            // 
            // tmrMisc
            // 
            this.tmrMisc.Interval = 10;
            this.tmrMisc.Tick += new System.EventHandler(this.tmrWait);
            // 
            // btnGuestList
            // 
            this.btnGuestList.Location = new System.Drawing.Point(12, 158);
            this.btnGuestList.Name = "btnGuestList";
            this.btnGuestList.Size = new System.Drawing.Size(292, 39);
            this.btnGuestList.TabIndex = 7;
            this.btnGuestList.Text = "Show Guest List";
            this.btnGuestList.UseVisualStyleBackColor = true;
            this.btnGuestList.Visible = false;
            this.btnGuestList.Click += new System.EventHandler(this.btnGuestList_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "1999/02/26";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(270, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 179;
            this.tmrTime.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // pnlDialogBox
            // 
            this.pnlDialogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDialogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDialogBox.Controls.Add(this.lblDialogInfo);
            this.pnlDialogBox.Controls.Add(this.lblDialogText);
            this.pnlDialogBox.Location = new System.Drawing.Point(12, 456);
            this.pnlDialogBox.Name = "pnlDialogBox";
            this.pnlDialogBox.Size = new System.Drawing.Size(598, 100);
            this.pnlDialogBox.TabIndex = 5;
            // 
            // lblDialogInfo
            // 
            this.lblDialogInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDialogInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogInfo.Location = new System.Drawing.Point(0, 71);
            this.lblDialogInfo.Name = "lblDialogInfo";
            this.lblDialogInfo.Size = new System.Drawing.Size(596, 27);
            this.lblDialogInfo.TabIndex = 1;
            this.lblDialogInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDialogText
            // 
            this.lblDialogText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDialogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogText.Location = new System.Drawing.Point(0, 0);
            this.lblDialogText.Name = "lblDialogText";
            this.lblDialogText.Size = new System.Drawing.Size(596, 98);
            this.lblDialogText.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 568);
            this.Controls.Add(this.pnlDialogBox);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnGuestList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxHotelInfo);
            this.Controls.Add(this.tbcHotel);
            this.Controls.Add(this.tbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Your new Hotel";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Validated += new System.EventHandler(this.frmMain_Validated);
            this.tbcHotel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.gbxAction.ResumeLayout(false);
            this.gbxRooms.ResumeLayout(false);
            this.tabWork.ResumeLayout(false);
            this.tabResturant.ResumeLayout(false);
            this.pnlDialogBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxInfo;
        private System.Windows.Forms.TabControl tbcHotel;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.GroupBox gbxRooms;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCleanRoom;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.TabPage tabResturant;
        private System.Windows.Forms.Timer tmrGameUpdate;
        private System.Windows.Forms.ProgressBar pgbRoom;
        private System.Windows.Forms.ProgressBar pbrRooms;
        private System.Windows.Forms.ProgressBar pgbClean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbxHotelInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.GroupBox gbxAction;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar pbrWait;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Timer tmrClean;
        private System.Windows.Forms.Timer tmrMisc;
        private System.Windows.Forms.Timer tmrRoomBuild;
        private System.Windows.Forms.Button btnGuestList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel pnlDialogBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDialogInfo;
        private System.Windows.Forms.Label lblDialogText;
    }
}

