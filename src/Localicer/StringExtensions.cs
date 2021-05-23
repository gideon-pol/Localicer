using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Localicer
{
    public enum MatchMode { MatchCase, IgnoreCase, UseReplacementCase }

    public static class StringExtensions
    {
        public static bool Search(this string src, string find, MatchMode mode)
        {
            if (mode == MatchMode.IgnoreCase)
            {
                find = find.ToLower();
                src = src.ToLower();
            }

            return stringContains(src, find);
        }

        public static string ReplaceWith(this string src, string replaceThis, string with, MatchMode mode, ref int occurrencesChanged)
        {
            string output = "";

            if (src.Length >= 3 && src[0] == 'I' && src[1] == 'D' && src[2] == '_') return src;

            if (mode == MatchMode.UseReplacementCase) {
                string compareSrc = src.ToLower();
                replaceThis = replaceThis.ToLower();

                for (int i = 0; i < src.Length; i++)
                {
                    if (stringContainsAt(compareSrc, replaceThis, i))
                    {
                        occurrencesChanged++;
                        bool lastCharIsUpper = false;
                        bool endOfStringReached = false;

                        for (int j = 0; j < with.Length; j++)
                        {
                            if(i + j < src.Length && j < replaceThis.Length)
                            {
                                if (Char.IsUpper(src[i + j]))
                                {
                                    output += Char.ToUpper(with[j]);
                                    lastCharIsUpper = true;
                                    continue;
                                }

                                if (Char.IsLetter(src[i + j]))
                                {
                                    lastCharIsUpper = false;
                                }
                                else
                                {
                                    if (lastCharIsUpper) output += Char.ToUpper(with[j]);
                                    else output += with[j];
                                    continue;
                                }
                            }
                            else
                            {
                                endOfStringReached = true;
                            }
                            if(endOfStringReached && lastCharIsUpper) output += Char.ToUpper(with[j]);
                            else output += with[j];

                        }
                        i += replaceThis.Length - 1;
                    }
                    else
                    {
                        output += src[i];
                    }
                }
            } else 
            {
                string compareSrc = src;

                if (mode == MatchMode.IgnoreCase) {
                    replaceThis = replaceThis.ToLower();
                    compareSrc = src.ToLower();
                }

                for (int i = 0; i < src.Length; i++)
                {
                    if (stringContainsAt(compareSrc, replaceThis, i))
                    {
                        occurrencesChanged++;
                        output += with;
                        i += replaceThis.Length - 1;
                    }
                    else
                    {
                        output += src[i];
                    }
                }
            }

            return output;
        }

        private static bool stringContains(string src, string substring)
        {
            for (int i = 0; i < src.Length; i++)
            {
                if (stringContainsAt(src, substring, i)) return true;
            }

            return false;
        }

        private static bool stringContainsAt(string src, string substring, int index)
        {
            for (int j = 0; j < substring.Length; j++)
            {
                if (j + index == src.Length || src[index + j] != substring[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
