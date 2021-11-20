
namespace WordsStudy
{
    partial class BackEndWindow
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
            this.components = new System.ComponentModel.Container();
            this.wordsDisplayerLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.приховатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.призупинитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revokeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивченоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LearnedCheckBox = new WordsStudy.CustomControls.MyCheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordsDisplayerLabel
            // 
            this.wordsDisplayerLabel.AutoSize = true;
            this.wordsDisplayerLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsDisplayerLabel.Location = new System.Drawing.Point(-1, 0);
            this.wordsDisplayerLabel.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.wordsDisplayerLabel.Name = "wordsDisplayerLabel";
            this.wordsDisplayerLabel.Size = new System.Drawing.Size(74, 29);
            this.wordsDisplayerLabel.TabIndex = 0;
            this.wordsDisplayerLabel.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приховатиToolStripMenuItem,
            this.призупинитиToolStripMenuItem,
            this.revokeToolStripMenuItem,
            this.вийтиToolStripMenuItem,
            this.вивченоToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // приховатиToolStripMenuItem
            // 
            this.приховатиToolStripMenuItem.Name = "приховатиToolStripMenuItem";
            this.приховатиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.приховатиToolStripMenuItem.Text = "Приховати";
            this.приховатиToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // призупинитиToolStripMenuItem
            // 
            this.призупинитиToolStripMenuItem.Name = "призупинитиToolStripMenuItem";
            this.призупинитиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.призупинитиToolStripMenuItem.Text = "Призупинити";
            this.призупинитиToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // revokeToolStripMenuItem
            // 
            this.revokeToolStripMenuItem.Enabled = false;
            this.revokeToolStripMenuItem.Name = "revokeToolStripMenuItem";
            this.revokeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revokeToolStripMenuItem.Text = "Відновити";
            this.revokeToolStripMenuItem.Click += new System.EventHandler(this.revokeToolStripMenuItem_Click);
            // 
            // вийтиToolStripMenuItem
            // 
            this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вийтиToolStripMenuItem.Text = "Вийти";
            this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // вивченоToolStripMenuItem
            // 
            this.вивченоToolStripMenuItem.Name = "вивченоToolStripMenuItem";
            this.вивченоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вивченоToolStripMenuItem.Text = "Вивчено!";
            this.вивченоToolStripMenuItem.Click += new System.EventHandler(this.learnedToolStripMenuItem_Click);
            // 
            // LearnedCheckBox
            // 
            this.LearnedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LearnedCheckBox.Location = new System.Drawing.Point(324, 0);
            this.LearnedCheckBox.Name = "LearnedCheckBox";
            this.LearnedCheckBox.Size = new System.Drawing.Size(28, 24);
            this.LearnedCheckBox.TabIndex = 1;
            this.LearnedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LearnedCheckBox.UseVisualStyleBackColor = true;
            this.LearnedCheckBox.CheckedChanged += new System.EventHandler(this.LearnedCheckBox_CheckedChanged);
            // 
            // BackEndWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(353, 26);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.LearnedCheckBox);
            this.Controls.Add(this.wordsDisplayerLabel);
            this.MinimumSize = new System.Drawing.Size(16, 42);
            this.Name = "BackEndWindow";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackEndWindow_FormClosing);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BackEndWindow_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackEndWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackEndWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackEndWindow_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordsDisplayerLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приховатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem призупинитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивченоToolStripMenuItem;
        private CustomControls.MyCheckBox LearnedCheckBox;
        private System.Windows.Forms.ToolStripMenuItem revokeToolStripMenuItem;
    }
}