namespace SEDC.Oop.Class03.StaticClasses
{
    public static class StringHelper
    {
        public static string CapitalizeFirstLetter(string word)
        {
            if(word.Length == 0)
            {
                return String.Empty;
            }
            else if(word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
            }
            else
            {
                return char.ToUpper(word[0]).ToString() + word.Substring(1);
            }
        }

        public static int VerifyStringNumber(string input)
        {
            int result = 0;

            bool isParsed = int.TryParse(input, out result);

            if (isParsed)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
