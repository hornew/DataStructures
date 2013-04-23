/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: Sentence.cs
// Purpose			: Model a Sentence object 
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
	/// Model a Sentence
	/// </summary>
	class Sentence
	{
		#region Properties
		public String Text { get; set; }
		public int WordCount { get; private set; }
		public double AverageWordLength { get; private set; }
		public int Start { get; private set; }
		public int End { get; private set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public Sentence ( )
		{
			Text = "";
			WordCount = 0;
			AverageWordLength = 0;
			Start = 0;
			End = -1;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="tokens">List of strings representing the tokens in a Text object</param>
		/// <param name="start">The position of the first token in the sentence</param>
		public Sentence (List<string> tokens, int start)
			: this ( )
		{
			Start = start;

			for (int n = Start; n < tokens.Count && End < 0; n++)
			{
				if (tokens[n].IndexOfAny (".?!".ToCharArray ( )) != -1)		// end of sentence?
				{
					End = n;
					Text += tokens[n];
				}
				else
					if (tokens[n].IndexOfAny (",;:[])(&~".ToCharArray ( )) != -1)  // non-sentence ending punctuation
					{
						Text += tokens[n];
					}
					else
						if (tokens[n] == "\n")
						{
							if (n < tokens.Count - 1 && tokens[n + 1] == "\n")		// if end of paragraph, assume end of sentence
							{
								End = n + 1;
							}
						}
						else														// we have a word
						{
							WordCount++;
							AverageWordLength += tokens[n].Length;
							Text += " " + tokens[n];
						}
				if (n == tokens.Count - 1)							// if we have reached the last token, it is the end of a sentence
				{
					End = n + 1;
				}
			}
			if (WordCount > 0)
				AverageWordLength /= WordCount;
		}
		#endregion

		#region ToString
		/// <summary>
		/// Format the Sentence as a string for display
		/// </summary>
		/// <returns>The formatted Sentence</returns>
		public override string ToString ( )
		{
            return Utility.FormatText(Text, 2, 78); //+
				//String.Format ("\n\n  Total Words: {0} \tAverage Word Length: {1:#0.#}", WordCount, AverageWordLength);
		}
		#endregion
	}
}
