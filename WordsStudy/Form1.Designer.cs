
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
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
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
            this.wordsDataGridView.Location = new System.Drawing.Point(70, 56);
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
            this.importBtn.Location = new System.Drawing.Point(70, 27);
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
            this.clearBtn.Location = new System.Drawing.Point(442, 27);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистити";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // startLearnBtn
            // 
            this.startLearnBtn.Location = new System.Drawing.Point(242, 449);
            this.startLearnBtn.Name = "startLearnBtn";
            this.startLearnBtn.Size = new System.Drawing.Size(75, 23);
            this.startLearnBtn.TabIndex = 3;
            this.startLearnBtn.Text = "Старт";
            this.startLearnBtn.UseVisualStyleBackColor = true;
            this.startLearnBtn.Click += new System.EventHandler(this.startLearnBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(283, 27);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startLearnBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.wordsDataGridView);
            this.Name = "Form1";
            this.Text = "Вивчення слів";
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
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
    }
}

