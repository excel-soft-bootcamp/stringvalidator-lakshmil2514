using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
   public class StringNullOrEmpty : IStringValidate
    {
        public bool IsValidString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            return true;
        }
    }

}

