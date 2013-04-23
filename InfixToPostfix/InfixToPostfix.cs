/**********************************************************************
 * File Name         : InfixToPostfix.cs
 * Purpose            : Driver for the program.  Allows user to choose a file
 *                          and converts each infix expression in the file, line by
 *                          line to a postfix expression.  
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : November 3, 2012
 * 
 * Modified Date    :November 4, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/

using System;
using Utils;
using System.IO;
using System.Windows.Forms;

namespace Infix_Postfix
{
    class InfixToPostfix
    {
        enum Choices {OPEN=1, QUIT}

        [STAThread]
        static void Main()
        {
            Postfix Post = null;                            //Postfix object used for conversion
            Utils.Menu menu;                                      //menu object to handle user interaction
            Choices choice;                                 //user's menu choice
            StreamReader rdr = null;                        //for file input
            OpenFileDialog dlg = null;
            DateTime CurrentDate = DateTime.Now;            
            String Date = "";                               //Holds the current date
            Date += CurrentDate;                            
            String Title = "Infix to Postfix Conversion";   //Title of the program. Displayed in console title and program execution.
            String fileName;                                
            String Infix;                                   //Holds the infix expression read from the current line in the file.
            bool Valid = true;                              //Used to make conversion loop run only if a valid file was chosen
            
            Console.Title = Title;
            menu = new Utils.Menu("Menu");                        //Open a menu and add the choices
            menu = menu + "Open a file" + "Quit";
            choice = (Choices)menu.GetChoice();             //get the menu choice

            //Run the menu until quit option is chosen
            while (choice != Choices.QUIT)
            {
                //switch used for menu selection for easy expandability
                switch (choice)
                {
                    case Choices.OPEN:  //if user chose open file option

                    Console.Clear();
                    //run the open file dialog
                    dlg = new OpenFileDialog();
                    dlg.InitialDirectory = Application.StartupPath;
                    dlg.Title = "Open a Personal Library";
                    dlg.Filter = "text files|*.txt|all files|*.*";
                        
                    if(dlg.ShowDialog() != DialogResult.Cancel)
                    {
                        fileName = dlg.FileName;
                        try
                        {
                            Valid = true;
                            rdr = new StreamReader(fileName);
                        }
                        catch (Exception)
                        {       //if file couldn't be opened, notify user and set Valid to false to skip conversion loop
                            Console.WriteLine("File could not be opened.");
                            Valid = false;
                            Utility.PressAnyKey();
                        }

                        //conversion loop. converts each line in the text file
                        while (Valid && rdr.Peek() != -1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(Console.WindowWidth - Title.Length, 0);
                            Console.WriteLine(Title);
                            Console.SetCursorPosition(Console.WindowWidth - Date.Length, 1);
                            Console.WriteLine(Date);

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Infix = rdr.ReadLine();
                            Console.WriteLine("Infix Expression: " + Infix + "\n\n");

                            Post = new Postfix(Infix);
                            Console.WriteLine("Postfix Expression: " + Post.PostfixExpression);
                            Utility.PressAnyKey();
                        }

                        if (rdr != null)    //close the file if a file was opened
                            rdr.Close();
                        
                    }//if file was chosen

                    break;  //end of case OPEN

                }//end switch

                choice = (Choices)menu.GetChoice(); //get the next menu choice
            }//end while

        }//end main
    }//end class
}//end namespace
