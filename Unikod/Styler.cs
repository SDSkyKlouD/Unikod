using System;
using System.Text;
using SDSK.Libs.Unikod.Common;

namespace SDSK.Libs.Unikod {
    public static class Styler {
        public static string Stylize(string text, params IUnikodSet[] set) {
            if(string.IsNullOrEmpty(text)) {
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
    }
}
