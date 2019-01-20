using System;
using System.Text;
using SDSK.Libs.Unikod.Common;

namespace SDSK.Libs.Unikod {
    public class UnikodUtils {
        public static string Normalize(string text) {
            if(string.IsNullOrWhiteSpace(text)) {
                return string.Empty;
            } else {
                char[] textCodeArray = text.ToCharArray();
                StringBuilder normalizedBuilder = new StringBuilder();
                
                for(int index = 0, length = textCodeArray.Length; index < length; index++) {
                    if(!(char.IsControl(textCodeArray[index]) || char.IsPunctuation(textCodeArray[index]) || char.IsWhiteSpace(textCodeArray[index]))) {
                        bool hasFound = false;
                        string charToCheck = string.Empty;

                        if((index + 1) < length && char.IsSurrogatePair(textCodeArray[index], textCodeArray[index + 1])) {
                            charToCheck = textCodeArray[index].ToString() + textCodeArray[index + 1].ToString();
                            index++;
                        } else {
                            charToCheck = textCodeArray[index].ToString();
                        }

                        foreach(AlphabetSet set in UnicodeSets.LatinSetList) {
                            int setIndex = Array.IndexOf(set.SetData, charToCheck);

                            if(setIndex != -1) {
                                normalizedBuilder.Append(UnicodeSets.LatinSetList[set.IsUppercase ? 0 : 1].SetData[setIndex]);
                                hasFound = true;
                                break;
                            }
                        }

                        foreach(NumberSet set in UnicodeSets.NumberSetList) {
                            int setIndex = Array.IndexOf(set.SetData, charToCheck);

                            if(setIndex != -1) {
                                normalizedBuilder.Append(UnicodeSets.NumberSetList[0].SetData[setIndex]);
                                hasFound = true;
                                break;
                            }
                        }

                        if(hasFound) {
                            continue;
                        } else {
                            normalizedBuilder.Append(charToCheck);
                        }
                    } else {
                        normalizedBuilder.Append(textCodeArray[index]);
                    }
                }

                return normalizedBuilder.ToString();
            }
        }
    }
}
