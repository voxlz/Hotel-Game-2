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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbxRooms = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pgbRoom = new System.Windows.Forms.ProgressBar();
            this.btnCapacity = new System.Windows.Forms.Button();
            this.btnCleanRoom = new System.Windows.Forms.Button();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabResturant = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.tmrRoomBuild = new System.Windows.Forms.Timer(this.components);
            this.tbxHotelInfo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tbcHotel.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.gbxRooms.SuspendLayout();
            this.tabWork.SuspendLayout();
            this.tabResturant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInfo
            // 
            this.tbxInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxInfo.Location = new System.Drawing.Point(12, 157);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ReadOnly = true;
            this.tbxInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.tbxInfo.Size = new System.Drawing.Size(292, 404);
            this.tbxInfo.TabIndex = 0;
            this.tbxInfo.Text = "As you close the door behind you, happiness spreads throughout your body. You can" +
    " finally start building your own hotel, just like you always dreamed! Better get" +
    " moving!";
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
            this.tbcHotel.Size = new System.Drawing.Size(292, 553);
            this.tbcHotel.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.progressBar5);
            this.tabMain.Controls.Add(this.progressBar2);
            this.tabMain.Controls.Add(this.gbxMisc);
            this.tabMain.Controls.Add(this.gbxRooms);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(284, 527);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "A worn down Hotel";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "A pretty worn down building you acquired very cheep from a suspicious salesman. I" +
    "t would not suprice you if the building is in a worse state than it seems.  ";
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar5.Location = new System.Drawing.Point(6, 511);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(271, 10);
            this.progressBar5.TabIndex = 3;
            this.progressBar5.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar2.Location = new System.Drawing.Point(7, 195);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(271, 10);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Visible = false;
            // 
            // gbxMisc
            // 
            this.gbxMisc.Controls.Add(this.progressBar9);
            this.gbxMisc.Controls.Add(this.progressBar7);
            this.gbxMisc.Controls.Add(this.progressBar3);
            this.gbxMisc.Controls.Add(this.progressBar8);
            this.gbxMisc.Controls.Add(this.progressBar6);
            this.gbxMisc.Controls.Add(this.progressBar4);
            this.gbxMisc.Controls.Add(this.button5);
            this.gbxMisc.Controls.Add(this.button1);
            this.gbxMisc.Controls.Add(this.button6);
            this.gbxMisc.Controls.Add(this.button4);
            this.gbxMisc.Controls.Add(this.button2);
            this.gbxMisc.Controls.Add(this.button3);
            this.gbxMisc.Location = new System.Drawing.Point(6, 211);
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.Size = new System.Drawing.Size(271, 294);
            this.gbxMisc.TabIndex = 0;
            this.gbxMisc.TabStop = false;
            this.gbxMisc.Text = "Misc.";
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
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar3.Location = new System.Drawing.Point(7, 94);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(258, 10);
            this.progressBar3.TabIndex = 3;
            this.progressBar3.Visible = false;
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
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar4.Location = new System.Drawing.Point(7, 49);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(258, 10);
            this.progressBar4.TabIndex = 3;
            this.progressBar4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Expand Room capacity";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
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
            this.button6.Click += new System.EventHandler(this.btnCleanRoom_Click);
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
            this.button4.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clean a room  -  10 $";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Wait for guest to leave";
            this.tooltip.SetToolTip(this.button3, "Because doing nothing is an option.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // gbxRooms
            // 
            this.gbxRooms.Controls.Add(this.progressBar1);
            this.gbxRooms.Controls.Add(this.pgbRoom);
            this.gbxRooms.Controls.Add(this.btnCapacity);
            this.gbxRooms.Controls.Add(this.btnCleanRoom);
            this.gbxRooms.Controls.Add(this.btnNewRoom);
            this.gbxRooms.Location = new System.Drawing.Point(7, 48);
            this.gbxRooms.Name = "gbxRooms";
            this.gbxRooms.Size = new System.Drawing.Size(271, 141);
            this.gbxRooms.TabIndex = 0;
            this.gbxRooms.TabStop = false;
            this.gbxRooms.Text = "Rooms (0/5)";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Location = new System.Drawing.Point(7, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(258, 10);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // pgbRoom
            // 
            this.pgbRoom.BackColor = System.Drawing.Color.DarkRed;
            this.pgbRoom.Location = new System.Drawing.Point(7, 49);
            this.pgbRoom.Name = "pgbRoom";
            this.pgbRoom.Size = new System.Drawing.Size(258, 10);
            this.pgbRoom.TabIndex = 3;
            this.pgbRoom.Visible = false;
            // 
            // btnCapacity
            // 
            this.btnCapacity.Location = new System.Drawing.Point(7, 110);
            this.btnCapacity.Name = "btnCapacity";
            this.btnCapacity.Size = new System.Drawing.Size(258, 23);
            this.btnCapacity.TabIndex = 2;
            this.btnCapacity.Text = "Expand Room capacity";
            this.btnCapacity.UseVisualStyleBackColor = true;
            this.btnCapacity.Visible = false;
            // 
            // btnCleanRoom
            // 
            this.btnCleanRoom.Location = new System.Drawing.Point(7, 65);
            this.btnCleanRoom.Name = "btnCleanRoom";
            this.btnCleanRoom.Size = new System.Drawing.Size(258, 23);
            this.btnCleanRoom.TabIndex = 1;
            this.btnCleanRoom.Text = "Clean a room  -  10 $";
            this.btnCleanRoom.UseVisualStyleBackColor = true;
            this.btnCleanRoom.Visible = false;
            this.btnCleanRoom.Click += new System.EventHandler(this.btnCleanRoom_Click);
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Location = new System.Drawing.Point(7, 20);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(258, 23);
            this.btnNewRoom.TabIndex = 0;
            this.btnNewRoom.Text = "Build new Room";
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
            this.tabWork.Size = new System.Drawing.Size(284, 527);
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
            this.label1.Text = "Your desk is literally just some upside down chairs with a bunch of importan pape" +
    "rs on them. It seriously needs an upgrade. ";
            // 
            // tabResturant
            // 
            this.tabResturant.BackColor = System.Drawing.Color.LightCyan;
            this.tabResturant.Controls.Add(this.label2);
            this.tabResturant.Location = new System.Drawing.Point(4, 22);
            this.tabResturant.Name = "tabResturant";
            this.tabResturant.Padding = new System.Windows.Forms.Padding(3);
            this.tabResturant.Size = new System.Drawing.Size(284, 527);
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
            this.tmrGameUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tmrRoomBuild
            // 
            this.tmrRoomBuild.Interval = 10;
            this.tmrRoomBuild.Tick += new System.EventHandler(this.tmrBuild_Tick);
            // 
            // tbxHotelInfo
            // 
            this.tbxHotelInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.tbxHotelInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxHotelInfo.DetectUrls = false;
            this.tbxHotelInfo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxHotelInfo.Location = new System.Drawing.Point(12, 34);
            this.tbxHotelInfo.Name = "tbxHotelInfo";
            this.tbxHotelInfo.ReadOnly = true;
            this.tbxHotelInfo.Size = new System.Drawing.Size(292, 96);
            this.tbxHotelInfo.TabIndex = 4;
            this.tbxHotelInfo.Text = "Hotel Name: \n\nMoney: \nIncome: \nRooms: \nAvbl. Rooms: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Info:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Log:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(622, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxHotelInfo);
            this.Controls.Add(this.tbcHotel);
            this.Controls.Add(this.tbxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Your new Hotel";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcHotel.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.gbxMisc.ResumeLayout(false);
            this.gbxRooms.ResumeLayout(false);
            this.tabWork.ResumeLayout(false);
            this.tabResturant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbxInfo;
        private System.Windows.Forms.TabControl tbcHotel;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.GroupBox gbxRooms;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.Button btnCapacity;
        private System.Windows.Forms.Button btnCleanRoom;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.TabPage tabResturant;
        private System.Windows.Forms.Timer tmrGameUpdate;
        private System.Windows.Forms.ProgressBar pgbRoom;
        private System.Windows.Forms.Timer tmrRoomBuild;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbxHotelInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip tooltip;
    }
}

