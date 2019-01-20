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
                
                for(int index = 0; index < textCodeArray.Length; index++) {
                    if(!(char.IsControl(textCodeArray[index]) || char.IsPunctuation(textCodeArray[index]) || char.IsWhiteSpace(textCodeArray[index]))) {
                        string charToCheck = string.Empty;

                        if(char.IsSurrogatePair(textCodeArray[index], textCodeArray[index + 1])) {
                            charToCheck = textCodeArray[index].ToString() + textCodeArray[index + 1].ToString();
                            index++;
                        } else {
                            charToCheck = textCodeArray[index].ToString();
                        }

                        foreach(AlphabetSet set in UnicodeSets.LatinSetList) {
                            bool found = false;
                            for(int setIndex = 0, length = set.SetData.Length; setIndex < length; setIndex++) {
                                if(set.SetData[setIndex] != null && set.SetData[setIndex].Equals(charToCheck)) {
                                    normalizedBuilder.Append(UnicodeSets.LatinSetList[set.IsUppercase ? 0 : 1].SetData[setIndex]);
                                    found = true;
                                    break;
                                }
                            }
                            if(found) break;
                        }

                        foreach(NumberSet set in UnicodeSets.NumberSetList) {
                            bool found = false;
                            for(int setIndex = 0, length = set.SetData.Length; setIndex < length; setIndex++) {
                                if(set.SetData[setIndex] != null && set.SetData[setIndex].Equals(charToCheck)) {
                                    normalizedBuilder.Append(UnicodeSets.NumberSetList[0].SetData[setIndex]);
                                    found = true;
                                    break;
                                }
                            }
                            if(found) break;
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
