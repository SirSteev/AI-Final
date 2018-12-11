namespace LaMountain_AI_Final
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
            this.components = new System.ComponentModel.Container();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnRunGA = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbFitnessVal = new System.Windows.Forms.TextBox();
            this.tbGenoration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbElapsedTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopGA = new System.Windows.Forms.Button();
            this.pbImageToMatch = new LaMountain_AI_Final.PictureBoxWithInterpolationMode();
            this.pbImage = new LaMountain_AI_Final.PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(943, 518);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open Image";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnRunGA
            // 
            this.btnRunGA.Enabled = false;
            this.btnRunGA.Location = new System.Drawing.Point(476, 518);
            this.btnRunGA.Name = "btnRunGA";
            this.btnRunGA.Size = new System.Drawing.Size(75, 23);
            this.btnRunGA.TabIndex = 3;
            this.btnRunGA.Text = "Run GA";
            this.btnRunGA.UseVisualStyleBackColor = true;
            this.btnRunGA.Click += new System.EventHandler(this.btnRunGA_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbFitnessVal
            // 
            this.tbFitnessVal.Location = new System.Drawing.Point(12, 531);
            this.tbFitnessVal.Name = "tbFitnessVal";
            this.tbFitnessVal.ReadOnly = true;
            this.tbFitnessVal.Size = new System.Drawing.Size(100, 20);
            this.tbFitnessVal.TabIndex = 4;
            // 
            // tbGenoration
            // 
            this.tbGenoration.Location = new System.Drawing.Point(119, 531);
            this.tbGenoration.Name = "tbGenoration";
            this.tbGenoration.ReadOnly = true;
            this.tbGenoration.Size = new System.Drawing.Size(100, 20);
            this.tbGenoration.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fitness";
            // 
            // tbElapsedTime
            // 
            this.tbElapsedTime.Location = new System.Drawing.Point(226, 531);
            this.tbElapsedTime.Name = "tbElapsedTime";
            this.tbElapsedTime.ReadOnly = true;
            this.tbElapsedTime.Size = new System.Drawing.Size(244, 20);
            this.tbElapsedTime.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Elapsed Time HH:MM:SS";
            // 
            // btnStopGA
            // 
            this.btnStopGA.Location = new System.Drawing.Point(557, 518);
            this.btnStopGA.Name = "btnStopGA";
            this.btnStopGA.Size = new System.Drawing.Size(75, 23);
            this.btnStopGA.TabIndex = 12;
            this.btnStopGA.Text = "Stop GA";
            this.btnStopGA.UseVisualStyleBackColor = true;
            this.btnStopGA.Click += new System.EventHandler(this.btnStopGA_Click);
            // 
            // pbImageToMatch
            // 
            this.pbImageToMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImageToMatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImageToMatch.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.pbImageToMatch.Location = new System.Drawing.Point(519, 12);
            this.pbImageToMatch.Name = "pbImageToMatch";
            this.pbImageToMatch.Size = new System.Drawing.Size(500, 500);
            this.pbImageToMatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageToMatch.TabIndex = 9;
            this.pbImageToMatch.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(500, 500);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 566);
            this.Controls.Add(this.btnStopGA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbElapsedTime);
            this.Controls.Add(this.pbImageToMatch);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGenoration);
            this.Controls.Add(this.tbFitnessVal);
            this.Controls.Add(this.btnRunGA);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LaMountain_AI_Final";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnRunGA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbFitnessVal;
        private System.Windows.Forms.TextBox tbGenoration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PictureBoxWithInterpolationMode pbImage;
        private PictureBoxWithInterpolationMode pbImageToMatch;
        private System.Windows.Forms.TextBox tbElapsedTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStopGA;
    }
}

