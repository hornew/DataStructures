using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils
{
    class User
    {
        public String strName { get; set; }
        public String strEmailAddress { get; set; }
        public String strPhoneNumber { get; set; }
        public Boolean IsValid=false;
        
        /// <summary>
        /// Parameterized Constructor for the User class. Accepts Name, EmailAddress, and PhoneNumber as parameters
        /// </summary>
        /// <param name="n"></param>
        /// <param name="e"></param>
        /// <param name="p"></param>
        public User(Name n, EmailAddress e, PhoneNumber p)
        {
            if (e.IsValid)
            {
                if (n.IsValid)
                {
                    if (p.IsValid)
                    {
                        IsValid = true;
                        strName = n.ToString();
                        strEmailAddress = e.Address;
                        strPhoneNumber = p.Number;
                    }
                    else
                        IsValid = false;
                }
                else
                    IsValid = false;
            }
            else
            {
                IsValid = false;
            }

        }//end of parameterized constructor User(Name, EmailAddress, PhoneNumber)

        /// <summary>
        /// Overridden ToString method. Returns Name, EmailAddres, and PhoneNumber.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strResult;
            strResult="User Name:\t\t\t" + strName + "\nE-mail Address:\t\t" + strEmailAddress + "\nPhoneNumber:\t\t" + strPhoneNumber;
            return strResult;
        }//end of ToString()
    }//end of User.cs
}//end of Utils namespace
