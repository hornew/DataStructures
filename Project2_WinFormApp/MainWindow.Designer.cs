using System.Windows.Forms;
using System;
namespace Project2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProductInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.Filler = new System.Windows.Forms.ToolStripStatusLabel();
            this.TokenCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.SentenceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateAndParagraphs = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.OriginalText = new System.Windows.Forms.TabPage();
            this.Original = new System.Windows.Forms.RichTextBox();
            this.Tokens = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TokensBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DistinctWords = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.WordsBox = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SentenceList = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.SentenceDisplayBox = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageSentenceWordLengthBox = new System.Windows.Forms.TextBox();
            this.SentenceWordCountBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.NextSentenceButton = new System.Windows.Forms.Button();
            this.PreviousSentenceButton = new System.Windows.Forms.Button();
            this.ParagraphTab = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.ParagraphDisplayBox = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfWordsBox = new System.Windows.Forms.TextBox();
            this.AverageWordsBox = new System.Windows.Forms.TextBox();
            this.NumberOfSentencesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.PreviousParagraphButton = new System.Windows.Forms.Button();
            this.NextParagraphButton = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ParagraphsUpDown = new System.Windows.Forms.NumericUpDown();
            this.DisplayParagraphs = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ParagraphsBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.OriginalText.SuspendLayout();
            this.Tokens.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DistinctWords.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SentenceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel8.SuspendLayout();
            this.ParagraphTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParagraphsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductInfo,
            this.Filler,
            this.TokenCount,
            this.WordCount,
            this.SentenceCount,
            this.DateAndParagraphs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // ProductInfo
            // 
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(342, 17);
            this.ProductInfo.Text = "Microsoft® Visual Studio® 2010 built by Microsoft Corporation";
            // 
            // Filler
            // 
            this.Filler.Name = "Filler";
            this.Filler.Size = new System.Drawing.Size(294, 17);
            this.Filler.Spring = true;
            // 
            // TokenCount
            // 
            this.TokenCount.Name = "TokenCount";
            this.TokenCount.Size = new System.Drawing.Size(0, 17);
            // 
            // WordCount
            // 
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(0, 17);
            // 
            // SentenceCount
            // 
            this.SentenceCount.Name = "SentenceCount";
            this.SentenceCount.Size = new System.Drawing.Size(0, 17);
            // 
            // DateAndParagraphs
            // 
            this.DateAndParagraphs.Name = "DateAndParagraphs";
            this.DateAndParagraphs.Size = new System.Drawing.Size(133, 17);
            this.DateAndParagraphs.Text = "Friday, October 19, 2012";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpenFile,
            this.MenuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuItemOpenFile
            // 
            this.MenuItemOpenFile.Name = "MenuItemOpenFile";
            this.MenuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpenFile.Size = new System.Drawing.Size(146, 22);
            this.MenuItemOpenFile.Text = "Open";
            this.MenuItemOpenFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(146, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItemAbout.Size = new System.Drawing.Size(126, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.OriginalText);
            this.Tabs.Controls.Add(this.Tokens);
            this.Tabs.Controls.Add(this.DistinctWords);
            this.Tabs.Controls.Add(this.SentenceList);
            this.Tabs.Controls.Add(this.ParagraphTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.HotTrack = true;
            this.Tabs.Location = new System.Drawing.Point(0, 24);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(784, 516);
            this.Tabs.TabIndex = 2;
            // 
            // OriginalText
            // 
            this.OriginalText.Controls.Add(this.Original);
            this.OriginalText.Location = new System.Drawing.Point(4, 22);
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.Padding = new System.Windows.Forms.Padding(3);
            this.OriginalText.Size = new System.Drawing.Size(776, 490);
            this.OriginalText.TabIndex = 0;
            this.OriginalText.Text = "Original Text";
            this.OriginalText.UseVisualStyleBackColor = true;
            // 
            // Original
            // 
            this.Original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Original.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Original.Location = new System.Drawing.Point(3, 3);
            this.Original.Name = "Original";
            this.Original.Size = new System.Drawing.Size(770, 484);
            this.Original.TabIndex = 0;
            this.Original.Text = "";
            // 
            // Tokens
            // 
            this.Tokens.Controls.Add(this.panel3);
            this.Tokens.Controls.Add(this.panel2);
            this.Tokens.Controls.Add(this.panel1);
            this.Tokens.Location = new System.Drawing.Point(4, 22);
            this.Tokens.Name = "Tokens";
            this.Tokens.Padding = new System.Windows.Forms.Padding(3);
            this.Tokens.Size = new System.Drawing.Size(776, 490);
            this.Tokens.TabIndex = 1;
            this.Tokens.Text = "Tokens";
            this.Tokens.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 484);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TokensBox);
            this.splitContainer1.Size = new System.Drawing.Size(370, 484);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(0, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tokens Found";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TokensBox
            // 
            this.TokensBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TokensBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokensBox.Location = new System.Drawing.Point(0, 0);
            this.TokensBox.Name = "TokensBox";
            this.TokensBox.ReadOnly = true;
            this.TokensBox.Size = new System.Drawing.Size(370, 443);
            this.TokensBox.TabIndex = 0;
            this.TokensBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 484);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(573, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 484);
            this.panel1.TabIndex = 0;
            // 
            // DistinctWords
            // 
            this.DistinctWords.Controls.Add(this.panel6);
            this.DistinctWords.Controls.Add(this.panel5);
            this.DistinctWords.Controls.Add(this.panel4);
            this.DistinctWords.Location = new System.Drawing.Point(4, 22);
            this.DistinctWords.Name = "DistinctWords";
            this.DistinctWords.Padding = new System.Windows.Forms.Padding(3);
            this.DistinctWords.Size = new System.Drawing.Size(776, 490);
            this.DistinctWords.TabIndex = 2;
            this.DistinctWords.Text = "Distinct Words";
            this.DistinctWords.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.splitContainer2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(153, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(470, 484);
            this.panel6.TabIndex = 3;
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.WordsBox);
            this.splitContainer2.Size = new System.Drawing.Size(470, 484);
            this.splitContainer2.SplitterDistance = 37;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBox3);
            this.splitContainer3.Size = new System.Drawing.Size(470, 37);
            this.splitContainer3.SplitterDistance = 235;
            this.splitContainer3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(0, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(235, 17);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Words";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(0, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(231, 17);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Occurences";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WordsBox
            // 
            this.WordsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsBox.Location = new System.Drawing.Point(0, 0);
            this.WordsBox.Name = "WordsBox";
            this.WordsBox.ReadOnly = true;
            this.WordsBox.Size = new System.Drawing.Size(470, 443);
            this.WordsBox.TabIndex = 0;
            this.WordsBox.Text = "";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 484);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(623, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 484);
            this.panel4.TabIndex = 1;
            // 
            // SentenceList
            // 
            this.SentenceList.Controls.Add(this.splitContainer7);
            this.SentenceList.Location = new System.Drawing.Point(4, 22);
            this.SentenceList.Name = "SentenceList";
            this.SentenceList.Size = new System.Drawing.Size(776, 490);
            this.SentenceList.TabIndex = 5;
            this.SentenceList.Text = "Sentences";
            this.SentenceList.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.SentenceDisplayBox);
            this.splitContainer7.Panel1.Controls.Add(this.panel7);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.AverageSentenceWordLengthBox);
            this.splitContainer7.Panel2.Controls.Add(this.SentenceWordCountBox);
            this.splitContainer7.Panel2.Controls.Add(this.label8);
            this.splitContainer7.Panel2.Controls.Add(this.label2);
            this.splitContainer7.Panel2.Controls.Add(this.panel8);
            this.splitContainer7.Size = new System.Drawing.Size(776, 490);
            this.splitContainer7.SplitterDistance = 245;
            this.splitContainer7.TabIndex = 0;
            // 
            // SentenceDisplayBox
            // 
            this.SentenceDisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SentenceDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentenceDisplayBox.Location = new System.Drawing.Point(0, 50);
            this.SentenceDisplayBox.Name = "SentenceDisplayBox";
            this.SentenceDisplayBox.Size = new System.Drawing.Size(776, 195);
            this.SentenceDisplayBox.TabIndex = 1;
            this.SentenceDisplayBox.Text = "";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numericUpDown1);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(776, 50);
            this.panel7.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDown1.Location = new System.Drawing.Point(407, 15);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Sentences";
            // 
            // AverageSentenceWordLengthBox
            // 
            this.AverageSentenceWordLengthBox.Location = new System.Drawing.Point(450, 77);
            this.AverageSentenceWordLengthBox.Name = "AverageSentenceWordLengthBox";
            this.AverageSentenceWordLengthBox.ReadOnly = true;
            this.AverageSentenceWordLengthBox.Size = new System.Drawing.Size(62, 20);
            this.AverageSentenceWordLengthBox.TabIndex = 8;
            // 
            // SentenceWordCountBox
            // 
            this.SentenceWordCountBox.Location = new System.Drawing.Point(450, 39);
            this.SentenceWordCountBox.Name = "SentenceWordCountBox";
            this.SentenceWordCountBox.ReadOnly = true;
            this.SentenceWordCountBox.Size = new System.Drawing.Size(62, 20);
            this.SentenceWordCountBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Average Word Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Of Words";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.NextSentenceButton);
            this.panel8.Controls.Add(this.PreviousSentenceButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 199);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(776, 42);
            this.panel8.TabIndex = 0;
            // 
            // NextSentenceButton
            // 
            this.NextSentenceButton.Image = ((System.Drawing.Image)(resources.GetObject("NextSentenceButton.Image")));
            this.NextSentenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NextSentenceButton.Location = new System.Drawing.Point(427, 10);
            this.NextSentenceButton.Name = "NextSentenceButton";
            this.NextSentenceButton.Size = new System.Drawing.Size(85, 23);
            this.NextSentenceButton.TabIndex = 4;
            this.NextSentenceButton.Text = "Next";
            this.NextSentenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextSentenceButton.UseVisualStyleBackColor = true;
            this.NextSentenceButton.Click += new System.EventHandler(this.NextSentenceButton_Click);
            // 
            // PreviousSentenceButton
            // 
            this.PreviousSentenceButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousSentenceButton.Image")));
            this.PreviousSentenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviousSentenceButton.Location = new System.Drawing.Point(293, 10);
            this.PreviousSentenceButton.Name = "PreviousSentenceButton";
            this.PreviousSentenceButton.Size = new System.Drawing.Size(85, 23);
            this.PreviousSentenceButton.TabIndex = 3;
            this.PreviousSentenceButton.Text = "Previous";
            this.PreviousSentenceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PreviousSentenceButton.UseVisualStyleBackColor = true;
            this.PreviousSentenceButton.Click += new System.EventHandler(this.PreviousSentenceButton_Click);
            // 
            // ParagraphTab
            // 
            this.ParagraphTab.Controls.Add(this.splitContainer6);
            this.ParagraphTab.Location = new System.Drawing.Point(4, 22);
            this.ParagraphTab.Name = "ParagraphTab";
            this.ParagraphTab.Padding = new System.Windows.Forms.Padding(3);
            this.ParagraphTab.Size = new System.Drawing.Size(776, 490);
            this.ParagraphTab.TabIndex = 4;
            this.ParagraphTab.Text = "Paragraphs";
            this.ParagraphTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.ParagraphDisplayBox);
            this.splitContainer6.Panel1.Controls.Add(this.panel9);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.label6);
            this.splitContainer6.Panel2.Controls.Add(this.label5);
            this.splitContainer6.Panel2.Controls.Add(this.NumberOfWordsBox);
            this.splitContainer6.Panel2.Controls.Add(this.AverageWordsBox);
            this.splitContainer6.Panel2.Controls.Add(this.NumberOfSentencesBox);
            this.splitContainer6.Panel2.Controls.Add(this.label4);
            this.splitContainer6.Panel2.Controls.Add(this.panel10);
            this.splitContainer6.Size = new System.Drawing.Size(770, 484);
            this.splitContainer6.SplitterDistance = 242;
            this.splitContainer6.TabIndex = 1;
            // 
            // ParagraphDisplayBox
            // 
            this.ParagraphDisplayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParagraphDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphDisplayBox.Location = new System.Drawing.Point(0, 41);
            this.ParagraphDisplayBox.Name = "ParagraphDisplayBox";
            this.ParagraphDisplayBox.Size = new System.Drawing.Size(770, 201);
            this.ParagraphDisplayBox.TabIndex = 2;
            this.ParagraphDisplayBox.Text = "";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.numericUpDown2);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(770, 41);
            this.panel9.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDown2.Location = new System.Drawing.Point(428, 10);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Display Paragraphs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Number Of Words";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Average Words";
            // 
            // NumberOfWordsBox
            // 
            this.NumberOfWordsBox.Location = new System.Drawing.Point(428, 83);
            this.NumberOfWordsBox.Name = "NumberOfWordsBox";
            this.NumberOfWordsBox.ReadOnly = true;
            this.NumberOfWordsBox.Size = new System.Drawing.Size(62, 20);
            this.NumberOfWordsBox.TabIndex = 7;
            // 
            // AverageWordsBox
            // 
            this.AverageWordsBox.Location = new System.Drawing.Point(428, 125);
            this.AverageWordsBox.Name = "AverageWordsBox";
            this.AverageWordsBox.ReadOnly = true;
            this.AverageWordsBox.Size = new System.Drawing.Size(62, 20);
            this.AverageWordsBox.TabIndex = 6;
            // 
            // NumberOfSentencesBox
            // 
            this.NumberOfSentencesBox.Location = new System.Drawing.Point(428, 40);
            this.NumberOfSentencesBox.Name = "NumberOfSentencesBox";
            this.NumberOfSentencesBox.ReadOnly = true;
            this.NumberOfSentencesBox.Size = new System.Drawing.Size(62, 20);
            this.NumberOfSentencesBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number Of Sentences";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 189);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(770, 49);
            this.panel10.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.PreviousParagraphButton);
            this.panel11.Controls.Add(this.NextParagraphButton);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(770, 49);
            this.panel11.TabIndex = 1;
            // 
            // PreviousParagraphButton
            // 
            this.PreviousParagraphButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousParagraphButton.Image")));
            this.PreviousParagraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviousParagraphButton.Location = new System.Drawing.Point(279, 13);
            this.PreviousParagraphButton.Name = "PreviousParagraphButton";
            this.PreviousParagraphButton.Size = new System.Drawing.Size(85, 23);
            this.PreviousParagraphButton.TabIndex = 2;
            this.PreviousParagraphButton.Text = "Previous";
            this.PreviousParagraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PreviousParagraphButton.UseVisualStyleBackColor = true;
            this.PreviousParagraphButton.Click += new System.EventHandler(this.PreviousParagraphButton_Click);
            // 
            // NextParagraphButton
            // 
            this.NextParagraphButton.Image = ((System.Drawing.Image)(resources.GetObject("NextParagraphButton.Image")));
            this.NextParagraphButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NextParagraphButton.Location = new System.Drawing.Point(405, 13);
            this.NextParagraphButton.Name = "NextParagraphButton";
            this.NextParagraphButton.Size = new System.Drawing.Size(85, 23);
            this.NextParagraphButton.TabIndex = 1;
            this.NextParagraphButton.Text = "Next";
            this.NextParagraphButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextParagraphButton.UseVisualStyleBackColor = true;
            this.NextParagraphButton.Click += new System.EventHandler(this.NextParagraphButton_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ParagraphsUpDown);
            this.splitContainer4.Panel1.Controls.Add(this.DisplayParagraphs);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Panel2.Controls.Add(this.ParagraphsBox);
            this.splitContainer4.Size = new System.Drawing.Size(770, 242);
            this.splitContainer4.SplitterDistance = 44;
            this.splitContainer4.TabIndex = 0;
            // 
            // ParagraphsUpDown
            // 
            this.ParagraphsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphsUpDown.ForeColor = System.Drawing.Color.Blue;
            this.ParagraphsUpDown.Location = new System.Drawing.Point(423, 14);
            this.ParagraphsUpDown.Name = "ParagraphsUpDown";
            this.ParagraphsUpDown.Size = new System.Drawing.Size(45, 20);
            this.ParagraphsUpDown.TabIndex = 1;
            this.ParagraphsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DisplayParagraphs
            // 
            this.DisplayParagraphs.AutoSize = true;
            this.DisplayParagraphs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayParagraphs.Location = new System.Drawing.Point(254, 14);
            this.DisplayParagraphs.Name = "DisplayParagraphs";
            this.DisplayParagraphs.Size = new System.Drawing.Size(154, 18);
            this.DisplayParagraphs.TabIndex = 0;
            this.DisplayParagraphs.Text = "Display Paragraphs";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.button2);
            this.splitContainer5.Panel2.Controls.Add(this.button1);
            this.splitContainer5.Size = new System.Drawing.Size(770, 194);
            this.splitContainer5.SplitterDistance = 139;
            this.splitContainer5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(393, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(257, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Previous";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ParagraphsBox
            // 
            this.ParagraphsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParagraphsBox.Location = new System.Drawing.Point(0, 0);
            this.ParagraphsBox.Name = "ParagraphsBox";
            this.ParagraphsBox.Size = new System.Drawing.Size(770, 194);
            this.ParagraphsBox.TabIndex = 0;
            this.ParagraphsBox.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analysis Toolkit";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.OriginalText.ResumeLayout(false);
            this.Tokens.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DistinctWords.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.SentenceList.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ParagraphTab.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParagraphsUpDown)).EndInit();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private ToolStripStatusLabel ProductInfo;
        private ToolStripStatusLabel Filler;
        private ToolStripStatusLabel DateAndParagraphs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem MenuItemExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem MenuItemOpenFile;
        private ToolStripMenuItem MenuItemAbout;
        private TabControl Tabs;
        private TabPage OriginalText;
        private TabPage Tokens;
        private TabPage DistinctWords;
        private TabPage ParagraphTab;
        private RichTextBox Original;
        private RichTextBox Paragraphs;
        private ToolStripStatusLabel TokenCount;
        private ToolStripStatusLabel WordCount;
        private ToolStripStatusLabel SentenceCount;
        private Panel panel3;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel5;
        private Panel panel4;
        private SplitContainer splitContainer4;
        private NumericUpDown ParagraphsUpDown;
        private Label DisplayParagraphs;
        private RichTextBox ParagraphsBox;
        private SplitContainer splitContainer5;
        private Button button2;
        private Button button1;
        private RichTextBox TokensBox;
        private RichTextBox WordsBox;
        private SplitContainer splitContainer6;
        private RichTextBox ParagraphDisplayBox;
        private Panel panel9;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox NumberOfWordsBox;
        private TextBox AverageWordsBox;
        private TextBox NumberOfSentencesBox;
        private Label label4;
        private Panel panel10;
        private Panel panel11;
        private Button PreviousParagraphButton;
        private Button NextParagraphButton;
        private TabPage SentenceList;
        private SplitContainer splitContainer7;
        private RichTextBox SentenceDisplayBox;
        private Panel panel7;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox AverageSentenceWordLengthBox;
        private TextBox SentenceWordCountBox;
        private Label label8;
        private Label label2;
        private Panel panel8;
        private Button NextSentenceButton;
        private Button PreviousSentenceButton;

    }
}