﻿namespace KeppyDriverConfigurator
{
    partial class KeppyDriverBufferSystem
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
            this.Default = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewBuf = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OldBuf = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Default
            // 
            this.Default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Default.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Default.Location = new System.Drawing.Point(294, 107);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(98, 23);
            this.Default.TabIndex = 11;
            this.Default.Text = "Restore default";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(398, 107);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 121);
            this.label1.TabIndex = 7;
            this.label1.Text = "Switch between the old and new buffer systems. Useful if you get better performan" +
    "ces with the old one.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewBuf
            // 
            this.NewBuf.AutoSize = true;
            this.NewBuf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewBuf.Location = new System.Drawing.Point(81, 10);
            this.NewBuf.Name = "NewBuf";
            this.NewBuf.Size = new System.Drawing.Size(132, 17);
            this.NewBuf.TabIndex = 12;
            this.NewBuf.TabStop = true;
            this.NewBuf.Text = "Use new buffer system";
            this.NewBuf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.OldBuf);
            this.panel1.Controls.Add(this.NewBuf);
            this.panel1.Location = new System.Drawing.Point(257, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 61);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KeppyDriverConfigurator.Properties.Resources.wi;
            this.pictureBox1.Location = new System.Drawing.Point(71, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OldBufferWarning_Click);
            // 
            // OldBuf
            // 
            this.OldBuf.AutoSize = true;
            this.OldBuf.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OldBuf.Location = new System.Drawing.Point(87, 33);
            this.OldBuf.Name = "OldBuf";
            this.OldBuf.Size = new System.Drawing.Size(126, 17);
            this.OldBuf.TabIndex = 13;
            this.OldBuf.TabStop = true;
            this.OldBuf.Text = "Use old buffer system";
            this.OldBuf.UseVisualStyleBackColor = true;
            // 
            // KeppyDriverBufferSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeppyDriverBufferSystem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change default buffer system";
            this.Load += new System.EventHandler(this.KeppyDriverBufferSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton NewBuf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton OldBuf;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}