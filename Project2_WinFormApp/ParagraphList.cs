/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: ParagraphList.cs
// Purpose			: Model a collection of Paragraph Objects 
// Author				: Don Bailes, E-Mail: bailes@etsu.edu
// Create Date			: Monday, September 27, 2010
//
//-----------------------------------------------------------------------------------
//
// Modified Date		: Monday, September 27, 2010
// Modified By			: Don Bailes
//
/////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using UtilityNamespace;

namespace Project1
{
	/// <summary>
	/// A collection of Paragraph objects
	/// </summary>
	class ParagraphList
	{
		#region Properties
		public List<Paragraph> Paragraphs { get; private set; }
		public int ParagraphCount { get; private set; }
		public double AverageLength { get; private set; } 
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public ParagraphList ( )
		{
			Paragraphs = new List<Paragraph> ( );
			ParagraphCount = 0;
			AverageLength = 0.0;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="txt">The Text object from which the paragraphs are retrieved</param>
		public ParagraphList (Text txt)
			: this ( )
		{
			int start = 0;
			while (start < txt.Tokens.Count)
			{
				Paragraph p = new Paragraph (txt.Tokens, start);
				if (p.WordCount > 0)
				{
					Paragraphs.Add (p);
					ParagraphCount++;
					AverageLength += p.WordCount;
				}

				start = p.End + 1;
			}
			if (ParagraphCount > 0)
				AverageLength /= ParagraphCount;
		} 
	#endregion

		#region DisplayParagraphs
		/// <summary>
		/// Display a heading at the top of a page
		/// </summary>
		private static void Heading ( )
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Paragraphs found in the text:\n");
			Console.ForegroundColor = ConsoleColor.Blue;
		}

		/// <summary>
		/// Display a report on the paragraphs found in a text file
		/// </summary>
		public void Display ( )
		{
			Heading ( );

			for (int n = 0; n < ParagraphCount; n++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("Paragraph {0}.\n", n + 1);

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine ("{0}\n", Paragraphs[n]);

				if (Console.CursorTop > Console.WindowHeight - 10 /* && (n + 1) < ParagraphCount*/)
				{
					Utility.PressAnyKey ( );
					Heading ( );
				}
			}

			Console.Write ("There are {0} paragraphs.  ", ParagraphCount);
			Console.WriteLine ("The average number of words in the paragraphs is {0:0.0}.",
								AverageLength);
			Utility.PressAnyKey ( );
		} 
		#endregion
	}
}
