using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSK.Libs.Unikod.Common;

namespace SDSK.Libs.Unikod.Test {
    [TestClass]
    public class StylizeTest {
        [TestMethod]
        public void StylizeTest_Latin_OneStyle() {
            string textToBeStylized1 = "Style me!";
            string textToBeStylized2 = "/*- Holy sxxt I gotta go -*/";

            Assert.AreEqual("𝐒𝐭𝐲𝐥𝐞 𝐦𝐞!", Styler.Stylize(textToBeStylized1, UnicodeSets.LatinBoldUppercaseSet, UnicodeSets.LatinBoldLowercaseSet));
            Assert.AreEqual("/*- ℌ𝔬𝔩𝔶 𝔰𝔵𝔵𝔱 ℑ 𝔤𝔬𝔱𝔱𝔞 𝔤𝔬 -*/", Styler.Stylize(textToBeStylized2, UnicodeSets.LatinFrakturUppercaseSet, UnicodeSets.LatinFrakturLowercaseSet));
        }

        [TestMethod]
        public void StylizeTest_Latin_IncompletedOneStyle() {
            string textToBeStylized1 = "Confusing!q";
            string textToBeStylized2 = "You are GREAT";

            Assert.AreEqual("Cᵒⁿᶠᵘˢⁱⁿᵍ!q", Styler.Stylize(textToBeStylized1, UnicodeSets.LatinModifierUppercaseSet, UnicodeSets.LatinModifierLowercaseSet));
            Assert.AreEqual("𐌖ou are GR𐌄𐌀𐌕", Styler.Stylize(textToBeStylized2, UnicodeSets.LatinOldItalicUppercaseSet));
        }

        [TestMethod]
        public void StylizeTest_Latin_WithFallbackStyle() {
            string textToBeStylized1 = "Without You";
            string textToBeStylized2 = "See You Again";

            Assert.AreEqual("ᵂⁱᵗʰᵒᵘᵗ 𝚈ᵒᵘ", Styler.Stylize(textToBeStylized1, UnicodeSets.LatinModifierUppercaseSet, UnicodeSets.LatinModifierLowercaseSet, UnicodeSets.LatinMonospaceUppercaseSet, UnicodeSets.LatinMonospaceLowercaseSet));
            Assert.AreEqual("🄢ₑₑ 🄨ₒᵤ 🄐⒢ₐᵢₙ", Styler.Stylize(textToBeStylized2, UnicodeSets.LatinSubscriptLowercaseSet, UnicodeSets.LatinParenthesizedUppercaseSet, UnicodeSets.LatinParenthesizedLowercaseSet));
        }

        [TestMethod]
        public void StylizeTest_Number_OneStyle() {
            string textToBeStylized1 = "00039039000";
            string textToBeStylized2 = "95423165877";

            Assert.AreEqual("０００３９０３９０００", Styler.Stylize(textToBeStylized1, UnicodeSets.NumberFullWidthSet));
            Assert.AreEqual("𝟵𝟱𝟰𝟮𝟯𝟭𝟲𝟱𝟴𝟳𝟳", Styler.Stylize(textToBeStylized2, UnicodeSets.NumberSansSerifBoldSet));
        }

        [TestMethod]
        public void StylizeTest_Number_IncompletedOneStyle() {
            string textToBeStylized = "01234567890";

            Assert.AreEqual("0⑴⑵⑶⑷⑸⑹⑺⑻⑼0", Styler.Stylize(textToBeStylized, UnicodeSets.NumberParenthesizedSet));
        }

        [TestMethod]
        public void StylizeTest_Number_WithFallbackStyle() {
            string textToBeStylized = "01234567890";

            Assert.AreEqual("⓿⓵⓶⓷⓸⓹⓺⓻⓼⓽⓿", Styler.Stylize(textToBeStylized, UnicodeSets.NumberDoubleCircledSet, UnicodeSets.NumberDingbatNegativeCircledSet));
        }

        [TestMethod]
        public void StylizeTest_LatinNumberMixed_OneStyle() {
            string textToBeStylized = "Commits 0 Modified 2 Unikod master";

            Assert.AreEqual("ℂ𝕠𝕞𝕞𝕚𝕥𝕤 𝟘 𝕄𝕠𝕕𝕚𝕗𝕚𝕖𝕕 𝟚 𝕌𝕟𝕚𝕜𝕠𝕕 𝕞𝕒𝕤𝕥𝕖𝕣", Styler.Stylize(textToBeStylized, UnicodeSets.LatinDoubleStruckUppercaseSet, UnicodeSets.LatinDoubleStruckLowercaseSet, UnicodeSets.NumberDoubleStruckSet));
        }

        [TestMethod]
        public void StylizeTest_LatinNumberMixed_WithFallbackStyle() {
            string textToBeStylized = "Curiosity was launched from Cape Canaveral on November 26, 2011, at 15:02 UTC";

            Assert.AreEqual("𝐶ᵘʳⁱᵒˢⁱᵗʸ ʷᵃˢ ˡᵃᵘⁿᶜʰᵉᵈ ᶠʳᵒᵐ 𝐶ᵃᵖᵉ 𝐶ᵃⁿᵃᵛᵉʳᵃˡ ᵒⁿ ᴺᵒᵛᵉᵐᵇᵉʳ ⑵⑹, ⑵🄌⑴⑴, ᵃᵗ ⑴⑸:🄌⑵ ᵁᵀ𝐶", Styler.Stylize(textToBeStylized, UnicodeSets.LatinModifierUppercaseSet, UnicodeSets.LatinModifierLowercaseSet, UnicodeSets.NumberParenthesizedSet, UnicodeSets.LatinItalicUppercaseSet, UnicodeSets.LatinItalicLowercaseSet, UnicodeSets.NumberDingbatSansSerifNegativeCircledSet));
        }
    }
}
