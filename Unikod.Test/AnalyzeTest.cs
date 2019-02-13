using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SDSK.Libs.Unikod.Test {
    [TestClass]
    public class AnalyzeTest {
        [TestMethod]
        public void AnalyzeTest_OneStylePerText() {
            string testText1 = "𝐀𝐛𝐬𝐨𝐥𝐮𝐭𝐞𝐥𝐲, 𝐬𝐢𝐫.";
            string testText2 = "ℑ𝔫𝔱𝔢𝔯𝔫𝔞𝔱𝔦𝔬𝔫𝔞𝔩 𝔏𝔬𝔳𝔢";
            string testText3 = "Ⓦⓞⓡⓛⓓ ⓘⓢ ⓡⓞⓤⓝⓓ";

            CollectionAssert.AreEquivalent(new Dictionary<string, int>() {
                { "Latin Bold Uppercase", 1 },
                { "Latin Bold Lowercase", 12 }
            }, UnikodUtils.Analyze(testText1));
            CollectionAssert.AreEquivalent(new Dictionary<string, int>() {
                { "Latin Fraktur Uppercase", 2 },
                { "Latin Fraktur Lowercase", 15 }
            }, UnikodUtils.Analyze(testText2));
            CollectionAssert.AreEquivalent(new Dictionary<string, int>() {
                { "Latin Circled Uppercase", 1 },
                { "Latin Circled Lowercase", 11 }
            }, UnikodUtils.Analyze(testText3));
        }

        [TestMethod]
        public void AnalyzeTest_LatinConfusing() {
            string testText = "𝑊𝑎𝑖𝑡𝑖𝑛𝑔 𝑓𝑜𝑟 𝑡ℎ𝑒 𝑡𝑖𝑚𝑒 𝑡𝑜 𝑝𝑎𝑠𝑠 𝑦𝑜𝑢 𝑏𝑦" +
                "𝑯𝒐𝒑𝒆 𝒕𝒉𝒆 𝒘𝒊𝒏𝒅𝒔 𝒐𝒇 𝒄𝒉𝒂𝒏𝒈𝒆 𝒘𝒊𝒍𝒍 𝒄𝒉𝒂𝒏𝒈𝒆 𝒚𝒐𝒖𝒓 𝒎𝒊𝒏𝒅" +
                "𝖨 𝖼𝗈𝗎𝗅𝖽 𝗀𝗂𝗏𝖾 𝖺 𝗍𝗁𝗈𝗎𝗌𝖺𝗇𝖽 𝗋𝖾𝖺𝗌𝗈𝗇𝗌 𝗐𝗁𝗒" +
                "𝔸𝕟𝕕 𝕀 𝕜𝕟𝕠𝕨 𝕪𝕠𝕦, 𝕒𝕟𝕕 𝕪𝕠𝕦'𝕧𝕖 𝕘𝕠𝕥 𝕥𝕠" +
                "𝓜𝓪𝓴𝓮 𝓲𝓽 𝓸𝓷 𝔂𝓸𝓾𝓻 𝓸𝔀𝓷" +
                "𝚋𝚞𝚝 𝚠𝚎 𝚍𝚘𝚗'𝚝 𝚑𝚊𝚟𝚎 𝚝𝚘 𝚐𝚛𝚘𝚠 𝚞𝚙" +
                "🄦⒠ ⒞⒜⒩ ⒮⒯⒜⒴ ⒡⒪⒭⒠⒱⒠⒭ ⒴⒪⒰⒩⒢" +
                "Ｌｉｖｉｎｇ ｏｎ ｍｙ ｓｏｆａ" +
                "𝖉𝖗𝖎𝖓𝖐𝖎𝖓𝖌 𝖗𝖚𝖒 𝖆𝖓𝖉 𝖈𝖔𝖑𝖆" +
                "𝒰𝓃𝒹ℯ𝓇𝓃ℯ𝒶𝓉𝒽 𝓉𝒽ℯ 𝓇𝒾𝓈𝒾𝓃ℊ 𝓈𝓊𝓃";        // Some part of Zedd - Stay

            CollectionAssert.AreEquivalent(new Dictionary<string, int>() {
                { "Latin Italic Uppercase", 1 },
                { "Latin Italic Lowercase", 6 + 3 + 3 + 4 + 2 + 4 + 3 + 2 },
                { "Latin Bold Italic Uppercase", 1 },
                { "Latin Bold Italic Lowercase", 3 + 3 + 5 + 2 + 6 + 4 + 6 + 4 + 4 },
                { "Latin Sans-Serif Uppercase", 1 },
                { "Latin Sans-Serif Lowercase", 5 + 4 + 1 + 8 + 7 + 3 },
                { "Latin Double-Struck Uppercase", 2 },
                { "Latin Double-Struck Lowercase", 2 + 4 + 3 + 3 + 5 + 3 + 2 },
                { "Latin Script Bold Uppercase", 1 },
                { "Latin Script Bold Lowercase", 3 + 2 + 2 + 4 + 3 },
                { "Latin Monospace Lowercase", 3 + 2 + 4 + 4 + 2 + 4 + 2 },
                { "Latin Parenthesized Uppercase", 1 },
                { "Latin Parenthesized Lowercase", 1 + 3 + 4 + 7 + 5 },
                { "Latin Fullwidth Uppercase", 1 },
                { "Latin Fullwidth Lowercase", 5 + 2 + 2 + 4 },
                { "Latin Fraktur Bold Lowercase", 8 + 3 + 3 + 4 },
                { "Latin Script Uppercase", 1 },
                { "Latin Script Lowercase", 9 + 3 + 6 + 3 }
            }, UnikodUtils.Analyze(testText));
        }
    }
}
