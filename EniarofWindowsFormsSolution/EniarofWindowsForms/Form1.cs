using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Aruco;
using Emgu.CV.Util;

namespace EniarofWindowsForms
{
    public partial class Form1 : Form
    {
        VideoCapture capture1;
        VideoCapture capture2;

        bool streamingVideo = false;

        List<int> scannedItems1 = new List<int>();
        List<int> scannedItems2 = new List<int>();

        int score1 = 0;
        int score2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture1 = new VideoCapture(0);
            capture2 = new VideoCapture(1);
        }

        private async void streamVideo()
        {
            while (streamingVideo)
            {
                Mat frame = new Mat();
                bool readSuccess = capture1.Read(frame);
                if (readSuccess)
                {
                    pictureBox1.Image = frame.ToBitmap();
                    ArucoScan(frame, 0);
                }
                readSuccess = capture2.Read(frame);
                if (readSuccess)
                {
                    pictureBox2.Image = frame.ToBitmap();
                    ArucoScan(frame, 1);
                    frame.Dispose();
                }

                await Task.Delay(16);
            }
        }

        private void ArucoScan(Mat frame, int player)
        {
            Dictionary.PredefinedDictionaryName name = new Dictionary.PredefinedDictionaryName();
            Dictionary Dict = new Dictionary(name);
            VectorOfVectorOfPointF Corners = new VectorOfVectorOfPointF();
            VectorOfInt Ids = new VectorOfInt();
            DetectorParameters Parameters = DetectorParameters.GetDefault();

            VectorOfVectorOfPointF Rejected = new VectorOfVectorOfPointF();
            ArucoInvoke.DetectMarkers(frame, Dict, Corners, Ids, Parameters, Rejected);
            if (Ids.Size > 0)
            {
                int element = Ids.ToArray()[0];
                if (player == 0)
                {
                    ArucoLabel1.Text = element.ToString();
                    if (!scannedItems1.Contains(element))
                    {
                        score1++;
                        ScoreLabel1.Text = score1.ToString();
                        scannedItems1.Add(element);
                    }
                }
                else if (player == 1)
                {
                    ArucoLabel2.Text = element.ToString();
                    if (!scannedItems2.Contains(element))
                    {
                        score2++;
                        ScoreLabel2.Text = score2.ToString();
                        scannedItems2.Add(element);
                    }
                }
            }
            else
            {
                if (player == 0)
                    ArucoLabel1.Text = "None Detected";
                else if (player == 1)
                    ArucoLabel2.Text = "None Detected";
            }
        }

        private void Reset()
        {
            score1 = 0;
            score2 = 0;
            scannedItems1.Clear();
            scannedItems2.Clear();
            ScoreLabel1.Text = "0";
            ScoreLabel2.Text = "0";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            streamingVideo = true;
            streamVideo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnStopGrab_Click(object sender, EventArgs e)
        {
            streamingVideo = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
