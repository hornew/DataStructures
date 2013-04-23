/**********************************************************************
 * File Name         : PhoneNumber.cs
 * Purpose            : Accept a string from the user that represents a 
 *                          candidate phone number. The string is determined to
 *                          be a valid US phone number if it matches the pattern 
 *                          of the defined regular expression and if it does not have 
 *                          more than one occurrence of opening or closing 
 *                          parentheses.
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
    class PhoneNumber
    {
        /// <summary>
        /// IsValid property is set to true or false depending upon the validity of the input string.
        /// Number property which represents the phone number. Set to the input string if IsValid is true.
        /// </summary>
        public bool IsValid { get; private set; }
        public string Number { get; private set; }

        /// <summary>
        /// Parameterized Constructor which accepts a string as an argument. 
        /// Argument is processed by the Validate method to determine whether it is a valid US phone number.
        /// </summary>
        /// <param name="candidate"></param>
        public PhoneNumber(string candidate)
        {
            Validate(candidate);
            if (IsValid == true)
            {
                this.Number = candidate;
            }
            else
            {
                this.Number = String.Empty;
            }
        }//end of PhoneNumber Constructor

        /// <summary>
        /// This method validates the input string, checking for illegal characters in the address and using a regular expression
        /// which matches the pattern of a phone number to check for the correct pattern in the input string.
        /// If the input string is valid, this method sets the IsValid property to true.
        /// </summary>
        /// <param name="candidate"></param>
        private void Validate(string candidate)
        {
            bool IsMatch = false;
            Regex PhoneNumberPattern;
            PhoneNumberPattern = new Regex(@"(\((?<AreaCode>\d{3})\))?\s*(?<Number>\d{3}(?:-|\s*)\d{4})");
            string IllegalChars = "abcdefghijklmnopqrstuvwxyz!@#$%^&*_+={}[]|\\:;\"'<,>.?/~`";
            string temp = candidate;
            int OpenParens = 0;
            int ClosedParens = 0;
            int Start = 0;

            while (temp.Length > 1 && OpenParens < 2)
            {
                if (temp.IndexOf('(') > -1)
                {
                    OpenParens++;
                    Start = temp.IndexOf('(');
                    if (Start < temp.Length - 1)
                    {
                        Start++;
                        temp = temp.Substring(Start, temp.Length - Start);
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

            temp = candidate;
            while (temp.Length > 1 && ClosedParens < 2)
            {
                if (temp.IndexOf(')') > -1)
                {
                    ClosedParens++;
                    Start = temp.IndexOf(')');
                    if (Start < temp.Length - 1)
                    {
                        Start++;
                        temp = temp.Substring(Start, temp.Length - Start);
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

            if (candidate.IndexOfAny(IllegalChars.ToCharArray()) == -1 && OpenParens < 2 && ClosedParens < 2)
            {
                IsMatch = PhoneNumberPattern.IsMatch(candidate);
                if (IsMatch == true)
                {
                    this.IsValid = true;
                }
            }

        }//end of Validate()

        /// <summary>
        /// Returns the value of the Number property
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Number;
        }

    }//end of PhoneNumber.cs

}//end of namespace Utils
