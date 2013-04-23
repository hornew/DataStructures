/**********************************************************************
 * File Name         : InputForm.cs
 * Purpose            : Used for user input of text to be analyzed.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : October 22, 2012
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

namespace Project2
{
    public partial class InputForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// <see cref="InputForm"/>
        /// </summary>
        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the text in the InputBox text box.
        /// </summary>
        /// <returns></returns>
        public string InputBoxText()
        {
            return InputBox.Text;
        }

        /// <summary>
        /// Handles the Click event of the OKButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.EventArgs"/></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of OkButton_Click
    }//end InputForm.cs
}//end Project2 namespace
