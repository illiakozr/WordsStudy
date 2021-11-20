using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WordsStudy.DataContext;

namespace WordsStudy
{
    public partial class BackEndWindow : Form
    {
        // Thread
        private Thread _sliderThread;

        // Cancelation token for stopping Thread
        private CancellationToken _cancellationToken { get; set; }
        private CancellationTokenSource _cancelTokenSource = new CancellationTokenSource();

        // variables for moving form functionality
        private bool _mouseDown;
        private Point _lastLocation;

        //index of word in the Data list
        private int _wordIndex;
        private int _wordNumber;

        public BackEndWindow()
        {
            InitializeComponent();

            _cancellationToken = _cancelTokenSource.Token;

            StartWordsSlider();
        }

        private void StartWordsSlider()
        {
            _sliderThread = new Thread(Display);
            _sliderThread.Start();
        }

        private void Display()
        {
            Random rnd = new Random();
            bool firstWord = true;

            while (true)
            {   
                if (_cancellationToken.IsCancellationRequested)
                {
                    return;
                }

                _wordIndex = rnd.Next(0, DataStorage.WordsDictionary.Count);
                RecordModel model = DataStorage.WordsDictionary[_wordIndex];
                _wordNumber = model.Number;
                if (firstWord)
                {
                    this.BackColor = Color.LightBlue;
                    LearnedCheckBox.Checked = false;
                    LearnedCheckBox.Enabled = true;
                    wordsDisplayerLabel.Text = model.Word;                    
                    Thread.Sleep(4500);
                    this.BackColor = Color.FromArgb(192, 255, 192);
                    wordsDisplayerLabel.Text = string.Format("{0} - {1}", model.Word, model.Translation);
                    Thread.Sleep(4500);
                    firstWord = !firstWord;
                } else
                {
                    this.BackColor = Color.LightBlue;
                    LearnedCheckBox.Checked = false;
                    LearnedCheckBox.Enabled = true;
                    wordsDisplayerLabel.Text = model.Translation;
                    Thread.Sleep(4500);
                    this.BackColor = Color.FromArgb(192, 255, 192);
                    wordsDisplayerLabel.Text = string.Format("{0} - {1}", model.Translation, model.Word);
                    Thread.Sleep(4500);
                    firstWord = !firstWord;
                }

            }
        }

        private void BackEndWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancelTokenSource.Cancel();            
        }

        private void BackEndWindow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _cancelTokenSource.Cancel();
            this.Close();
        }

        // moving window functionality
        private void BackEndWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        // moving window functionality
        private void BackEndWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - _lastLocation.X) + e.X, (this.Location.Y - _lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // moving window functionality
        private void BackEndWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cancelTokenSource.Cancel();
            this.Close();
        }

        private void LearnedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LearnedCheckBox.Checked)
            {
                LearnedCheckBox.Enabled = false;
                DataStorage.WordsDictionary.RemoveAt(_wordIndex);
                // if after check no words are left for learning - close the window
                if (!DataStorage.WordsDictionary.Any())
                {
                    _cancelTokenSource.Cancel();
                    this.Close();
                }
                MarkedRecords.LearnedWordsIndexes.Add(_wordNumber);
            }
        }

        private void learnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LearnedCheckBox.Checked = true;
            LearnedCheckBox_CheckedChanged(sender, e);
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sliderThread.Suspend();
            contextMenuStrip1.Items[1].Enabled = false;
            contextMenuStrip1.Items[2].Enabled = true;
        }

        private void revokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sliderThread.Resume();
            contextMenuStrip1.Items[1].Enabled = true;
            contextMenuStrip1.Items[2].Enabled = false;
        }
    }
}
