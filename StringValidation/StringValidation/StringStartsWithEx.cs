using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class StringStartsWithEx : IStringValidate
    {
        public bool IsValidString(string data)
        {
            if (data.StartsWith("ex"))
            {
                return false;
            }
            return true;
        }
    }
}
