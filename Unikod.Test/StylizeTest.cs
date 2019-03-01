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
    }
}
