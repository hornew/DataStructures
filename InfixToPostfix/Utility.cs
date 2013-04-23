/**********************************************************************
 * File Name         : Utility.cs
 * Purpose            : Provide methods that will be used by many of the 
 *                          classes in this project and could also be used beyond 
 *                          the scope of this project. Provides a Tokenize method
 *                          and FormatForDisplay method to perform operations
 *                          on text and also provides a welcome message,
 *                          goodbye message, pause, and skip line methods to be
 *                          used in a driver to interact with the user.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : October 8, 2012
 * 
 * Modified Date    :October 19, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/
using System;
using System.Collections.Generic;

namespace Utils
{
    class Utility
    {
        #region Welcome and Goodbye Messages
        /// <summary>
        /// Displays a welcome message to the user, including the current information about the program
        /// and the current date and time from the system.
        /// </summary>
        public static void WelcomeMessage()
        {
            DateTime CurrentDate = DateTime.Now;
            Console.WriteLine("Welcome and thank you for using this program!\n{0:f}", CurrentDate);
            
        }//end of WelcomeMessage()

        /// <summary>
        /// Displays a goodbye message to the user, along with the current time.
        /// </summary>
        public static void GoodbyeMessage()
        {
            DateTime CurrentDate = DateTime.Now;

            Console.WriteLine("************************************************************");
            Console.WriteLine("Thank you for using this program. Goodbye!");
            Console.WriteLine("{0:T}", CurrentDate);
            Console.WriteLine("************************************************************");
        }//end of GoodbyeMessage() 
        #endregion

        #region Other methods
        /// <summary>
        /// Returns all tokens found in a string as a List of strings.
        /// Tokens are defined to be all non-empty substrings between delimiters and delimiters themselves.
        /// </summary>
        /// <param name="strIn">Intended to receive a string to be processed</param>
        /// <param name="strDelim">Intended to receive a list of delimiters</param>
        /// <returns></returns>
        public static List<string> Tokenize(string strIn, string strDelim)
        {
            List<string> Tokens = new List<string>();
            string temp = strIn;
            int start = 0;
            int end;

            temp = temp.Replace("\n", "");
            temp = temp.Replace("\r", "");
            temp = temp.Replace("\t", "");

            while (String.IsNullOrEmpty(temp) == false)
            {
                temp = temp.Trim(' ');

                if (temp.IndexOfAny(strDelim.ToCharArray()) == -1)
                {
                    Tokens.Add(temp);
                    temp = String.Empty;
                }
                else if (temp.IndexOfAny(strDelim.ToCharArray(), start, 1) > -1)
                {

                    if (String.IsNullOrWhiteSpace(temp.Substring(start, 1)))
                    {

                    }
                    else
                    {
                        Tokens.Add(temp.Substring(start, 1));
                        temp = (temp.Substring(1, temp.Length - 1));
                    }

                }
                else
                {
                    if (temp.IndexOfAny(strDelim.ToCharArray()) > -1)
                    {
                        end = temp.IndexOfAny(strDelim.ToCharArray());
                    }
                    else
                    {
                        end = 0;
                    }
                    Tokens.Add(temp.Substring(start, end)); //change end to reset when no delim found
                    temp = temp.Substring(end, temp.Length - end);
                }
            }
            return Tokens;
        }//end Tokenize()

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tokens"></param>
        /// <param name="Delimiters"></param>
        /// <param name="Left"></param>
        /// <param name="Right"></param>
        /// <returns></returns>
        public static string FormatForDisplay(List<string> Tokens, string Delimiters, int Left, int Right)
        {
            List<string> TempStringList = new List<string>();
            string TempString = "";
            string FormattedString = "";
            string LongestToken;
            int Index = 0;
            int MarginLength = Right - Left;
            int Count = MarginLength;

            for (int i = 0; i < Tokens.Count - 1; i++)
            {
                if (Tokens[i + 1].Length > Tokens[i].Length)
                {
                    Index = i + 1;
                }
            }

            LongestToken = Tokens[Index];

            if (Right - Left < LongestToken.Length)
            {
                throw new Exception("Right margin minus left margin cannot be less than longest token");
            }

            for (int i = 0; i < Tokens.Count; i++)
            {
                if (String.IsNullOrWhiteSpace(Tokens[i]))
                {

                }
                else if (Tokens[i].Length + 1 <= Count) //if the token and one space fit within the remaining space in margins
                {
                    if (Tokens[i].IndexOfAny(Delimiters.ToCharArray()) > -1) //if the token is a delimiter
                    {
                        TempString += Tokens[i];
                        Count -= Tokens[i].Length;
                    }
                    else    //if the token is a word, include a space and add the word
                    {
                        TempString += " ";
                        TempString += Tokens[i];
                        Count -= (Tokens[i].Length + 1);
                    }
                }
                else if (Tokens[i].Length <= Count && Tokens[i].IndexOfAny(Delimiters.ToCharArray()) > -1)  //if only the token fits and it is a delimiter
                {
                    TempString += Tokens[i];
                    Count -= Tokens[i].Length;
                }
                else    
                {
                    TempString = TempString.PadLeft(Right);
                    TempStringList.Add(TempString);
                    TempString = String.Empty;
                    TempString += Tokens[i];
                    Count = MarginLength - Tokens[i].Length;
                }
            }

            TempString = TempString.PadLeft(Right);
            TempStringList.Add(TempString);

            foreach (string str in TempStringList)
            {
                FormattedString += str;
                FormattedString += "\n";
            }
            return FormattedString;
        }//end of FormatForDisplay(List<string>, string, int, int)

        /// <summary>
        /// Display a Press Any Key to ... message at the bottom of the screen
        /// </summary>
        /// <param name="strVerb">term in the Press Any Key to ... message; default: "continue . . ."</param>
        public static void PressAnyKey(string strVerb = "continue ...")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Console.CursorTop < Console.WindowHeight - 1)
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
            else
                Console.SetCursorPosition(0, Console.CursorTop + 2);

            Console.Write("Press any key to " + strVerb);
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
        } // End PressAnyKey 

        /// <summary>
        /// Skip n lines in the console window
        /// </summary>
        /// <param name="n">the number of lines to skip - defaults to 1</param>
        public static void Skip(int n = 1)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
        } 
        #endregion

    }//end of Utility.cs
}//end of Utils namespace
