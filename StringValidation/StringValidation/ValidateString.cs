using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidation
{
    public class ValidateString
    {
        IStringValidate _verify;

        public ValidateString(IStringValidate verify)
        {
            this._verify = verify;
        }
        public bool ValidString(string data)
        {
            return _verify.IsValidString(data);
        }
    }
}
