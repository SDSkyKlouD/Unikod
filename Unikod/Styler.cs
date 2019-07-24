using System;
using System.Text;
using SDSK.Libs.Unikod.Common;
using SDSK.Libs.Unikod.Common.Types;

namespace SDSK.Libs.Unikod {
    /// <summary>
    /// A static class with some functions about text stylization
    /// </summary>
    public static class Styler {
        /// <summary>
        /// Stylize the given styled text string
        /// </summary>
        /// <param name="text">A string text to be stylized</param>
        /// <param name="set">A/Some style set(s) </param>
        /// <returns>Stylized text as `string`</returns>
        public static string Stylize(string text, params IUnikodSet[] set) {
            if(text == null) {
                return null;
            } else {
                StringBuilder builder = new StringBuilder();

                foreach(string character in text.ToUnicodeStringArray()) {
                    if(char.TryParse(character, out char singleCharacter)) {
                        if(char.IsControl(singleCharacter) || char.IsWhiteSpace(singleCharacter)) {
                            builder.Append(character);
                            continue;
                        }
                    }

                    bool existInNormalSets = false;
                    int index = -1;
                    Type characterSetType = null;
                    bool? characterIsUppercase = null;

                    foreach(IUnikodSet normalSet in UnicodeSets.GetSetsByStyleType(StyleType.Normal)) {
                        for(int i = 0, normalSetLength = normalSet.SetData.Length; i < normalSetLength; i++) {
                            if(normalSet.SetData[i].Equals(character)) {
                                index = i;
                                existInNormalSets = true;
                                characterSetType = normalSet.GetType();
                                
                                if(normalSet is AlphabetSet alphabetSet) {
                                    characterIsUppercase = alphabetSet.IsUppercase;
                                }
                            }
                        }
                    }

                    if(existInNormalSets) {
                        bool found = false;

                        foreach(IUnikodSet targetSet in set) {
                            if(characterSetType == targetSet.GetType()) {
                                if(targetSet is AlphabetSet alphabetSet) {
                                    if(alphabetSet.IsUppercase != characterIsUppercase) {
                                        continue;
                                    }
                                }
                                
                                if(targetSet.SetData[index] != null) {
                                    builder.Append(targetSet.SetData[index]);
                                    found = true;
                                    break;
                                }
                            }
                        }

                        if(!found) {
                            builder.Append(character);
                        }
                    } else {
                        builder.Append(character);
                    }
                }

                return builder.ToString();
            }
        }

        /// <summary>
        /// Unstylize the given styled text string
        /// </summary>
        /// <param name="text">Styled string text to be unstylized</param>
        /// <returns>Unstylized `string`. `null` if the `text` argument is null or contains only white space(s).</returns>
        public static string Unstylize(string text) {
            if(string.IsNullOrWhiteSpace(text)) {
                return null;
            } else {
                StringBuilder normalizedBuilder = new StringBuilder();

                foreach(string charToCheck in text.ToUnicodeStringArray()) {
                    if(char.TryParse(charToCheck, out char singleCharacter)) {
                        if(char.IsControl(singleCharacter) || char.IsWhiteSpace(singleCharacter)) {
                            normalizedBuilder.Append(charToCheck);
                            continue;
                        }
                    }

                    bool hasFound = false;

                    foreach(IUnikodSet set in UnicodeSets.SetListAll) {
                        if(set != null) {
                            int setIndex = Array.IndexOf(set.SetData, charToCheck);

                            if(setIndex != -1) {
                                if(set is AlphabetSet alphabetSet) {
                                    normalizedBuilder.Append(UnicodeSets.SetListLatin[alphabetSet.IsUppercase ? 0 : 1].SetData[setIndex]);
                                } else if(set is NumberSet) {
                                    normalizedBuilder.Append(UnicodeSets.SetListNumber[0].SetData[setIndex]);
                                }

                                hasFound = true;
                                break;
                            }
                        } else {
                            continue;
                        }
                    }

                    if(hasFound) {
                        continue;
                    } else {
                        normalizedBuilder.Append(charToCheck);
                    }
                }

                return normalizedBuilder.ToString();
            }
        }
    }
}
