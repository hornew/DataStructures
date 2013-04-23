/**********************************************************************
 * File Name         : Postfix.cs
 * Purpose            : Convert an infix expression into a postfix expression.
 *                          Uses the Operator class to help with the conversion.
 *                          Converted expression is stored in the 
 *                          PostfixExpression property. 
 *                          
 * Author             : Austin Horne     E-mail: hornew@goldmail.etsu.edu       
 * Course             : CSCI 2210 - Data Structures
 * Create Date      : November 3, 2012
 * 
 * Modified Date    :November 4, 2012
 * Modified by       : Austin Horne
***********************************************************************
*/

using System.Collections.Generic;
using Utils;

namespace Infix_Postfix
{
    class Postfix
    {
        public string InfixExpression { get; set; }
        public string PostfixExpression { get; set; }
        public string Operators { get; set; }

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the  class.<see cref="Postfix"/>
        /// </summary>
        public Postfix()
        {

        }//end default constructor

        /// <summary>
        /// Initializes a new instance of the  class.<see cref="Postfix"/>
        /// </summary>
        /// <param name="input">The input infix expression..</param>
        public Postfix(string input)
        {
            this.InfixExpression = input;
            this.Operators = "+-*/=";
            this.PostfixExpression = Convert();
        }//end of parameterized constructor Postfix(string) 
        #endregion

        #region Convert Method
        /// <summary>
        /// Convert the expression from infix notation to postfix notation.
        /// </summary>
        /// <returns "Output">The input string converted into a postfix expression.</returns>
        private string Convert()
        {
            string Output = "";         //holds the expression in postfix notation
            string Delims = " ()+=-*/"; //delimiters for Tokenize
            List<string> Tokens;        //Holds the tokens parsed from the input string
            Stack<Operator> stack = new Stack<Operator>();
            Operator OpenParen = new Operator("(", 3);
            Operator Multiply = new Operator("*", 2);
            Operator Divide = new Operator("/", 2);
            Operator Plus = new Operator("+", 1);
            Operator Minus = new Operator("-", 1);
            Operator Equals = new Operator("=", 0);
            Operator op = new Operator();

            //parse the tokens from the string
            Tokens = Utility.Tokenize(this.InfixExpression, Delims);

            //sort the tokens into a postfix expression
            for (int i = 0; i < Tokens.Count; i++)
            {
                if (Tokens[i] == "(")   //if current token is an open parenthesis, push it on the stack
                {
                    stack.Push(OpenParen);
                }
                else if (Tokens[i] == ")")  //if the current token is a close parenthesis
                {
                    //if close parenthesis is found, pop the stack 
                    while (stack.Count > 0 && stack.Peek() != OpenParen)
                    {
                        Output += stack.Pop().Op + " ";
                    }
                    if (stack.Count == 0)   //if no open parenthesis is on the stack, there is an error
                    {
                        Output = "***Error*** Unpaired close parenthesis";
                        break;
                    }
                    else
                    {
                        stack.Pop();        //pop the leftover open parenthesis off the stack.
                    }
                }

                //if the token is a valid operator other than an open or close parenthesis
                else if (Tokens[i].IndexOfAny(this.Operators.ToCharArray()) > -1)
                {
                    if (Tokens[i] == "+")
                    {
                        op = Plus;
                    }
                    else if (Tokens[i] == "-")
                    {
                        op = Minus;
                    }
                    else if (Tokens[i] == "*")
                    {
                        op = Multiply;
                    }
                    else if (Tokens[i] == "/")
                    {
                        op = Divide;
                    }
                    else
                    {
                        op = Equals;
                    }

                    //if top of the stack is not an open parenthesis or an operator of lower precedence, put operator at top of stack in output
                    while (stack.Count > 0 && stack.Peek() != OpenParen && stack.Peek().Precedence >= op.Precedence)
                    {
                        Output += stack.Pop().Op + " ";
                    }

                    //after the stack has been popped to an open parenthesis or operator of lower precedence, new operator is pushed
                    stack.Push(op);
                }
                else
                {
                    Output += Tokens[i] + " "; //if the token is a variable or constant, concatenate into the output string
                }
            }//end for

            //Input string has been completely parsed. Pop the remaining operators off the stack. 
            //If an open parenthesis remains on the stack, there was no matching close parenthesis and an error is output.
            while (stack.Count > 0)
            {
                if (stack.Peek() == OpenParen)
                {
                    Output = "***Error*** Unpaired open parenthesis";
                    break;
                }
                Output += stack.Pop().Op + " ";
            }

            return Output;
        }//end Convert() 
        #endregion

    }//end Postfix.cs

}//end namespace Infix_Postfix
