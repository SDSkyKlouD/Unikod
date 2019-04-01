using System;
using System.Collections.Generic;
using SDSK.Libs.Unikod.Common;
using SDSK.Libs.Unikod.Common.Types;

namespace SDSK.Libs.Unikod {
    /// <summary>
    /// A static class with some useful utility collections other than text styling
    /// </summary>
    public static class Utils {
        /// <summary>
        /// Analyze the given styled text string
        /// </summary>
        /// <param name="text">Styled string text to be analyzed</param>
        /// <returns>A `Dictionary(name|string, char count|int)`. 'name' is the name of set which contains individual character,
        ///          and `char count` is, literally. If the `text` argument is null or contains only white space(s), this will return `null`</returns>
        public static Dictionary<string, int> Analyze(string text) {
            if(string.IsNullOrEmpty(text)) {
                return null;
            } else {
                Dictionary<string, int> analyzedPairs = new Dictionary<string, int>();

                foreach(string charToCheck in text.ToUnicodeStringArray()) {
                    if(char.TryParse(charToCheck, out char singleCharacter)) {
                        if(char.IsControl(singleCharacter) || char.IsWhiteSpace(singleCharacter)) {
                            continue;
                        }
                    }

                    foreach(IUnikodSet set in UnicodeSets.SetListAll) {
                        if(set != null) {
                            int setIndex = Array.IndexOf(set.SetData, charToCheck);

                            if(setIndex != -1) {
                                if(analyzedPairs.ContainsKey(set.SetName)) {
                                    analyzedPairs[set.SetName] += 1;
                                } else {
                                    analyzedPairs.Add(set.SetName, 1);
                                }

                                break;
                            }
                        } else {
                            continue;
                        }
                    }
                }

                return analyzedPairs;
            }
        }

        internal static IEnumerable<string> ToUnicodeStringArray(this string input) {
            char[] textCharArray = input.ToCharArray();

            for(int index = 0, length = textCharArray.Length; index < length; index++) {
                if((index + 1) < length && char.IsSurrogatePair(textCharArray[index], textCharArray[index + 1])) {
                    yield return textCharArray[index].ToString() + textCharArray[index + 1].ToString();
                    index++;
                } else {
                    yield return textCharArray[index].ToString();
                }
            }
        }
    }
}
