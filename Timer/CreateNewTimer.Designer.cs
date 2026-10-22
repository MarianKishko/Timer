namespace Timer
{
    partial class CreateNewTimer
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            AddNewTimerButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 45);
            numericUpDown1.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 31);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(139, 45);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(121, 31);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(266, 45);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(116, 31);
            numericUpDown3.TabIndex = 2;
            // 
            // AddNewTimerButton
            // 
            AddNewTimerButton.Location = new Point(270, 99);
            AddNewTimerButton.Name = "AddNewTimerButton";
            AddNewTimerButton.Size = new Size(112, 34);
            AddNewTimerButton.TabIndex = 3;
            AddNewTimerButton.Text = "Add";
            AddNewTimerButton.UseVisualStyleBackColor = true;
            AddNewTimerButton.Click += AddNewTimerButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(152, 99);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 5;
            label1.Text = "Hour:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 6;
            label2.Text = "Minute:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 7;
            label3.Text = "Second:";
            // 
            // CreateNewTimer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 145);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(AddNewTimerButton);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateNewTimer";
            Text = "CreateNewTimer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button AddNewTimerButton;
        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}