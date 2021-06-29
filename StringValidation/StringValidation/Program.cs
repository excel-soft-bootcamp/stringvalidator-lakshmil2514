using System;

namespace StringValidation
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            StringNullOrEmpty nullOremptystring = new StringNullOrEmpty();
            ValidateString validate = new ValidateString(nullOremptystring);
            validate.ValidString(null);

            ValidateString validateLength = new ValidateString(new StringLength());
            validateLength.ValidString("string");

            ValidateString validateStartsWith = new ValidateString(new StringStartsWithEx());
           validateStartsWith.ValidString("example");

        }

    }
}

