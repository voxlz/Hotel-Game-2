using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace HotelGame
{
    public partial class frmMain : Form
    {
        #region variables
        SoundPlayer soundGuestArriving;
        SoundPlayer soundCash;
        Hotel hotel;
        DateTime lastDateTime = new DateTime(1999, 2, 26, 0, 0, 0);
        Random r = new Random();
        static DateTime inGameTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 0, 0);

        static List<Tuple<string, string>> outputQueue = new List<Tuple<string, string>>();

        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        int waitCount = 0;
        int idleCounter = 0;

        bool dayTime = true;
        bool morning = false;
        bool evening = false;




        // Sounds
        static string soundPath;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            hotel = new Hotel(Output, UpdateLabels);
            Start();
        }

        #region My funktions

        public void Start()
        {
            soundPath = path + @"\Sound Effects\Leaving Guest.wav";
            soundGuestArriving = new SoundPlayer(soundPath);
            soundPath = path + @"\Sound Effects\Cash.wav";
            soundCash = new SoundPlayer(soundPath);

            tbcHotel.TabPages.Remove(tabWork);
            tbcHotel.TabPages.Remove(tabResturant);
            btnNewRoom.Visible = true;
            //numRoom.Visible = true;


            Thread messagePrinter = new Thread(() => {
                while (true)
                {
                    string message;

                    lock (outputQueue)
                    {
                        while (outputQueue.Count == 0)
                        {
                            Monitor.Wait(outputQueue);
                        }
                        var messageTuple = outputQueue[0];
                        message = messageTuple.Item1;
                        var info = messageTuple.Item2;

                        lblDialogInfo.Invoke(new Action(() => {
                            string oldText = tbxInfo.Text;

                            if (lblDialogText.Text.Length > 0)
                            {
                                tbxInfo.Text = lblDialogText.Text + "  " + lblDialogInfo.Text;
                                if (oldText.Length > 0)
                                    tbxInfo.AppendText("\n\n" + oldText);
                            }

                            if (info.Length > 0)
                                lblDialogInfo.Text = "(" + info + ")";
                            else
                                lblDialogInfo.Text = "";

                            lblDialogText.Text = "";
                        }));

                        outputQueue.RemoveAt(0);
                    }

                    Speak(message);
                    idleCounter = 0;
                }
            });
            messagePrinter.Start();
        }

        private void Output(string text, string info = "")
        {
            Thread producer = new Thread(() => {
                lock (outputQueue)
                {
                    outputQueue.Add(new Tuple<string, string>(text, info));
                    Monitor.Pulse(outputQueue);
                }

                });
            producer.Start();

        }
        private void Output(string[] textArray, string extraInfo)
        {
            string text = textArray[r.Next(textArray.Length)];
            Output(text, extraInfo);
        }
        private void Speak(string text)
        {
            string soundPath = path + @"\Sound Effects\Text Scroll Beep.wav";
            SoundPlayer dialogbeep = new SoundPlayer(soundPath);

            for (int i = 0; i < text.Length; i++)
            {
                Invoke(new Action(() => {
                    lblDialogText.Text += text[i];
                }));

                if (text[i] != ' ')
                {
                    dialogbeep.Play();
                } else
                {
                    Thread.Sleep(15);
                }
                Thread.Sleep(40);
            }
            Thread.Sleep(500);
        }
        private void NewRoom()
        {
            hotel.buildNewRoom();
        }
        private void UpdateLabels(Hotel h)
        {
            // Update LabelText
            tbxHotelInfo.Text = "Hotel Name: " + Hotel.name + "\n\nMoney: " + h.money +
                "$\nRoom staying fee: " + h.roomStayingPrice + "$\nTot. Guests: " +
                h.guests.Count + "\nTot. Rooms: " + h.rooms + "\nDrty. Rooms: " +
                h.roomsDirty + "\nAvbl. Rooms: " +
                (h.rooms - h.roomsDirty - h.guests.Count);

            // Update ButtonText
            btnCleanRoom.Text = "Clean a Room: 10$ (" + h.roomsDirty + " Drty. Room/s left)";
            btnNewRoom.Text = "Build new Room: " + h.roomCost + "$";
            btnExpand.Text = "Expand Room Capacity: " + h.roomExpandCost + "$";

            // Update GroupBoxText
            gbxRooms.Text = "Rooms (" + h.rooms + "/" + h.roomCap + ")";

            // Unlock buttons
            if (h.roomsDirty > 0)
            {
                gbxAction.Visible = true;
                btnCleanRoom.Visible = true;
            }
            if (h.roomsCleaned > 0)
            {
                btnWait.Visible = true;
            }
            if (h.rooms > 0)
            {
                gbxAction.Visible = true;
                btnWait.Visible = true;
            }
            if (h.rooms > 3)
            {
                btnExpand.Visible = true;
            }

        }

        private static List<Color> ColorTransition(Color Start, Color End, int Steps)
        {
            int rMax = Start.R;
            int rMin = End.R;
            int bMax = Start.R;
            int bMin = End.R;
            int gMax = Start.R;
            int gMin = End.R;

            var colorList = new List<Color>();

            for (int i = 1; i < Steps + 1; i++)
            {
                var rAverage = rMin + (rMax - rMin) * i / Steps;
                var gAverage = gMin + (gMax - gMin) * i / Steps;
                var bAverage = bMin + (bMax - bMin) * i / Steps;
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }

            return colorList;
        }
        public IEnumerable<Control> GetAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }

        #endregion

        #region Timers

        // Color switching
        int FadeCounter = 0;
        List<Color> colorList = new List<Color>();
        List<List<Color>> colorListArray = new List<List<Color>>();
        bool colorSwitch = false;
        int controlIndex = 0;

        private void onEveryIngameMin(object sender, EventArgs e)
        {
            // Update counters
            idleCounter++;
            if (waitCount > 0)
            {
                waitCount--;
            }

            // Set time of day
            DateTime thisDateTime = inGameTime;

            // Hour has passed
            if (lastDateTime.Hour != thisDateTime.Hour)
            {

                hotel.onHourPassed();

                if (!dayTime && thisDateTime.Hour >= 9 && thisDateTime.Hour < 21)
                {
                    dayTime = true;
                    morning = true;
                } else if (dayTime && ((thisDateTime.Hour >= 0 && thisDateTime.Hour < 9) || thisDateTime.Hour >= 21))
                {
                    dayTime = false;
                    evening = true;
                }
            }

            if (morning)
            {
                colorSwitch = true;
                Output(Dialog.dayBegins);
                morning = false;
            }

            if (evening)
            {
                colorSwitch = true;
                Output(Dialog.nightBegins);
                evening = false;
            }

            if (colorSwitch)
            {
                // Inverse the main Form BackColor
                if (FadeCounter == 0)
                {
                    int newR = 255 - BackColor.R;
                    int newG = 255 - BackColor.G;
                    int newB = 255 - BackColor.B;

                    colorList = ColorTransition(Color.FromArgb(BackColor.A, newR, newG, newB), BackColor, 100);
                    colorListArray.Add(colorList);
                }

                BackColor = colorListArray[controlIndex][FadeCounter];

                controlIndex++;

                foreach (Control c in GetAllControls(this))
                {
                    // Inverse all BackColors
                    if (true)
                    {
                        if (FadeCounter == 0)
                        {
                            int newR = 255 - c.BackColor.R;
                            int newG = 255 - c.BackColor.G;
                            int newB = 255 - c.BackColor.B;

                            colorList = ColorTransition(Color.FromArgb(c.BackColor.A, newR, newG, newB), c.BackColor, 100);
                            colorListArray.Add(colorList);
                        }

                        c.BackColor = colorListArray[controlIndex][FadeCounter];

                        controlIndex++;
                    }

                    // Inverse all ForeColors
                    if (true)
                    {
                        if (FadeCounter == 0)
                        {
                            int newR = 255 - c.ForeColor.R;
                            int newG = 255 - c.ForeColor.G;
                            int newB = 255 - c.ForeColor.B;

                            colorList = ColorTransition(Color.FromArgb(c.ForeColor.A, newR, newG, newB), c.ForeColor, 100);
                            colorListArray.Add(colorList);
                        }

                        c.ForeColor = colorListArray[controlIndex][FadeCounter];

                        controlIndex++;
                    }
                }

                controlIndex = 0;
                FadeCounter++;

                if (FadeCounter == colorList.Count)
                {
                    FadeCounter = 0;
                    controlIndex = 0;
                    colorListArray.Clear();
                    colorSwitch = false;
                }
            }

            // Update Buttons
            btnNewRoom.Enabled = hotel.roomCost < hotel.money && hotel.rooms != hotel.roomCap && tmrRoomBuild.Enabled == false ? true : false;
            btnExpand.Enabled = hotel.roomExpandCost < hotel.money && pbrRooms.Enabled == false ? true : false;
            btnCleanRoom.Enabled = hotel.roomsDirty > 0 && tmrClean.Enabled == false ? true : false;

            // Check for arriving Guests
            int x = 100 - (hotel.rooms * 10);
            if (x < 1)
            {
                x = 1;
            }

            if (r.NextDouble() < 0.005)
            {
                if (hotel.guests.Count < (hotel.rooms - hotel.roomsDirty))
                {
                    int stayTime = (int)Math.Pow(3.059777159949040030889077756275, hotel.rooms) + 72;
                    if (stayTime > 7200)
                    {
                        stayTime = 7200;
                    }

                    hotel.guestArrived();
                } 
            }

            // Nothing has happened for a while
            if (idleCounter == 400)
            {
                GiveHint();
            }

            lastDateTime = thisDateTime;
        }

        private void GiveHint()
        {
            if (hotel.rooms == 0)
                Output(Dialog.noRooms);

            if (hotel.roomsDirty == hotel.rooms)
                Output(Dialog.allDirty);
        }

        float countBuild = 0f;
        private void tmrBuild_Tick(object sender, EventArgs e)
        {
            countBuild++;
            int x = (int)(countBuild / hotel.roomBuildTime * 100) + 10;
            if (x > 100)
            {
                x = 100;
            }

            pgbRoom.Value = x;

            if (countBuild / hotel.roomBuildTime == 1)
            {
                tmrRoomBuild.Enabled = false;
                pgbRoom.Visible = false;
                countBuild = 0;
                NewRoom();
            }
        }

        float countClean = 0f;
        private void tmrClean_Tick(object sender, EventArgs e)
        {
            countClean++;
            int x = (int)(countClean / hotel.roomCleanTime * 100) + 50;
            if (x > 100)
            {
                x = 100;
            }

            pgbClean.Value = x;

            if (countClean / hotel.roomCleanTime == 1)
            {
                hotel.cleanRoom();

                tmrClean.Enabled = false;
                pgbClean.Visible = false;
                countClean = 0;
            }
        }

        int countWait = 0;
        int wastedClicks = 0;
        private void tmrWait(object sender, EventArgs e)
        {
            countWait++;
            pbrWait.Value = countWait;

            if (pbrWait.Value >= 100)
            {
                countWait = 0;
                wastedClicks++;
                tmrMisc.Enabled = false;
                pbrWait.Visible = false;
                gbxAction.Enabled = true;

                Output(Dialog.doNothing, "");
            }
        }
        #endregion

        #region Buttons

        private void btnCleanRoom_Click(object sender, EventArgs e)
        {
            // Pay
            hotel.spendMoney(hotel.roomCleanCost);

            // Wait for construction
            pgbClean.Visible = true;
            tmrClean.Enabled = true;
        }
        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            // Wait for construction
            pgbRoom.Visible = true;
            tmrRoomBuild.Enabled = true;

            // Pay
            hotel.spendMoney(hotel.roomCost);
        }
        private void btnWait_Click(object sender, EventArgs e)
        {
            gbxAction.Enabled = false;
            tmrMisc.Enabled = true;
            pbrWait.Visible = true;
            //backgroundWorker.RunWorkerAsync(4);
        }
        private void btnGuestList_Click(object sender, EventArgs e)
        {
            frmGuestList guestListForm = new frmGuestList(hotel.guests);
            guestListForm.Show();
        }

        #endregion

        private void Clock_Tick(object sender, EventArgs e)
        {
            inGameTime = inGameTime.AddMinutes(1);
            lblTime.Text = inGameTime.ToShortTimeString();
            lblDate.Text = inGameTime.ToShortDateString();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Output(Dialog.gameStarts);
        }

        private void frmMain_Validated(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tbxHotelInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
