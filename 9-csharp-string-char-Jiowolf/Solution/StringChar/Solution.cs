namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string toReverse)
        {
            if (toReverse == "")
            {
                throw new ArgumentException("Input string must not be empty");
            }
            else
            {
                char[] chars = toReverse.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
        }

        public static string CountVowels(string toCount)
        {
            int[] vowelsArr = new int[6];
            int vowels = 0;

            if (toCount == "")
            {
                throw new ArgumentException("Input string must not be empty");
            }
            else
            {
                char[] chars = toCount.ToCharArray();
                foreach (char c in chars)
                {

                    int count = c switch
                    {
                        'a' or 'A' => vowelsArr[0]=1,
                        'e' or 'E' => vowelsArr[1]=1,
                        'i' or 'I' => vowelsArr[2]=1,
                        'o' or 'O' => vowelsArr[3]=1,
                        'u' or 'U' => vowelsArr[4]=1,
                        'y' or 'Y' => vowelsArr[5]=1,
                        _ => 0
                    };
                    
                }
                foreach(int i in vowelsArr)
                {
                    vowels += i;
                }
            }
                return $"Number of vowels:{vowels.ToString()}";
        }

        public static bool IsPalindrome(string text)
        {
            if (text == "")
            {
                throw new ArgumentException("Input string must not be empty");
            }
            else
            {
                string noSpace = text.Replace(" ", string.Empty).ToLower();
                char[] chars = noSpace.ToCharArray();
                char[] charsInverse = noSpace.ToCharArray();
                Console.Write(noSpace);
                Array.Reverse(charsInverse);
                return charsInverse.SequenceEqual(chars) == true;
                
            }

        }

        public static char FirstNonRepeatingCharacter(string text)
        {
            if (text == "")
            {
                throw new ArgumentException("Input string must not be empty");
            }
            else
            {
                string noSpace = text.Replace(" ", string.Empty).ToLower();
                char[] charTxt = noSpace.ToCharArray();

                for(int i = 0; i < charTxt.Length; i++) 
                {
                    bool ok = false;

                    for (int j = 0; j < charTxt.Length; j++)
                    {
                        if (i != j && charTxt[i] == charTxt[j])
                        {
                            ok = true;
                            break;
                        }
                    }
                    if (!ok)
                    {
                        return charTxt[i];
                    }
                }

                throw new Exception("There are no unique characters");
            }
        }
    }
}
