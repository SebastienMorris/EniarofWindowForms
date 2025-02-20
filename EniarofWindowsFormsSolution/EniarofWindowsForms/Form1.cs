using System.Diagnostics;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Aruco;
using Emgu.CV.Util;

namespace EniarofWindowsForms
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture1;
        private VideoCapture _capture2;
        private bool _streamingVideo = false;

        private readonly Dictionary<int, Item> _itemsDatabase = new()
        {
            {1, new Item(1, "Constraint 1")},
            {2, new Item(1, "Constraint 2")},
            {3, new Item(2, "Constraint 3")},
            {4, new Item(2, "Constraint 4")},
            {5, new Item(1, "Constraint 5")},
            {6, new Item(1, "Constraint 6")},
        };

        private readonly List<Item> _scannedItems1 = new();
        private readonly List<Item> _scannedItems2 = new();

        private int _score1 = 0;
        private int _score2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture1 = new VideoCapture(0);
            _capture2 = new VideoCapture(1);
        }

        private async void StreamVideo()
        {
            while (_streamingVideo)
            {
                Mat frame = new Mat();
                bool readSuccess = _capture1.Read(frame);
                if (readSuccess)
                {
                    pictureBox1.Image = frame.ToBitmap();
                    ArucoScan(frame, 0);
                }
                readSuccess = _capture2.Read(frame);
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

            if (Ids.Size == 0)
            {
                Label label = player == 0 ? ArucoLabel1 : ArucoLabel2;
                label.Text = "None Detected";
                return;
            }

            int element = Ids.ToArray()[0];
            if (!_itemsDatabase.TryGetValue(element, out Item item))
            {
                Console.WriteLine($"Element with ID {element} not found in database.");
                return;
            }

            if (player == 0)
            {
                ArucoLabel1.Text = element.ToString();

                if (_scannedItems1.Contains(item)) return;
                _score1 += item.Score;
                Console.WriteLine(item.Constraint);
                ScoreLabel1.Text = _score1.ToString();
                _scannedItems1.Add(item);
            }
            else if (player == 1)
            {
                ArucoLabel2.Text = element.ToString();

                if (_scannedItems2.Contains(item)) return;
                _score2 += item.Score;
                Console.WriteLine(item.Constraint);
                ScoreLabel2.Text = _score2.ToString();
                _scannedItems2.Add(item);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            _streamingVideo = true;
            StreamVideo();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStopGrab_Click(object sender, EventArgs e)
        {
            _streamingVideo = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            _score1 = 0;
            _score2 = 0;
            _scannedItems1.Clear();
            _scannedItems2.Clear();
            ScoreLabel1.Text = "0";
            ScoreLabel2.Text = "0";
        }
    }

    public class Item
    {
        public int Score { get; set; }
        public string Constraint { get; set; }

        public Item(int score, string constraint)
        {
            Score = score;
            Constraint = constraint;
        }
    }
}
