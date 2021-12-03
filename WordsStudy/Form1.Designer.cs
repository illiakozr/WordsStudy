
namespace WordsStudy
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wordsDataGridView = new System.Windows.Forms.DataGridView();
            this.wordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearBtn = new System.Windows.Forms.Button();
            this.startLearnBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.rangeCheckBox = new System.Windows.Forms.CheckBox();
            this.rangeGroupBox = new System.Windows.Forms.GroupBox();
            this.toNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.trainingStartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
            this.rangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).BeginInit();
            this.optionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordsDataGridView
            // 
            this.wordsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.wordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordNumber,
            this.Word,
            this.Translation,
            this.studied});
            this.wordsDataGridView.Location = new System.Drawing.Point(57, 56);
            this.wordsDataGridView.Name = "wordsDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wordsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.wordsDataGridView.Size = new System.Drawing.Size(447, 387);
            this.wordsDataGridView.TabIndex = 0;
            this.wordsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wordsDataGridView_CellContentClick);
            this.wordsDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.wordsDataGridView_RowPostPaint);
            // 
            // wordNumber
            // 
            this.wordNumber.HeaderText = "№";
            this.wordNumber.Name = "wordNumber";
            this.wordNumber.ReadOnly = true;
            this.wordNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wordNumber.Width = 35;
            // 
            // Word
            // 
            this.Word.HeaderText = "Слово";
            this.Word.Name = "Word";
            this.Word.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Word.Width = 150;
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Переклад";
            this.Translation.Name = "Translation";
            this.Translation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Translation.Width = 150;
            // 
            // studied
            // 
            this.studied.HeaderText = "Вивчено";
            this.studied.Name = "studied";
            this.studied.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studied.Width = 70;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(57, 27);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(140, 23);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Імпортувати словник";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(429, 27);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистити";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // startLearnBtn
            // 
            this.startLearnBtn.Location = new System.Drawing.Point(550, 216);
            this.startLearnBtn.Name = "startLearnBtn";
            this.startLearnBtn.Size = new System.Drawing.Size(75, 29);
            this.startLearnBtn.TabIndex = 3;
            this.startLearnBtn.Text = "Старт";
            this.startLearnBtn.UseVisualStyleBackColor = true;
            this.startLearnBtn.Click += new System.EventHandler(this.startLearnBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(262, 27);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // rangeCheckBox
            // 
            this.rangeCheckBox.AutoSize = true;
            this.rangeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.rangeCheckBox.Name = "rangeCheckBox";
            this.rangeCheckBox.Size = new System.Drawing.Size(109, 17);
            this.rangeCheckBox.TabIndex = 5;
            this.rangeCheckBox.Text = "Задати діапазон";
            this.rangeCheckBox.UseVisualStyleBackColor = true;
            this.rangeCheckBox.CheckedChanged += new System.EventHandler(this.rangeCheckBox_CheckedChanged);
            // 
            // rangeGroupBox
            // 
            this.rangeGroupBox.Controls.Add(this.toNumericUpDown);
            this.rangeGroupBox.Controls.Add(this.fromNumericUpDown);
            this.rangeGroupBox.Controls.Add(this.label2);
            this.rangeGroupBox.Controls.Add(this.label1);
            this.rangeGroupBox.Enabled = false;
            this.rangeGroupBox.Location = new System.Drawing.Point(6, 42);
            this.rangeGroupBox.Name = "rangeGroupBox";
            this.rangeGroupBox.Size = new System.Drawing.Size(152, 44);
            this.rangeGroupBox.TabIndex = 6;
            this.rangeGroupBox.TabStop = false;
            // 
            // toNumericUpDown
            // 
            this.toNumericUpDown.Location = new System.Drawing.Point(108, 13);
            this.toNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.toNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toNumericUpDown.Name = "toNumericUpDown";
            this.toNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.toNumericUpDown.TabIndex = 9;
            this.toNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fromNumericUpDown
            // 
            this.fromNumericUpDown.Location = new System.Drawing.Point(35, 13);
            this.fromNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown.Name = "fromNumericUpDown";
            this.fromNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.fromNumericUpDown.TabIndex = 8;
            this.fromNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Від";
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.rangeGroupBox);
            this.optionGroupBox.Controls.Add(this.rangeCheckBox);
            this.optionGroupBox.Location = new System.Drawing.Point(510, 56);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(165, 154);
            this.optionGroupBox.TabIndex = 7;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Опції";
            // 
            // trainingStartBtn
            // 
            this.trainingStartBtn.Location = new System.Drawing.Point(526, 264);
            this.trainingStartBtn.Name = "trainingStartBtn";
            this.trainingStartBtn.Size = new System.Drawing.Size(135, 29);
            this.trainingStartBtn.TabIndex = 8;
            this.trainingStartBtn.Text = "Почати тренування";
            this.trainingStartBtn.UseVisualStyleBackColor = true;
            this.trainingStartBtn.Click += new System.EventHandler(this.trainingStartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 449);
            this.Controls.Add(this.trainingStartBtn);
            this.Controls.Add(this.optionGroupBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startLearnBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.wordsDataGridView);
            this.Name = "Form1";
            this.Text = "Вивчення слів";
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
            this.rangeGroupBox.ResumeLayout(false);
            this.rangeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).EndInit();
            this.optionGroupBox.ResumeLayout(false);
            this.optionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView wordsDataGridView;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button startLearnBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn studied;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox rangeCheckBox;
        private System.Windows.Forms.GroupBox rangeGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown;
        private System.Windows.Forms.NumericUpDown toNumericUpDown;
        private System.Windows.Forms.Button trainingStartBtn;
    }
}

