namespace FunnyQuestionsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Timer questionTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.questionTimer = new System.Windows.Forms.Timer();
            this.SuspendLayout();

            // questionLabel
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(180, 50);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(245, 30);

            // yesButton
            this.yesButton.BackColor = System.Drawing.Color.Green;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.yesButton.ForeColor = System.Drawing.Color.White;
            this.yesButton.Location = new System.Drawing.Point(150, 150);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(100, 40);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.YesButton_Click);

            // noButton
            this.noButton.BackColor = System.Drawing.Color.Red;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.Location = new System.Drawing.Point(350, 150);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(100, 40);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.MouseEnter += new System.EventHandler(this.NoButton_MouseEnter);

            // Timer
            this.questionTimer.Interval = 3000; // Question change interval (in ms)
            this.questionTimer.Tick += new System.EventHandler(this.QuestionTimer_Tick);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(33, 43, 54);
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funny Questions App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
