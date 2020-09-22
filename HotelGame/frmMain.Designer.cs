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
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tmrClean = new System.Windows.Forms.Timer(this.components);
            this.tmrMisc = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDialog7 = new System.Windows.Forms.Label();
            this.lblDialog6 = new System.Windows.Forms.Label();
            this.lblDialog5 = new System.Windows.Forms.Label();
            this.lblDialog4 = new System.Windows.Forms.Label();
            this.lblDialog3 = new System.Windows.Forms.Label();
            this.lblDialog2 = new System.Windows.Forms.Label();
            this.lblDialog1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblDialog8 = new System.Windows.Forms.Label();
            this.tbcHotel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.gbxAction.SuspendLayout();
            this.gbxRooms.SuspendLayout();
            this.tabWork.SuspendLayout();
            this.tabResturant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcHotel
            // 
            this.tbcHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcHotel.Controls.Add(this.tabMain);
            this.tbcHotel.Controls.Add(this.tabWork);
            this.tbcHotel.Controls.Add(this.tabResturant);
            this.tbcHotel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tbcHotel.Location = new System.Drawing.Point(369, 57);
            this.tbcHotel.Name = "tbcHotel";
            this.tbcHotel.SelectedIndex = 0;
            this.tbcHotel.Size = new System.Drawing.Size(327, 444);
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
            this.tabMain.Size = new System.Drawing.Size(319, 418);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "A worn down Hotel";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 45);
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
            this.gbxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbxAction.Location = new System.Drawing.Point(9, 205);
            this.gbxAction.Name = "gbxAction";
            this.gbxAction.Size = new System.Drawing.Size(306, 201);
            this.gbxAction.TabIndex = 0;
            this.gbxAction.TabStop = false;
            this.gbxAction.Text = "Actions";
            this.gbxAction.Visible = false;
            // 
            // pgbClean
            // 
            this.pgbClean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbClean.BackColor = System.Drawing.Color.DarkRed;
            this.pgbClean.Location = new System.Drawing.Point(7, 94);
            this.pgbClean.Name = "pgbClean";
            this.pgbClean.Size = new System.Drawing.Size(293, 10);
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
            this.progressBar7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar7.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar7.Location = new System.Drawing.Point(8, 184);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(293, 10);
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
            this.progressBar6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar6.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar6.Location = new System.Drawing.Point(8, 139);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(293, 10);
            this.progressBar6.TabIndex = 3;
            this.progressBar6.Visible = false;
            // 
            // btnCleanRoom
            // 
            this.btnCleanRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanRoom.Location = new System.Drawing.Point(7, 65);
            this.btnCleanRoom.Name = "btnCleanRoom";
            this.btnCleanRoom.Size = new System.Drawing.Size(293, 23);
            this.btnCleanRoom.TabIndex = 1;
            this.btnCleanRoom.Text = "Clean a room:  10$";
            this.tooltip.SetToolTip(this.btnCleanRoom, "Clean a room");
            this.btnCleanRoom.UseVisualStyleBackColor = true;
            this.btnCleanRoom.Visible = false;
            this.btnCleanRoom.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // pbrWait
            // 
            this.pbrWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrWait.BackColor = System.Drawing.Color.DarkRed;
            this.pbrWait.Location = new System.Drawing.Point(7, 49);
            this.pbrWait.Name = "pbrWait";
            this.pbrWait.Size = new System.Drawing.Size(293, 10);
            this.pbrWait.TabIndex = 3;
            this.pbrWait.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(7, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
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
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(8, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(293, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Clean a room  -  10 $";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // btnWait
            // 
            this.btnWait.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWait.Location = new System.Drawing.Point(7, 20);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(293, 23);
            this.btnWait.TabIndex = 0;
            this.btnWait.Text = "Do absolutely nothing";
            this.tooltip.SetToolTip(this.btnWait, "Because doing nothing is an option.");
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Visible = false;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // gbxRooms
            // 
            this.gbxRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRooms.Controls.Add(this.pgbRoom);
            this.gbxRooms.Controls.Add(this.btnExpand);
            this.gbxRooms.Controls.Add(this.pbrRooms);
            this.gbxRooms.Controls.Add(this.btnNewRoom);
            this.gbxRooms.Location = new System.Drawing.Point(10, 58);
            this.gbxRooms.Name = "gbxRooms";
            this.gbxRooms.Size = new System.Drawing.Size(306, 141);
            this.gbxRooms.TabIndex = 0;
            this.gbxRooms.TabStop = false;
            this.gbxRooms.Text = "Construct Rooms (0/5 Blocks)";
            // 
            // pgbRoom
            // 
            this.pgbRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbRoom.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pgbRoom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pgbRoom.Location = new System.Drawing.Point(7, 49);
            this.pgbRoom.Name = "pgbRoom";
            this.pgbRoom.Size = new System.Drawing.Size(293, 10);
            this.pgbRoom.TabIndex = 3;
            this.pgbRoom.Visible = false;
            // 
            // btnExpand
            // 
            this.btnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpand.Enabled = false;
            this.btnExpand.Location = new System.Drawing.Point(7, 65);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(293, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand Room capacity";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Visible = false;
            // 
            // pbrRooms
            // 
            this.pbrRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrRooms.BackColor = System.Drawing.Color.DarkRed;
            this.pbrRooms.Location = new System.Drawing.Point(7, 94);
            this.pbrRooms.Name = "pbrRooms";
            this.pbrRooms.Size = new System.Drawing.Size(292, 10);
            this.pbrRooms.TabIndex = 3;
            this.pbrRooms.Visible = false;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRoom.Location = new System.Drawing.Point(7, 20);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(292, 23);
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
            this.tabWork.Size = new System.Drawing.Size(319, 434);
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
            this.tabResturant.Size = new System.Drawing.Size(319, 434);
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
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(607, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 19);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "1999/02/26";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lblTime.Location = new System.Drawing.Point(647, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 19);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 179;
            this.tmrTime.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblDialog7
            // 
            this.lblDialog7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog7.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog7.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDialog7.Location = new System.Drawing.Point(8, 390);
            this.lblDialog7.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog7.Name = "lblDialog7";
            this.lblDialog7.Size = new System.Drawing.Size(346, 55);
            this.lblDialog7.TabIndex = 14;
            this.lblDialog7.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog6
            // 
            this.lblDialog6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog6.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog6.ForeColor = System.Drawing.Color.LightGray;
            this.lblDialog6.Location = new System.Drawing.Point(8, 327);
            this.lblDialog6.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog6.Name = "lblDialog6";
            this.lblDialog6.Size = new System.Drawing.Size(346, 57);
            this.lblDialog6.TabIndex = 15;
            this.lblDialog6.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog5
            // 
            this.lblDialog5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog5.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog5.ForeColor = System.Drawing.Color.Silver;
            this.lblDialog5.Location = new System.Drawing.Point(8, 264);
            this.lblDialog5.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog5.Name = "lblDialog5";
            this.lblDialog5.Size = new System.Drawing.Size(346, 57);
            this.lblDialog5.TabIndex = 16;
            this.lblDialog5.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog4
            // 
            this.lblDialog4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog4.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog4.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDialog4.Location = new System.Drawing.Point(8, 201);
            this.lblDialog4.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog4.Name = "lblDialog4";
            this.lblDialog4.Size = new System.Drawing.Size(346, 57);
            this.lblDialog4.TabIndex = 17;
            this.lblDialog4.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog3
            // 
            this.lblDialog3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog3.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog3.ForeColor = System.Drawing.Color.Gray;
            this.lblDialog3.Location = new System.Drawing.Point(8, 138);
            this.lblDialog3.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog3.Name = "lblDialog3";
            this.lblDialog3.Size = new System.Drawing.Size(346, 57);
            this.lblDialog3.TabIndex = 18;
            this.lblDialog3.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog2
            // 
            this.lblDialog2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog2.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog2.ForeColor = System.Drawing.Color.DimGray;
            this.lblDialog2.Location = new System.Drawing.Point(8, 75);
            this.lblDialog2.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog2.Name = "lblDialog2";
            this.lblDialog2.Size = new System.Drawing.Size(346, 57);
            this.lblDialog2.TabIndex = 19;
            this.lblDialog2.Text = "Text\r\nText\r\nText";
            // 
            // lblDialog1
            // 
            this.lblDialog1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog1.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog1.ForeColor = System.Drawing.Color.Black;
            this.lblDialog1.Location = new System.Drawing.Point(8, 12);
            this.lblDialog1.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog1.Name = "lblDialog1";
            this.lblDialog1.Size = new System.Drawing.Size(346, 57);
            this.lblDialog1.TabIndex = 20;
            this.lblDialog1.Text = "as dasdasdasdasd asdasdasdasdasdasdasdasd asdasd ads as dads  asd asd a sda sd ds" +
    " dsa ads das ads  asd ads sadasad asd asd as da sd asd d  d d d as d asd as d as" +
    "d asd ads";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(369, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 19);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Hotel Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.lblRooms.Location = new System.Drawing.Point(369, 29);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(100, 19);
            this.lblRooms.TabIndex = 9;
            this.lblRooms.Text = "Rooms 0/0/0";
            this.lblRooms.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDialog8
            // 
            this.lblDialog8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDialog8.BackColor = System.Drawing.Color.Transparent;
            this.lblDialog8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog8.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDialog8.Location = new System.Drawing.Point(8, 451);
            this.lblDialog8.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.lblDialog8.Name = "lblDialog8";
            this.lblDialog8.Size = new System.Drawing.Size(346, 55);
            this.lblDialog8.TabIndex = 13;
            this.lblDialog8.Text = "Text\r\nText\r\nText";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 513);
            this.Controls.Add(this.lblDialog8);
            this.Controls.Add(this.lblDialog7);
            this.Controls.Add(this.lblDialog6);
            this.Controls.Add(this.lblDialog5);
            this.Controls.Add(this.lblDialog4);
            this.Controls.Add(this.lblDialog3);
            this.Controls.Add(this.lblDialog2);
            this.Controls.Add(this.lblDialog1);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbcHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.Text = "Hotel Game";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Validated += new System.EventHandler(this.frmMain_Validated);
            this.tbcHotel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.gbxAction.ResumeLayout(false);
            this.gbxRooms.ResumeLayout(false);
            this.tabWork.ResumeLayout(false);
            this.tabResturant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDialog7;
        private System.Windows.Forms.Label lblDialog6;
        private System.Windows.Forms.Label lblDialog5;
        private System.Windows.Forms.Label lblDialog4;
        private System.Windows.Forms.Label lblDialog3;
        private System.Windows.Forms.Label lblDialog2;
        private System.Windows.Forms.Label lblDialog1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblDialog8;
    }
}

