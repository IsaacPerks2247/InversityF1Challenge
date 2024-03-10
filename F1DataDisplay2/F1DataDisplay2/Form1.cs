using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace F1DataDisplay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loop();
        }
        public void loop()//To set data
        {
            //set up: [meetingkey, sessionkey, drivernumber, date, rpm, speed, gear, throttle, drs, brake]
            string[] dataArr = SR.GetCarData();//Get car data

            labelMeetingKey.Text = "Meeting Key: " + dataArr[0];
            labelSessionKey.Text = "Session Key: " + dataArr[1];
            labelDriverNumber.Text = "Driver: " + dataArr[2];
            labelDRS.Text = "DRS: " + dataArr[8];

            labelDate.Text = dataArr[3];
            labelSpeed.Text = dataArr[5];
            labelGear.Text = dataArr[6];

            barBrake.Value = Convert.ToInt32(dataArr[9]);
            barThrottle.Value = Convert.ToInt32(dataArr[7]);
            barRPM.Value = (Convert.ToInt32(dataArr[4]) / 15000) * 100;

            loop();//Recursive loop
        }
    }
}