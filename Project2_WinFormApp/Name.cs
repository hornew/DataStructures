using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils
{
    class Name
    {
        /// <summary>
        /// IsValid property which is set to true or false depending upon the validity of the input string.
        /// nm property which contains the split input string.
        /// str property which contains the string representing the User's name.
        /// </summary>
        public bool IsValid { get; private set; }
        public String[] nm;
        public String str { get; private set; }
        /// <summary>
        /// Name constructor which accepts an input string and calls the Validate() method to check for input validity
        /// </summary>
        /// <param name="candidate"></param>
        public Name(String candidate)
        {
            Validate(candidate);
            
            
        }//end of Parameterized Constructor Name(String)

        /// <summary>
        /// This method validates the input string, checking for illegal characters. 
        /// If the input string is valid, this method sets the IsValid property to true.
        /// </summary>
        /// <param name="candidate"></param>      
        private void Validate(string candidate)
        {
            this.IsValid = false;
            char[] delims={' ', ','};
            char[] illegal={'~', '1','!','2','@','3','#','4','$','5','%','6','^','7','&','8','*','9','(','0',')', '+','=','\\','{','}','[',']','|','"',':', ';', '<','>','.','?','/'};
            String strTemp;
            if (candidate.IndexOfAny(illegal) == -1 && !(String.IsNullOrWhiteSpace(candidate)))
            {
                if (candidate.IndexOf(',') == -1)
                {
                    
                    nm = candidate.Split(delims);
                    nm[0].Trim();
                    nm[1].Trim();
                    str = nm[1] + "," + nm[0];
                    IsValid = true;
                }
                else
                {
                    nm = candidate.Split(delims);
                    if (String.IsNullOrWhiteSpace(nm[1]))
                    {
                        strTemp = nm[2];
                    }
                    else
                    {
                        strTemp = nm[1];
                    }
                    nm[1] = nm[0].Trim();
                    nm[0] = strTemp.Trim();
                    str = nm[1] + ", " + nm[0];
                    IsValid = true;
                }
            }
            else
            {
                str="";
                IsValid = false;
            }            
          
        }//end of Validate()

        /// <summary>
        /// Overridden ToString method. Returns the user name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return str;
        }//end of overridden ToString()

    }//end of Name.cs

}//end of namespace Utils
