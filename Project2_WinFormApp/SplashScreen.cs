/**********************************************************************
 * File Name         : SplashScreen.cs
 * Purpose            : 
 *                          
 * Author             : Kristen Bales     E-mail: balesk@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : October 15, 2012
 * 
 * Modified Date    : October 22, 2012
 * Modified by       : Kristen Bales
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
using UtilityNamespace;

namespace Project2
{
    public partial class SplashScreen : Form
    {
        public string VersionNumber { get; private set; }
        public string WelcomeMessage { get; private set; }
        /// <summary>
        /// Initializes a new instance of the class.
        /// <see cref="SplashScreen"/> 
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
            this.VersionNumber = Application.ProductVersion;
            this.WelcomeMessage = Utility.WelcomeMessage();
            this.VersionBox.Text = VersionNumber;
            this.WelcomeBox.Text = WelcomeMessage;
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e"> <see cref="System.EventArgs"/>The instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }//end timer1_Tick

    }//end SplashScreen.cs
}//end Project2 namespace
