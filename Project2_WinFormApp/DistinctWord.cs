/////////////////////////////////////////////////////////////////////////////////////
//
// Company Name		: Don Bailes
// Department Name	: Computer and Information Sciences 
// File Name			: DistinctWord.cs
// Purpose			: Model a distinct word with a string property for the 
//						text and an integer counter for the number of 
//						occurrences 
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

namespace Project1
{
	/// <summary>
	/// DistinctWord  models a distinct word in the text and contains properties 
	/// representing the word itself and the number of times the word occurs 
	/// in the Text object
	/// </summary>
	public class DistinctWord : IEquatable<DistinctWord>, IComparable<DistinctWord>
	{
		#region Properties
		public string Word { get; set; }
		public int Count { get; set; }
		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor
		/// </summary>
		public DistinctWord ( )
		{
			Word = "";
			Count = 0;
		}

		/// <summary>
		/// Parameterized constructor
		/// </summary>
		/// <param name="text">the string representing the Word portion of this DistinctWord</param>
		public DistinctWord (string text)
		{
			Word = text.ToLower ( );
			Count = 1;
		}
		#endregion

		#region Comparison Operators
		/// <summary>
		/// Less Than operator
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS DistinctWord</param>
		/// <returns>true if LHS.Word < RHS.Word; false otherwise</returns>
		public static bool operator < (DistinctWord w1, DistinctWord w2)
		{
			return (w1.Word.CompareTo (w2.Word) < 0);
		}

		/// <summary>
		/// Greater Than operator
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS DistinctWord</param>
		/// <returns>true if LHS.Word > RHS.Word; false otherwise</returns>
		public static bool operator > (DistinctWord w1, DistinctWord w2)
		{
			return (w1.Word.CompareTo (w2.Word) > 0);
		}

		/// <summary>
		/// Equality operator
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS DistinctWord</param>
		/// <returns>true if LHS.Word == RHS.Word; false otherwise</returns>
		public static bool operator == (DistinctWord w1, DistinctWord w2)
		{
			return (w1.Word == w2.Word);
		}

		/// <summary>
		/// != operator
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS DistinctWord</param>
		/// <returns>true if LHS.Word != RHS.Word; false otherwise</returns>
		public static bool operator != (DistinctWord w1, DistinctWord w2)
		{
			return (w1.Word != w2.Word);
		}

		/// <summary>
		/// == operator for comparing a DistinctWord with a string
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS string</param>
		/// <returns>true if LHS.Word == RHS; false otherwise</returns>
		public static bool operator == (DistinctWord w1, string s)
		{
			return (w1.Word == s);
		}

		/// <summary>
		/// != operator for comparing a DistinctWord with a string
		/// </summary>
		/// <param name="w1">LHS DistinctWord</param>
		/// <param name="w2">RHS string</param>
		/// <returns>true if LHS.Word != RHS; false otherwise</returns>
		public static bool operator != (DistinctWord w1, string s)
		{
			return (w1.Word != s);
		}
		#endregion

		#region Equals, IEquatable<DistinctWord>.Equals, IComparable<DistinctWord>.CompareTo, and GetHashCode
		/// <summary>
		/// Override Object.Equals method
		/// </summary>
		/// <param name="obj">the object to be compared</param>
		/// <returns>true if  two DistinctWord objects have the same Word property; false otherwise</returns>
		public override bool Equals (Object obj)
		{
			DistinctWord a = null;

			if (obj is DistinctWord)
				a = (DistinctWord)obj;
			else
				return false;				// If not comparing two DistinctWord objects

			return (Word.Equals (a.Word));  // Uses String.Equals
		}

		/// <summary>
		/// Return the hash code of the String returned by ToString
		/// </summary>
		/// <returns>the hash code of the String returned by ToString</returns>
		public override int GetHashCode ( )
		{
			return this.Word.GetHashCode ( );
		}

		/// <summary>
		/// Compare two DistinctWord objects
		/// </summary>
		/// <param name="dw">the RHS DistinctWord object</param>
		/// <returns>less than 0 if LHS < RHS; greater than 0 if LHS > RHS; 0 if LHS == RHS</returns>
		int IComparable<DistinctWord>.CompareTo (DistinctWord dw)
		{
			return (this.Word.CompareTo (dw.Word));
		}

		/// <summary>
		/// Compares two DistinctWord objects and returns true if they represent the same word
		/// </summary>
		/// <param name="rhs">The RHS DistinctWord object</param>
		/// <returns>true if the two DistinctWord objects represent the same "word"</returns>
		bool IEquatable<DistinctWord>.Equals (DistinctWord rhs)
		{
			return this.Equals (rhs);
		}
		#endregion

		#region ToString method
		/// <summary>
		/// Formats the DistinctWord and its number of occurrences as a string suitable for display
		/// </summary>
		/// <returns>The formatted string</returns>
		public override string ToString ( )
		{
			return String.Format ("{0}{1}", Word.PadRight (50), Count.ToString ( ).PadLeft (45));
		}
		#endregion
	}
}
