using Utils;
using System.Windows.Forms;
namespace Project2
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WelcomeBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TitleBox = new System.Windows.Forms.RichTextBox();
            this.VersionBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.WelcomeBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(395, 226);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.WelcomeBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.WelcomeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.ForeColor = System.Drawing.Color.Gold;
            this.WelcomeBox.Location = new System.Drawing.Point(0, 0);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.ReadOnly = true;
            this.WelcomeBox.Size = new System.Drawing.Size(395, 135);
            this.WelcomeBox.TabIndex = 0;
            this.WelcomeBox.TabStop = false;
            this.WelcomeBox.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TitleBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.VersionBox);
            this.splitContainer2.Size = new System.Drawing.Size(395, 87);
            this.splitContainer2.SplitterDistance = 58;
            this.splitContainer2.TabIndex = 1;
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.Gold;
            this.TitleBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TitleBox.Location = new System.Drawing.Point(0, 0);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(395, 58);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "\t    Text Analysis Toolkit\n\t           CSCI 2210";
            // 
            // VersionBox
            // 
            this.VersionBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.VersionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionBox.Location = new System.Drawing.Point(0, 0);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VersionBox.Size = new System.Drawing.Size(395, 25);
            this.VersionBox.TabIndex = 0;
            this.VersionBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 228);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox WelcomeBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox VersionBox;
        private RichTextBox TitleBox;

    }
}

