using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePadDecoderApp
{
    public static class OldPhonePadDecoder
    {
        private static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
        {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        public static string OldPhonePad(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Input cannot be null or empty.");

            StringBuilder result = new StringBuilder();
            char lastChar = '\0';
            int count = 0;

            foreach (char c in input)
            {
                if (c == '#') // end of input
                {
                    if (lastChar != '\0' && KeyMap.ContainsKey(lastChar))
                    {
                        result.Append(GetLetter(lastChar, count));
                    }
                    break;
                }
                else if (c == ' ')
                {
                    if (lastChar != '\0' && KeyMap.ContainsKey(lastChar))
                    {
                        result.Append(GetLetter(lastChar, count));
                    }
                    lastChar = '\0';
                    count = 0;
                }
                else if (c == '*')
                {
                    if (result.Length > 0)
                        result.Remove(result.Length - 1, 1);
                    lastChar = '\0';
                    count = 0;
                }
                else if (char.IsDigit(c))
                {
                    if (c == lastChar)
                    {
                        count++;
                    }
                    else
                    {
                        if (lastChar != '\0' && KeyMap.ContainsKey(lastChar))
                        {
                            result.Append(GetLetter(lastChar, count));
                        }
                        lastChar = c;
                        count = 1;
                    }
                }
                else
                {
                    continue; // ignore invalid characters
                }
            }

            return result.ToString();
        }

        private static char GetLetter(char key, int count)
        {
            if (!KeyMap.ContainsKey(key))
                return '?';

            string letters = KeyMap[key];
            int index = (count - 1) % letters.Length;
            return letters[index];
        }
    }
}
