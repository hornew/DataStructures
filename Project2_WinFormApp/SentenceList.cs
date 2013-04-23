/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: Sentences.cs
// Purpose			: Model a Collection of Sentence objects 
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
	/// A collection of Sentence objects
	/// </summary>
	class SentenceList
	{
		#region Properties
		public List<Sentence> Sentences { get; private set; }
		public int SentenceCount { get; private set; }
		public double AverageLength { get; private set; } 
		#endregion

		#region Constructors
		/// <summary>
		/// Default Constructor
		/// </summary>
		public SentenceList ( )
		{
			Sentences = new List<Sentence> ( );
			SentenceCount = 0;
			AverageLength = 0.0;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="txt">Text object from which to build the sentences</param>
		public SentenceList (Text txt)
			: this ( )
		{
			int start      = 0;

			while (start < txt.Tokens.Count)
			{
				Sentence s = new Sentence (txt.Tokens, start);
				if (s.WordCount > 0)
				{
					Sentences.Add (s);
					SentenceCount++;
					AverageLength += s.WordCount;
				}
				start = s.End + 1;
			}

			if (SentenceCount > 0)
				AverageLength /= SentenceCount;
		} 
		#endregion

		#region Heading and Display methods
		/// <summary>
		/// Private method to display a heading on the top of each page
		/// </summary>
		private static void Heading ( )
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Sentences found in the text:\n");
			Console.ForegroundColor = ConsoleColor.Blue;
		}

		/// <summary>
		/// Display a report of all sentence objects found in the text
		/// </summary>
		public void Display ( )
		{
			Heading ( );

			for (int n = 0; n < SentenceCount; n++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("Sentence {0}.\n", n + 1);

				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine ("{0}\n", Sentences[n]);

				if (Console.CursorTop > Console.WindowHeight - 8 && (n + 1) < SentenceCount)
				{
					Utility.PressAnyKey ( );
					Heading ( );
				}
			}
			Utility.Skip (2);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("There are {0} sentences with an average length of {1:#.#} words.",
								SentenceCount, AverageLength);
			Utility.PressAnyKey ( );
		} 
		#endregion
	}
}
