/**********************************************************************
 * File Name         : Operator.cs
 * Purpose            : Help the Postfix class in converting an infix expression
 *                          to postfix notation.  Allows creation of operators 
 *                          based on their string representation.  Operators must
 *                          be assigned a precedence for order of operations.
 *                          Overloaded operator comparison methods are 
 *                          implemented to check for one operator greater than
 *                          or equal to another.
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : November 3, 2012
 * 
 * Modified Date    :November 4, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/

namespace Infix_Postfix
{
    class Operator
    {
        public string Op { get; set; }      //Character representation of the operator.
        public int Precedence { get; set; } //Precedence value for the given operator.

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the  class.<see cref="Operator"/>
        /// </summary>
        public Operator()
        {

        }//end default constructor

        /// <summary>
        /// Initializes a new instance of the class<see cref="Operator"/> .
        /// </summary>
        /// <param name="op">The operator character representation.</param>
        /// <param name="precedence">The precedence value of the operator.</param>
        public Operator(string op, int precedence)
        {
            this.Op = op;
            this.Precedence = precedence;
        }//end of parameterized constructor Operator(string) 
        #endregion

        #region Overloaded Operators
        /// <summary>
        /// Implements the less than operator for this class.
        /// </summary>
        /// <param name="lhs">The Left hand side of the operation.</param>
        /// <param name="rhs">The Right hand side of the operation.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator <(Operator lhs, Operator rhs)
        {
            return lhs.Precedence > rhs.Precedence;
        }//end operator <(Operator, Operator)

        /// <summary>
        /// Implements the greater than operator for this class.
        /// </summary>
        /// <param name="lhs">The Left hand side of the operation.</param>
        /// <param name="rhs">The Right hand side of the operation.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator >(Operator lhs, Operator rhs)
        {
            return lhs.Precedence > rhs.Precedence;
        }//end operator >(Operator, Operator)

        /// <summary>
        /// Implements the greater than or equal to operator for this class.
        /// </summary>
        /// <param name="lhs">The Left hand side of the operation.</param>
        /// <param name="rhs">The Right hand side of the operation.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator >=(Operator lhs, Operator rhs)
        {
            return lhs.Precedence >= rhs.Precedence;
        }//end operator >=(Operator, Operator)

        /// <summary>
        /// Implements the less than or equal to operator for this class.
        /// </summary>
        /// <param name="lhs">The Left hand side of the operation.</param>
        /// <param name="rhs">The Right hand side of the operation.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator <=(Operator lhs, Operator rhs)
        {
            return lhs.Precedence <= rhs.Precedence;
        }//end operator <=(Operator, Operator) 
        #endregion

    }//end of Operator.cs

}//end namespace
