﻿namespace IBMConsultantTool
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.NewConsultButton = new System.Windows.Forms.PictureBox();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TrendAnalysisButton = new System.Windows.Forms.PictureBox();
            this.NewConsultMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrendAnalysisLabel = new System.Windows.Forms.Label();
            this.TrendDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewConsultButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrendAnalysisButton)).BeginInit();
            this.SuspendLayout();
            // 
            // NewConsultButton
            // 
            this.NewConsultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewConsultButton.Image = ((System.Drawing.Image)(resources.GetObject("NewConsultButton.Image")));
            this.NewConsultButton.Location = new System.Drawing.Point(72, 135);
            this.NewConsultButton.Name = "NewConsultButton";
            this.NewConsultButton.Size = new System.Drawing.Size(120, 131);
            this.NewConsultButton.TabIndex = 3;
            this.NewConsultButton.TabStop = false;
            this.NewConsultButton.Click += new System.EventHandler(this.NewConsultButton_Click);
            this.NewConsultButton.MouseEnter += new System.EventHandler(this.NewConsultButton_MouseEnter);
            this.NewConsultButton.MouseLeave += new System.EventHandler(this.NewConsultButton_MouseLeave);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(68, 83);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(563, 21);
            this.WelcomeMessage.TabIndex = 5;
            this.WelcomeMessage.Text = "The IBM Consultant Toolkit makes it easier than ever to perform workshop tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "WELCOME";
            // 
            // TrendAnalysisButton
            // 
            this.TrendAnalysisButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrendAnalysisButton.Image = ((System.Drawing.Image)(resources.GetObject("TrendAnalysisButton.Image")));
            this.TrendAnalysisButton.Location = new System.Drawing.Point(72, 301);
            this.TrendAnalysisButton.Name = "TrendAnalysisButton";
            this.TrendAnalysisButton.Size = new System.Drawing.Size(120, 129);
            this.TrendAnalysisButton.TabIndex = 7;
            this.TrendAnalysisButton.TabStop = false;
            this.TrendAnalysisButton.MouseEnter += new System.EventHandler(this.TrendAnalysisButton_MouseEnter);
            this.TrendAnalysisButton.MouseLeave += new System.EventHandler(this.TrendAnalysisButton_MouseLeave);
            // 
            // NewConsultMessage
            // 
            this.NewConsultMessage.AutoSize = true;
            this.NewConsultMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewConsultMessage.Location = new System.Drawing.Point(215, 161);
            this.NewConsultMessage.Name = "NewConsultMessage";
            this.NewConsultMessage.Size = new System.Drawing.Size(219, 29);
            this.NewConsultMessage.TabIndex = 8;
            this.NewConsultMessage.Text = "Start a new Consult";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "The new consultant toolkit makes it easier than ever to plan your workshops. ";
            // 
            // TrendAnalysisLabel
            // 
            this.TrendAnalysisLabel.AutoSize = true;
            this.TrendAnalysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendAnalysisLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TrendAnalysisLabel.Location = new System.Drawing.Point(215, 315);
            this.TrendAnalysisLabel.Name = "TrendAnalysisLabel";
            this.TrendAnalysisLabel.Size = new System.Drawing.Size(172, 29);
            this.TrendAnalysisLabel.TabIndex = 10;
            this.TrendAnalysisLabel.Text = "Trend Analysis";
            // 
            // TrendDescription
            // 
            this.TrendDescription.AutoSize = true;
            this.TrendDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendDescription.Location = new System.Drawing.Point(216, 364);
            this.TrendDescription.Name = "TrendDescription";
            this.TrendDescription.Size = new System.Drawing.Size(471, 20);
            this.TrendDescription.TabIndex = 11;
            this.TrendDescription.Text = "Organize past consults in a number of ways to see industry trends";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 595);
            this.Controls.Add(this.TrendDescription);
            this.Controls.Add(this.TrendAnalysisLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewConsultMessage);
            this.Controls.Add(this.TrendAnalysisButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.NewConsultButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestForm";
            this.Text = "Server Upload";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewConsultButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrendAnalysisButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NewConsultButton;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox TrendAnalysisButton;
        private System.Windows.Forms.Label NewConsultMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TrendAnalysisLabel;
        private System.Windows.Forms.Label TrendDescription;
    }
}