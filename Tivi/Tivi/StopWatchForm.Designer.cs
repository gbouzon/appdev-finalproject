namespace Tivi
{
    partial class StopWatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopWatchForm));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.stopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.btn_capture = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(34, 441);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(160, 63);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(462, 441);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(160, 63);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // stopWatchTimer
            // 
            this.stopWatchTimer.Tick += new System.EventHandler(this.stopWatchTimer_Tick);
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(259, 213);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(202, 46);
            this.returnToMainMenuButton.TabIndex = 10;
            this.returnToMainMenuButton.Text = "Back To Main Menu";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // btn_capture
            // 
            this.btn_capture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capture.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capture.Location = new System.Drawing.Point(246, 441);
            this.btn_capture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(164, 63);
            this.btn_capture.TabIndex = 11;
            this.btn_capture.Text = "CAPTURE";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(668, 441);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(160, 63);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.listBox1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(28, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(812, 352);
            this.listBox1.TabIndex = 13;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(28, 393);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(242, 33);
            this.lbl_time.TabIndex = 14;
            this.lbl_time.Text = "Timer: 00:00:00:000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 63);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back To Main Menu\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // StopWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(891, 696);
            this.MinimumSize = new System.Drawing.Size(891, 696);
            this.Name = "StopWatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer stopWatchTimer;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Button btn_capture;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button button1;
    }
}