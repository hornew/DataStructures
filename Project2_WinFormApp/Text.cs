/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: Text.cs
// Purpose			: Implementation of the Text Class 
// Author				: Don Bailes, E-Mail: bailes@etsu.edu
// Create Date			: Thursday, February 09, 2012
//
//-----------------------------------------------------------------------------------
//
// Modified Date		: Thursday, February 09, 2012
// Modified By			: Don Bailes
//
/////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using UtilityNamespace;

namespace Project1
{
	/// <summary>
	/// Input a text file and tokenize it for use by other classes
	/// </summary>
	public class Text
	{
		#region Properties
		public string Original { get; private set; }
		public List<string> Tokens { get; private set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public Text ( )
		{
			Original = "";
			Tokens = new List<string> ( );
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="fileName">the path of the file to analyze</param>
		public Text (string fileName)
		{
			if (!File.Exists (fileName))
				throw new FileNotFoundException ("The file '{0}' was not found and could not be opened.",
												fileName);
			StreamReader reader = null;
			try
			{
				reader = new StreamReader (fileName);
				Original = reader.ReadToEnd ( );
			}
			catch
			{
				throw;
			}
			finally
			{
				if (reader != null)
					reader.Close ( );
			}

			Tokens = Utility.Tokenize (Original, ".,?!*()-+=@%&{}|\r\n :;',<>~[]");
		}
		#endregion

		#region Display methods
		/// <summary>
		/// Display all the tokens in a formatted report
		/// </summary>
		public void DisplayTokens ( )
		{
			int lines = Console.WindowHeight - 7;  // lines per page after headings, etc.

			for (int n = 0; n < Tokens.Count; n++)
			{

				// Display headings if needed
				if (n % lines == 0)
				{
					Console.Clear ( );
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine ("Tokens Found In The Text\n\n" +
						"      Token\n      -----");
					Console.ForegroundColor = ConsoleColor.Blue;
				}

				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write ("{0}. ", (n + 1).ToString ( ).PadLeft (4));
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine ("'{0}'", (Tokens[n] == "\n" || Tokens[n] == "\r") ? @"\n" : Tokens[n]);

				// if end-of-page, PressAnyKey and then clear screen
				if ((n + 1) % lines == 0)
				{
					Utility.PressAnyKey ( );
					Console.Clear ( );
				}
			}
			Utility.PressAnyKey ( );
		}

		/// <summary>
		/// Display the original text, formatted for the window
		/// </summary>
		public string Display ( )
		{
            return Original;
		}
		#endregion
	}
}
