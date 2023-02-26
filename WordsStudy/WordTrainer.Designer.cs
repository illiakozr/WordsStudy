
namespace WordsStudy
{
    partial class WordTrainer
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
            this.wordTranslationLabel = new System.Windows.Forms.Label();
            this.checkCorectnessBtn = new System.Windows.Forms.Button();
            this.NextWordBtn = new System.Windows.Forms.Button();
            this.RichWordTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.promptBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordTranslationLabel
            // 
            this.wordTranslationLabel.AutoSize = true;
            this.wordTranslationLabel.BackColor = System.Drawing.Color.LightBlue;
            this.wordTranslationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wordTranslationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordTranslationLabel.Location = new System.Drawing.Point(51, 21);
            this.wordTranslationLabel.Name = "wordTranslationLabel";
            this.wordTranslationLabel.Size = new System.Drawing.Size(62, 26);
            this.wordTranslationLabel.TabIndex = 0;
            this.wordTranslationLabel.Text = "label1";
            // 
            // checkCorectnessBtn
            // 
            this.checkCorectnessBtn.Location = new System.Drawing.Point(80, 113);
            this.checkCorectnessBtn.Name = "checkCorectnessBtn";
            this.checkCorectnessBtn.Size = new System.Drawing.Size(75, 23);
            this.checkCorectnessBtn.TabIndex = 2;
            this.checkCorectnessBtn.Text = "Перевірити";
            this.checkCorectnessBtn.UseVisualStyleBackColor = true;
            this.checkCorectnessBtn.Click += new System.EventHandler(this.checkCorectnessBtn_Click);
            // 
            // NextWordBtn
            // 
            this.NextWordBtn.Enabled = false;
            this.NextWordBtn.Location = new System.Drawing.Point(199, 113);
            this.NextWordBtn.Name = "NextWordBtn";
            this.NextWordBtn.Size = new System.Drawing.Size(107, 23);
            this.NextWordBtn.TabIndex = 3;
            this.NextWordBtn.Text = "Наступне слово";
            this.NextWordBtn.UseVisualStyleBackColor = true;
            this.NextWordBtn.Click += new System.EventHandler(this.NextWordBtn_Click);
            // 
            // RichWordTextBox
            // 
            this.RichWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichWordTextBox.Location = new System.Drawing.Point(51, 66);
            this.RichWordTextBox.Name = "RichWordTextBox";
            this.RichWordTextBox.Size = new System.Drawing.Size(255, 29);
            this.RichWordTextBox.TabIndex = 4;
            this.RichWordTextBox.Text = "";
            this.RichWordTextBox.TextChanged += new System.EventHandler(this.RichWordTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.promptBtn);
            this.groupBox1.Location = new System.Drawing.Point(51, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // promptBtn
            // 
            this.promptBtn.Location = new System.Drawing.Point(7, 20);
            this.promptBtn.Name = "promptBtn";
            this.promptBtn.Size = new System.Drawing.Size(75, 23);
            this.promptBtn.TabIndex = 0;
            this.promptBtn.Text = "Підказка";
            this.promptBtn.UseVisualStyleBackColor = true;
            this.promptBtn.Click += new System.EventHandler(this.promptBtn_Click);
            // 
            // WordTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RichWordTextBox);
            this.Controls.Add(this.NextWordBtn);
            this.Controls.Add(this.checkCorectnessBtn);
            this.Controls.Add(this.wordTranslationLabel);
            this.Name = "WordTrainer";
            this.Text = "Тренування слів";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordTranslationLabel;
        private System.Windows.Forms.Button checkCorectnessBtn;
        private System.Windows.Forms.Button NextWordBtn;
        private System.Windows.Forms.RichTextBox RichWordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button promptBtn;
    }
}