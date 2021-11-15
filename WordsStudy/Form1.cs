﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using System.Xml.Serialization;
using WordsStudy.DataContext;

namespace WordsStudy
{
    public partial class Form1 : Form
    {
        public const string FilePath = "wordsDB.xml";

        public Form1()
        {
            InitializeComponent();
            LoadWordsFromFile();
            ChangeColorRow();
        }

        private void LoadWordsFromFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RecordModelCollection));

            RecordModelCollection recordsCollection;

            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                recordsCollection = (RecordModelCollection)serializer.Deserialize(fs);
            }

            foreach (RecordModel model in recordsCollection.RecordModel)
            {
                wordsDataGridView.Rows.Add(1, model.Word, model.Translation, model.Studied);
                // change color to green for checked words
            }
        }

        // change color to green for checked words
        private void ChangeColorRow()
        {
            foreach (DataGridViewRow row in wordsDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["studied"].Value)) {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    //Создаём приложение.
                    var ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                    //Открываем книгу. 
                    Workbook ObjWorkBook = ObjExcel.Workbooks.Open(filePath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                    //Выбираем таблицу(лист).
                    Worksheet ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];

                    // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
                    int numCol1 = 1;

                    Range usedColumn1 = ObjWorkSheet.UsedRange.Columns[numCol1];
                    Array myvalues1 = (Array)usedColumn1.Cells.Value2;
                    string[] words = myvalues1.OfType<object>().Select(o => Convert.ToString(o)).ToArray();

                    //////////////////////////////////////////////////////////////////////////

                    int numCol2 = 2;

                    Range usedColumn2 = ObjWorkSheet.UsedRange.Columns[numCol2];
                    Array myvalues2 = (Array)usedColumn2.Cells.Value2;
                    string[] translation = myvalues2.OfType<object>().Select(o => Convert.ToString(o)).ToArray();

                    // Выходим из программы Excel.
                    ObjExcel.Quit();

                    // find shorter array
                    int lastIndex = words.Length < translation.Length ? words.Length : translation.Length;

                    for(int i = 0; i < lastIndex; i++)
                    {
                        wordsDataGridView.Rows.Add(i+1, words[i], translation[i], false);
                    }

                    
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                   $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        // clear all rows from DataGridView
        private void clearBtn_Click(object sender, EventArgs e)
        {
            wordsDataGridView.Rows.Clear();
        }

        // change color of row after clicking checkBox
        private void wordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == wordsDataGridView.Columns["studied"].Index)
            {
                //Set the CheckBox selection.
                wordsDataGridView.CurrentCell.Value = Convert.ToBoolean(wordsDataGridView.CurrentCell.EditedFormattedValue);

                if (Convert.ToBoolean(wordsDataGridView.CurrentCell.Value))
                {
                    // change color of row to green
                    wordsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                } else
                {
                    // change color of row to default
                    wordsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LemonChiffon;
                }
            }
        }

        private void startLearnBtn_Click(object sender, EventArgs e)
        {
            DataStorage.WordsDictionary.Clear();
            MarkedRecords.LearnedWordsIndexes.Clear();

            foreach (DataGridViewRow row in wordsDataGridView.Rows)
            {
                var number = Convert.ToInt32(row.Cells["wordNumber"].Value);
                var word = row.Cells["Word"].Value ?? "";
                var translation = row.Cells["Translation"].Value ?? "";
                bool alredyStudied = Convert.ToBoolean(row.Cells["studied"].Value);

                if (row.IsNewRow || alredyStudied || string.IsNullOrWhiteSpace(word.ToString()) 
                    || string.IsNullOrWhiteSpace(translation.ToString()) )
                {
                    continue;
                }

                DataStorage.WordsDictionary.Add(new RecordModel { 
                  Number = number, 
                  Word = word.ToString(),
                  Translation = translation.ToString(),
                  Studied = alredyStudied
                });
            }

            // show small form
            BackEndWindow backEndWindow = new BackEndWindow();
            this.Visible = false;
            backEndWindow.ShowDialog();

            // mark all learned words
            foreach(int index in MarkedRecords.LearnedWordsIndexes)
            {
                wordsDataGridView.Rows[index].Cells["studied"].Value = true;
                // change color of row to green
                wordsDataGridView.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            this.Visible = true;
        }

        // auto numeration of wordNumber column
        private void wordsDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            wordsDataGridView.Rows[e.RowIndex].Cells["wordNumber"].Value = (e.RowIndex + 1).ToString();
        }

        // save Changes into file
        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<RecordModel> records = new List<RecordModel>();

            foreach (DataGridViewRow row in wordsDataGridView.Rows)
            {
                var number = Convert.ToInt32(row.Cells["wordNumber"].Value);
                var word = row.Cells["Word"].Value ?? "";
                var translation = row.Cells["Translation"].Value ?? "";
                bool alredyStudied = Convert.ToBoolean(row.Cells["studied"].Value);

                if (row.IsNewRow || string.IsNullOrWhiteSpace(word.ToString())
                    || string.IsNullOrWhiteSpace(translation.ToString()))
                {
                    continue;
                }

                records.Add(new RecordModel { Number = number, Word = word.ToString(), Translation = translation.ToString(), Studied = alredyStudied });
            }

            XmlSerializer serializer = new XmlSerializer(typeof(RecordModelCollection));
            RecordModelCollection recordModelCollection = new RecordModelCollection
            {
                RecordModel = records.ToArray()
            };

            using ( FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                if (records.Any())
                {
                    serializer.Serialize(fs, recordModelCollection);
                }

            }

            MessageBox.Show(
                "Словник успішно збережено",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1 );
        }
    }
}