/**********************************************************************
 * File Name         : EmailAddress.cs
 * Purpose            : Accept a string from the user that represents a 
 *                          candidate e-mail address. The string is determined to
 *                          be a valid e-mail address f it matches the pattern 
 *                          of the defined regular expression and if it does not have 
 *                          more than one occurrence of an @ symbol.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : September 20, 2012
 * 
 * Modified Date    :October 8, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils
{
    class EmailAddress
    {
        /// <summary>
        /// IsValid property which is set to true or false depending upon the validity of the input string.
        /// Address property which represents the e-mail address. Set to the input string if IsValid is true.
        /// </summary>
        public bool IsValid { get; private set; }
        public string Address { get; private set; }

        /// <summary>
        /// EmailAddress constructor which accepts an input string and calls the Validate() method to check for input validity
        /// </summary>
        /// <param name="candidate"></param>
        public EmailAddress(string candidate)
        {
            this.IsValid = Validate(candidate);
            if (IsValid == true)
            {
                this.Address = candidate;
            }
            else
            {
                this.Address = String.Empty;
            }
        }//End of EmailAddress Constructor

        /// <summary>
        /// This method validates the input string, checking for illegal characters in the address and using a regular expression
        /// which matches the pattern of an e-mail address to check for the correct pattern in the input string.
        /// If the input string is valid, this method sets the IsValid property to true.
        /// </summary>
        /// <param name="candidate"></param>
        private bool Validate(string candidate)
        {            
            string temp = candidate;
            string IllegalChars = "!#$%^&*()=+[]{}:;'\"?><,/~`";
            int AtSymbols = 0;
            int start = 0;
            bool IsMatch = false;
            bool IsEmail = false;
            Regex EmailPattern;

            EmailPattern = new Regex (@"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})");

           while (temp.Length > 1 && AtSymbols < 2) 
            {
                if (temp.IndexOf('@') > -1)
                {
                    AtSymbols++;
                    start = temp.IndexOf('@');
                    if (start < temp.Length - 1)
                    {
                        start++;
                        temp = temp.Substring(start, temp.Length - start);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
           
            if (candidate.IndexOfAny(IllegalChars.ToCharArray()) == -1 && AtSymbols < 2)
            {
                IsMatch = EmailPattern.IsMatch(candidate);
                if (IsMatch == true)
                {
                    IsEmail = true;
                }
            }

            return IsEmail;
        }//end of Validate()

        /// <summary>
        /// Returns the value of the Address property
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Address;
        }//end of ToString()

    }//end of EmailAddress.cs

}//end of namespace Utils
