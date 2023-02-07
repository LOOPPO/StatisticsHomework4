namespace Homework_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SequencesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrialsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProbabilityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AbsoluteRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RelativeRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalizedRadioButton = new System.Windows.Forms.RadioButton();
            this.ChartPictureBox = new System.Windows.Forms.PictureBox();
            this.BarChartPictureBox = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SequencesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityNumericUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SequencesNumericUpDown
            // 
            this.SequencesNumericUpDown.Location = new System.Drawing.Point(84, 7);
            this.SequencesNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SequencesNumericUpDown.Name = "SequencesNumericUpDown";
            this.SequencesNumericUpDown.Size = new System.Drawing.Size(61, 23);
            this.SequencesNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sequences:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trials:";
            // 
            // TrialsNumericUpDown
            // 
            this.TrialsNumericUpDown.Location = new System.Drawing.Point(193, 7);
            this.TrialsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TrialsNumericUpDown.Name = "TrialsNumericUpDown";
            this.TrialsNumericUpDown.Size = new System.Drawing.Size(61, 23);
            this.TrialsNumericUpDown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Probability:";
            // 
            // ProbabilityNumericUpDown
            // 
            this.ProbabilityNumericUpDown.DecimalPlaces = 1;
            this.ProbabilityNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ProbabilityNumericUpDown.Location = new System.Drawing.Point(333, 7);
            this.ProbabilityNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProbabilityNumericUpDown.Name = "ProbabilityNumericUpDown";
            this.ProbabilityNumericUpDown.Size = new System.Drawing.Size(61, 23);
            this.ProbabilityNumericUpDown.TabIndex = 5;
            // 
            // AbsoluteRadioButton
            // 
            this.AbsoluteRadioButton.AutoSize = true;
            this.AbsoluteRadioButton.Checked = true;
            this.AbsoluteRadioButton.Location = new System.Drawing.Point(3, 3);
            this.AbsoluteRadioButton.Name = "AbsoluteRadioButton";
            this.AbsoluteRadioButton.Size = new System.Drawing.Size(130, 19);
            this.AbsoluteRadioButton.TabIndex = 6;
            this.AbsoluteRadioButton.TabStop = true;
            this.AbsoluteRadioButton.Text = "Absolute Frequency";
            this.AbsoluteRadioButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AbsoluteRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.RelativeRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.NormalizedRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(400, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 23);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // RelativeRadioButton
            // 
            this.RelativeRadioButton.AutoSize = true;
            this.RelativeRadioButton.Location = new System.Drawing.Point(139, 3);
            this.RelativeRadioButton.Name = "RelativeRadioButton";
            this.RelativeRadioButton.Size = new System.Drawing.Size(124, 19);
            this.RelativeRadioButton.TabIndex = 7;
            this.RelativeRadioButton.Text = "Relative Frequency";
            this.RelativeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NormalizedRadioButton
            // 
            this.NormalizedRadioButton.AutoSize = true;
            this.NormalizedRadioButton.Location = new System.Drawing.Point(269, 3);
            this.NormalizedRadioButton.Name = "NormalizedRadioButton";
            this.NormalizedRadioButton.Size = new System.Drawing.Size(144, 19);
            this.NormalizedRadioButton.TabIndex = 8;
            this.NormalizedRadioButton.Text = "Normalized Frequency";
            this.NormalizedRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChartPictureBox
            // 
            this.ChartPictureBox.BackColor = System.Drawing.Color.Black;
            this.ChartPictureBox.Location = new System.Drawing.Point(12, 36);
            this.ChartPictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ChartPictureBox.Name = "ChartPictureBox";
            this.ChartPictureBox.Size = new System.Drawing.Size(806, 589);
            this.ChartPictureBox.TabIndex = 8;
            this.ChartPictureBox.TabStop = false;
            // 
            // BarChartPictureBox
            // 
            this.BarChartPictureBox.BackColor = System.Drawing.Color.Black;
            this.BarChartPictureBox.Location = new System.Drawing.Point(819, 36);
            this.BarChartPictureBox.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.BarChartPictureBox.Name = "BarChartPictureBox";
            this.BarChartPictureBox.Size = new System.Drawing.Size(263, 589);
            this.BarChartPictureBox.TabIndex = 9;
            this.BarChartPictureBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(824, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 666);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BarChartPictureBox);
            this.Controls.Add(this.ChartPictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ProbabilityNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrialsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SequencesNumericUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SequencesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrialsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityNumericUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown SequencesNumericUpDown;
        private Label label1;
        private Label label2;
        private NumericUpDown TrialsNumericUpDown;
        private Label label3;
        private NumericUpDown ProbabilityNumericUpDown;
        private RadioButton AbsoluteRadioButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton RelativeRadioButton;
        private RadioButton NormalizedRadioButton;
        private PictureBox ChartPictureBox;
        private PictureBox BarChartPictureBox;
        private Button StartButton;
    }
}