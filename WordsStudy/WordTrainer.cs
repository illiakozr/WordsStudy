using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WordsStudy.DataContext;

namespace WordsStudy
{
    public partial class WordTrainer : Form
    {
        private int _wordIndex;
        private Random _random;
        private int _rightLettersIndex;

        public WordTrainer()
        {
            _random = new Random();
            InitializeComponent();
            DisplayFirstWord();
        }

        private void DisplayFirstWord()
        {
            _wordIndex = _random.Next(0, DataStorage.WordsDictionary.Count);
            RecordModel model = DataStorage.WordsDictionary[_wordIndex];
            wordTranslationLabel.Text = model.Translation;

        }

        private void checkCorectnessBtn_Click(object sender, EventArgs e)
        {
            if (!DataStorage.WordsDictionary.Any())
            {
                return;
            }

            RecordModel model = DataStorage.WordsDictionary[_wordIndex];
            string normalizedTextBoxString = RichWordTextBox.Text.Trim().Replace(Convert.ToChar(32), Convert.ToChar(160));
            string normalizedWordString = model.Word.Trim().Replace(Convert.ToChar(32), Convert.ToChar(160));
            if (normalizedTextBoxString == normalizedWordString)
            {
                RichWordTextBox.BackColor = Color.LightGreen;
                RichWordTextBox.Select(0, RichWordTextBox.Text.Length);
                RichWordTextBox.SelectionBackColor = Color.LightGreen;
                DataStorage.WordsDictionary.RemoveAt(_wordIndex);

                promptBtn.Enabled = false;

                if (!DataStorage.WordsDictionary.Any())
                {
                    MessageBox.Show(
                      "Всі слова пройдені.",
                      "",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1);

                    return;
                }
                NextWordBtn.Enabled = true;
            }
            else
            {
                WordValidator();
            }
        }

        private void NextWordBtn_Click(object sender, EventArgs e)
        {
            _wordIndex = _random.Next(0, DataStorage.WordsDictionary.Count);
            RecordModel model = DataStorage.WordsDictionary[_wordIndex];
            wordTranslationLabel.Text = model.Translation;

            RichWordTextBox.Text = "";
            RichWordTextBox.BackColor = Color.White;
            NextWordBtn.Enabled = false;
            promptBtn.Enabled = true;
            _rightLettersIndex = 0;
        }

        private void WordValidator()
        {
            RecordModel model = DataStorage.WordsDictionary[_wordIndex];
            string normalizedTextBoxString = RichWordTextBox.Text.Trim().Replace(Convert.ToChar(32), Convert.ToChar(160));
            string normalizedWordString = model.Word.Trim().Replace(Convert.ToChar(32), Convert.ToChar(160));
            char[] textBoxLetters = normalizedTextBoxString.ToArray();
            char[] rightWordLetters = normalizedWordString.ToArray();

            if (!textBoxLetters.Any())
            {
                return;
            }

            int smallestArrayLength = rightWordLetters.Length <= textBoxLetters.Length ? rightWordLetters.Length : textBoxLetters.Length;

            int indexTo = 0;
            for (int i = 0; i < smallestArrayLength; i++)
            {
                if (rightWordLetters[i] != textBoxLetters[i])
                {
                    break;
                }
                if (rightWordLetters[i] == textBoxLetters[i]) {
                    indexTo++;
                }
                
            }
            RichWordTextBox.Select(0,indexTo);
            RichWordTextBox.SelectionBackColor = Color.LightGreen;
            RichWordTextBox.Select(indexTo, textBoxLetters.Length);
            RichWordTextBox.SelectionBackColor = Color.Red;
            _rightLettersIndex = indexTo;
        }

        private void promptBtn_Click(object sender, EventArgs e)
        {
            RecordModel model = DataStorage.WordsDictionary[_wordIndex];

            if (model.Word == RichWordTextBox.Text)
            {
                return;
            }

            var str = RichWordTextBox.Text.Substring(0, _rightLettersIndex);

            RichWordTextBox.Text = str + model.Word[_rightLettersIndex];
            _rightLettersIndex++;
            RichWordTextBox.Select(0, _rightLettersIndex);
            RichWordTextBox.SelectionBackColor = Color.LightGreen;
        }
    }
}
