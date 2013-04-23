/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: Words.cs
// Purpose			: Implement the Words class, representing a collection 
//						of DistinctWord objects that is sorted alphabetically 
//						by word 
// Author				: Don Bailes, E-Mail: bailes@etsu.edu
// Create Date			: Friday, September 24, 2010
//
//-----------------------------------------------------------------------------------
//
// Modified Date		: Friday, September 24, 2010
// Modified By			: Don Bailes
//
/////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using UtilityNamespace;

namespace Project1
{
	/// <summary>
	/// Model a collection of DistinctWord objects
	/// </summary>
	public class DistinctWordList
	{
		#region Properties
		public List<DistinctWord> DistinctWords { get; private set; }
		public int Count
		{
			get
			{
				return DistinctWords.Count;
			}
		}
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor with empty list
		/// </summary>
		public DistinctWordList ( )
		{
			DistinctWords = new List<DistinctWord> ( );
		}

		/// <summary>
		/// Create a sorted list of DistinctWords using the Tokens in a Text object
		/// </summary>
		/// <param name="txt">The Text object of which we use its Tokens</param>
		public DistinctWordList (Text txt)
		{
			DistinctWords = new List<DistinctWord> ( );
			foreach (string s in txt.Tokens)
			{
				if (s.IndexOfAny ("!$%&*()-+=}{[]|\n\r\t':;?.,<>~".ToCharArray ( )) == -1)
				{
					DistinctWord dw = new DistinctWord (s);
					int n = DistinctWords.IndexOf (dw);
					if (n == -1)
						DistinctWords.Add (dw);
					else
						DistinctWords[n].Count++;
				}
			}
			DistinctWords.Sort ( );
		}
		#endregion

        #region Display()
        /// <summary>
        /// Formats WordsList into an aligned list of all distinct words in the text with their count.
        /// </summary>
        /// <returns Output></returns>
        public string Display()
        {
            string Output = "";         //Holds all of the final output including the distinctions for each word and the word itself.
            

            foreach (DistinctWord word in DistinctWords)
            {
                Output += word.ToString() + "\n";
            }

            return Output;
        }//end of DIsplay()
        #endregion
	}
}
