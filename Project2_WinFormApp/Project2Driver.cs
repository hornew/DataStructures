/**********************************************************************
 * File Name         : Project2Driver.cs
 * Purpose            : Runs each form in the application sequentially, driving
 *                          the program.
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
using System.Linq;
using System.Windows.Forms;

namespace Project2
{
    static class Project2Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
            Application.Run(new UserForm());
            Application.Run(new MainWindow());
            Application.Run(new Form3());
        }
    }//end Project2Driver.cs
}//end Project2 namespace
