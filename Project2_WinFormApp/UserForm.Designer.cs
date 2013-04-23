namespace Project2
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.InstructionBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.MessagePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessagePanel
            // 
            this.MessagePanel.Controls.Add(this.InstructionBox);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(484, 38);
            this.MessagePanel.TabIndex = 0;
            // 
            // InstructionBox
            // 
            this.InstructionBox.BackColor = System.Drawing.SystemColors.Control;
            this.InstructionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.InstructionBox.Location = new System.Drawing.Point(75, 10);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.ReadOnly = true;
            this.InstructionBox.Size = new System.Drawing.Size(350, 13);
            this.InstructionBox.TabIndex = 0;
            this.InstructionBox.TabStop = false;
            this.InstructionBox.Text = "Please fill in your name, e-mail address, and phone number";
            this.InstructionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 38);
            this.panel1.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(150, 9);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(310, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.UserNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(20, 9);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(100, 17);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.TabStop = false;
            this.UserNameLabel.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.EmailBox);
            this.panel2.Controls.Add(this.EmailLabel);
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 38);
            this.panel2.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailBox.Location = new System.Drawing.Point(150, 9);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(310, 20);
            this.EmailBox.TabIndex = 2;
            this.EmailBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.EmailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(20, 9);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(110, 17);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.TabStop = false;
            this.EmailLabel.Text = "E-mail Address";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.PhoneNumberBox);
            this.panel3.Controls.Add(this.PhoneNumberLabel);
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 38);
            this.panel3.TabIndex = 3;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberBox.Location = new System.Drawing.Point(150, 9);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(310, 20);
            this.PhoneNumberBox.TabIndex = 3;
            this.PhoneNumberBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(20, 9);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(110, 17);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.TabStop = false;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.CancelButton);
            this.panel4.Controls.Add(this.OkButton);
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 33);
            this.panel4.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelButton.Location = new System.Drawing.Point(255, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OkButton.Location = new System.Drawing.Point(150, 5);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 212);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analysis User Information";
            this.TransparencyKey = System.Drawing.Color.Bisque;
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.TextBox InstructionBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox UserNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox EmailLabel;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox PhoneNumberLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}