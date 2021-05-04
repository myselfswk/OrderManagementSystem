namespace OrderManagementSystem.Tools
{
    partial class StopWatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblmiliseconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartingHours = new System.Windows.Forms.TextBox();
            this.txtStartingMinutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStartingSeconds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Stop Watch";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.Blue;
            this.lblHours.Location = new System.Drawing.Point(16, 194);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(191, 135);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.Blue;
            this.lblMinutes.Location = new System.Drawing.Point(283, 194);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(191, 135);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.Blue;
            this.lblSeconds.Location = new System.Drawing.Point(546, 194);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(191, 135);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(68, 388);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(209, 95);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Yellow;
            this.btnStop.Location = new System.Drawing.Point(717, 388);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(209, 95);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Red;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Yellow;
            this.btnPause.Location = new System.Drawing.Point(369, 388);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(274, 95);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblmiliseconds
            // 
            this.lblmiliseconds.AutoSize = true;
            this.lblmiliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmiliseconds.ForeColor = System.Drawing.Color.Blue;
            this.lblmiliseconds.Location = new System.Drawing.Point(810, 194);
            this.lblmiliseconds.Name = "lblmiliseconds";
            this.lblmiliseconds.Size = new System.Drawing.Size(191, 135);
            this.lblmiliseconds.TabIndex = 7;
            this.lblmiliseconds.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(175, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 135);
            this.label2.TabIndex = 8;
            this.label2.Text = "::";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(445, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 135);
            this.label3.TabIndex = 9;
            this.label3.Text = "::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(708, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 135);
            this.label4.TabIndex = 10;
            this.label4.Text = "::";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Yellow;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Red;
            this.btnSettings.Location = new System.Drawing.Point(987, 47);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(271, 81);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.Yellow;
            this.settingsPanel.Controls.Add(this.btnApply);
            this.settingsPanel.Controls.Add(this.txtStartingSeconds);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.txtStartingMinutes);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.txtStartingHours);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.ForeColor = System.Drawing.Color.Red;
            this.settingsPanel.Location = new System.Drawing.Point(987, 135);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(271, 348);
            this.settingsPanel.TabIndex = 12;
            this.settingsPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "hours :";
            // 
            // txtStartingHours
            // 
            this.txtStartingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingHours.Location = new System.Drawing.Point(168, 17);
            this.txtStartingHours.Name = "txtStartingHours";
            this.txtStartingHours.Size = new System.Drawing.Size(100, 45);
            this.txtStartingHours.TabIndex = 1;
            // 
            // txtStartingMinutes
            // 
            this.txtStartingMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingMinutes.Location = new System.Drawing.Point(168, 84);
            this.txtStartingMinutes.Name = "txtStartingMinutes";
            this.txtStartingMinutes.Size = new System.Drawing.Size(100, 45);
            this.txtStartingMinutes.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "minutes :";
            // 
            // txtStartingSeconds
            // 
            this.txtStartingSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingSeconds.Location = new System.Drawing.Point(168, 146);
            this.txtStartingSeconds.Name = "txtStartingSeconds";
            this.txtStartingSeconds.Size = new System.Drawing.Size(100, 45);
            this.txtStartingSeconds.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 39);
            this.label7.TabIndex = 13;
            this.label7.Text = "seconds :";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(168, 210);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 49);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 582);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmiliseconds);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.label1);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblmiliseconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtStartingSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStartingMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartingHours;
        private System.Windows.Forms.Label label5;
    }
}