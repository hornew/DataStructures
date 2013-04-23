/**********************************************************************
 * File Name         : UserForm.cs
 * Purpose            : Create a new instance of the UserForm class which 
 *                          will get user information from the current user. 
 *                          Disallows invalid information.
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
using Utils;

namespace Project2
{
    public partial class UserForm : Form
    {
        private User NewUser;               //User object created from Name, EmailAddress, and PhoneNumber objects.
        private Name UserName;              //Created from a valid name entered in the name text box.
        private EmailAddress UserEmail;     //Created from a valid e-mail address entered in the e-mail address text box.
        private PhoneNumber UserPhoneNumber;//Created from a valid US phone number entered in the phone number text box.

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the class.
        /// <see cref="UserForm"/>
        /// </summary>
        public UserForm()
        {
            InitializeComponent();
        } 
        #endregion

        #region Other Methods
        /// <summary>
        /// Determines whether the input information was valid, clears fields that contain invalid information,
        /// and highlights that field's label. Called by OKButton_Click and by NameBox_KeyPress, EmailBox_KeyPress,
        /// and PhoneNumber_KeyPress when the enter key is pressed and any of these controls have the focus.
        /// </summary>
        private void FormAccept()
        {
            int InvalidFieldCount = 0;
            UserName = new Name(NameBox.Text);
            UserEmail = new EmailAddress(EmailBox.Text);
            UserPhoneNumber = new PhoneNumber(PhoneNumberBox.Text);

            NewUser = new User(UserName, UserEmail, UserPhoneNumber);
            if (NewUser.IsValid)
            {
                this.Close();
            }
            else
            {
                if (UserName.IsValid == false)
                {
                    UserNameLabel.ForeColor = Color.Red;
                    NameBox.Text = String.Empty;
                    InvalidFieldCount++;
                }
                else
                {
                    UserNameLabel.ForeColor = Color.Black;
                }

                if (UserEmail.IsValid == false)
                {
                    EmailLabel.ForeColor = Color.Red;
                    EmailBox.Text = String.Empty;
                    InvalidFieldCount++;
                }
                else
                {
                    EmailLabel.ForeColor = Color.Black;
                }

                if (UserPhoneNumber.IsValid == false)
                {
                    PhoneNumberLabel.ForeColor = Color.Red;
                    PhoneNumberBox.Text = String.Empty;
                    InvalidFieldCount++;
                }
                else
                {
                    PhoneNumberLabel.ForeColor = Color.Black;
                }

                if (InvalidFieldCount > 1)
                {
                    InstructionBox.Text = "Highlighted fields were invalid. Please enter valid values";
                }
                else
                {
                    InstructionBox.Text = "Highlighted field was invalid. Please enter a valid value";
                }
            }
        }//end FormAccept() 
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Click event of the OkButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.EventArgs"/></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            FormAccept();
        }//end OkButton_Click

        /// <summary>
        /// Handles the Enter event of the NameBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.EventArgs"/></param>
        private void NameBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.SelectAll();
        }//end NameBox_Enter

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.EventArgs"/></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end CancelButton_Click

        /// <summary>
        /// Handles the KeyPress event of the NameBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.Windows.Forms.KeyPressEventArgs"/></param>
        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;

            if (Key == (char)Keys.Enter)
            {
                FormAccept();
            }
        }//end NameBox_KeyPress

        /// <summary>
        /// Handles the KeyPress event of the EmailBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.Windows.Forms.KeyPressEventArgs"/></param>
        private void EmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;

            if (Key == (char)Keys.Enter)
            {
                FormAccept();
            }
        }//end EmailBox_KeyPress

        /// <summary>
        /// Handles the KeyPress event of the PhoneNumberBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The instance containing the event data.
        /// <see cref="System.Windows.Forms.KeyPressEventArgs"/></param>
        private void PhoneNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;

            if (Key == (char)Keys.Enter)
            {
                FormAccept();
            }
        }//end PhoneNumberBox_KeyPress 
        #endregion

    }//end UserForm.cs
}//end namespace
