namespace Timer
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
            components = new System.ComponentModel.Container();
            ListOfTimers = new ListBox();
            AddNewTimer = new Button();
            DeleteSelectedTimer = new Button();
            TimerLabel = new Label();
            StartTimerButton = new Button();
            StopTimerButton = new Button();
            PauseTimerButton = new Button();
            TimerCountdown = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ListOfTimers
            // 
            ListOfTimers.FormattingEnabled = true;
            ListOfTimers.ItemHeight = 25;
            ListOfTimers.Location = new Point(12, 12);
            ListOfTimers.Name = "ListOfTimers";
            ListOfTimers.Size = new Size(227, 379);
            ListOfTimers.TabIndex = 0;
            ListOfTimers.SelectedIndexChanged += ListOfTimers_SelectedIndexChanged;
            // 
            // AddNewTimer
            // 
            AddNewTimer.Location = new Point(12, 404);
            AddNewTimer.Name = "AddNewTimer";
            AddNewTimer.Size = new Size(112, 34);
            AddNewTimer.TabIndex = 1;
            AddNewTimer.Text = "Add";
            AddNewTimer.UseVisualStyleBackColor = true;
            AddNewTimer.Click += AddNewTimer_Click;
            // 
            // DeleteSelectedTimer
            // 
            DeleteSelectedTimer.Location = new Point(127, 404);
            DeleteSelectedTimer.Name = "DeleteSelectedTimer";
            DeleteSelectedTimer.Size = new Size(112, 34);
            DeleteSelectedTimer.TabIndex = 2;
            DeleteSelectedTimer.Text = "Delete";
            DeleteSelectedTimer.UseVisualStyleBackColor = true;
            DeleteSelectedTimer.Click += DeleteSelectedTimer_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Font = new Font("Digital-7", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerLabel.Location = new Point(256, 153);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(516, 143);
            TimerLabel.TabIndex = 3;
            TimerLabel.Text = "00:00:00";
            // 
            // StartTimerButton
            // 
            StartTimerButton.Location = new Point(256, 323);
            StartTimerButton.Name = "StartTimerButton";
            StartTimerButton.Size = new Size(165, 34);
            StartTimerButton.TabIndex = 4;
            StartTimerButton.Text = "Start";
            StartTimerButton.UseVisualStyleBackColor = true;
            StartTimerButton.Click += StartTimerButton_Click;
            // 
            // StopTimerButton
            // 
            StopTimerButton.Location = new Point(614, 323);
            StopTimerButton.Name = "StopTimerButton";
            StopTimerButton.Size = new Size(158, 34);
            StopTimerButton.TabIndex = 5;
            StopTimerButton.Text = "Stop";
            StopTimerButton.UseVisualStyleBackColor = true;
            StopTimerButton.Click += StopTimerButton_Click;
            // 
            // PauseTimerButton
            // 
            PauseTimerButton.Location = new Point(427, 323);
            PauseTimerButton.Name = "PauseTimerButton";
            PauseTimerButton.Size = new Size(181, 34);
            PauseTimerButton.TabIndex = 6;
            PauseTimerButton.Text = "Pause";
            PauseTimerButton.UseVisualStyleBackColor = true;
            PauseTimerButton.Click += PauseTimerButton_Click;
            // 
            // TimerCountdown
            // 
            TimerCountdown.Interval = 1000;
            TimerCountdown.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PauseTimerButton);
            Controls.Add(StopTimerButton);
            Controls.Add(StartTimerButton);
            Controls.Add(TimerLabel);
            Controls.Add(DeleteSelectedTimer);
            Controls.Add(AddNewTimer);
            Controls.Add(ListOfTimers);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListOfTimers;
        private Button AddNewTimer;
        private Button DeleteSelectedTimer;
        private Label TimerLabel;
        private Button StartTimerButton;
        private Button StopTimerButton;
        private Button PauseTimerButton;
        private System.Windows.Forms.Timer TimerCountdown;
    }
}
