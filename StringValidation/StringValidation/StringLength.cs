using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class StringLength : IStringValidate
    {
        public bool IsValidString(string data)
        {
            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
    }
}

