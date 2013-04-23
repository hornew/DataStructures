/**********************************************************************
 * File Name         : MainWindow.cs
 * Purpose            : Create a new instance of the MainWindow class
 *                          which serves as the main user interface for this windows
 *                          forms application. Also handle certain events linked to
 *                          controls in the form.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : October 18, 2012
 * 
 * Modified Date    : October 22, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Project1;

namespace Project2
{
    public partial class MainWindow : Form
    {
        public string Product { get; set; }
        public string Company { get; set; }
        public string Date { get; set; }
        private Text NewFile = null;
        private DistinctWordList WordsList = null;
        private SentenceList Sentences = null;
        private ParagraphList NewParagraphsList = null;
        private OpenFileDialog FileDialog = null;

        /// <summary>
        /// Initializes a new instance of the class.<see cref="MainWindow"/> 
        /// </summary>
        public MainWindow()
        {
            DateTime CurrentDate = DateTime.Now;
            this.Product = Application.ProductName;
            this.Company = Application.CompanyName;      
            this.Date = String.Format("{0:D}", CurrentDate);

            InitializeComponent();
            this.ProductInfo.Text = this.Product + " built by " + this.Company;
            this.DateAndParagraphs.Text = this.Date;
            this.Original.Text = "Please select a text file for analysis using the File menu above";
            this.TokensBox.Text = "Please select a text file for analysis using the File menu above";
            this.WordsBox.Text = "Please select a text file for analysis using the File menu above";
            this.ParagraphsBox.Text = "Please select a text file for analysis using the File menu above";
            this.SentenceDisplayBox.Text = "Please select a text file for analysis using the File menu above";
        }//end Constructor MainWindow()

        private void DisplayAnalysis()
        {
            string[] Fields = this.FileDialog.FileName.Split('\\');
            string FileName = Fields[Fields.Length - 1];            //Gets the last field of the file path
            List<string> TokensList = NewFile.Tokens;
            string TokenString = String.Empty;

            foreach (string str in TokensList)
            {
                TokenString += str + "\n";
            }

            //Text boxes inside tabs
            this.Original.Text = NewFile.Display();
            this.WordsBox.Text = WordsList.Display();
            this.TokensBox.Text = TokenString;
            this.SentenceDisplayBox.Text = Sentences.Sentences[0].ToString();
            this.AverageSentenceWordLengthBox.Text = Sentences.Sentences[0].AverageWordLength.ToString();
            this.SentenceWordCountBox.Text = Sentences.Sentences[0].WordCount.ToString();

            this.ParagraphDisplayBox.Text = NewParagraphsList.Paragraphs[0].ToString();
            this.NumberOfSentencesBox.Text = NewParagraphsList.Paragraphs[0].SentenceCount.ToString();
            this.NumberOfWordsBox.Text = NewParagraphsList.Paragraphs[0].WordCount.ToString();
            this.AverageWordsBox.Text = NewParagraphsList.Paragraphs[0].AverageWords.ToString();

            //Status bar labels
            this.ProductInfo.Text = "File: " + FileName;
            this.TokenCount.Text = "Tokens: " + NewFile.Tokens.Count.ToString();
            this.WordCount.Text = "Distinct Words: " + WordsList.Count.ToString();
            this.SentenceCount.Text = "Sentences: " + Sentences.SentenceCount.ToString();
            this.DateAndParagraphs.Text = "Paragraphs: " + NewParagraphsList.ParagraphCount.ToString();
        }//end DisplayAnalysis()

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"> <see cref="System.EventArgs"/>The instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end exitToolStringMenuItem_Click

        /// <summary>
        /// Handles the Click event of the openToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"> <see cref="System.EventArgs"/>The instance containing the event data.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog = new OpenFileDialog();

            FileDialog.InitialDirectory = @"C:\";
            FileDialog.Title = "Open a Text File";
            FileDialog.Filter = "text files|*.txt|all files|*.*";

            if (FileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                NewFile = new Text(FileDialog.FileName);
                WordsList = new DistinctWordList(NewFile);
                Sentences = new SentenceList(NewFile);
                NewParagraphsList = new ParagraphList(NewFile);
                DisplayAnalysis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }//end openToolStripMenuItem_Click

        private void MenuItemNewFile_Click(object sender, EventArgs e)
        {
            string UserInput;
            InputForm Input = new InputForm();
            Input.ShowDialog();
            UserInput = Input.InputBoxText();
        }//end MenuItemNewFile_Click

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            Form4 AboutBox = new Form4();
            AboutBox.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;

            if (Sentences == null && i > 1)
            {
                numericUpDown1.Value = 1;
            }
            else if (Sentences != null && i >= Sentences.Sentences.Count)
            {
                numericUpDown1.Value = (Sentences.Sentences.Count - 1);
            }

            if (i < 1)
            {
                numericUpDown1.Value = 1;
            }

            if (Sentences != null && i < Sentences.Sentences.Count && numericUpDown1.Value >= 0 
                                && numericUpDown1.Value < Sentences.SentenceCount)
            {
                this.SentenceDisplayBox.Text = Sentences.Sentences[i-1].ToString();
                this.AverageSentenceWordLengthBox.Text = Sentences.Sentences[i-1].AverageWordLength.ToString();
                this.SentenceWordCountBox.Text = Sentences.Sentences[i-1].WordCount.ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int i = (int)numericUpDown2.Value;
            if (NewParagraphsList == null && i > 1)
            {
                numericUpDown2.Value = 1;
            }
            else if (NewParagraphsList != null && i >= NewParagraphsList.Paragraphs.Count)
            {
                numericUpDown2.Value = (NewParagraphsList.Paragraphs.Count - 1);
            }

            if (i < 1)
            {
                numericUpDown2.Value = 1;
            }

            if (NewParagraphsList != null && i < NewParagraphsList.Paragraphs.Count && numericUpDown2.Value > 0 
                            && numericUpDown2.Value < NewParagraphsList.Paragraphs.Count)
            {
                this.ParagraphDisplayBox.Text = NewParagraphsList.Paragraphs[i-1].ToString();
                this.NumberOfSentencesBox.Text = NewParagraphsList.Paragraphs[i-1].SentenceCount.ToString();
                this.NumberOfWordsBox.Text = NewParagraphsList.Paragraphs[i-1].WordCount.ToString();
                this.AverageWordsBox.Text = NewParagraphsList.Paragraphs[i-1].AverageWords.ToString();
            }
        }

        private void PreviousSentenceButton_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;

            if (Sentences != null && i > 0)
            {
                this.SentenceDisplayBox.Text = Sentences.Sentences[i - 1].ToString();
                this.AverageSentenceWordLengthBox.Text = Sentences.Sentences[i - 1].AverageWordLength.ToString();
                this.SentenceWordCountBox.Text = Sentences.Sentences[i - 1].WordCount.ToString();
                numericUpDown1.Value = i - 1;
            }
        }

        private void NextSentenceButton_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown1.Value;

            if (Sentences != null && i < Sentences.Sentences.Count)
            {
                this.SentenceDisplayBox.Text = Sentences.Sentences[i].ToString();
                this.AverageSentenceWordLengthBox.Text = Sentences.Sentences[i].AverageWordLength.ToString();
                this.SentenceWordCountBox.Text = Sentences.Sentences[i].WordCount.ToString();
                numericUpDown1.Value = i + 1;
            }
        }

        private void PreviousParagraphButton_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown2.Value;

            if (NewParagraphsList != null && i > 0)
            {
                this.ParagraphDisplayBox.Text = NewParagraphsList.Paragraphs[i - 1].ToString();
                this.NumberOfSentencesBox.Text = NewParagraphsList.Paragraphs[i - 1].SentenceCount.ToString();
                this.NumberOfWordsBox.Text = NewParagraphsList.Paragraphs[i - 1].WordCount.ToString();
                this.AverageWordsBox.Text = NewParagraphsList.Paragraphs[i - 1].AverageWords.ToString();
                numericUpDown2.Value = i - 1;
            }
        }

        private void NextParagraphButton_Click(object sender, EventArgs e)
        {
            int i = (int)numericUpDown2.Value;

            if (Sentences != null && i < Sentences.Sentences.Count)
            {
                this.ParagraphDisplayBox.Text = NewParagraphsList.Paragraphs[i].ToString();
                this.NumberOfSentencesBox.Text = NewParagraphsList.Paragraphs[i].SentenceCount.ToString();
                this.NumberOfWordsBox.Text = NewParagraphsList.Paragraphs[i].WordCount.ToString();
                this.AverageWordsBox.Text = NewParagraphsList.Paragraphs[i].AverageWords.ToString();
                numericUpDown2.Value = i + 1;
            }
        }

       
    }//end MainWindow.cs
}//end Project2 namespace
