/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: Paragraph.cs
// Purpose			: Model a single paragraph of text from a text file 
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
	/// Model a paragraph of text 
	/// </summary>
	class Paragraph
	{
		#region Properties
		public String Text { get; set; }
		public int SentenceCount { get; private set; }
		public int WordCount { get; private set; }
		public double AverageWords { get; private set; }
		public int Start { get; private set; }
		public int End { get; private set; }
		#endregion

		#region Constructors
		public Paragraph ( )
		{
			Text = "";
			SentenceCount = 0;
			WordCount = 0;
			AverageWords = 0.0;
			Start = 0;
			End = -1;
		}

		public Paragraph (List<string> tokens, int start)
			: this ( )
		{
			Start = start;

			for (int n = Start; n < tokens.Count && End < 0; n++)
			{
				if (n < tokens.Count - 1 && tokens[n] == "\n" && tokens[n + 1] == "\n")	// is this the end of the paragraph?
				{
					End = n + 1;
					if (SentenceCount > 0)
						AverageWords = WordCount / (double)SentenceCount;
				}
				else
					if (tokens[n] == "\n")							// ignore a single newline instance
						continue;
					else
						if (tokens[n].IndexOfAny (",;:'[]{}()&@'-=".ToCharArray ( )) != -1) // non-end-of-sentence punctuation
						{
							Text += tokens[n];
						}
						else
							if (tokens[n].IndexOfAny (".?!".ToCharArray ( )) != -1)			// end of sentence punctuation
							{
								Text += tokens[n] + " ";
								SentenceCount++;
							}
							else
							{
								if (String.IsNullOrEmpty (Text))
									Text += tokens[n];
								else
									Text += " " + tokens[n];
								WordCount++;
							}
				if (n == tokens.Count - 1)							// if we have reached the last token, it is the end of a paragraph
				{
					End = n + 1;
					if (SentenceCount > 0)
						AverageWords = WordCount / (double)SentenceCount;
				}
			}
		}
		#endregion

		#region ToString
		/// <summary>
		/// Format the paragraph as a string for display
		/// </summary>
		/// <returns>The formatted string representing the paragraph</returns>
		public override string ToString ( )
		{
            return Utility.FormatText(Text, 2, 78); /*+
				String.Format ("\n\n  Total Sentences: {0} \tAverage Words Per Sentence: {1:0.#}",
				SentenceCount, AverageWords);*/
		}
		#endregion
	}
}
